using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class FacilityDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public FacilityDAC()
        {
            strConn = this.ConnectionString;
            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        // 설비군 데이터 검색
        public List<FacilityVO> GetFacilityList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Facilities_Code, Facilities_Name, Facilities_Use, Facilities_Amender,                                           Facilities_ModdifyDate, Facilities_Explain
                                    from Facility";
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(reader);

                return list;
            }
        }

        //설비 데이터 검색
        public List<FacilityVO> GetFacilityDetailList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Facility_Code, Facilities_Code, Facility_Name, Facility_Exhaustion, Facility_Imported,
                                           Facility_Poor, Facility_MES, Facility_OutSourcing, Facility_Amender,
                                           Facility_ModdifyDate, Facility_Use, Facility_Note, Facility_Comment
                                    from Facility_Detail";
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(reader);

                return list;
            }
        }
    }
}
