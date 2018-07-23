using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.SQQ;

namespace cangku_01.SQQ
{
    interface InstrumentInterfaces
    {
        //将出入门的仪器信息记录 存入数据库中
        List<Instrument> Ins_Info(List<Instrument> ins_list);

        List<Instrument> find_ins();
      
    }
}
