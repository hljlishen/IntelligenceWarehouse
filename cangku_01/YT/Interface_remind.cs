using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//到期提醒的接口

namespace cangku_01.YT
{
    interface Interface_remind
    {
        //查询所有快要到期的仪器
        List<Entity_remind> All_remind();
        //进行修改
        void Alter_remind(Entity_remind remind);

    }
}
