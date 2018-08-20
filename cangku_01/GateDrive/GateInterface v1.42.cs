using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using Gate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int Port = 6000;
        private string ipAddr = "192.168.1.190";
        private bool IsGetting;
        private byte[] MaskData = new byte[100];
        private byte[] setTime = new byte[6];
        private byte[] MaskAdr = new byte[2];
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

        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);
        List<GateData> gateDatas = new List<GateData>();
        GateData door = new GateData();

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
        
        public void StartDetect(Form1 fr)
        {
            string ThroughDoorTime;
            string ThroughDoorDirection;
            IsGetting = true;    
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
                    //FileInfo f = new FileInfo(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + TagId + ".png");
                    //if (f.Exists)
                    //{
                    //    fr.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + TagId + ".png");
                    //}
                    //else
                    //{
                    //    fr.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\..\image\InstrumentPhoto\" + "仪器" + ".png");
                    //}

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
                year = Convert.ToString(Msg[11]).PadLeft(2, '0');
                month = Convert.ToString(Msg[12]).PadLeft(2, '0');
                Dates = Convert.ToString(Msg[13]).PadLeft(2, '0');
                Hour = Convert.ToString(Msg[14]).PadLeft(2, '0');
                minutes = Convert.ToString(Msg[15]).PadLeft(2, '0');
                second = Convert.ToString(Msg[16]).PadLeft(2, '0');
                ThroughDoorTime = "20" + year + "-" + month + "-" + Dates + " " + Hour + ":" + minutes + ":" + second;
                door.ThroughDoorTime = ThroughDoorTime;
                door.ThroughDoorDirection = ThroughDoorDirection;
                gateDatas.Add(door);
                MessageBox.Show(door.TagId);
                MessageBox.Show(door.ThroughDoorTime);
                MessageBox.Show(door.ThroughDoorDirection);
                //if (!fr.Tb_ShowId.Text.Equals(""))
                //{
                //    TagIDQueryInstrumentName(door);
                //    DataTable dt = TagIDQueryInstrumentName(door);
                //    DataRow myDr = dt.Rows[0];
                //    fr.Tb_ShowName.Text = myDr["in_name"].ToString();
                //    fr.Tb_ShowTime.Text = ThroughDoorTime;
                //    fr.Tb_ShowState.Text = ThroughDoorDirection;
                //    if (fr.Tb_ShowTime.Text.Equals("") && fr.Tb_ShowState.Text.Equals(""))
                //    {
                //        throw new Exception("未读到数据");
                //    }
                //    else
                //    {
                //        BorrowInformation(door);

                //    }
                // }
            }
            DeviceApi.Acknowledge(ref ControllerAdr, PortHandle);
        }
        //将探测到的借用信息存入到数据库
        public void BorrowInformation(GateData insborrow)
        {
            string sql = insborrow.BorrowInformationSql();
            
            dbo.WriteDB(sql);
        }
        //查询Tagid仪器名
        public DataTable TagIDQueryInstrumentName(GateData door)
        {
            string sql = door.TagIDQueryInstrumentNameSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
