using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH.interfaces
{
    //仪器出入库接口
    interface Interface_warehouse
    {
        //查询仪器
        List<Warehouse> All_warehouse();
        //仪器进出库中的人员查询
        //根据人名进行查询
        List<Warehouse> findUserByName(String Name);
    }
}
