using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.LK.interfacelmp;
using cangku_01.SQQ;

namespace cangku_01.LK
{
    //温度检测，观察者
    class temperatureTest : Observer
    {
        temperatureTestInterface dao = new temperatureTestInterfaceImp();
        // public TemperatureInterface temperatureDao = new temperatureInterfaceImp();
        public temperatureTest() { }
        public temperatureTest(Subject subject)
            : base(subject)
        {

        }
        protected override void Notified(object sender, EventArgs e)
        {
            dao.temperature("38"); 
        }
    }
}
