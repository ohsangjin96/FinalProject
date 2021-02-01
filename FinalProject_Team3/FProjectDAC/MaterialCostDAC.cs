using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class MaterialCostDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public MaterialCostDAC()
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
       
        public List<MaterialCostVO> GetMCInfo(string  day)
        {
            using (SqlCommand cmd= new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select MC_Code, m.COM_Code, c.Com_Name,m.ITEM_Code,i.ITEM_Name,i.ITEM_Unit_Qty,i.ITEM_Unit,
		                                  MC_IngCost,MC_BeforeCost,Convert(Date, MC_StartDate, 23) MC_StartDate,Convert(Date, MC_EndDate, 23) MC_EndDate,
		                                  MC_Remark,MC_USE
		                                  from Material_Cost M inner join item  i on m.ITEM_Code=i.ITEM_Code
						                                       inner join Company C on m.COM_Code=c.Com_Code
						                  where @day >= m.MC_StartDate and @day<=m.MC_EndDate";
                cmd.Parameters.AddWithValue("@day", day);
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialCostVO> list = Helper.DataReaderMapToList<MaterialCostVO>(reader);

                return list;
            }
        }
        public List<MaterialCostVO> GetItemCode(string order)
        {
            using (SqlCommand cmd =new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code 
                                   from item i inner join company c on i.ITEM_Order_Company=c.Com_Name
                                   where i.ITEM_Order_Company=@ITEM_Order_Company";

                cmd.Parameters.AddWithValue("@ITEM_Order_Company", order);
                SqlDataReader reader = cmd.ExecuteReader();
                
                List<MaterialCostVO> list = Helper.DataReaderMapToList<MaterialCostVO>(reader);

                return list;
            }
        }
    }
}
