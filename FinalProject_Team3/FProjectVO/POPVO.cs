using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class POPVO
    {
        public int WorkOrder_ID { get; set; }
        public int BOM_Level { get; set; }
        public string Item_Code { get; set; }
        public string Facility_Code { get; set; }
        public string Facility_Name { get; set; }
        public string Facility_IP { get; set; }
        public string Facility_Port { get; set; }
        public string plan_ID { get; set; }
    }
}
