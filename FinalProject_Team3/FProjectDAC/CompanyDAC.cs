using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class CompanyDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public CompanyDAC()
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

        // 업체정보 검색
        public List<CompanyVO> GetCompanyList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Com_Code, Com_Name, Com_Type, Com_CEO, Com_CNum, Com_Category, Com_Conditions,
                                           Com_Charge, Com_Email, CONVERT(CHAR(10), Com_StartDate, 23) Com_StartDate,
                                           CONVERT(CHAR(10), Com_EndDate, 23) Com_EndDate, Com_Phone, Com_Fax,
                                           Com_Warehouse, Com_Use, Com_Amender,
                                           CONVERT(CHAR(19), Com_ModdifyDate, 120) Com_ModdifyDate, Com_Info
                                    from Company";
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(reader);

                return list;
            }
        }

        // 업체정보 등록
        public bool InsertCompany(CompanyVO vo)
        {
            if (!IsCodeValied(vo.Com_Code))
            {
                throw new Exception("이미 등록된 업체코드입니다.");
            }
            else if (!IsNameValied(vo.Com_Name))
            {
                throw new Exception("이미 등록된 업체명입니다.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Company (Com_Code, Com_Name, Com_Type, Com_CEO, Com_CNum, Com_Category,
                                                             Com_Conditions, Com_Charge, Com_Email, Com_StartDate,
                                                             Com_EndDate, Com_Phone, Com_Fax, Com_Warehouse, Com_Use,
                                                             Com_Amender, Com_ModdifyDate, Com_Info)
                                        values (@Com_Code, @Com_Name, @Com_Type, @Com_CEO, @Com_CNum, @Com_Category,
                                                @Com_Conditions, @Com_Charge, @Com_Email, @Com_StartDate, @Com_EndDate,
                                                @Com_Phone, @Com_Fax, @Com_Warehouse, @Com_Use, @Com_Amender,
                                                @Com_ModdifyDate, @Com_Info)";

                    cmd.Parameters.AddWithValue("@Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Name", vo.Com_Name);
                    cmd.Parameters.AddWithValue("@Com_Type", vo.Com_Type);
                    cmd.Parameters.AddWithValue("@Com_CEO", (string.IsNullOrEmpty(vo.Com_CEO)) ? DBNull.Value : (object)vo.Com_CEO);
                    cmd.Parameters.AddWithValue("@Com_CNum", (string.IsNullOrEmpty(vo.Com_CNum)) ? DBNull.Value : (object)vo.Com_CNum);
                    cmd.Parameters.AddWithValue("@Com_Category", (string.IsNullOrEmpty(vo.Com_Category)) ? DBNull.Value : (object)vo.Com_Category);
                    cmd.Parameters.AddWithValue("@Com_Conditions", (string.IsNullOrEmpty(vo.Com_Conditions)) ? DBNull.Value : (object)vo.Com_Conditions);
                    cmd.Parameters.AddWithValue("@Com_Charge", (string.IsNullOrEmpty(vo.Com_Charge)) ? DBNull.Value : (object)vo.Com_Charge);
                    cmd.Parameters.AddWithValue("@Com_Email", (string.IsNullOrEmpty(vo.Com_Email)) ? DBNull.Value : (object)vo.Com_Email);
                    cmd.Parameters.AddWithValue("@Com_StartDate", Convert.ToDateTime(vo.Com_StartDate));
                    cmd.Parameters.AddWithValue("@Com_EndDate", Convert.ToDateTime(vo.Com_EndDate));
                    cmd.Parameters.AddWithValue("@Com_Phone", (string.IsNullOrEmpty(vo.Com_Phone)) ? DBNull.Value : (object)vo.Com_Phone);
                    cmd.Parameters.AddWithValue("@Com_Fax", (string.IsNullOrEmpty(vo.Com_Fax)) ? DBNull.Value : (object)vo.Com_Fax);
                    cmd.Parameters.AddWithValue("@Com_Warehouse", vo.Com_Warehouse);
                    cmd.Parameters.AddWithValue("@Com_Use", vo.Com_Use);
                    cmd.Parameters.AddWithValue("@Com_Amender", vo.Com_Amender);
                    cmd.Parameters.AddWithValue("@Com_ModdifyDate", vo.Com_ModdifyDate);
                    cmd.Parameters.AddWithValue("@Com_Info", (string.IsNullOrEmpty(vo.Com_Info)) ? DBNull.Value : (object)vo.Com_Info);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 업체정보 수정
        public bool UpdateCompany(CompanyVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Company set Com_Type = @Com_Type, Com_CEO = @Com_CEO, Com_CNum = @Com_CNum,
                                               Com_Category = @Com_Category, Com_Conditions = @Com_Conditions,
                                               Com_Charge = @Com_Charge, Com_Email = @Com_Email,
                                               Com_StartDate = @Com_StartDate, Com_EndDate = @Com_EndDate,
                                               Com_Phone = @Com_Phone, Com_Fax = @Com_Fax, Com_Warehouse = @Com_Warehouse,
                                               Com_Use = @Com_Use, Com_Info = @Com_Info
										where Com_Code = @Com_Code";

                    cmd.Parameters.AddWithValue("@Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Type", vo.Com_Type);
                    cmd.Parameters.AddWithValue("@Com_CEO", (string.IsNullOrEmpty(vo.Com_CEO)) ? DBNull.Value : (object)vo.Com_CEO);
                    cmd.Parameters.AddWithValue("@Com_CNum", (string.IsNullOrEmpty(vo.Com_CNum)) ? DBNull.Value : (object)vo.Com_CNum);
                    cmd.Parameters.AddWithValue("@Com_Category", (string.IsNullOrEmpty(vo.Com_Category)) ? DBNull.Value : (object)vo.Com_Category);
                    cmd.Parameters.AddWithValue("@Com_Conditions", (string.IsNullOrEmpty(vo.Com_Conditions)) ? DBNull.Value : (object)vo.Com_Conditions);
                    cmd.Parameters.AddWithValue("@Com_Charge", (string.IsNullOrEmpty(vo.Com_Charge)) ? DBNull.Value : (object)vo.Com_Charge);
                    cmd.Parameters.AddWithValue("@Com_Email", (string.IsNullOrEmpty(vo.Com_Email)) ? DBNull.Value : (object)vo.Com_Email);
                    cmd.Parameters.AddWithValue("@Com_StartDate", Convert.ToDateTime(vo.Com_StartDate));
                    cmd.Parameters.AddWithValue("@Com_EndDate", Convert.ToDateTime(vo.Com_EndDate));
                    cmd.Parameters.AddWithValue("@Com_Phone", (string.IsNullOrEmpty(vo.Com_Phone)) ? DBNull.Value : (object)vo.Com_Phone);
                    cmd.Parameters.AddWithValue("@Com_Fax", (string.IsNullOrEmpty(vo.Com_Fax)) ? DBNull.Value : (object)vo.Com_Fax);
                    cmd.Parameters.AddWithValue("@Com_Warehouse", vo.Com_Warehouse);
                    cmd.Parameters.AddWithValue("@Com_Use", vo.Com_Use);
                    cmd.Parameters.AddWithValue("@Com_Info", (string.IsNullOrEmpty(vo.Com_Info)) ? DBNull.Value : (object)vo.Com_Info);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 업체정보 삭제
        public bool DeleteCompany(string companyCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from Company where Com_Code = @Com_Code";

                    cmd.Parameters.AddWithValue("@Com_Code", companyCode);

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
        // 업체코드 중복 체크
        public bool IsCodeValied(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Company where Com_Code = @Com_Code";

                cmd.Parameters.AddWithValue("@Com_Code", code);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }

        // 업체명 중복 체크
        public bool IsNameValied(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Company where Com_Name = @Com_Name";

                cmd.Parameters.AddWithValue("@Com_Name", name);

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
