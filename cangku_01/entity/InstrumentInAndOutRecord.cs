using System;
using DbLink;

namespace cangku_01
{
    class InstrumentInAndOutRecord : ActiveRecord
    {
        private InstrumentInAndOutRecord record;
        private ISelectSqlMaker makerIns;
        ISelectSqlMaker makerEm;

        public int? Id { get; set; }
        public int? InstrumentId { get; set; }
        public int? EmployeeId { get; set; }
        public string Direction { get; set; }
        public DateTime? Time { get; set; }

        private InstrumentInAndOutRecord(DbLinkFactory factory) : base("t_insinandoutrecords", "Id", factory)
        {
            AddInstrumentRecordSql();
            record = new InstrumentInAndOutRecord(factory);
            makerIns = factory.CreateSelectSqlMaker("t_instrument");
            makerEm = factory.CreateSelectSqlMaker("t_employee");
        }

        //添加仪器记录
        private string AddInstrumentRecordSql()
        {
            record.InstrumentId = 1;
            record.EmployeeId = 3;
            record.Direction = "是";
            record.Time = new DateTime(2018, 3, 11, 23, 14, 59);
            //record.InstrumentId = Convert.ToUInt16("ins_instrument");
            //record.EmployeeId = Convert.ToUInt16("ins_employeeid");
            //record.Direction = "ins_direct";
            //record.Time = new DateTime(Convert.ToUInt32("ins_time"));
            string sql = record.MakeInsertSqlCommand();
            return sql;
        }

        //通过tagid查仪器数据库id
        private string GetInstrumentInformation(string TagId)
        {
            string sql = makerIns.MakeSelectSql();
            return sql;
        }

        //获取员工id
        private string GetEmployeesInformation()
        {
            string sql = makerEm.MakeSelectSql();
            return sql;
        }
    }
}
