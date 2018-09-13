using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Windows.Forms;

//仪器实体类

namespace cangku_01.entity
{
    public class Instrument
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public int Id { get; set; }                  //sql仪器主键id
        public string TagId { get; set; }            //仪器标签ID
        public string Name { get; set; }             //仪器名称
        public string Model { get; set; }            //型号规格
        public string Manufactor { get; set; }       //生产厂商
        public string SerialNumber { get; set; }     //出厂编号
        public DateTime ProductionDate { get; set; } //生产日期
        public string Position { get; set; }         //货架位置  
        public string IsInWareHouse { get; set; }    //在库状态       
        public int CheckCycle { get; set; }          //检定周期
        public DateTime LastCheckTime { get; set; }  //上一次检查时间
        public int Duty { get; set; }                //责任人

        ISelectSqlMaker maker;

        //计算下一次检查日期
        public string NextCheckTimes()
        {
            string NextCheckTimes = LastCheckTime.AddDays(CheckCycle).ToString("yyyy-MM-dd");
            return NextCheckTimes;
        }

        //计算剩余的检查日期
        public int TimeRemaining()
        {
            string TimeRemaining = (LastCheckTime.AddDays(CheckCycle) - DateTime.Now).Days.ToString();
            int timeremaining = int.Parse(TimeRemaining);
            return timeremaining;
        }

        //将日期转化为String年、月、日
        public string DateFormatConversion(DateTime data)
        {
            string StringData = data.ToString("yyyy-MM-dd");
            return StringData;
        }

        //获取全部仪器信息sql
        public string QueryAllInstrumentSql()
        {
            SetupInstrument();
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //TagID查询仪器信息sql
        public string TagIDQueryInstrumentSql()
        {
            SetupInstrument();
            maker.AddAndCondition(new StringEqual("in_tagid", TagId));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //仪器信息添加sql
        public string AddInstrumentSql()
        {
            string sql = "insert into t_instrument (in_tagid,in_name,in_model,in_manufactor,in_serialnumber,in_productiondate,in_position,in_isinwarehouse,in_checkcycle,in_lastchecktimes,in_duty)" +
                "values('"+ TagId + "','" + Name + "','" + Model + "','" + Manufactor + "','" + SerialNumber + "','" + ProductionDate + "','" 
                + Position + "','" + IsInWareHouse + "','" + CheckCycle + "','" + LastCheckTime + "','" + Duty + "')";
            return sql;
        }

        //仪器信息修改sql
        public string UpdateInstrumentSql()
        {
            string sql = "update t_instrument set in_name='" + Name + "',in_model='"
                + Model + "',in_manufactor='" + Manufactor + "',in_serialnumber='" + SerialNumber + "',in_productiondate='" 
                + ProductionDate + "',in_position='" + Position + "',in_isinwarehouse='" + IsInWareHouse + "',in_checkcycle='"
                + CheckCycle + "',in_lastchecktimes='" + LastCheckTime + "',in_duty='" + Duty + "' where in_tagid = '" + TagId + "'";
            return sql;
        }

        //仪器信息删除sql
        public string TagidDeleteInstrumentSql()
        {
            string sql = "delete from t_instrument where in_tagid = '" + TagId + "'";
            return sql;
        }

        //修改检查日期的sql语句
        public string UpdateInstrumentLastCheckTimeSql()
        {
            string sql = "update t_instrument set in_lastchecktimes='" 
                + LastCheckTime + "' where in_tagid = '" + TagId + "'";
            return sql;
        }

        //仪器多条件搜素
        public string QueryInstrumentSql()
        {
            SetupInstrument();
            maker.AddAndCondition(new StringLike("in_name", Name));
            maker.AddAndCondition(new StringLike("in_model", Model));
            maker.AddAndCondition(new StringLike("in_manufactor", Manufactor));
            if (Duty != 0)
            {
                maker.AddAndCondition(new IntEqual("in_duty", Duty));
            }
            maker.AddAndCondition(new StringLike("in_serialNumber", SerialNumber));
            maker.AddAndCondition(new StringEqual("in_isinwarehouse", IsInWareHouse));
            maker.AddSelectField("in_id");
            maker.AddSelectField("in_tagid");
            maker.AddSelectField("in_name");
            maker.AddSelectField("in_model");
            maker.AddSelectField("in_manufactor");
            maker.AddSelectField("in_position");
            maker.AddSelectField("in_isinwarehouse");
            maker.AddSelectField("in_duty");
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //仪器历次检查时间信息添加sql
        public string AddInstrumentAllPreviousCheckDateSql()
        {
            string sql = "insert into t_checkdate (ch_instrumentid,ch_date) values('" + TagId + "','" + LastCheckTime + "')";
            return sql;
        }

        //获取仪器历次检查信息sql
        public string QueryAllCheckDateSql()
        {
            SetupCheckdate();
            maker.AddAndCondition(new StringEqual("ch_instrumentid", TagId));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //仪器id查仪器信息
        public string IdQueryInstrumentSql()
        {
            SetupInstrument();
            maker.AddAndCondition(new IntEqual("in_id", Id));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        private void SetupInstrument()
        {
            maker = factory.CreateSelectSqlMaker("t_instrument");
        }

        private void SetupCheckdate()
        {
            maker = factory.CreateSelectSqlMaker("t_checkdate");
        }
    }
}
