using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//仪器接口

namespace cangku_01.LX
{
    interface Interface_instrument
    {
        //查询所有数据
        List<instrument> All_instrument();
        //添加
        int Add_instrument(List<instrument> instrument);
        //删除
        int Delete_instrument(int id);
        //修改
        int Alter_instrument(instrument instrument);
        //根据id查找，显示仪器信息
        List<instrument> findInstrumentById(int id);
        //根据name查找，显示仪器信息
        List<instrument> findInstrumentByName(string name);
    }
}
