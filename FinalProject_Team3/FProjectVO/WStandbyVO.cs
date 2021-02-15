using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WStandbyVO
    {
        public string Reorder_OrderDate { get; set; }
        public string Com_Code { get; set; }
        public string ITEM_Delivery_Company { get; set; }
        public string Com_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Unit { get; set; }
        public int Reorder_Amount { get; set; }
        public int Reorder_InAmount { get; set; }
        public int Reorder_Balance { get; set; }
        public string Order_FixedDate { get; set; }
        public string Reorder_Note { get; set; }

        public int Reorder_Number { get; set; }
        public int InQty { get; set; }
        public string InDate { get; set; }
    }
}
