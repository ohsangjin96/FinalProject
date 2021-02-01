using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class DemandVO
    {
        public string Plan_ID { get; set; }
        public string Com_Code { get; set; }
        public string Com_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Demand_WO { get; set; }
        public DateTime Demand_FixedDate { get; set; }
        public int Demand_OrderAmount { get; set; }
    }
}
