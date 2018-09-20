using cangku_01.UHFReader09CSharp;
using ReaderB;
using System;
using System.Text;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.UHFReader09
{
    class UHFReader : UHFReader09Interface
    {
        private byte fComAdr = 0xff; //当前操作的ComAdr
        private byte fBaud;
        private int frmcomportindex;
        private int fOpenComIndex; //打开的串口索引号
        private int fCmdRet = 30; 
        private string sEPC;
        private byte MaskFlag;
        private byte Maskadr;
        private byte MaskLen;
        private int ferrorcode;
        private byte[] EPC;
        private int port = 0;
        private string temp = "COM3";
        private static UHFReader instance = null;

        Timer readTimer;

        public event TagConnectedHandler TagConnected;

        private UHFReader()
        {
            readTimer = new Timer();
            readTimer.Interval = 50;
            readTimer.Tick += ReadTimer_Tick;
            readTimer.Start();
        }

        public static UHFReader CreateInstance()
        {
            if (instance == null)
                instance = new UHFReader();
            return instance;
        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            string tagId = StartReadTagId();
            TagConnected?.Invoke(tagId);
        }

        //关闭连接
        public void CloseConnectReader()
        {
            port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
            fCmdRet = StaticClassReaderB.CloseSpecComPort(port);
            if (fCmdRet == 0)
            {
                StaticClassReaderB.CloseSpecComPort(port);
                fComAdr = 0xFF;
                StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                fOpenComIndex = frmcomportindex;
            }
            else
                throw new Exception("串口通讯错误");
        }

        //开启连接
        public void OpenConnectReader()
        {
            bool _ComOpen = false;
            string AlreadyOpenCOM;
            int openresult = 30;
            fComAdr = Convert.ToByte("FF", 16); // $FF;
            port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
            for (int i = 6; i >= 0; i--)
            {
                fBaud = Convert.ToByte(i);
                if (fBaud == 3)
                    continue;
                openresult = StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                fOpenComIndex = frmcomportindex;
                if (openresult == 0x35)
                    return;
                if (openresult == 0)
                {
                    _ComOpen = true;
                    if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
                    {
                        _ComOpen = false;
                        StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                        return;
                    }
                    break;
                }
            }
            if ((fOpenComIndex != -1) & (openresult != 0X35) & (openresult != 0X30))
            {
                AlreadyOpenCOM = "COM" + Convert.ToString(fOpenComIndex);
                _ComOpen = true;
            }
            if ((fOpenComIndex == -1) && (openresult == 0x30))
                AutoClosingMessageBox.Show("未连接读卡器", "读卡器连接失败", 1000);
        }

        //获取TagId
        private string StartReadTagId()
        {
            int CardNum = 0;
            int Totallen = 0;
            byte[] EPC = new byte[5000];
            bool fIsInventoryScan = true;
            byte AdrTID = Convert.ToByte("00", 16);
            byte LenTID = Convert.ToByte("06", 16);
            byte TIDFlag = 1;
            fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, frmcomportindex);
            if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))//代表已查找结束，
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                string temps = ByteArrayToHexString(daw);
                int m = 0;
                if (CardNum == 0)
                {
                    fIsInventoryScan = false;
                    return sEPC="";
                }
                int EPClen = daw[m];
                sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
                m = m + EPClen + 1;
            }
            return sEPC;
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();
        }

        //将仪器信息写入卡片
        public void WriteCardInformation(string writedatas)
        {
            int WrittenDataNum = 0;
            byte Mem = 3;//存储到用户区
            byte EPClength = 0;
            byte[] fPassWord = new byte[4];
            string pc="";
            if (Convert.ToInt32("00") + Convert.ToInt32("4") > 120)
                return;
            int m, n;
            n = writedatas.Length;
            if (n % 4 == 0)
            {
                m = n / 4;
                m = (m & 0x3F) << 3;
                pc = Convert.ToString(m, 16).PadLeft(2, '0') + "00";
            }
            byte WordPtr = Convert.ToByte("02", 16);
            byte Num = Convert.ToByte("32");
            string s2 = writedatas;
            if (s2.Length % 4 != 0)
            {
                MessageBox.Show("以字为单位输入.", "写");
                return;
            }
            byte WNum = Convert.ToByte(s2.Length / 4);
            byte[] Writedata = new byte[WNum * 2];
            Writedata = HexStringToByteArray(s2);
            byte Writedatalen = Convert.ToByte(WNum * 2);
            WordPtr = 1;
            Writedatalen = Convert.ToByte(writedatas.Length / 2 + 2);
            Writedata = HexStringToByteArray(pc + writedatas);
            fCmdRet = StaticClassReaderB.WriteCard_G2(ref fComAdr, EPC, Mem, WordPtr, Writedatalen, Writedata, fPassWord, Maskadr, MaskLen, MaskFlag, WrittenDataNum, EPClength, ref ferrorcode, frmcomportindex);
        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
    }
}
