using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;
using cangku_01.interfaces;

//到期提醒的实现接口

namespace cangku_01.interfaceImp
{
    class InterfaceImp_remind : Interface_remind
    {
        //定义接收实体类数据的数组
        List<Instrument> Remind_list = new List<Instrument>();
        Instrument Sql = new Instrument();

        //在数据库查询所用快要到期的仪器，并存放在数组中
        List<Instrument> Interface_remind.All_remind()
        {
            string AllRemindSql = Sql.AllRemindSql();

            //text
            Instrument remind = new Instrument();
            Instrument remind2 = new Instrument();
            Instrument remind3 = new Instrument();
            Instrument remind4 = new Instrument();
            Instrument remind5 = new Instrument();
            Instrument remind6 = new Instrument();

            remind.Id = 1;
            remind.TagId = 001;
            remind.Name = "电子标签卡";
            remind.Manufactor = "红叶";
            remind.LastCheckTimes = DateTime.Parse("2018-2-12"); ;
            remind.CheckCycle = 120;
            Remind_list.Add(remind);

            remind.Id = 2;
            remind2.TagId = 002;
            remind2.Name = "UFH读写器";
            remind2.Manufactor = "润之科技";
            remind2.LastCheckTimes = DateTime.Parse("2018-5-12"); ;
            remind2.CheckCycle = 360;
            Remind_list.Add(remind2);

            remind.Id = 3;
            remind3.TagId = 003;
            remind3.Name = "电子门禁";
            remind3.Manufactor = "智能酷睿";
            remind3.LastCheckTimes = DateTime.Parse("2018-7-12"); ;
            remind3.CheckCycle = 10;
            Remind_list.Add(remind3);

            remind.Id = 4;
            remind4.TagId = 004;
            remind4.Name = "智能电视";
            remind4.Manufactor = "KT家具";
            remind4.LastCheckTimes = DateTime.Parse("2018-6-12"); ;
            remind4.CheckCycle = 30;
            Remind_list.Add(remind4);

            remind.Id = 5;
            remind5.TagId = 005;
            remind5.Name = "宏基笔记本";
            remind5.Manufactor = "acer";
            remind5.LastCheckTimes = DateTime.Parse("2018-5-18"); ;
            remind5.CheckCycle = 120;
            Remind_list.Add(remind5);

            remind.Id = 6;
            remind6.TagId = 006;
            remind6.Name = "智能水杯";
            remind6.Manufactor = "流浪者科技";
            remind6.LastCheckTimes = DateTime.Parse("2018-7-1"); ;
            remind6.CheckCycle = 40;
            Remind_list.Add(remind6);
            return Remind_list;
        }

        //将修改的信息传入，对数据库进行修改
        int Interface_remind.Alter_remind(int Remind_id, DateTime Remind_lastdate)
        {
            int i = 1;
            string AlterRemindSql = Sql.AlterRemindSql(Remind_id,Remind_lastdate);
            return i;
        }
    }
}
