using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
   public class MRealeaseVO
    {
        public int MR_Code { get; set; }
        public DateTime requestDate { get; set; }
        public string Item_Code { get; set; }
        public string Item_name { get; set; }
        public string ITEM_Type { get; set; }
        public string Item_Standard { get; set; }
        public string Item_Unit { get; set; }
        public string item_Order_Company { get; set; }
        public string ITEM_WareHouse_IN { get; set; }
        public int Qty { get; set; }
        public DateTime RegDate { get; set; }
        public string MR_State { get; set; }
        public int WorkOrder_ID { get; set; }


    }
}
