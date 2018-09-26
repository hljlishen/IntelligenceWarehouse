using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cangku_01
{
    delegate void NewGateDataHandler(List<GateData> dateDatas);
    interface IGateDataProcessor
    {
        void ReceiveMsg(byte[] Msg, int MsgType,byte MsgLength);
        DataTable IdQueryInstrumentBorrow(GateData door);
        event NewGateDataHandler NewGateDataEvent;
    }

    class JointProcessor : IGateDataProcessor
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        private List<string> _tagIds = new List<string>();
        private string _direction = null;
        private DateTime? _time = null;
        private Timer _timer;

        public event NewGateDataHandler NewGateDataEvent;

        //定时器
        public JointProcessor()
        {
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Tick += MakeGateData;
        }

        private void MakeGateData(object sender, EventArgs args)
        {
            _timer.Stop();

            if(!_tagIds.Any())
            {
                Initialiaze();
                return;
            }

            List<GateData> gateDatas = MakeGateDatas();

            InsertDatabase(gateDatas);

            InstrumentCardExist(gateDatas);

            Initialiaze();

            NewGateDataEvent?.Invoke(gateDatas);
        }

        private List<GateData> MakeGateDatas()
        {
            List<GateData> gateDatas = new List<GateData>();
            foreach (string id in _tagIds)
            {
                gateDatas.Add(new GateData(id, _direction, _time.Value));
            }
            return gateDatas;
        }

        //添加数据
        private void InsertDatabase(List<GateData> gateDatas)
        {
            for (int i = 0;i<gateDatas.Count;i++)
            {
                InstrumentInterface dao = new InstrumentDataManipulation();
                Instrument ins = new Instrument();
                ins.TagId = gateDatas[i].TagId;
                DataTable dt = dao.TagIdQueryInstrument(ins);
                if (dt.Rows.Count > 0)
                {
                    DataTable datatable = ins.InstrumentTagidFindInstrument();
                    DataRow myDr = datatable.Rows[0];
                    Employee em = new Employee();
                    EmployeesInterface employee = new EmployeeDataManipulation();
                    int dutyid = int.Parse(myDr["in_duty"].ToString());
                    em.Id = dutyid;
                    DataTable emdatatable = employee.IdQueryEmployee(em);
                    DataRow emmyDr = emdatatable.Rows[0];
                    gateDatas[i].Name = myDr["in_name"].ToString();
                    gateDatas[i].Model = myDr["in_model"].ToString();
                    gateDatas[i].Manufactor = myDr["in_manufactor"].ToString();
                    gateDatas[i].Position = myDr["in_position"].ToString();
                    gateDatas[i].Duty = emmyDr["em_name"].ToString();
                }
                string sql = gateDatas[i].BorrowInformationSql();
                dbo.WriteDB(sql);
                if (dt.Rows.Count > 0)
                    InformInsertInAndOutRecords(gateDatas, i);
            }
        }

        //修改仪器状态
        private void ModifyInstrumentState(List<GateData> gateDatas, int i)
        {
            Instrument ins = new Instrument();
            InstrumentDataManipulation dao = new InstrumentDataManipulation();
            if (gateDatas[i].Direction == "出库")
            {
                ins.IsInWareHouse = "不在库";
                ins.TagId = gateDatas[i].TagId;
                dao.UpdateInstrumentInwarehouseState(ins);
            }
            else if (gateDatas[i].Direction == "入库")
            {
                ins.IsInWareHouse = "在库";
                ins.TagId = gateDatas[i].TagId;
                dao.UpdateInstrumentInwarehouseState(ins);
            }
        }

        //当卡号存在仪器表
        private void InstrumentCardExist(List<GateData> gateDatas)
        {
            for (int i = 0;i<gateDatas.Count;i++)
            {
                InstrumentInterface dao = new InstrumentDataManipulation();
                Instrument ins = new Instrument();
                ins.TagId = gateDatas[i].TagId;
                DataTable dt = dao.TagIdQueryInstrument(ins);
                if (dt.Rows.Count > 0)
                {
                    ModifyInstrumentState(gateDatas,i);  
                }
            }
        }

        //通知添加仪器出入库记录信息
        private void InformInsertInAndOutRecords(List<GateData> gateDatas,int i)
        {
            InstrumenBorrowRecord ibr = new InsBorrowRecord();
            InstrumentInAndOutRecord record = new InstrumentInAndOutRecord(factory);
            Fingerprint fingerprint = new Fingerprint(factory);
            ibr.AddInAndOutRecords(record, fingerprint, gateDatas[i]);
        }

        private void Initialiaze()
        {
            _direction = null;
            _time = null;
            _tagIds.Clear();
        }

        //msgtype为0
        private void GetMsgType0(byte[] Msg,byte MsgLength)
        {
            int CardNum = Msg[6];
            if (CardNum == 0)
                return;
            byte[] daw = new byte[MsgLength - 7];//除去前面6个字节的时间和1个字节的长度
            Array.Copy(Msg, 7, daw, 0, MsgLength - 7);
            string temps = ByteArrayToHexString(daw);
            for (int CardIndex = 0, m = 0; CardIndex < CardNum; CardIndex++)
            {
                int TIDlen = daw[m];
                string tagId = temps.Substring(m * 2 + 2, TIDlen * 2);
                if (!_tagIds.Contains(tagId))
                    _tagIds.Add(tagId);
                m = m + TIDlen + 1;
            }
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();
        }

        //msgtype为1
        private void GetMsgType1(byte[] Msg)
        {
            var InFlag = Convert.ToByte(Msg[0]);
            switch (InFlag)
            {
                case 0:
                    _direction = "入库";
                    break;
                case 1:
                    _direction = "出库";
                    break;
            }
            var year = Convert.ToString(Msg[11]).PadLeft(2, '0');
            var month = Convert.ToString(Msg[12]).PadLeft(2, '0');
            var Dates = Convert.ToString(Msg[13]).PadLeft(2, '0');
            var Hour = Convert.ToString(Msg[14]).PadLeft(2, '0');
            var minutes = Convert.ToString(Msg[15]).PadLeft(2, '0');
            var second = Convert.ToString(Msg[16]).PadLeft(2, '0');
            _time = DateTime.Parse("20" + year + "-" + month + "-" + Dates + " " + Hour + ":" + minutes + ":" + second);
            _timer.Start();
        }

        public void ReceiveMsg(byte[] Msg, int MsgType, byte MsgLength)
        {
            if (MsgType == 0)
            {
                GetMsgType0(Msg, MsgLength);
            }
            else if (MsgType == 1)
            {
                GetMsgType1(Msg);
            }
            else
            {
                throw new Exception($"错误的MsgType:{MsgType}");
            }
        }

        //id查仪器借用表的信息
        public DataTable IdQueryInstrumentBorrow(GateData door)
        {
            string sql = door.IdQueryInstrumentBorrowSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
