using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class POVO
    {
        public DateTime Order_Plandate { get; set; }
        public string Order_WO { get; set; }
        public string Com_Code { get; set; }
        public string Com_Type { get; set; }
        public int Order_MKT { get; set; }
        public string Order_OrderType { get; set; }
        public string Order_Group { get; set; }
        public string Order_Gubun { get; set; }
        public int Order_Size { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public DateTime Order_FixedDate { get; set; }
        public int Order_RelaseAmount { get; set; }
        public int Order_OrderAmount { get; set; }
        public int Order_CancelAmount { get; set; }
        public string Order_Arrive { get; set; }
        public string Order_Remark { get; set; }
        public string Plan_ID { get; set; }
        public string PO_State { get; set; }

        public string Com_Name { get; set; }
        public string ITEM_Type { get; set; }
    }
}
