using cangku_01.LX;
using cangku_01.MH.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口实现
namespace cangku_01.MH.interfaceImp
{
    class InstrumentQueryImp : interfaces.InstrumentQuery
    {
        //定义接收实体类数据的数组
        List<instrument> instrument_list = new List<instrument>();
        //时间查询
        public List<instrument> FindDate(DateTime Date1, DateTime Date2)
        {
            //写sql语句返回
            return instrument_list;
        }

        public List<instrument> FindModel(string Model)
        {
            // 写sql语句返回
            return instrument_list;
        }

        public List<instrument> FindUserByName(string Name)
        {
            // 写sql语句返回
            return instrument_list;
        }
    
    }
}
