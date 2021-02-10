using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class CurrentWStockVO
    {
        public long RowNo { get; set; }
        public string Factory_Code { get; set; }
        public string ITEM_WareHouse_IN { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Standard { get; set; }
	    public int Warehouse_StockQty { get; set; }
        public string ITEM_Unit { get; set; }
        public string Reorder_Note { get; set; }
    }
}
