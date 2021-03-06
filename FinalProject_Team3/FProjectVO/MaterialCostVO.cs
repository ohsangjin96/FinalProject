﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class MaterialCostVO
    {
        public int MC_Code { get; set; }//단가 일련번호
        public string COM_Code { get; set; }//업체코드
        public string Com_Name { get; set; }//업체명
        public string ITEM_Code { get; set; }//품목코드
        public string ITEM_Name { get; set; }//품명
        public int ITEM_Unit_Qty { get; set; }//단위수량
        public string ITEM_Unit { get; set; }//단위
        public int MC_IngCost { get; set; }//현재단가
        public int MC_BeforeCost { get; set; }//이전단가
        public DateTime MC_StartDate { get; set; }//시작일
        public DateTime MC_EndDate { get; set; }//종료일
        public string MC_USE { get; set; }//사용유무
        public string MC_Remark { get; set; }//비고
        public string MC_Last_Modifier { get; set; }//수정자
        public DateTime MC_Last_Modifier_Time { get; set; }//종료일
        //public string Code { get; set; }
        //public string Gubun { get; set; }
    }
}
