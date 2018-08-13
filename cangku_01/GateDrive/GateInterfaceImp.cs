using Gate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    class GateInterfaceImp : GateInterface
    {
        private static int fCmdRet = 30;
        private static byte ControllerAdr = 0xff;
        private static int PortHandle = -1;
        private static byte IRStatus;
        private static byte fModel;
        private static string mtidaddr = "00";
        private static string Mtidlen = "06";
        private static string Maddr = "0000";
        private static string Mlen = "00";
        private static int Port = Convert.ToInt32(6000);
        private static string ipAddr = "192.168.1.190";
        private static string Mdata = "";
        //关闭门的网口
        public int Close()
        {
            fCmdRet = Device.CloseNetPort(PortHandle);
            return 0;
        }
        //打开门的网口
        public int Open()
        {
            try
            {
                fCmdRet = Device.OpenNetPort(Port, ipAddr, ref ControllerAdr, ref PortHandle);
                if (fCmdRet == 0)
                {
                    GetDeviceInfo(null, null);
                    fModel = 0;
                    fCmdRet = Device.ModeSwitch(ref ControllerAdr, ref fModel, ref IRStatus, PortHandle);
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }
        //门配置
        private void SetGateConfigure(object sender, EventArgs e)
        {
            byte IREnable = 0;
            byte IRTime = 0;
            byte TagExistTime = 0;
            byte AlarmEn = 0;
            byte DelayTime = 0;
            byte Pepolemsg = 0;
            byte AEn = 1;
            fCmdRet = Device.ConfigureController(ref ControllerAdr, IREnable, IRTime, TagExistTime, AlarmEn, DelayTime, Pepolemsg, AEn, ref IRStatus, PortHandle);
        }
        //获取配置信息
        private void GetGateConfigure(object sender, EventArgs e)
        {
            byte IREnable = 0;
            byte IRTime = 0;
            byte TagExistTime = 0;
            byte AlarmEn = 0;
            byte DelayTime = 0;
            byte Pepolemsg = 0;
            byte AEn = 1;
            fCmdRet = Device.GetControllerConfig(ref ControllerAdr, ref IREnable, ref IRTime, ref TagExistTime, ref AlarmEn, ref DelayTime, ref Pepolemsg, ref AEn, ref IRStatus, PortHandle);
        }
        //设置控制器地址
        private void SetControAddr(object sender, EventArgs e)
        {
            byte NewAddr = 0;
            byte Mode = 1;
            string TextNewConAddr ="00";
            NewAddr = Convert.ToByte(TextNewConAddr, 16);
            fCmdRet = Device.SetControllerAddr(ref ControllerAdr, Mode, NewAddr, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
                ControllerAdr = NewAddr;
        }
        //时间
        private void ClockCMD(object sender, EventArgs e)
        {
            byte[] setTime = new byte[6];
            byte outTime = Convert.ToByte(DateTime.Now);
            fCmdRet = Device.GetClock(ref ControllerAdr, setTime, ref IRStatus, PortHandle);
        }
        //红外方向
        private void SetIR(object sender, EventArgs e)
        {
            byte model = 0;
            fCmdRet = Device.IRDirectionSetting(ref ControllerAdr, ref model, ref IRStatus, PortHandle);
        }
        private void GetIR(object sender, EventArgs e)
        {
            byte model = 0;
            fCmdRet = Device.IRDirectionSetting(ref ControllerAdr, ref model, ref IRStatus, PortHandle);
            if (model == 0)
            {
                //StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " " + "红外线正向";
            }
            if (model == 1)
            {
                //StatusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString() + " " + "红外线反向";
            }
        }
        // 存盘后查询
        #region  16进制字符串到数组之间的相互转换
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();
        }
        #endregion
        private void SetParameter(object sender, EventArgs e)
        {
            byte Qvalue = 0;
            byte Session = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            
            if (Session == 4) Session = 255;
            AdrTID = Convert.ToByte(mtidaddr, 16);
            LenTID = Convert.ToByte(Mtidlen, 16);
            MaskMem = 2;
            MaskAdr = HexStringToByteArray(Maddr);
            MaskLen = Convert.ToByte(Mlen, 16);
            if (Mdata.Length % 2 == 0)
                MaskData = HexStringToByteArray(Mdata);
            fCmdRet = Device.SetReadParameter(ref ControllerAdr, Qvalue, Session, AdrTID, LenTID, MaskMem, MaskAdr, MaskLen, MaskData, ref IRStatus, PortHandle);
        }
        //读取查询
        private void GetParameter(object sender, EventArgs e)
        {
            byte Qvalue = 0;
            byte Session = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            fCmdRet = Device.GetReadParameter(ref ControllerAdr, ref Qvalue, ref Session, ref AdrTID, ref LenTID, ref MaskMem, MaskAdr, ref MaskLen, MaskData, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                if (Session == 255)
                    Qvalue = 4;
                mtidaddr = Convert.ToString(AdrTID, 16).PadLeft(2, '0');
                Mtidlen = Convert.ToString(LenTID, 16).PadLeft(2, '0');
                if(MaskMem == 2)
                Mlen = Convert.ToString(MaskLen, 16).PadLeft(2, '0');
                int len = 0;
                if (MaskLen % 8 == 0)
                {
                    len = MaskLen / 8;
                }
                else
                {
                    len = MaskLen / 8 + 1;
                }
                string temp = "";
                for (int m = 0; m < len; m++)
                {
                    temp = temp + Convert.ToString(MaskData[m], 16).PadLeft(2, '0');
                }
                Mdata = temp;
            }
        }


        private void GetDeviceInfo(object sender, EventArgs e)
        {
            byte Productcode = 0;
            byte MainVer = 0;
            byte SubVer = 0;
            string gateModel;
            fCmdRet = Device.GetControllerInfo(ref ControllerAdr, ref Productcode, ref MainVer, ref SubVer, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                string productcode = Convert.ToString(Productcode, 16).PadLeft(2, '0').ToUpper();
                if (productcode == "90")
                {
                    gateModel = "RRU-CH-WL";
                }
                if (productcode == "91")
                {
                    gateModel = "RRU-CH-C16058";
                }
                string version = Convert.ToString(MainVer, 16).PadLeft(2, '0').ToUpper() + "." + Convert.ToString(SubVer, 16).PadLeft(2, '0').ToUpper();
            }
        }


        //开始执行读卡
        public int StartReaderTagId()
        {
            throw new NotImplementedException();
        }
    }
}
