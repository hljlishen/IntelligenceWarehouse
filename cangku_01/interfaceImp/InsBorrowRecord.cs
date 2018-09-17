using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using System;
using System.Data;
using System.Data.SqlClient;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//仪器出入库接口实现
namespace cangku_01.interfaceImp
{
    internal class InsBorrowRecord : InstrumenBorrowRecord
    {
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        //全部仪器出库和入库记录
        public DataTable AllInAndOutRecords(InstrumentInAndOutRecord record)
        {
            string sql = record.QueryAllInstrumentInAndOutRecordsSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //添加仪器出入记录
        public void AddInAndOutRecords(InstrumentInAndOutRecord record, Employee ee, GateData door)
        {
            MergeInAndOutRecord(ee, door, record);
            record.ins_direct = door.Direction;
            record.ins_time = door.Time;
            if (record.ins_instrumentid != null && record.ins_employeeid != null && record.ins_direct != null && record.ins_time != null)
            {
                string sql = record.AddInstrumentRecordSql();
                dbo.WriteDB(sql);
            }
        }

        //通过tagid查询仪器id
        public void GetInstrumentId(GateData door,InstrumentInAndOutRecord record)
        {
            DataTable dt = GetInstrumentDbId(door);
            DataRow myDr = dt.Rows[0];
            record.ins_instrumentid = Convert.ToInt16(myDr["in_id"]);
        }

        public DataTable GetInstrumentDbId(GateData door)
        {
            Instrument ins = new Instrument();
            ins.TagId = door.TagId;
            string sql = ins.TagIDQueryInstrumentSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //通过员工编号查询员工id
        public void GetEmployeeId(InstrumentInAndOutRecord record,Employee ee)
        {
            DataTable dt = GetEmployeeDbId(ee); 
            DataRow myDr = dt.Rows[0];
            record.ins_employeeid = Convert.ToInt16(myDr["em_id"]);
        }

        public DataTable GetEmployeeDbId(Employee ee)
        {
            DataTable dt1 = Fingerprint(ee);
            DataRow myDr = dt1.Rows[0];
            ee.EmployeeNumber = myDr["fi_employeenumber"].ToString();
            string sql = ee.EmployeeNumberFindEmployeeSql();
            DataTable dt2 = dbo.ReadDBDataTable(sql);
            return dt2;
        }

        //查fingerprint表
        public DataTable Fingerprint(Employee ee)
        {
            string sql = ee.FingerprintSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        public void MergeInAndOutRecord(Employee ee,GateData door, InstrumentInAndOutRecord record)
        {
            DataTable dt = Fingerprint(ee);
            int count = dt.Rows.Count;///得到你数据源的行数 
            for (int i=0; i < count; i++)
            {
                DataRow myDr = dt.Rows[i];
                ee.PassDoor = Convert.ToDateTime(myDr["fi_passtime"]);
                DateTime emPassTime = ee.PassDoor;
                DateTime insPassTime = door.Time;
                TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
                double timeInterval = td.TotalSeconds;
                if (timeInterval <= 12000)
                {
                    GetInstrumentId(door, record);
                    GetEmployeeId(record, ee);
                }
            }
        }
    }
}
