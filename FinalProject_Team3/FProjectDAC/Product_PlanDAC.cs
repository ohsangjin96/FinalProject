using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetProduct_Plan()
        {
            string date = DateTime.Now.ToShortDateString();
            string date1 = DateTime.Now.AddDays(12).ToShortDateString();
                
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetPplan_Data";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", date);
                cmd.Parameters.AddWithValue("@EndDate", date1);

                //SqlDataReader reader = cmd.ExecuteReader();
                //List<POVO> list = Helper.DataReaderMapToList<POVO>(reader);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);

                return ds;
               
            }
        }
    }
}
