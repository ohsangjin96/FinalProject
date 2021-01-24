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

        // 데이터 검색
        public List<CompanyVO> GetCompanyList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Com_Code, Com_Name, Com_Type, Com_CEO, Com_CNum, Com_Category, Com_Conditions,
                                           Com_Charge, Com_Email, Com_StartDate, Com_EndDate, Com_Phone, Com_Fax,
                                           Com_Warehouse, Com_Use, Com_Amender, Com_ModdifyDate
                                    from Company";
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(reader);

                return list;
            }
        }
    }
}
