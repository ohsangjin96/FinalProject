using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class ShiftVO
    {
        public int Shift_Code { get; set; }//시프트코드
        public string Facility_Code { get; set; } //설비코드
        public string Facility_Name { get; set; }//설비명
        public string Shift_type { get; set; }//시프트타입
        public int Shift_StartTime { get; set; }//시작일자
        public int Shift_EndTime { get; set; }//종료일자
        public DateTime Shift_Apply_StartDate { get; set; }//적용시작일자
        public DateTime Shift_Apply_EndDate { get; set; }//적용완료일자
        public int Shift_People { get; set; }//투입인원
        public string Shift_Use { get; set; }//사용유무
        public string Shift_Last_Modifier { get; set; }//수정자
        public DateTime Shift_Last_Modifier_Time { get; set; }//수정일
        public string Shift_Remark { get; set; }//비고
    }
}
