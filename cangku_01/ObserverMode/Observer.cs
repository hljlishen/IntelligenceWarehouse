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

        //当  感应门 通过标签时  ||  当温度发生变化时执行
        abstract protected void Notified(object sender, EventArgs e);
        
        
    }
}
