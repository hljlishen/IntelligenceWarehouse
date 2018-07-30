using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.SQQ;

namespace cangku_01.SQQ
{
    class InstrumentFindInterfaceImp : InstrumentFindInterface
    {
        public static List<InstrumentFind> instrumentFindsList = new List<InstrumentFind>();
        InstrumentFind instrumentFind = new InstrumentFind();

        public List<InstrumentFind> findByName(String name)
        {
            //根据仪器名称   查询仪器的位置    返回值的类型是List
            instrumentFind.Ins_name = name;
            instrumentFind.Ins_Localtion = "书上";
            instrumentFindsList.Add(instrumentFind);
            return instrumentFindsList;
        }
    }
}
