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
        public DataTable AllInAndOutRecords()
        {
            InstrumentInAndOutRecord record = new InstrumentInAndOutRecord();
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
            DateTime emPassTime = ee.PassDoor;
            DateTime insPassTime = DateTime.Parse(door.ThroughDoorTime);
            TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
            double timeInterval = td.TotalSeconds;
            if (timeInterval <= 1800)
            {

            }
        }

        public DataTable IdQueryEmployee(InstrumentInAndOutRecord record)
        {
            string sql = record.IdQueryEmployeeSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
