using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.YT
{
    class Date_remind
    {
        String id;
        String name;
        String manufacturer;
        DateTime lastdate;
        DateTime cycle;
        DateTime nextdate;
        DateTime expiredate;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public DateTime Lastdate { get => lastdate; set => lastdate = value; }
        public DateTime Cycle { get => cycle; set => cycle = value; }
        public DateTime Nextdate { get => nextdate; set => nextdate = value; }
        public DateTime Expiredate { get => expiredate; set => expiredate = value; }
    }
}
