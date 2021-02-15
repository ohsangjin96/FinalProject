using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FProjectDAC
{
   public class MRequestDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public MRequestDAC()
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

        public List<MRequestVO> GetMRequestList(string from, string to, string item, string WOID, string Facility)
        {
            using (SqlCommand cmd=new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [WorkOrder_ID],[Com_Code] ,[Com_Name]  ,[Item_Code],[Item_Name]
		                                  ,[WorkOrder_State],[Facility_Code],[Facility_Name],[OrderAmount]
		                                  ,[FixDate],[TackTime],[Plan_ID]
                                    FROM WorkOrder
                                    where WorkOrder_State='지시확정' and FixDate>=@FixDateA  and FixDate<=@FixDateB
                                 		  and Item_Code= isnull(@Item_Code,Item_Code) and WorkOrder_ID=ISNULL(@WorkOrder_ID,WorkOrder_ID) and
                                 		  Facility_Name=isnull(@Facility_Name,Facility_Name)";

                cmd.Parameters.AddWithValue("@FixDateA", from);
                cmd.Parameters.AddWithValue("@FixDateB", to);
                cmd.Parameters.AddWithValue("@Item_Code", ((item == "")) ? DBNull.Value : (object)item);
                cmd.Parameters.AddWithValue("@WorkOrder_ID", ((WOID == "")) ? DBNull.Value : (object)WOID);
                cmd.Parameters.AddWithValue("@Facility_Name", ((Facility == "전체")) ? DBNull.Value : (object)Facility);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MRequestVO> list = Helper.DataReaderMapToList<MRequestVO>(reader);

                return list;
            }
        }

        public List<MRequestVO> GetList(string code,int qty)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_MRequestBOM";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@item_code", code);
                cmd.Parameters.AddWithValue("@qty", qty);
               

                SqlDataReader reader = cmd.ExecuteReader();
                List<MRequestVO> list = Helper.DataReaderMapToList<MRequestVO>(reader);

                return list;
            }
        }
    }
}
