using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class ItemDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public ItemDAC()
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
        public List<ItemVO> GetItemAllList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code, ITEM_Name, ITEM_Standard, ITEM_Unit, ITEM_Unit_Qty, ITEM_Type, ITEM_Import_YN,
                                    ITEM_Process_YN, ITEM_Export_YN, ITEM_Delivery_Company, ITEM_Order_Company, ITEM_WareHouse_IN,
                                    ITEM_WareHouse_OUT, ITME_LeadTime, ITME_Min_Order_Qty, ITME_Safe_Qty, ITME_Manager, ITME_Last_Modifier,
                                    Convert(Date, ITME_Last_Modifier_Time, 23) ITME_Last_Modifier_Time, ITME_Use, 
                                    ITEM_Discontinuance, ITEM_Delivery_Type, ITEM_Remark
                                    from ITEM";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(reader);

                return list;
            }
        }
    }
}
//