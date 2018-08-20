using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.entity;

//到期提醒的接口

namespace cangku_01.interfaces
{
    interface RemindInterface
    {
        //查询所有快要到期的仪器
        DataTable QueryAllExpireInstrument();
        //修改最后一次检查时间
        void UpdateInstrumentLastCheckTime(Instrument ins);
    }
}
 