using cangku_01.LX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH.interfaces
{
    //仪器出入库接口
    interface InstrumentQuery
    {
        //查询仪器
        List<instrument> AllWarehouse();
        //仪器进出库中的人员查询
        //根据人名进行查询
        List<instrument> FindUserByName(String Name);
        //仪器进出库中的时间查询
        //根据时间段进行查询
        List<instrument> FindDate(DateTime Date1,DateTime Date2);
    }
}
