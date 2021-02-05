using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WareHouseVO
    {
		public string Factory_Code { get; set; }
		public string Factory_Name { get; set; }
		public string ITEM_Code { get; set; }
		public int Warehouse_StockQty { get; set; }
		public string ITEM_Unit { get; set; }
		public string Warehouse_Note { get; set; }
		public string Warehouse_date { get; set; }
	}
}
