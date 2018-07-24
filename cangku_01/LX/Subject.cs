using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//被观察对象        打开添加页面或修改页面
namespace cangku_01.LX
{
    //委托   当感应到操作时   将信息传给观察者
    public delegate void AddEventHandler(object sender, EventArgs e);
    public delegate void ModifyEventHandler(object sender, EventArgs e);

    abstract class Subject
    {
        public event AddEventHandler addEventHandler;//感应到打开添加页面的事件
        public event ModifyEventHandler modifyEventHandler;//感应到打开修改页面的事件

        public void Write(EventArgs e)
        {
            this.addEventHandler(this, e);
        }
        public void Read(EventArgs e)
        {
            this.modifyEventHandler(this, e);
        }
        public void Read()
        {
            //不接收事件 
            this.addEventHandler(this, new EventArgs());
            this.modifyEventHandler(this, new EventArgs());
        }

    }
}
