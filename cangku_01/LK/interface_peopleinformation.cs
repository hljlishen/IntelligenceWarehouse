using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

namespace cangku_01.LK
{
    //人员信息接口
    interface interface_peopleinformation
    {
        //人员信息列表
        List<User> All_information();
        //人员肖像
        String person_picture();
    }
}
