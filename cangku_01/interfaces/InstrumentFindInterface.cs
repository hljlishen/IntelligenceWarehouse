using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.SQQ
{
    interface InstrumentFindInterface
    {
        //根据仪器的名称 查询位置
        List<InstrumentFind> findByName(String name);

    }
}
