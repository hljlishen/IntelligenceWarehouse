using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//观察者       读写标签的工具
namespace cangku_01.LX
{
    abstract class Observer
    {

        public Observer() { }
        public Observer(Subject subject)
        {
            subject.addEventHandler += new AddEventHandler(this.Weite);
            subject.modifyEventHandler += new ModifyEventHandler(this.Read);
        }

        //当  感应到 打开操作时
        abstract protected void Weite(object sender, EventArgs e);
        abstract protected void Read(object sender, EventArgs e);
    }
}
