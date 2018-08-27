using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.interfaces
{
    interface FingerprintInformation
    {
        //传入指纹信息
        void SetFingerprintInformation(string employeeid, string passtime);
    }
}
