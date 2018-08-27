using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.FingerprintDrive
{
    interface DataShowInterface
    {
        void TextShow(GateData door, Form1 fr);
        void ListViewShow(GateData door, Form1 fr);
        void GetTagIdName(GateData door);
        void BorrowInformation(GateData insborrow);
    }
}
