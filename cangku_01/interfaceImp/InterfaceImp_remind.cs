using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.LX;

//到期提醒的实现接口

namespace cangku_01.YT
{
    class InterfaceImp_remind : Interface_remind
    {
        //定义接收实体类数据的数组
        List<instrument> Remind_list = new List<instrument>();
     

        //在数据库查询所用快要到期的仪器，并存放在数组中
        List<instrument> Interface_remind.All_remind()
        {
            //text
            instrument remind = new instrument();
            instrument remind2 = new instrument();
            instrument remind3 = new instrument();
            instrument remind4 = new instrument();
            instrument remind5 = new instrument();
            instrument remind6 = new instrument();

            remind.tagId = 001;
            remind.name = "电子标签卡";
            remind.manufactor = "红叶";
            remind.lastCheckTimes = DateTime.Parse("2018-2-12"); ;
            remind.checkCycle = 120;
            Remind_list.Add(remind);

            remind2.tagId = 002;
            remind2.name = "UFH读写器";
            remind2.manufactor = "润之科技";
            remind2.lastCheckTimes = DateTime.Parse("2018-5-12"); ;
            remind2.checkCycle = 360;
            Remind_list.Add(remind2);

            remind3.tagId = 003;
            remind3.name = "电子门禁";
            remind3.manufactor = "智能酷睿";
            remind3.lastCheckTimes = DateTime.Parse("2018-7-12"); ;
            remind3.checkCycle = 10;
            Remind_list.Add(remind3);

            remind4.tagId = 004;
            remind4.name = "智能电视";
            remind4.manufactor = "KT家具";
            remind4.lastCheckTimes = DateTime.Parse("2018-6-12"); ;
            remind4.checkCycle = 30;
            Remind_list.Add(remind4);

            remind5.tagId = 005;
            remind5.name = "宏基笔记本";
            remind5.manufactor = "acer";
            remind5.lastCheckTimes = DateTime.Parse("2018-5-18"); ;
            remind5.checkCycle = 120;
            Remind_list.Add(remind5);

            remind6.tagId = 006;
            remind6.name = "智能水杯";
            remind6.manufactor = "流浪者科技";
            remind6.lastCheckTimes = DateTime.Parse("2018-7-1"); ;
            remind6.checkCycle = 40;
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
