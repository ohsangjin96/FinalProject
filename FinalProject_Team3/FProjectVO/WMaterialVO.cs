using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WMaterialVO
    {
        //업체, 납품업체, 품목, 품명, 규격, 품목유형, 단위, 검사여부, 발주수량, 입고량, 잔량, 납기일, 주문상태, 발주번호
        //입고창고, 단가, 공장코드
        public long RowNo { get; set; }
        public string Com_Name { get; set; }
        public string ITEM_Delivery_Company { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Unit { get; set; }
        public int Reorder_Amount { get; set; }
        public int Reorder_InAmount { get; set; }
        public int Reorder_Balance { get; set; }
        public DateTime Order_FixedDate { get; set; }
        public string Reorder_State { get; set; }
        public int Reorder_Number { get; set; }

        public string ITEM_WareHouse_IN { get; set; }
        public int MC_IngCost { get; set; }
        public DateTime Warehousing_Date { get; set; }
        public string Warehousing_Note { get; set; }

        public string Factory_Code { get; set; }
        public int Warehouse_StockQty { get; set; }
        public int InQty { get; set; }

    }
}
