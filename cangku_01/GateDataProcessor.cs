using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cangku_01.GateDrive;

namespace cangku_01
{
    interface IGateDataProcessor
    {
        void GetMsgType0(byte[] Msg);
        void GetMsgType1(byte[] msg);
        GateData GetGateData();
    }

    class JointProcessor : IGateDataProcessor
    {
        public GateData GetGateData()
        {
            throw new NotImplementedException();
        }

        public void GetMsgType0(byte[] Msg)
        {
            throw new NotImplementedException();
        }

        public void GetMsgType1(byte[] msg)
        {
            throw new NotImplementedException();
        }
    }
}
