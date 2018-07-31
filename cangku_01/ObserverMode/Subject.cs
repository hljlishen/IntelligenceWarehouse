using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.ObserverMode
{
    //委托   当感应门通过标签卡时    将所有信息传给观察者
    public delegate void DoorEventHandler(object sender,EventArgs e);
    //委托   当温度发生变化时    将所有信息传给观察者
    public delegate void TemperatureEventHandler(object sender, EventArgs e);
    //委托   当湿度发生变化时    将所有信息传给观察者
    public delegate void HumidityEventHandler(object sender, EventArgs e);


    //被观察者对象
    abstract class Subject
    {
        public event DoorEventHandler doorEventHandler;//标签通过门的事件
        public event TemperatureEventHandler temperatureEventHandler;   //温度变化事件
        public event HumidityEventHandler humidityEventHandler;   //湿度度变化事件


        //湿度发生变化
        public void HumidityChange(EventArgs e)
        {
            this.humidityEventHandler(this, e);
        }
        //湿度未发生变化
        public void HumidityChange()
        {
            this.humidityEventHandler(this, new EventArgs());
        }



        //温度发生变化
        public void temperatureChange(EventArgs e)
        {
            this.temperatureEventHandler(this, e);
        }
        //温度未发生变化
        public void temperatureChange( )
        {
            this.temperatureEventHandler(this, new EventArgs());
        }



        //标签通过门
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
