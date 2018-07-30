using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.SQQ;

namespace cangku_01.LK
{
    //湿度检测，观察者
    class HumidityTest:Observer
    {
        HumidityInterface dao = new HumidityInterfaceImp();
        public HumidityTest() { }
        public HumidityTest(Subject subject)
            : base(subject)
        {

        }
        protected override void Notified(object sender, EventArgs e)
        {
            dao.Humidity("30");
        }
    }
}
