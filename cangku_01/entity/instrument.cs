using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Data;

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
        public string UsedMode { get; set; }         //用于型号
        public string State { get; set; }            //状态
        public string Remarks { get; set; }          //备注

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

        //位置编码解读
        public string PlaceUnscramble()
        {
            string place = "";
            WarehouseLocation wa = new WarehouseLocation();
            string[] sArray = Position.Split(new char[1] { '-' });
            for (int i = 0; i <= 3; i++)
            {
                wa.id = int.Parse(sArray[i]);
                DataTable dt = wa.SqlIdQueryWarehouseInformation();
                DataRow myDr = dt.Rows[0];
                place += myDr["wa_name"].ToString() + "-";
            }
            place = place.Substring(0, place.Length - 1);
            return place;
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
            string sql = "insert into t_instrument (in_tagid,in_name,in_model,in_manufactor,in_serialnumber,in_productiondate,in_position,in_isinwarehouse,in_checkcycle,in_lastchecktimes,in_duty,in_usedmode,in_state,in_remarks)" +
                "values('"+ TagId + "','" + Name + "','" + Model + "','" + Manufactor + "','" + SerialNumber + "','" + ProductionDate + "','" 
                + Position + "','" + IsInWareHouse + "','" + CheckCycle + "','" + LastCheckTime + "','" + Duty + "','" + UsedMode + "','" + State + "','" + Remarks + "')";
            return sql;
        }

        //仪器信息修改sql
        public void UpdateInstrument()
        {
            DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);
            string sql = "update t_instrument set in_tagid='" + TagId + "', in_name='" + Name + "',in_model='"
                + Model + "',in_manufactor='" + Manufactor + "',in_serialnumber='" + SerialNumber + "',in_productiondate='" 
                + ProductionDate + "',in_position='" + Position + "',in_isinwarehouse='" + IsInWareHouse + "',in_checkcycle='"
                + CheckCycle + "',in_lastchecktimes='" + LastCheckTime + "',in_duty='" + Duty + "',in_usedmode='" + UsedMode + "',in_state='" + State + "',in_remarks='" + Remarks + "'" +
                "where in_id = '" + Id + "'";
            dbo.WriteDB(sql);

        }

        //仪器在库状态的修改sql
        public string UpdateInstrumentInwarehouseStateSql()
        {
            string sql = "update t_instrument set in_isinwarehouse='" + IsInWareHouse + "' where in_tagid ='" + TagId + "'";
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
            maker.AddAndCondition(new StringLike("in_tagid", TagId));
            maker.AddAndCondition(new StringLike("in_name", Name));
            maker.AddAndCondition(new StringLike("in_model", Model));
            maker.AddAndCondition(new StringLike("in_manufactor", Manufactor));
            if (Duty != 0)
            {
                maker.AddAndCondition(new IntEqual("in_duty", Duty));
            }
            maker.AddAndCondition(new StringLike("in_serialNumber", SerialNumber));
            maker.AddAndCondition(new StringEqual("in_isinwarehouse", IsInWareHouse));
            string sql = maker.MakeSelectSql();
            return sql;
        }

        //仪器历次检查时间信息添加sql
        public string AddInstrumentAllPreviousCheckDateSql()
        {
            string sql = "insert into t_checkdate (ch_instrumentid,ch_date) values('" + Id + "','" + LastCheckTime + "')";
            return sql;
        }

        //获取仪器历次检查信息sql
        public string QueryAllCheckDateSql()
        {
            SetupCheckdate();
            maker.AddAndCondition(new IntEqual("ch_instrumentid", Id));
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

        //责任人查仪器信息
        public DataTable EmployeeIdQueryInstrument()
        {
            SetupInstrument();
            maker.AddAndCondition(new IntEqual("in_duty", Duty));
            string sql = maker.MakeSelectSql();
            DataTable datatable = dbo.ReadDBDataTable(sql);
            return datatable;
        }

        //tagid查询仪器sql
        public DataTable InstrumentTagidFindInstrument()
        {
            SetupInstrument();
            maker.AddAndCondition(new StringEqual("in_tagid", TagId));
            string sql = maker.MakeSelectSql();
            DataTable dt = dbo.ReadDBDataTable(sql);
            return dt;
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
