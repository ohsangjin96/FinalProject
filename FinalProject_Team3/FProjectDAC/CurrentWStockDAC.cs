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

        public List<CurrentWStockVO> GetCurrentWStockList()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ROW_NUMBER() OVER (Order by MAX(Warehouse_ID) desc) RowNo, Factory_Code,
                                           ITEM_WareHouse_IN, W.ITEM_Code, ITEM_Name, ITEM_Type, ITEM_Standard,
	                                       SUM(Warehouse_StockQty) Warehouse_StockQty, ITEM_Unit, Reorder_Note
                                    from Warehouse W join Reorder R on W.Reorder_Number = R.Reorder_Number
				                                     join ITEM I on W.ITEM_Code = I.ITEM_Code
                                    group by Factory_Code, ITEM_WareHouse_IN, W.ITEM_Code, ITEM_Name,
                                             ITEM_Type, ITEM_Standard, ITEM_Unit, Reorder_Note";

                SqlDataReader reader = cmd.ExecuteReader();
                List<CurrentWStockVO> list = Helper.DataReaderMapToList<CurrentWStockVO>(reader);

                return list;
            }
        }
    }
}
