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
        //实例化实体类
        Entity_remind remind = new Entity_remind();
        Entity_remind remind2 = new Entity_remind();

        //在数据库查询所用快要到期的仪器，并存放在数组中
        List<Entity_remind> Interface_remind.All_remind()
        {
            remind.Id = 001;
            remind.Name = "电子标签卡";
            remind.Manufacturer = "红叶";
            remind.Lastdate = DateTime.Parse("2018-2-12"); ;
            remind.Cycle = 540;
            Remind_list.Add(remind);

            remind2.Id = 002;
            remind2.Name = "UFH读写器";
            remind2.Manufacturer = "润之科技";
            remind2.Lastdate = DateTime.Parse("2018-5-12"); ;
            remind2.Cycle = 680;
            Remind_list.Add(remind2);
            return Remind_list;
        }

        //将修改的信息传入数组中，对数据库进行修改
        void Interface_remind.Alter_remind(Entity_remind remind)
        {
            Remind_list.Add(remind);
        }
    }
}
