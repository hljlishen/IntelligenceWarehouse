using cangku_01.entity;
using cangku_01.GateDrive;
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
        //添加仪器出入记录
        void AddInAndOutRecords(InstrumentInAndOutRecord rec,Employee ee, GateData door);

        //获取全部仪器出入库信息
        DataTable AllInAndOutRecords();

        //仪器出入库信息的搜索
        DataTable SearchRecords(InstrumentInAndOutRecord rec);


    }
}
