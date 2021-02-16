using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class MRequestVO
    {
        public int WorkOrder_ID { get; set; }
        public string Com_Code { get; set; }
        public string Com_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string WorkOrder_State { get; set; }
        public string Facility_Code { get; set; }
        public string Facility_Name { get; set; }
        public int OrderAmount { get; set; }
        public DateTime FixDate { get; set; }
        public int TackTime { get; set; }
        public string Plan_ID { get; set; }
        public string MR_State { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Unit { get; set; }
        public string ITEM_Order_Company { get; set; }
        public int Qty { get; set; }
        public string ReqDate { get; set; }
        public string ITEM_WareHouse_IN { get; set; }

    }
}
