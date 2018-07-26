using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LK.interfacelmp
{
    class temperatureTestInterfaceImp : temperatureTestInterface
    {
        public static List<string> lists = new List<string>();
        public List<string> temperature(String list)
        {
            lists.Add(list);
            return lists;
        }
       public List<string> showTemperature()
        {
            return lists;
        }
    }
}
