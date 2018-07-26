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
            //标签通过门事件
            subject.doorEventHandler += new DoorEventHandler(this.Notified);
            //温度发生变化事件
            subject.temperatureEventHandler += new TemperatureEventHandler(this.Notified);
            //湿度发生改变事件
            subject.humidityEventHandler += new HumidityEventHandler(this.Notified);
        }

        //当  感应门 通过标签时  ||  当温度发生变化时执行
        abstract protected void Notified(object sender, EventArgs e);
        
        
    }
}
