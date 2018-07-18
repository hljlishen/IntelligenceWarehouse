using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//到期提醒的实现接口

namespace cangku_01.YT
{
    class InterfaceImp_remind : Interface_remind
    {
        //定义接收实体类数据的数组
        List<Entity_remind> Remind_list = new List<Entity_remind>();
     

        //在数据库查询所用快要到期的仪器，并存放在数组中
        List<Entity_remind> Interface_remind.All_remind()
        {
            //text
            Entity_remind remind = new Entity_remind();
            Entity_remind remind2 = new Entity_remind();
            Entity_remind remind3 = new Entity_remind();
            Entity_remind remind4 = new Entity_remind();
            Entity_remind remind5 = new Entity_remind();
            Entity_remind remind6 = new Entity_remind();

            remind.Id = 001;
            remind.Name = "电子标签卡";
            remind.Manufacturer = "红叶";
            remind.Lastdate = DateTime.Parse("2018-2-12"); ;
            remind.Cycle = 120;
            Remind_list.Add(remind);

            remind2.Id = 002;
            remind2.Name = "UFH读写器";
            remind2.Manufacturer = "润之科技";
            remind2.Lastdate = DateTime.Parse("2018-5-12"); ;
            remind2.Cycle = 360;
            Remind_list.Add(remind2);

            remind3.Id = 003;
            remind3.Name = "电子门禁";
            remind3.Manufacturer = "智能酷睿";
            remind3.Lastdate = DateTime.Parse("2018-7-12"); ;
            remind3.Cycle = 10;
            Remind_list.Add(remind3);

            remind4.Id = 004;
            remind4.Name = "智能电视";
            remind4.Manufacturer = "KT家具";
            remind4.Lastdate = DateTime.Parse("2018-6-12"); ;
            remind4.Cycle = 30;
            Remind_list.Add(remind4);

            remind5.Id = 005;
            remind5.Name = "宏基笔记本";
            remind5.Manufacturer = "acer";
            remind5.Lastdate = DateTime.Parse("2018-5-18"); ;
            remind5.Cycle = 120;
            Remind_list.Add(remind5);

            remind6.Id = 006;
            remind6.Name = "智能水杯";
            remind6.Manufacturer = "流浪者科技";
            remind6.Lastdate = DateTime.Parse("2018-7-1"); ;
            remind6.Cycle = 40;
            Remind_list.Add(remind6);
            return Remind_list;
        }

        //将修改的信息传入，对数据库进行修改
        int Interface_remind.Alter_remind(int Remind_id, DateTime Remind_lastdate)
        {
            int i = 1;
            return i;
        }
    }
}
