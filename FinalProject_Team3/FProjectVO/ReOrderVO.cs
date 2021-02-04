using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class ReOrderVO
    {
        public int Reorder_Number { get; set; }

        public string Reorder_ComCode { get; set; }
        public DateTime Reorder_date { get; set; }
        public DateTime Reorder_Arrivedate { get; set; }
        public string Reorder_ItemCode { get; set; }
        public int Reorder_Amount { get; set; }
        public string Reorder_type { get; set; }
        public string Reorder_state { get; set; }
        public string Reorder_Unit { get; set; }


        public int ReorderDetail_Code { get; set; }
        public int ReorderDetail_All { get; set; }
        public int ReorderDetail_Bad { get; set; }
        public int ReorderDetail_Normal { get; set; }
        public DateTime ReorderDetail_InDate { get; set; }
        public DateTime ReorderDetail_CheckDate { get; set; }
        public string ReorderDetail_result { get; set; }
    }
}
