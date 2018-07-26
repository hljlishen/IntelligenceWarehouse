using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.LK
{
    class HumidityInterfaceImp : HumidityInterface
    {
        public static List<string> lists1 = new List<string>();
        public List<string> Humidity(string list)
        {
            lists1.Add(list);
            return lists1;
        }

        public List<string> showHumidity()
        {
            return lists1;
        }
    }
}
