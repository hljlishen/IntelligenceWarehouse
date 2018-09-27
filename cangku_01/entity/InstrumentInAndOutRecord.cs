using System;
using DbLink;

namespace cangku_01
{
    public class InstrumentInAndOutRecord : ActiveRecord
    {
        private ISelectSqlMaker maker;
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public int? insr_recordsid { get; set; }
        public int? insr_insborrowid { get; set;}
        public int? insr_fingerprintid { get; set; }
        public string insr_direct { get; set; }
        public DateTime? insr_time { get; set; }
        public string insr_tagid { get; set; }
        public string insr_emnumber { get; set; }

        public InstrumentInAndOutRecord(DbLinkFactory factory) : base("t_insinandoutrecords", "insr_recordsid", factory)
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
            record.insr_insborrowid = insr_insborrowid;
            record.insr_fingerprintid = insr_fingerprintid;
            record.insr_direct = insr_direct;
            record.insr_time = insr_time;
            record.insr_tagid = insr_tagid;
            record.insr_emnumber = insr_emnumber;
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
