using cangku_01.entity;
using cangku_01.GateDrive;
using System.Collections.Generic;
using System.Data;

//仪器出入库接口

namespace cangku_01.interfaces
{
    interface InstrumenBorrowRecord
    {
        //添加仪器出入记录
        void AddInAndOutRecords(InstrumentInAndOutRecord record, Fingerprint fingerprint, GateData door);

        //获取全部仪器出入库信息
        DataTable AllInAndOutRecords(InstrumentInAndOutRecord record);

    }
}
