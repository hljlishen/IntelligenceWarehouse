using cangku_01.entity;
using cangku_01.LX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH.interfaces
{
    //仪器出入库接口
    interface Instrumen_query
    {
        //根据借用人姓名进行查询
        List<InstrumentQuery> FindInstrumentByBorrow(String Borrow);
        //根据责任人姓名进行查询
        List<InstrumentQuery> FindInstrumentByDuty(String Duty);
        //根据仪器型号进行查询
        List<InstrumentQuery> FindInstrumentByModel(String Model);
        //根据仪器的生产厂商查询
        List<InstrumentQuery> FindInstrumentByManufacturer(String Manufacturer);
        //根据时间段进行查询
        List<InstrumentQuery> FindInstrumentBetween(DateTime begin,DateTime end);
    }
}
