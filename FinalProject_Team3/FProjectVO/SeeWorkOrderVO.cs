using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class SeeWorkOrderVO
    {
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Facility_Code { get; set; }
        public string Facility_Name { get; set; }
        public int Order_OrderAmount { get; set; }
        public int BOR_Order { get; set; }
        public DateTime Order_FixedDate { get; set; }
        public int TackTime { get; set; }
        public string Plan_ID { get; set; }
        public string Com_Code { get; set; }
        public string Com_Name { get; set; }
    }
}
