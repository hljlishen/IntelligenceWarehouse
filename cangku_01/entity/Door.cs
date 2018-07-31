using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

namespace cangku_01.SQQ
{
    class Door:Observer
    {
        public InstrumentInterfaces instrumentDao = new instrumentInterfaceImp();

        protected override void Notified(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            List<Instrument> list = new List<Instrument>();
            Instrument ins = new Instrument();
            ins.TagId = 1;
            ins.Name = "二锅头";
            ins.IsInWareHouse = true;
            list.Add(ins);
            instrumentDao.Ins_Info(list);
        }
    }
}
