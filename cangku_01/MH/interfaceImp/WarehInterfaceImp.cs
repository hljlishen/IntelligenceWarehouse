using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH.interfaceImp
{
    class WarehInterfaceImp : WarehInterface
    {
        List<Class_Warehouse> arr = new List<Class_Warehouse>();
        public List<Class_Warehouse> findUserByName(string Name)
        {
            //写sql语句返回
            return arr;
        }
    }
}
