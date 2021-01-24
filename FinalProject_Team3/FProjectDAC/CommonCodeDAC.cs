using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class CommonCodeDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public CommonCodeDAC()
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

        // 공통코드 데이터 검색
        public List<CommonCodeVO> GetCommonCodeList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Common_Code, Common_Name, Common_Parent, Common_Seq from CommonCode";
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                return list;
            }
        }

        // 공통코드 등록
        public bool InsertCommonCode(CommonCodeVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into CommonCode (Common_Code, Common_Name, Common_Parent, Common_Seq)
                                        values (@Common_Code, @Common_Name, isnull(@Common_Parent, null), @Common_Seq)";

                    cmd.Parameters.AddWithValue("@Common_Code", vo.Common_Code);
                    cmd.Parameters.AddWithValue("@Common_Name", vo.Common_Name);
                    cmd.Parameters.AddWithValue("@Common_Parent", (vo.Common_Parent == "미선택") ? DBNull.Value : (object)vo.Common_Parent);
                    cmd.Parameters.AddWithValue("@Common_Seq", vo.Common_Seq);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 공통코드 수정
        public bool UpdateCommonCode(CommonCodeVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update CommonCode set Common_Name = @Common_Name, Common_Parent = @Common_Parent
                                        where Common_Code = @Common_Code";

                    cmd.Parameters.AddWithValue("@Common_Name", vo.Common_Name);
                    cmd.Parameters.AddWithValue("@Common_Parent", (vo.Common_Parent == "미선택") ? DBNull.Value : (object)vo.Common_Parent);
                    cmd.Parameters.AddWithValue("@Common_Code", vo.Common_Code);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 공통코드 삭제
        public bool DeleteCommonCode(string name, string pname)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_DeleteCommonCode";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Common_Name", name);
                    cmd.Parameters.AddWithValue("@Common_Parent", pname);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        #region 중복체크
        // 코드 중복 체크
        public bool IsCodeValied(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from CommonCode where Common_Code = @Common_Code";

                cmd.Parameters.AddWithValue("@Common_Code", code);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }

        // 코드명 중복 체크
        public bool IsCodeNameValied(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from CommonCode where Common_Name = @Common_Name";

                cmd.Parameters.AddWithValue("@Common_Name", name);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region 순서 설정을 위한 쿼리문
        public int GetSeqValue(string pname)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                if (pname == "미선택")
                    cmd.CommandText = @"select count(*) from CommonCode where Common_Parent is null";
                else
                {
                    cmd.CommandText = @"select count(*) from CommonCode where Common_Parent = @Common_Parent";
                    cmd.Parameters.AddWithValue("@Common_Parent", pname);
                }

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                return result;
            }
        }
        #endregion
    }
}
