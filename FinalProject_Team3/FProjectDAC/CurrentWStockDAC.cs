using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class CurrentWStockDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public CurrentWStockDAC()
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

        public List<CurrentWStockVO> GetCurrentWStockList(string itemCode, string itemType, string warehouse)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Factory_Code, ITEM_WareHouse_IN, W.ITEM_Code, ITEM_Name, ITEM_Type,
                                           ITEM_Standard, Warehouse_StockQty, ITEM_Unit, ITEM_Remark
                                    from Warehouse W join ITEM I on W.ITEM_Code = I.ITEM_Code
									where W.ITEM_Code = ISNULL(@ITEM_Code, W.ITEM_Code) and
										  ITEM_Type = ISNULL(@ITEM_Type, ITEM_Type) and
										  ITEM_WareHouse_IN = ISNULL(@ITEM_WareHouse_IN, ITEM_WareHouse_IN)";

                cmd.Parameters.AddWithValue("@ITEM_Code", (string.IsNullOrEmpty(itemCode)) ? DBNull.Value : (object)itemCode);
                cmd.Parameters.AddWithValue("@ITEM_Type", (string.IsNullOrEmpty(itemType)) ? DBNull.Value : (object)itemType);
                cmd.Parameters.AddWithValue("@ITEM_WareHouse_IN", (string.IsNullOrEmpty(warehouse)) ? DBNull.Value : (object)warehouse);

                SqlDataReader reader = cmd.ExecuteReader();
                List<CurrentWStockVO> list = Helper.DataReaderMapToList<CurrentWStockVO>(reader);

                return list;
            }
        }
    }
}
