using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class CurrentWMaterialVO
    {
        public int Warehousing_His_No { get; set; }
        public DateTime Warehousing_Date { get; set; }
        public string ITEM_WareHouse_IN { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Unit { get; set; }
        public int Warehousing_InAmount { get; set; }
        public int Reorder_Cancel { get; set; }
        public int Reorder_Balance { get; set; }
        public string Com_Name { get; set; }
        public string ITEM_Delivery_Company { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public int Reorder_Number { get; set; }
    }
}
