using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class FacilityVO
    {
        //설비군
        public string Facilities_Code { get; set; }
        public string Facilities_Name { get; set; }
        public string Facilities_Use { get; set; }
        public string Facilities_Amender { get; set; }
        public DateTime Facilities_ModdifyDate { get; set; }
        public string Facilities_Explain { get; set; }

        //설비
        public string Facility_Code { get; set; }
        //public string Facilities_Code { get; set; }
        public string Facility_Name { get; set; }
        public string Facility_Exhaustion { get; set; }
        public string Facility_Imported { get; set; }
        public string Facility_Poor { get; set; }
        public string Facility_MES { get; set; }
        public string Facility_OutSourcing { get; set; }
        public string Facility_Amender { get; set; }
        public DateTime Facility_ModdifyDate { get; set; }
        public string Facility_Use { get; set; }
        public string Facility_Note { get; set; }
        public string Facility_Comment { get; set; }


    }
}
