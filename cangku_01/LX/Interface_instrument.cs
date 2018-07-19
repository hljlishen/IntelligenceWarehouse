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
        //列表上显示所有
        List<instrument_entity> All_instrument();
        //添加
        void Add_instrument(instrument_entity instrument);
        //删除
        void Delete_instrument(instrument_entity instrument);
        //修改
        void Alter_instrument(instrument_entity instrument);
        //查询
        void Select_instrument(instrument_entity instrument);
        //根据id查找，显示仪器信息
        //List<instrument_entity> findUserById(int id);
    }
}
