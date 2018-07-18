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
        // DateTime nextdate;  //下一次检查日期
        // DateTime expiredate; //剩余检查时间


        //set、get方法
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public DateTime Lastdate { get => lastdate; set => lastdate = value; }
        public int Cycle { get => cycle; set => cycle = value; }
       // public DateTime Nextdate { get => nextdate; set => nextdate = value; }
       // public DateTime Expiredate { get => expiredate; set => expiredate = value; }
    }
}
