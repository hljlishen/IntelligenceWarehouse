using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace cangku_01
{
    class InstrumentInAndOutRecord : ActiveRecord
    {
        protected InstrumentInAndOutRecord(DbLinkFactory factory) : base("t_insinandoutrecords", "Id", factory)
        {
            
        }

        public int? Id { get; set; }
        public int? InstrumentId { get; set; }
        public int? EmployeeId { get; set; }
        public string Direction { get; set; }
        public DateTime? Time { get; set; }
    }
}
