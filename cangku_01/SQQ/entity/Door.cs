using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    class Door:Observer
    {
        public InstrumentInterfaces instrumentDao = new instrumentInterfaceImp();
        public Door(){}
        public Door(Subject subject)
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
