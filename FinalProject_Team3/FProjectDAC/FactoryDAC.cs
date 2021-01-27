using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class FactoryDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public FactoryDAC()
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

        // 데이터 검색
        public List<FactoryVO> GetFactoryList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Factory_ID, Factory_Grade, Factory_Type, Factory_Code, Factory_Name,
                                           Factory_HighRank, Factory_Explain, Factory_Credit, Factory_Order, Factory_Demand, 
                                           Factory_Process, Factory_Material, Com_Code, Com_Name, Factory_Use, Factory_Amender,
                                           Factory_ModdifyDate
                                           from Factory";

                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);

                return list;
            }
        }

        public List<FactoryVO> GetFactoryGradeList(string codeOrName, string grade)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetFactoryInfo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeOrName", (string.IsNullOrEmpty(codeOrName)) ? DBNull.Value : (object)codeOrName);
                cmd.Parameters.AddWithValue("@FactoryGrade", (grade == "전체") ? DBNull.Value : (object)grade);

                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);

                return list;
            }
        }

        // 공장정보 등록
        public bool InsertFactory(FactoryVO vo)
        {
            if (!IsNameValied(vo.Factory_Name))
            {
                throw new Exception("이미 등록된 시설명입니다.");
            }
            else if (!IsNameValied(vo.Factory_Code))
            {
                throw new Exception("이미 등록된 시설코드입니다.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Factory (Factory_Grade, Factory_Type, Factory_Code, Factory_Name,
                                                             Factory_HighRank, Factory_Explain, Factory_Credit, Factory_Order,
                                                             Factory_Demand, Factory_Process, Factory_Material, Com_Code,
                                                             Com_Name, Factory_Use, Factory_Amender, Factory_ModdifyDate)
                                        values(@Factory_Grade, @Factory_Type, @Factory_Code, @Factory_Name, @Factory_HighRank,
                                               @Factory_Explain, @Factory_Credit, @Factory_Order, @Factory_Demand, 
                                               @Factory_Process, @Factory_Material, @Com_Code, @Com_Name, @Factory_Use,
                                               @Factory_Amender, @Factory_ModdifyDate)";

                    cmd.Parameters.AddWithValue("@Factory_Grade", vo.Factory_Grade);
                    cmd.Parameters.AddWithValue("@Factory_Type", vo.Factory_Type);
                    cmd.Parameters.AddWithValue("@Factory_Code", vo.Factory_Code);
                    cmd.Parameters.AddWithValue("@Factory_Name", vo.Factory_Name);
                    cmd.Parameters.AddWithValue("@Factory_HighRank", (vo.Factory_HighRank == "없음") ? DBNull.Value : (object)vo.Factory_HighRank);
                    cmd.Parameters.AddWithValue("@Factory_Explain", (vo.Factory_Explain == "") ? DBNull.Value : (object)vo.Factory_Explain);
                    cmd.Parameters.AddWithValue("@Factory_Credit", (vo.Factory_Credit == "") ? DBNull.Value : (object)vo.Factory_Credit);
                    cmd.Parameters.AddWithValue("@Factory_Order", (vo.Factory_Order == -1) ? DBNull.Value : (object)vo.Factory_Order);
                    cmd.Parameters.AddWithValue("@Factory_Demand", (vo.Factory_Demand == "") ? DBNull.Value : (object)vo.Factory_Demand);
                    cmd.Parameters.AddWithValue("@Factory_Process", (vo.Factory_Process == "") ? DBNull.Value : (object)vo.Factory_Process);
                    cmd.Parameters.AddWithValue("@Factory_Material", (vo.Factory_Material == "") ? DBNull.Value : (object)vo.Factory_Material);
                    cmd.Parameters.AddWithValue("@Com_Code", (vo.Com_Code == "") ? DBNull.Value : (object)vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Name", (vo.Com_Name == "") ? DBNull.Value : (object)vo.Com_Name);
                    cmd.Parameters.AddWithValue("@Factory_Use", vo.Factory_Use);
                    cmd.Parameters.AddWithValue("@Factory_Amender", vo.Factory_Amender);
                    cmd.Parameters.AddWithValue("@Factory_ModdifyDate", vo.Factory_ModdifyDate);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 공장정보 수정
        public bool UpdateFactory(FactoryVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Factory set Factory_Grade = @Factory_Grade, Factory_Type = @Factory_Type,
                                               Factory_Name = @Factory_Name, Factory_HighRank = @Factory_HighRank,
                                               Factory_Explain = @Factory_Explain, Factory_Credit = @Factory_Credit,
                                               Factory_Order = @Factory_Order, Factory_Demand = @Factory_Demand,
                                               Factory_Process = @Factory_Process, Factory_Material = @Factory_Material,
                                               Com_Code = @Com_Code, Com_Name = @Com_Name, Factory_Use = @Factory_Use
                                        where Factory_Code = @Factory_Code";

                    cmd.Parameters.AddWithValue("@Factory_Grade", vo.Factory_Grade);
                    cmd.Parameters.AddWithValue("@Factory_Type", vo.Factory_Type);
                    cmd.Parameters.AddWithValue("@Factory_Code", vo.Factory_Code);
                    cmd.Parameters.AddWithValue("@Factory_Name", vo.Factory_Name);
                    cmd.Parameters.AddWithValue("@Factory_HighRank", (vo.Factory_HighRank == "없음") ? DBNull.Value : (object)vo.Factory_HighRank);
                    cmd.Parameters.AddWithValue("@Factory_Explain", (vo.Factory_Explain == "") ? DBNull.Value : (object)vo.Factory_Explain);
                    cmd.Parameters.AddWithValue("@Factory_Credit", (vo.Factory_Credit == "") ? DBNull.Value : (object)vo.Factory_Credit);
                    cmd.Parameters.AddWithValue("@Factory_Order", (vo.Factory_Order == -1) ? DBNull.Value : (object)vo.Factory_Order);
                    cmd.Parameters.AddWithValue("@Factory_Demand", (vo.Factory_Demand == "") ? DBNull.Value : (object)vo.Factory_Demand);
                    cmd.Parameters.AddWithValue("@Factory_Process", (vo.Factory_Process == "") ? DBNull.Value : (object)vo.Factory_Process);
                    cmd.Parameters.AddWithValue("@Factory_Material", (vo.Factory_Material == "") ? DBNull.Value : (object)vo.Factory_Material);
                    cmd.Parameters.AddWithValue("@Com_Code", (vo.Com_Code == "") ? DBNull.Value : (object)vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Name", (vo.Com_Name == "") ? DBNull.Value : (object)vo.Com_Name);
                    cmd.Parameters.AddWithValue("@Factory_Use", vo.Factory_Use);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 공장정보 삭제
        public bool DeleteFactory(string factoryName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_DeleteFactory";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Factory_Name", factoryName);

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

        #region 중복체크
        // 시설명 중복 체크
        public bool IsNameValied(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Factory where Factory_Name = @Factory_Name";

                cmd.Parameters.AddWithValue("@Factory_Name", name);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }

        // 시설명 중복 체크
        public bool IsCodeValied(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Factory where Factory_Code = @Factory_Code";

                cmd.Parameters.AddWithValue("@Factory_Code", code);

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
