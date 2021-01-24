using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC 
{
     public class Product_PlanDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public Product_PlanDAC()
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

        // 데이터 조회
        public List<Product_PlanVO> GetProduct_PlanList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Process_Code,Facility_Code,ITEM_Code,PP_Fromdate,PP_QTY from Product_Plan";
                SqlDataReader reader = cmd.ExecuteReader();
                List<Product_PlanVO> list = Helper.DataReaderMapToList<Product_PlanVO>(reader);
                return list;
            }
        }
    }
}
