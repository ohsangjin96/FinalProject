using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WorkRegistVO
    {
        public int WorkRegistID { get; set; }
        public string WorkRegist_Start { get; set; }
        public string Item_Code { get; set; }
        public string WorkRegist_State { get; set; }
        public int WorkRegist_WorkTime { get; set; }
        public int WorkRegist_NomalQty { get; set; }
        public int WorkRegist_FailQty { get; set; }
        public int WorkRegist_OrderAmount { get; set; }
        public string FacilityDetail_Code { get; set; }
        public string Plan_ID { get; set; }
    }
}
