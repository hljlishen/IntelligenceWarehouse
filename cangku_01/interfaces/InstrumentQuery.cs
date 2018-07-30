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
        //根据借用人姓名进行查询
        List<instrument> FindInstrumentByBorrow(String Borrow);
        //根据责任人姓名进行查询
        List<instrument> FindInstrumentByDuty(String Duty);
        //根据仪器型号进行查询
        List<instrument> FindInstrumentByModel(String Model);
        //根据仪器的生产厂商查询
        List<instrument> FindInstrumentByManufacturer(String Manufacturer);
        //根据时间段进行查询
        List<instrument> FindInstrumentBetween(DateTime begin,DateTime end);
    }
}
