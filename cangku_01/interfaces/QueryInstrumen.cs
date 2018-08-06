using cangku_01.entity;
using cangku_01.interfaceImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口

namespace cangku_01.interfaces
{
    interface QueryInstrumen
    {
        //根据借用人姓名进行查询
        List<QueryInstrument> FindInstrumentByBorrow(String Borrow);
        //根据责任人姓名进行查询
        List<QueryInstrument> FindInstrumentByDuty(String Duty);
        //根据仪器型号进行查询
        List<QueryInstrument> FindInstrumentByModel(String Model);
        //根据仪器的生产厂商查询
        List<QueryInstrument> FindInstrumentByManufacturer(String Manufacturer);
        //根据时间段进行查询
        List<QueryInstrument> FindInstrumentBetween(DateTime begin,DateTime end);
    }
}
