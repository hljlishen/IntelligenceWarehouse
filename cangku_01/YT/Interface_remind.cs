using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.LX;

//到期提醒的接口

namespace cangku_01.YT
{
    interface Interface_remind
    {
        //查询所有快要到期的仪器
        List<instrument> All_remind();
        //进行修改
        int Alter_remind(int Remind_id,DateTime Remind_lastdate);

    }
}
 