using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.FingerprintDrive
{
    interface DataTransferInterface
    {
        void DataTransfer(GateData door, Form1 fr, string[] gatedata);
        //添加借用信息
        void BorrowInformation(GateData insborrow);
    }
}
