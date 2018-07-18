using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//到期提醒的实体类

namespace cangku_01.YT
{
    class Entity_remind
    {
        //到期提醒所需要的属性
        int id; //仪器id
        String name; //仪器名字
        String manufacturer; //生产厂商
        DateTime lastdate;  //上一次检查时间
        int cycle;  //检查周期



        //set、get方法
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public DateTime Lastdate { get => lastdate; set => lastdate = value; }
        public int Cycle { get => cycle; set => cycle = value; }

    }
}
