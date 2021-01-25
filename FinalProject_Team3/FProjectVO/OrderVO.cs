using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class OrderVO
    {
        public string Plan_ID{ set; get; }
        public DateTime Order_Plandate { set; get; }
        public int Order_WO { set; get; }
        public string Com_Code { set; get; }
        public string Com_Type { set; get; }
        public int Order_MKT { set; get; }
        public string Order_OrderType { set; get; }
        public string Order_Group { set; get; }
        public string Order_Gubun { set; get; }
        public int Order_Size { set; get; }
        public string Item_Code { set; get; }
        public string Item_Name { set; get; }
        public DateTime Order_FixedDate { set; get; }
        public int Order_RelaseAmount { set; get; }
        public int Order_OrderAmount { set; get; }
        public int Order_CancelAmount { set; get; }
        public string Order_Arrive { set; get; }
        public string Order_Remark { set; get; }
    } 
}
