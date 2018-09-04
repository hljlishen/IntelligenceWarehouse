using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器出入库接口实现
namespace cangku_01.interfaceImp
{
    class InsBorrowRecord : InstrumenBorrowRecord
    {
        public void AddInAndOutRecords(InstrumentInAndOutRecord rec)
        {
            throw new NotImplementedException();
        }

        public DataTable QueryInAndOutRecords()
        {
            throw new NotImplementedException();
        }

        public DataTable QueryInRecords()
        {
            throw new NotImplementedException();
        }

        public DataTable QueryOutRecords()
        {
            throw new NotImplementedException();
        }

        public DataTable SearchRecords(InstrumentInAndOutRecord rec)
        {
            throw new NotImplementedException();
        }
    }
}
