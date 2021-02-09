using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class BORVO
    {
        public long RowNo { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string BOR_Route { get; set; }
        public string BOR_RouteName { get; set; }
        public string Facility_Code { get; set; }
        public string Facility_Name { get; set; }
        public int BOR_TactTime { get; set; }
        public string BOR_ReadyTime { get; set; }       //다음 공정 가기 전 까지의 대기 시간 (공정선행일)
        public int BOR_Order { get; set; }           //우선순위
        public string BOR_Transference { get; set; }    //수율
        public string BOR_Use { get; set; }
        public string BOR_Note { get; set; }
        public int BOR_Code { get; set; }
        public string BOR_Amender { get; set; }
        public string BOR_ModdifyDate { get; set; }
    }
}
