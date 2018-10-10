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

        //添加仪器出入记录
        public void AddInAndOutRecords(InstrumentInAndOutRecord record, Fingerprint fingerprint, GateData door, Instrument ins)
        {
            JointInAndOutRecord(fingerprint, door, record);
            record.insr_direct = door.Direction;
            record.insr_time = door.Time;
            record.insr_tagid = door.TagId;
            record.insr_instrumentid = ins.Id;
            if (record.insr_insborrowid != null && record.insr_fingerprintid != null && record.insr_direct != null && record.insr_time != null)
            {
                string sql = record.AddInstrumentRecordSql();
                dbo.WriteDB(sql);
            }
        }

        //拼接出入库记录
        private void JointInAndOutRecord(Fingerprint fingerprint, GateData door, InstrumentInAndOutRecord record)
        {
            DataTable findt = Fingerprint(fingerprint);
            DataTable insdt = InsBorrow(door);
            for (int i = 0; i < findt.Rows.Count; i++)
            {
                for (int j = 0;j<insdt.Rows.Count;j++)
                {
                    DataRow finmyDr = findt.Rows[i];
                    DataRow insmyDr = insdt.Rows[j];
                    DateTime emPassTime = Convert.ToDateTime(finmyDr["fi_passtime"]);
                    DateTime insPassTime = door.Time;
                    TimeSpan td = emPassTime.Subtract(insPassTime).Duration();
                    double timeInterval = td.TotalSeconds;
                    //20分钟
                    if (timeInterval <= 1200000)
                    {
                        record.insr_insborrowid = int.Parse(insmyDr["ins_borrowid"].ToString());
                        record.insr_fingerprintid = int.Parse(finmyDr["fi_id"].ToString());
                        record.insr_emnumber = finmyDr["fi_employeenumber"].ToString();
                        return;
                    }
                }
            }
        }

        //查fingerprint表
        private DataTable Fingerprint(Fingerprint fingerprint)
        {
            string sql = fingerprint.FingerprintSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }

        //查insborrow表
        private DataTable InsBorrow(GateData gateData)
        {
            string sql = gateData.InsBorrowSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
