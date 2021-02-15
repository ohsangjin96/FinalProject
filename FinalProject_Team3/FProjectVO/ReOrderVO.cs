using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class ReOrderVO
    {
        public string ReOrder_FixDate { get; set; }
        public string ITEM_Code { get; set; }
        public int Reorder_Amount { get; set; }
        public string Com_Code { get; set; }
        public int Reorder_Balance { get; set; }
        public int Reorder_CanCancel{ get; set; }
        public string Plan_ID { get; set; }
        public string WareHouse_In { get; set; }
        public string Note { get; set; }


    }
}
