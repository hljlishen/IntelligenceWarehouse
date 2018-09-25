using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Data;

namespace cangku_01.entity
{
    public class Fingerprint : ActiveRecord
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public int? fi_id { get; set; }
        public string fi_employeenumber { get; set; }
        public DateTime? fi_passtime { get; set; }
        public string fi_name { get; set; }

        ISelectSqlMaker maker;

        //private int thisIsNotAProperty;
        //public int Get() => thisIsNotAProperty;
        //public void Set(int value) => thisIsNotAProperty = value;

        //public int ThisIsAproperty { get; set; }

        public Fingerprint(DbLinkFactory factory) : base("t_fingerprint", "fi_id", factory)
        {

        }
        //重写模板
        public override void Insert()
        {
            base.Insert();
        }

        //查指纹信息
        public string FingerprintSql()
        {
            SetupFingerprint();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //指纹id查信息
        private string FingerprintIdQuerySql()
        {
            SetupFingerprint();
            maker.AddAndCondition(new IntEqual("fi_id",Convert.ToInt32(fi_id)));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void SetupFingerprint()
        {
            maker = factory.CreateSelectSqlMaker("t_fingerprint");
        }

        //指纹id查询员工
        public DataTable FingerprinIdQueryEmployee(Fingerprint fingerprint)
        {
            string sql = fingerprint.FingerprintIdQuerySql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
        }
    }
}
