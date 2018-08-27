using cangku_01.entity;
using cangku_01.UHFReader09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.UHFReader09CSharp
{
    interface UHFReader09Interface
    {
        void ConnectReader();
        void CloseConnectReader();
        string ReadTagId();
    }
}
