using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    //委托   当感应门通过标签卡时    将所有信息传给观察者
    public delegate void DoorEventHandler(object sender,EventArgs e);
    //被观察者对象
    abstract class Subject
    {
        public event DoorEventHandler doorEventHandler;//标签通过们的事件
        public void Pass(EventArgs e)
        {
            this.doorEventHandler(this,e);
        }
        public void Pass()
        {
            //不接收   通过的信息
            this.doorEventHandler(this,new EventArgs());
        }
    }
}
