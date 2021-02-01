using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WareHouseVO
    {
        public int Warehouse_ID { get; set; }           //입고번호
        public string Warehouse_Company { get; set; }   //납품업체
        public string Item_Code { get; set; }           //물품코드
        public string Item_Name { get; set; }           //물품이름
        public string Item_Standard { get; set; }       //물품규격
        public string Item_Type { get; set; }           //물품형태
        public string Item_Unit { get; set; }           //물품단위
        public string Warehouse_Check { get; set; }     //검사여부
        public int Warehouse_OrderQty { get; set; }     //주문개수
        public int Warehouse_FailQty { get; set; }      //불량개수
        public int Warehouse_LeaveQty { get; set; }     //통과된 상품(주문개수-불량개수)
        public DateTime Warehouse_date { get; set; }    //입고날짜
        public string Warehouse_State { get; set; }     //입고상태

    }
}
