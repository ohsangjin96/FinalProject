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

        #region 설비군
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

        // 설비군 데이터 등록
        public bool InsertFacility(FacilityVO vo)
        {
            if (!IsCodeValied(vo.Facilities_Code))
            {
                throw new Exception("이미 등록된 설비군코드입니다.");
            }
            else if (!IsNameValied(vo.Facilities_Name))
            {
                throw new Exception("이미 등록된 설비군명입니다.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Facility (Facilities_Code, Facilities_Name, Facilities_Use,
                                                              Facilities_Amender, Facilities_ModdifyDate, Facilities_Explain)
                                        values (@Facilities_Code, @Facilities_Name, @Facilities_Use, @Facilities_Amender,
                                                @Facilities_ModdifyDate, @Facilities_Explain)";

                    cmd.Parameters.AddWithValue("@Facilities_Code", vo.Facilities_Code);
                    cmd.Parameters.AddWithValue("@Facilities_Name", vo.Facilities_Name);
                    cmd.Parameters.AddWithValue("@Facilities_Use", vo.Facilities_Use);
                    cmd.Parameters.AddWithValue("@Facilities_Amender", vo.Facilities_Amender);
                    cmd.Parameters.AddWithValue("@Facilities_ModdifyDate", vo.Facilities_ModdifyDate);
                    cmd.Parameters.AddWithValue("@Facilities_Explain", (vo.Facilities_Explain == "") ? DBNull.Value : (object)vo.Facilities_Explain);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 설비군 데이터 수정
        public bool UpdateFacility(FacilityVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Facility set Facilities_Name = @Facilities_Name, Facilities_Use = @Facilities_Use,
                                                            Facilities_Explain = @Facilities_Explain
                                        where Facilities_Code = @Facilities_Code";

                    cmd.Parameters.AddWithValue("@Facilities_Code", vo.Facilities_Code);
                    cmd.Parameters.AddWithValue("@Facilities_Name", vo.Facilities_Name);
                    cmd.Parameters.AddWithValue("@Facilities_Use", vo.Facilities_Use);
                    cmd.Parameters.AddWithValue("@Facilities_Explain", (vo.Facilities_Explain == "") ? DBNull.Value : (object)vo.Facilities_Explain);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 설비군 데이터 삭제
        public bool DeleteFacility(string code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_DeleteFacility";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Facilities_Code", code);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    if (iRowAffect > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 선택한 설비에 대한 설비군이 존재하는지 검색
        public int SearchFacilityDetaile(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Facility_Detail where Facilities_Code = @Facilities_Code";
                cmd.Parameters.AddWithValue("@Facilities_Code", code);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result == 0)
                    return 0;
                else
                    return result;
            }
        }
        #endregion

        #region 설비
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
        #endregion
        //select count(*) from Facility_Detail where Facilities_Code = 'TEST1'

        #region 중복체크
        // 설비군명 중복 체크
        public bool IsNameValied(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Facility where Facilities_Name = @Facilities_Name";

                cmd.Parameters.AddWithValue("@Facilities_Name", name);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }

        // 설비군코드 중복 체크
        public bool IsCodeValied(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Facility where Facilities_Code = @Facilities_Code";

                cmd.Parameters.AddWithValue("@Facilities_Code", code);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }
        #endregion
    }
}
