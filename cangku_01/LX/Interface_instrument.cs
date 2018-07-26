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
        List<instrument> All_instrument();
        //添加
        void Add_instrument(List<instrument> instrument);
        //id 删除
        void Delete_instrument(int id);
        //修改
        void Modify_instrument(List<instrument> instrument);
       
        //根据id查找，显示仪器信息
        List<instrument> findInstrumentById(int id);
        //根据name查找，显示仪器信息
        List<instrument> findInstrumentByName(string name);
    }
}
