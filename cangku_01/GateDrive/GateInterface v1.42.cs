using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using DbLink;
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
        private List<GateData> gateData = new List<GateData>();

        List<string> list = new List<string>();
        InstrumenBorrowRecord ibr = new InsBorrowRecord();
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        InstrumentInAndOutRecord record = new InstrumentInAndOutRecord(factory);
        Instrument ins = new Instrument();
        Employee ee = new Employee();
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
            int ret = DeviceApi.ClearControllerBuffer(ref ControllerAdr, ref IRStatus, PortHandle);
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
            GateData door = new GateData();
            if (IsGetting) return;
            IsGetting = true;
            Msg = new byte[300];
            fCmdRet = DeviceApi.GetChannelMessage(ref ControllerAdr, Msg, ref MsgLength, ref MsgType, ref IRStatus, PortHandle);
            if (fCmdRet == 0)
            {
                if (MsgType == 0)
                {
                    DetectTagId();//获取TagID 
                }
                if (MsgType == 1)
                {
                    DetectDirectionAndTime();//获取方向和时间
                }
                RecordTimeAndDirection();

                if (IsGateDataReady())
                {
                    foreach (GateData data in gateData)
                    {
                        DetermineCardExistence(data, fr);
                    }
                    
                    gateData.Clear();
                    ThroughDoorDirection = "";
                    ThroughDoorTime = "";
                }
            }
            DeviceApi.Acknowledge(ref ControllerAdr, PortHandle);
            IsGetting = false;
        }

        private bool IsGateDataReady()
        {
            if (!gateData.Any()) return false;
            foreach(GateData data in gateData)
            {
                if (!data.IsValid()) return false;
            }

            return true;
        }

        private void RecordTimeAndDirection()
        {
            if (string.IsNullOrEmpty(ThroughDoorDirection)) return;
            foreach (GateData data in gateData)
            {
                data.Direction = ThroughDoorDirection;
                data.Time = DateTime.Parse(ThroughDoorTime);
            }
        }

        //探测的TagId
        private void DetectTagId()
        {
            int CardNum = Msg[6];
            if (CardNum == 0)
                return;
            byte[] daw = new byte[MsgLength - 7];//除去前面6个字节的时间和1个字节的长度
            Array.Copy(Msg, 7, daw, 0, MsgLength - 7);
            string temps = ByteArrayToHexString(daw);
            int m = 0;
            list = new List<string>();
            for (int CardIndex = 0; CardIndex < CardNum; CardIndex++)
            {
                int TIDlen = daw[m];
                string tagId = temps.Substring(m * 2 + 2, TIDlen * 2);
                if (!list.Contains(tagId))
                    list.Add(tagId);
                m = m + TIDlen + 1;
            }
            foreach (string id in list)
            {
                Console.WriteLine(id + $"   CardNum = {CardNum}");

                GateData gateData = new GateData();
                gateData.TagId = id;
                this.gateData.Add(gateData);
            }
            Console.WriteLine("-------------------------------------------");
        }

        //探测的方向和时间
        private void DetectDirectionAndTime()
        {
            for (int i = 0; i<list.Count;i++)
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
                year = Convert.ToString(Msg[11]).PadLeft(2, '0');
                month = Convert.ToString(Msg[12]).PadLeft(2, '0');
                Dates = Convert.ToString(Msg[13]).PadLeft(2, '0');
                Hour = Convert.ToString(Msg[14]).PadLeft(2, '0');
                minutes = Convert.ToString(Msg[15]).PadLeft(2, '0');
                second = Convert.ToString(Msg[16]).PadLeft(2, '0');
                ThroughDoorTime = "20" + year + "-" + month + "-" + Dates + " " + Hour + ":" + minutes + ":" + second;
                Console.WriteLine(ThroughDoorTime);
                if(gateData.Count == 0)
                {

                }
            }
        }

        //将探测到的借用信息存入到数据库
        private void BorrowInformation(GateData insborrow)
        {
            string sql = insborrow.BorrowInformationSql();
            dbo.WriteDB(sql);
        }

        //判断是否存在标签
        private void DetermineCardExistence(GateData door,Form1 fr)
        {
            InstrumentInterface dao = new InstrumentDataManipulation();
            ins.TagId = door.TagId;
            DataTable dt = dao.TagIdQueryInstrument(ins);
            if (dt.Rows.Count > 0)
            {
                BorrowInformation(door);
                ibr.AddInAndOutRecords(record, ee, door);
                UpdateInwarehouseState(door);
                fr.TextAndListViewShow(door);
            }
        }

        //更新仪器在库状态
        private void UpdateInwarehouseState(GateData door)
        {
            InstrumentDataManipulation dao = new InstrumentDataManipulation();
            if (door.Direction == "出库")
            {
                ins.IsInWareHouse = "不在库";
                dao.UpdateInstrumentInwarehouseState(ins);
            }
            else if (door.Direction == "入库")
            {
                ins.IsInWareHouse = "在库";
                dao.UpdateInstrumentInwarehouseState(ins);
            }
        }
    }
}
