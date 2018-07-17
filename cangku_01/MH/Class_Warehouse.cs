using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.MH
{
    class Class_Warehouse
    {
        String id;
        String name;
        String location;
        String model;
        String manufacturers;
        DateTime  productionDate;
        String agent;
        String principal;
        int outbound_number;
        int intbound_number;
        int remaining_number;
        DateTime outboundDate;
        DateTime inboundDate;

        public string Id { get => id; set => id = value; }
        public string Name { get => Name; set => id = Name; }
        public string Location { get => Location; set => Location = value; }
        public string Model { get => Model; set => Model = value; }
        public string Manufacturers { get => Manufacturers; set => Manufacturers = value; }
        public DateTime ProductionDate { get => ProductionDate; set => ProductionDate = value; }
        public string Agent { get => Agent; set => Agent = value; }
        public string Principal { get => Principal; set => Principal = value; }
        public int Outbound_number { get => Outbound_number; set => Outbound_number = value; }
        public int Intbound_number { get => Intbound_number; set => Intbound_number = value; }
        public int Remaining_number { get => Remaining_number; set => Remaining_number = value; }
        public DateTime OutboundDate { get => OutboundDate; set => OutboundDate = value; }
        public DateTime InboundDate { get => InboundDate; set => InboundDate = value; }
    }
}
