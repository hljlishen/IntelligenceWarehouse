using Gate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cangku_01.GateDrive
{
    class GateInterfaceImp : GateInterface
    {
        private int fCmdRet = 30;
        private byte ControllerAdr = 0xff;
        private int PortHandle = -1;
        private byte IRStatus;
        private byte fModel;
        private string mtidaddr = "00";
        private string Mtidlen = "06";
        private string Maddr = "0000";
        private string Mlen = "00";
        private int Port = 6000;
        private string ipAddr = "192.168.1.190";
        private string Mdata = "";
        private string rnum = "";
        private string lnum = "";
        private bool IsGetting;
        private byte[] MaskData = new byte[100];
        private byte IREnable = 0;
        private byte IRTime = 0;
        private byte TagExistTime = 0;
        private byte AlarmEn = 0;
        private byte DelayTime = 0;
        private byte Pepolemsg = 0;
        private byte AEn = 1;
        private byte NewAddr = 00;
        private byte Mode = 1;
        private byte[] setTime = new byte[6];
        private byte model = 0;
        private byte Qvalue = 0;
        private byte Session = 0;
        private byte AdrTID = 0;
        private byte LenTID = 0;
        private byte MaskMem = 0;
        private byte[] MaskAdr = new byte[2];
        private byte MaskLen = 0;
        private byte[] positive = new byte[3];
        private byte[] reverse = new byte[3];
        private byte[] AlarmNum = new byte[4];
        private byte Productcode = 0;
        private byte MainVer = 0;
        private byte SubVer = 0;
        private string gateModel;
        private byte InFlag;
        private byte[] Msg = new byte[300];
        private string year, month, Dates, Hour, minutes, second;
        private byte MsgLength = 0;
        private string dminfre = "";
        private string dmaxfre = "";

        //关闭门的网口
        public void Close()
        {
            fCmdRet = DeviceApi.CloseNetPort(PortHandle);
            if (fCmdRet != 0)
            {
                throw new Exception("网口关闭失败");
                

            }
            MessageBox.Show("关闭成功");

        }
        //打开门的网口
        public void Open()
        {
            fCmdRet = DeviceApi.OpenNetPort(Port, ipAddr, ref ControllerAdr, ref PortHandle);

            if (fCmdRet == 0)
            {
                GetDeviceInfo();
                fModel = 0;
                fCmdRet = DeviceApi.ModeSwitch(ref ControllerAdr, ref fModel, ref IRStatus, PortHandle);
                MessageBox.Show("连接成功");
            }
            else
            {
                throw new Exception("连接失败");
            }
            
        }
       
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();
        }
       

        private void GetDeviceInfo()
        {
            fCmdRet = DeviceApi.GetControllerInfo(ref ControllerAdr, ref Productcode, ref MainVer, ref SubVer, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                string productCode = Convert.ToString(Productcode, 16).PadLeft(2, '0').ToUpper();
                if (productCode == "90")
                {
                    gateModel = "RRU-CH-WL";
                }
                if (productCode == "91")
                {
                    gateModel = "RRU-CH-C16058";
                }
                string version = Convert.ToString(MainVer, 16).PadLeft(2, '0').ToUpper() + "." + Convert.ToString(SubVer, 16).PadLeft(2, '0').ToUpper();
            }
        }
        
        public void  StartDetect(Form1 fr)
        {
            GateVirtualEntity door = new GateVirtualEntity();
            string ThroughDoorTime;
            string ThroughDoorDirection;
            IsGetting = true;     //进入该过程时将正在执行标志置1.
            byte MsgType = 0;
            ThroughDoorDirection = "";
            ThroughDoorTime = "";
            fCmdRet = DeviceApi.GetChannelMessage(ref ControllerAdr, Msg, ref MsgLength, ref MsgType, ref IRStatus, PortHandle);
            if ((fCmdRet == 0) && (MsgType == 0))
            {
                int CardNum = Msg[6];
                if (CardNum == 0)
                {
                    return;
                }
                byte[] daw = new byte[MsgLength - 7];//除去前面6个字节的时间和1个字节的长度
                Array.Copy(Msg, 7, daw, 0, MsgLength - 7);
                string temps = ByteArrayToHexString(daw);
                int m = 0;

                for (int CardIndex = 0; CardIndex < CardNum; CardIndex++)
                {
                    int TIDlen = daw[m];
                    string TagId = temps.Substring(m * 2 + 2, TIDlen * 2);
                    m = m + TIDlen + 1;
                    if (TagId.Length != TIDlen * 2)
                    {
                        return;
                    }
                    door.TagId = TagId;
                    fr.Tb_ShowId.Text = TagId;
                    fr.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + TagId + ".png");
                }
            }
            else if ((fCmdRet == 0) && (MsgType == 1))
            {
                InFlag = Convert.ToByte(Msg[0]);
                switch (InFlag)
                {
                    case 0:
                        ThroughDoorDirection = " 进  库  ";
                        break;
                    case 1:
                        ThroughDoorDirection = " 出  库  ";
                        break;
                }
                int num = 0;
                num = Msg[3] << 16 + Msg[2] << 8 + Msg[1];
                string Rnum = num.ToString();

                num = Msg[6] << 16 + Msg[5] << 8 + Msg[4];
                string Lnum = num.ToString();

                num = Msg[10] << 24 + Msg[9] << 16 + Msg[8] << 8 + Msg[7];
                string Anum = num.ToString();

                year = Convert.ToString(Msg[11]).PadLeft(2, '0');
                month = Convert.ToString(Msg[12]).PadLeft(2, '0');
                Dates = Convert.ToString(Msg[13]).PadLeft(2, '0');
                Hour = Convert.ToString(Msg[14]).PadLeft(2, '0');
                minutes = Convert.ToString(Msg[15]).PadLeft(2, '0');
                second = Convert.ToString(Msg[16]).PadLeft(2, '0');
                ThroughDoorTime = "20" + year + "-" + month + "-" + Dates + " " + Hour + ":" + minutes + ":" + second;
                door.ThroughDoorTime = ThroughDoorTime;
                door.ThroughDoorDirection = ThroughDoorDirection;
                
                if (fr.Tb_ShowId.Text.Equals(""))
                {
                    fr.Tb_ShowState.Text = "";
                    fr.Tb_ShowTime.Text = "";
                }
                else
                {
                    fr.Tb_ShowTime.Text = ThroughDoorTime;
                    fr.Tb_ShowState.Text = ThroughDoorDirection;
                }
            }
            DeviceApi.Acknowledge(ref ControllerAdr, PortHandle);
        }
    }
}
