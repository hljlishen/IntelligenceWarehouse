using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    public class Instrument
    {
        public int Id { get; set; }                  //仪器id
        public int TagId { get; set; }               //仪器标签ID
        public string Name { get; set; }             //仪器名称
        public string Model { get; set; }            //型号规格
        public string Manufactor { get; set; }       //生产厂商
        public string SerialNumber { get; set; }     //出厂编号
        public DateTime ProductionDate { get; set; } //生产日期
        public string Position { get; set; }         //货架位置  
        public bool IsInWareHouse { get; set; }      //在库状态       
        public int CheckCycle { get; set; }          //检定周期
        public DateTime LastCheckTimes { get; set; } //上一次检查时间
        public string Duty { get; set; }             //责任人

        //计算下一次检查日期
        public string NextCheckTimes(DateTime LastCheckTimes,int CheckCycle)
        {
            string NextCheckTimes = LastCheckTimes.AddDays(CheckCycle).Year.ToString() + "年" + LastCheckTimes.AddDays(CheckCycle).Month.ToString() + "月" + LastCheckTimes.AddDays(CheckCycle).Day.ToString() + "日";
            return NextCheckTimes;
        }

        //计算剩余的检查日期
        public string TimeRemaining(DateTime LastCheckTimes, int CheckCycle)
        {
            string TimeRemaining = (LastCheckTimes.AddDays(CheckCycle) - DateTime.Now).Days.ToString();
            return TimeRemaining;
        }

        //将日期转化为String年、月、日
        public string DateFormatConversion(DateTime data)
        {
            string StringData = data.Year.ToString() + "年" + data.Month.ToString() + "月" + data.Day.ToString() + "日";
            return StringData;
        }

        //查询所有的快要到期的仪器的sql语句
        public string AllRemindSql()
        {
            string AllRemindSql = "";
            return AllRemindSql;
        }

        //修改检查日期的sql语句
        public string AlterRemindSql(int TagId,DateTime NewLastCheckTimes)
        {
            string AlterRemindSql = "";
            return AlterRemindSql;
        }

    }
}
