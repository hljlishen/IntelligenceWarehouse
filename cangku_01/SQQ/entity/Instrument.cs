using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01;

namespace cangku_01.SQQ
{
    class Instrument:Observer
    {
        public InstrumentInterfaces instrumentDao = new instrumentInterfaceImp();
        public int Ins_id { get; set; }
        public string Ins_name { get; set; }
        public bool Ins_state { get; set; }
        public DateTime Ins_dateTime { get; set; }


        public Instrument() { }

        public Instrument(Subject subject)
            : base(subject)
        {
        }

        protected override void Notified(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            List<Instrument> list = new List<Instrument>();
            Instrument ins = new Instrument();
            ins.Ins_id = 1;
            ins.Ins_name = "二锅头";
            ins.Ins_state = true;
            ins.Ins_dateTime = DateTime.Now;
            list.Add(ins);
            instrumentDao.Ins_Info(list);
        }
    }
}
