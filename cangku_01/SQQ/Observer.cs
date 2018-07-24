using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
   abstract class Observer
    {
        public Observer() { }
        public Observer(Subject subject)
        {
            subject.doorEventHandler += new DoorEventHandler(this.Notified);
        }

        //当  感应门 通过标签时
        abstract protected void Notified(object sender, EventArgs e);
    }
}
