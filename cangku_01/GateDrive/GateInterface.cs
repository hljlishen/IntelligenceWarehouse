﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    interface GateInterface
    {
        //打开门的网口
        void Open();
        //关闭门的网口
        void Close();
        //开始探测
        void StartDetect(Form1 fr);

    }
}
