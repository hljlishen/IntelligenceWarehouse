using System;
using DbLink;

namespace cangku_01
{
    public class InstrumentInAndOutRecord : ActiveRecord
    {
        private ISelectSqlMaker maker;
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();

        public int? ins_recordsid { get; set; }
        public int? ins_instrumentid { get; set; }
        public int? ins_employeeid { get; set; }
        public string ins_direct { get; set; }
        public DateTime? ins_time { get; set; }

        public InstrumentInAndOutRecord() : base("t_insinandoutrecords", "ins_recordsid", factory)
        {
        }

        private void SetupInsRecord()
        {
            maker = factory.CreateSelectSqlMaker("t_insinandoutrecords");
        }

        private void SetInstrument()
        {
            maker = factory.CreateSelectSqlMaker("t_instrument");
        }

        private void SetEmployee()
        {
            maker = factory.CreateSelectSqlMaker("t_employee");
        }

        ////添加仪器记录
        //public string AddInstrumentRecordSql()
        //{
        //    SetupInsRecord();
        //    record.ins_instrumentid = Convert.ToUInt16("ins_instrument");
        //    record.ins_employeeid = Convert.ToUInt16("ins_employeeid");
        //    record.ins_direct = "ins_direct";
        //    record.ins_time = new DateTime(Convert.ToUInt32("ins_time"));
        //    string sql = record.MakeInsertSqlCommand();
        //    return sql;
        //}

        //获取全部仪器出入库记录的信息
        public string QueryAllInstrumentInAndOutRecordsSql()
        {
            SetupInsRecord();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //员工id查员工信息
        public string IdQueryEmployeeSql()
        {
            SetEmployee();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //仪器出入库记录的多条件搜索
        public string QueryInAndOutRecordSql()
        {
            SetupInsRecord();
            maker.AddAndCondition(new IntEqual("ins_instrumentid",Convert.ToInt32(ins_instrumentid)));
            maker.AddAndCondition(new IntEqual("ins_employeeid", Convert.ToInt32(ins_employeeid)));
            maker.AddAndCondition(new StringEqual("ins_direct", ins_direct));
            maker.AddAndCondition(new DateBetweenOpenInterval("ins_time", ins_time, ins_time, factory.CreateDateTimeFormater()));
            maker.AddSelectField("ins_instrumentid");
            maker.AddSelectField("ins_employeeid");
            maker.AddSelectField("ins_direct");
            maker.AddSelectField("ins_time");
            string sql = maker.MakeSelectSql();
            return sql;
        }
    }
}
