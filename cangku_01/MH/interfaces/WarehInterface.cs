using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH.interfaces
{
    interface WarehInterface
    {
        //仪器进出库中的人员查询
        //根据人名进行查询
        List<Class_Warehouse> findUserByName(String Name);
    }
}
