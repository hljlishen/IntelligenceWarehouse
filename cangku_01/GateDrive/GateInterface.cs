using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    interface GateInterface
    {
        //打开门的网口
        int Open();
        //关闭门的网口
        int Close();
        //开始执行读卡
        int StartReaderTagId();

    }
}
