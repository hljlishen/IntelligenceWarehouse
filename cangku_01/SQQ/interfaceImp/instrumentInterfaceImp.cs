using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    class instrumentInterfaceImp : InstrumentInterfaces
    {
        public static List<Instrument> ins_List = new List<Instrument>();

        public List<Instrument> find_ins()
        {
            return ins_List;
        }

        public List<Instrument> Ins_Info(List<Instrument> list)
        {
            Instrument instrument = new Instrument();
            foreach (Instrument ins in list)
            {
                instrument.Ins_id = ins.Ins_id;
                instrument.Ins_name = ins.Ins_name;
                instrument.Ins_state = true;
                instrument.Ins_dateTime = ins.Ins_dateTime;
                ins_List.Add(instrument);
            }
            
            //insert 数据库的sql语句
            return ins_List;
        }

        
    }
}
