using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
   public class BOMVO
    {
        public int bom_code { get; set; }
        public string item_type { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string BOM_Parent_Name { get; set; }
        public int BOM_Spend { get; set; }
        public int BOM_Level { get; set; }
        public DateTime BOM_StardDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string ITME_Use { get; set; }
        public string BOM_Plan { get; set; }
        public string BOM_Auto { get; set; }
        public string BOM_Note { get; set; }

        public string Gubun { get; set; }

        public string Code { get; set; }

    }
}
