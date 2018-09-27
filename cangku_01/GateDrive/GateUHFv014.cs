using Gate;
using System;
using System.Windows.Forms;

namespace cangku_01.GateDrive
{
    class GateUhfv014 : GateInterface
    {
        private int fCmdRet = 30;
        private byte ControllerAdr = 0xff;
        private int PortHandle = -1;
        private byte IRStatus; 
        private bool IsGetting;
        private IGateDataProcessor processor;
        private static GateUhfv014 gate = null;

        public GateUhfv014(IGateDataProcessor processor)
        {
            this.processor = processor;
        }

        //关闭门的网口
        public void Close()
        {
            fCmdRet = DeviceApi.CloseNetPort(PortHandle);
            if (fCmdRet != 0)
            {
                throw new Exception("网口关闭失败");
            }
        }

        //打开门的网口
        public void Open()
        {
            int Port = 6000;
            string ipAddr = "192.168.1.190";
            fCmdRet = DeviceApi.OpenNetPort(Port, ipAddr, ref ControllerAdr, ref PortHandle);
            if (fCmdRet == 0)
            {
                byte fModel = 0;
                GetDeviceInfo();
                fCmdRet = DeviceApi.ModeSwitch(ref ControllerAdr, ref fModel, ref IRStatus, PortHandle);
            }
            else
            {
                MessageBox.Show("电子标签通道设备连接失败");
            }
            int ret = DeviceApi.ClearControllerBuffer(ref ControllerAdr, ref IRStatus, PortHandle);
        }

        private void GetDeviceInfo()
        {
            byte Productcode = 0;
            byte MainVer = 0;
            byte SubVer = 0;
            string productCode = "";
            fCmdRet = DeviceApi.GetControllerInfo(ref ControllerAdr, ref Productcode, ref MainVer, ref SubVer, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                if (productCode == Convert.ToString(Productcode, 16).PadLeft(2, '0').ToUpper())
                {
                    string gatemodel = "RRU-CH-WL";
                }
                string version = Convert.ToString(MainVer, 16).PadLeft(2, '0').ToUpper() + "." + Convert.ToString(SubVer, 16).PadLeft(2, '0').ToUpper();
            }
        }

        //开始探测
        public void Detect()
        {
            byte[] Msg = new byte[300];
            byte MsgLength = 0;
            byte MsgType = 0;
            if (IsGetting) return;
            IsGetting = true;
            fCmdRet = DeviceApi.GetChannelMessage(ref ControllerAdr, Msg, ref MsgLength, ref MsgType, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                processor.ReceiveMsg(Msg, MsgType, MsgLength);
            }
            DeviceApi.Acknowledge(ref ControllerAdr, PortHandle);
            IsGetting = false;
        }
    }
}
