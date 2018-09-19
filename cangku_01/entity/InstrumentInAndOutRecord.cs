using System;
using DbLink;

namespace cangku_01
{
    public class InstrumentInAndOutRecord : ActiveRecord
    {
        private ISelectSqlMaker maker;
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public int? ins_recordsid { get; set; }
        public int? ins_instrumentid { get; set;}
        public int? ins_employeeid { get; set; }
        public string ins_direct { get; set; }
        public DateTime? ins_time { get; set; }

        public InstrumentInAndOutRecord(DbLinkFactory factory) : base("t_insinandoutrecords", "ins_recordsid", factory)
        {
        }

        private void SetupInsRecord()
        {
            maker = factory.CreateSelectSqlMaker("t_insinandoutrecords");
        }

        //添加仪器记录
        public string AddInstrumentRecordSql()
        {
            InstrumentInAndOutRecord record = new InstrumentInAndOutRecord(factory);
            SetupInsRecord();
            record.ins_instrumentid = ins_instrumentid;
            record.ins_employeeid = ins_employeeid;
            record.ins_direct = ins_direct;
            record.ins_time = ins_time;
            string sql = record.MakeInsertSqlCommand();
            return sql;
        }

        //获取全部仪器出入库记录的信息
        public string QueryAllInstrumentInAndOutRecordsSql()
        {
            SetupInsRecord();
            string sql = maker.MakeSelectSql();
            return sql;
        }
    }
}
