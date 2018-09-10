using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using Gate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace cangku_01.GateDrive
{
    class GateInterfaceImp : GateInterface
    {
        private int fCmdRet = 30;
        private byte ControllerAdr = 0xff;
        private int PortHandle = -1;
        private byte IRStatus;
        private byte fModel;
        private int Port = 6000;
        private string ipAddr = "192.168.1.190";
        private bool IsGetting;
        private byte Productcode = 0;
        private byte MainVer = 0;
        private byte SubVer = 0;
        private string gateModel= "RRU-CH-WL";
        private byte InFlag;
        private byte[] Msg = new byte[300];
        private string year, month, Dates, Hour, minutes, second;
        private byte MsgLength = 0;
        private byte MsgType = 0;
        private string ThroughDoorTime = "";
        private string ThroughDoorDirection = "";
        private string productCode = "";

        private static GateData door = new GateData();
        private static DataShowInterface data = new DataShow();
        private static GateInterfaceImp gateInterface = new GateInterfaceImp();

        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);


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
            fCmdRet = DeviceApi.OpenNetPort(Port, ipAddr, ref ControllerAdr, ref PortHandle);
            if (fCmdRet == 0)
            {
                GetDeviceInfo();
                fModel = 0;
                fCmdRet = DeviceApi.ModeSwitch(ref ControllerAdr, ref fModel, ref IRStatus, PortHandle);
            }
            else
            {
                MessageBox.Show("连接失败");    
            }
        }

        private void GetDeviceInfo()
        {
            fCmdRet = DeviceApi.GetControllerInfo(ref ControllerAdr, ref Productcode, ref MainVer, ref SubVer, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                if (productCode == Convert.ToString(Productcode, 16).PadLeft(2, '0').ToUpper())
                {
                    string gatemodel = gateModel;
                }
                string version = Convert.ToString(MainVer, 16).PadLeft(2, '0').ToUpper() + "." + Convert.ToString(SubVer, 16).PadLeft(2, '0').ToUpper();
            }
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();
        }
       
        //开始探测
        public void StartDetect(Form1 fr)
        {
            IsGetting = true;
            fCmdRet = DeviceApi.GetChannelMessage(ref ControllerAdr, Msg, ref MsgLength, ref MsgType, ref IRStatus, PortHandle);
            if ((fCmdRet == 0) && (MsgType == 0))
            {
                DetectTagId(fr);//获取TagID  
            }
            else if ((fCmdRet == 0) && (MsgType == 1))
            {
                DetectDirectionAndTime(fr);//获取方向和时间
            }
            DeviceApi.Acknowledge(ref ControllerAdr, PortHandle);
        }

        //探测的TagId
        public void DetectTagId(Form1 fr)
        {
            int CardNum = Msg[6];
            if (CardNum == 0) return;
            byte[] daw = new byte[MsgLength - 7];//除去前面6个字节的时间和1个字节的长度
            Array.Copy(Msg, 7, daw, 0, MsgLength - 7);
            string temps = ByteArrayToHexString(daw);
            string TagId = null;
            int m = 0;
            for (int CardIndex = 0; CardIndex < CardNum; CardIndex++)
            {
                int TIDlen = daw[m];
                TagId = temps.Substring(m * 2 + 2, TIDlen * 2);
                m = m + TIDlen + 1;
                door.TagId = TagId;
                data.GetTagIdName(door);
                if (door.TagId != null && door.Name != null && door.ThroughDoorDirection != null)
                {
                    data.ShowInstrumentPhoto(door, fr);
                    data.TextAndListViewShow(door,fr);
                }
            }
            door.ThroughDoorDirection = null;
        }

        //探测的方向和时间
        public void DetectDirectionAndTime(Form1 fr)
        {
            InFlag = Convert.ToByte(Msg[0]);
            switch (InFlag)
            {
                case 0:
                    ThroughDoorDirection = "入库";
                    break;
                case 1:
                    ThroughDoorDirection = "出库";
                    break;
            }
            door.ThroughDoorDirection = ThroughDoorDirection;
            year = Convert.ToString(Msg[11]).PadLeft(2, '0');
            month = Convert.ToString(Msg[12]).PadLeft(2, '0');
            Dates = Convert.ToString(Msg[13]).PadLeft(2, '0');
            Hour = Convert.ToString(Msg[14]).PadLeft(2, '0');
            minutes = Convert.ToString(Msg[15]).PadLeft(2, '0');
            second = Convert.ToString(Msg[16]).PadLeft(2, '0');
            ThroughDoorTime = "20" + year + "-" + month + "-" + Dates + " " + Hour + ":" + minutes + ":" + second;
            door.ThroughDoorTime = ThroughDoorTime;
        }
    }
}
