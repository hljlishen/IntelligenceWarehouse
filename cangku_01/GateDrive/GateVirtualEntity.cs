using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    class GateVirtualEntity
    {
        public string TagId { get; set; }  //仪器标签Id
        public string ThroughDoorTime { get; set; }//通过门的时间
        public string ThroughDoorDirection { get; set; }//仪器过门的操作
    }
}
