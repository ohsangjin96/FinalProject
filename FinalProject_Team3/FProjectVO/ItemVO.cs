using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class ItemVO
    {
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Unit { get; set; }
        public int ITEM_Unit_Qty { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Import_YN { get; set; }
        public string ITEM_Process_YN { get; set; }
        public string ITEM_Export_YN { get; set; }
        public string ITEM_Delivery_Company { get; set; }
        public string ITEM_Order_Company { get; set; }
        public string ITEM_WareHouse_IN { get; set; }
        public string ITEM_WareHouse_OUT { get; set; }
        public int ITME_LeadTime { get; set; }
        public int ITME_Min_Order_Qty { get; set; }
        public int ITME_Safe_Qty { get; set; }
        public string ITME_Manager { get; set; }
        public string ITME_Last_Modifier { get; set; }
        public DateTime ITME_Last_Modifier_Time { get; set; }
        public string ITME_Use { get; set; }
        public string ITEM_Discontinuance { get; set; }
        public string ITEM_Delivery_Type { get; set; }
        public string ITEM_Remark { get; set; }

        public string Code { get; set; }
        public string Gubun { get; set; }
        public string CodeName { get; set; }
    }
}
