using cangku_01.entity;
using cangku_01.UHFReader09;
using cangku_01.UHFReader09CSharp;
using cangku_01.view.InstrumentManagement;
using ReaderB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.UHFReader09
{
    class UHFReader : UHFReader09Interface
    {
        private byte fComAdr = 0xff; //当前操作的ComAdr
        private byte fBaud;
        private int frmcomportindex;
        private int fOpenComIndex; //打开的串口索引号
        private bool ComOpen = false;
        private int fCmdRet = 30; //所有执行指令的返回值
        private string AlreadyOpenCOM;
        private bool fIsInventoryScan;
        private string fInventory_EPC_List; //存贮询查列表（如果读取的数据没有变化，则不进行刷新）
        private bool fAppClosed; //在测试模式下响应关闭应用程序
        private InstrumentManagement fr;
        string sEPC;
        string TagId;

        public void CloseConnectReader()
        {
            throw new NotImplementedException();
        }

        public void ConnectReader()
        {
            int port = 0;
            int openresult, i;
            openresult = 30;
            string temp;
            fComAdr = Convert.ToByte("FF", 16); // $FF;
            temp = "COM3";
            port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
            for (i = 6; i >= 0; i--)
            {
                fBaud = Convert.ToByte(i);
                if (fBaud == 3)
                    continue;
                openresult = StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                fOpenComIndex = frmcomportindex;
                if (openresult == 0x35)
                {
                    return;
                }
                if (openresult == 0)
                {
                    ComOpen = true;
                    if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
                    {
                        ComOpen = false;
                        StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                        return;
                    }
                    break;
                }
            }
            if ((fOpenComIndex != -1) & (openresult != 0X35) & (openresult != 0X30))
            {
                AlreadyOpenCOM = "COM" + Convert.ToString(fOpenComIndex);
                ComOpen = true;
                //MessageBox.Show("连接成功");
            }
            if ((fOpenComIndex == -1) && (openresult == 0x30))
                MessageBox.Show("连接失败");
        }

        public string ReadTagId()
        {
            int CardNum = 0;
            int Totallen = 0;
            int EPClen, m;
            byte[] EPC = new byte[5000];
            string temps;

            fIsInventoryScan = true;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte TIDFlag = 0;
            AdrTID = Convert.ToByte("00", 16);
            LenTID = Convert.ToByte("06", 16);
            TIDFlag = 1;
            fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, frmcomportindex);
            if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))//代表已查找结束，
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                temps = ByteArrayToHexString(daw);
                m = 0;
                if (CardNum == 0)
                {
                    fIsInventoryScan = false;
                    return sEPC="";
                }
                EPClen = daw[m];
                sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
                m = m + EPClen + 1;
            }
            TagId = sEPC;
            return TagId;

        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }
    }
}
