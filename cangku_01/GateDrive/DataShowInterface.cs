using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    interface DataShowInterface
    {
        void ShowInstrumentPhoto(GateData door, Form1 fr);

        void TextAndListViewShow(GateData door, Form1 fr);

        void GetTagIdName(GateData door);

        void BorrowInformation(GateData insborrow);
    }
}
