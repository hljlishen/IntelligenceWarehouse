using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

//仪器接口

namespace cangku_01.interfaces
{
    interface InstrumentInterface
    {
        //获取全部仪器信息
        DataTable QueryAllInstrument();
        //TagId查询仪器信息
        DataTable TagIdQueryInstrument(Instrument ins);
        //仪器信息添加
        void AddInstrument(Instrument ins);
        //仪器信息删除
        void DeleteInstrument(Instrument ins);
        //修改
        void UpdateInstrument(Instrument ins);
        //仪器搜索
        DataTable QueryInstrument(Instrument ins);
        //仪器id查询仪器信息
        DataTable IdQueryInstrument(Instrument ins);
    }
}
