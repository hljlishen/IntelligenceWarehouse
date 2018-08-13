using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.GateDrive
{
    class Gate
    {
        public string TagId { get; set; }  //仪器标签Id
        public DateTime ThroughDoor { get; set; }//通过门的时间
        public Boolean isOperating { get; set; }//仪器过门的操作
    }
}
