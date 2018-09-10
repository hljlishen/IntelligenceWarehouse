using cangku_01.entity;
using cangku_01.GateDrive;
using cangku_01.interfaces;
using cangku_01.MysqlConnection;
using System;
using System.Data;

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

        //记录搜索
        public DataTable SearchRecords(InstrumentInAndOutRecord record)
        {
            string sql = record.QueryInAndOutRecordSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //添加仪器出入记录
        public void AddInAndOutRecords(InstrumentInAndOutRecord record, Employee ee, GateData door)
        {
            GetInstrumentId(door,record);
            GetEmployeeId(record,ee,door);
            record.ins_direct = door.ThroughDoorDirection;
            record.ins_time = DateTime.Parse(door.ThroughDoorTime);
            string sql = record.AddInstrumentRecordSql();
            dbo.WriteDB(sql);

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
        public void GetEmployeeId(InstrumentInAndOutRecord record,Employee ee,GateData door)
        {
            DataTable dt = GetEmployeeDbId(ee,door);
            DataRow myDr = dt.Rows[0];
            record.ins_employeeid = Convert.ToInt16(myDr["em_id"]);
        }

        public DataTable GetEmployeeDbId(Employee ee, GateData door)
        {
            Fingerprint(ee);
            DataTable dt = GetEmployeeDbId(ee, door);
            DataRow myDr = dt.Rows[0];
            ee.EmployeeNumber = myDr["fi_employeenumber"].ToString();
            //DateTime emPassTime = ee.PassDoor;
            //DateTime insPassTime = DateTime.Parse(door.ThroughDoorTime);
            //TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
            //double timeInterval = td.TotalSeconds;
            //if (timeInterval <= 1200)
            //{

            //}
            //string sql = ee.EmployeeNumberFindEmployeeSql();
            //DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //查fingerprint表
        public DataTable Fingerprint(Employee ee)
        {
            string sql = ee.FingerprintSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
