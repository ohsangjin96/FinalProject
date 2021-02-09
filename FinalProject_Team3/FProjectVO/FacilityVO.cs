using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class FacilityVO
    {
        public long RowNo { get; set; }
        //설비군
        public string Facilities_Code { get; set; }         //설비군코드
        public string Facilities_Name { get; set; }         //설비군명
        public string Facilities_Use { get; set; }          //사용유무
        public string Facilities_Amender { get; set; }      //수정자
        public string Facilities_ModdifyDate { get; set; }//수정일자
        public string Facilities_Explain { get; set; }      //설명

        //설비
        public string Facility_Code { get; set; }           //설비코드
        //public string Facilities_Code { get; set; }       //설비군코드 - 이미 선언되있음
        public string Facility_Name { get; set; }           //설비명
        public string Facility_Exhaustion { get; set; }     //소진창고
        public string Facility_Imported { get; set; }       //양품창고
        public string Facility_Poor { get; set; }           //불량창고
        public string Facility_MES { get; set; }            //MES설비
        public string Facility_OutSourcing { get; set; }    //외주여부
        public string Facility_Amender { get; set; }        //수정자
        public string Facility_ModdifyDate { get; set; }  //수정일자
        public string Facility_Use { get; set; }            //사용유무
        public string Facility_Note { get; set; }           //특이사항
        public string Facility_Comment { get; set; }        //비고
        public string Item_Code { get; set; }               //품목코드
        public string Facility_IP { get; set; }             //설비 IP
        public string Facility_Port { get; set; }           //설비 Port



    }
}
