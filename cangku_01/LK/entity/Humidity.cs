using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.SQQ;

namespace cangku_01.LK
{
    //湿度，被观察者
    class Humidity:Subject
    {
        public string HumidityNumber { get; set; }

        public Humidity() { }
    }
}
