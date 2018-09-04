using cangku_01.entity;
using cangku_01.interfaceImp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口

namespace cangku_01.interfaces
{
    interface InstrumenBorrowRecord
    {


        //获取全部仪器出入库信息
        DataTable QueryInAndOutRecords();

        //获取全部仪器的出库信息
        DataTable QueryOutRecords();

        //获取全部仪器的入库信息
        DataTable QueryInRecords();

        //仪器出入库信息的添加
        void AddInAndOutRecords(InstrumentInAndOutRecord rec);

        //仪器出入库信息的搜索
        DataTable SearchRecords(InstrumentInAndOutRecord rec);
    }
}
