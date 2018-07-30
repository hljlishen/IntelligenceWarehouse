using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01;

namespace cangku_01.SQQ
{
    class Instrument:Subject
    {
       
        public int Ins_id { get; set; }
        public string Ins_name { get; set; }
        public bool Ins_state { get; set; }
        public DateTime Ins_dateTime { get; set; }


        public Instrument() { }

       
    }
}
