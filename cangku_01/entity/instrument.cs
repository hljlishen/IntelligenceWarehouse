using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    public class Instrument
    {
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
        public DateTime LastCheckTimes { get; set; } //上一次检查时间
        public string Duty { get; set; }             //责任人

        //计算下一次检查日期
        public string NextCheckTimes()
        {
            string NextCheckTimes = LastCheckTimes.AddDays(CheckCycle).ToString("yyyy-MM-dd");
            return NextCheckTimes;
        }

        //计算剩余的检查日期
        public string TimeRemaining()
        {
            string TimeRemaining = (LastCheckTimes.AddDays(CheckCycle) - DateTime.Now).Days.ToString();
            return TimeRemaining;
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
            string sql = "select * from t_instrument";
            return sql;
        }

        //TagID查询仪器信息sql
        public string TagIDQueryInstrumentSql()
        {
            string sql = "select * from t_instrument where in_tagid = '" + TagId + "'";
            return sql;
        }

        //仪器信息添加sql
        public string AddInstrumentSql()
        {
            string sql = "insert into t_instrument (in_tagid,in_name,in_model,in_manufactor,in_serialnumber,in_productiondate,in_position,in_isinwarehouse,in_checkcycle,in_lastchecktimes,in_duty)" +
                "values('"+ TagId + "','" + Name + "','" + Model + "','" + Manufactor + "','" + SerialNumber + "','" + ProductionDate + "','" 
                + Position + "','" + IsInWareHouse + "','" + CheckCycle + "','" + LastCheckTimes + "','" + Duty + "')";
            return sql;
        }

        //仪器信息修改sql
        public string UpdateInstrumentSql()
        {
            string sql = "update t_instrument set in_name='" + Name + "',in_model='"
                + Model + "',in_manufactor='" + Manufactor + "',in_serialnumber='" + SerialNumber + "',in_productiondate='" 
                + ProductionDate + "',in_position='" + Position + "',in_isinwarehouse='" + IsInWareHouse + "',in_checkcycle='"
                + CheckCycle + "',in_lastchecktimes='" + LastCheckTimes + "',in_duty='" + Duty + "' where in_tagid = '" + TagId + "'";
            return sql;
        }

        //仪器信息删除sql
        public string TagidDeleteInstrumentSql()
        {
            string sql = "delete from t_instrument where in_tagid = '" + TagId + "'";
            return sql;
        }

        //查询所有的快要到期的仪器的sql语句
        public string QueryAllExpireInstrumentSql()
        {
            string sql = "select * from t_instrument";
            return sql;
        }

        //修改检查日期的sql语句
        public string AlterRemindSql(int TagId,DateTime NewLastCheckTimes)
        {
            string AlterRemindSql = "";
            return AlterRemindSql;
        }

    }
}
