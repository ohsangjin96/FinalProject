using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class OrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public OrderDAC()
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
        public List<OrderVO> GetOrderList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Plan_ID,Order_Plandate,Order_WO,Com_Code,Com_Type,Order_MKT,Order_OrderType,Order_Group,Order_Gubun,
	 Order_Size,Item_Code,Item_Name,Order_FixedDate,Order_RelaseAmount,Order_OrderAmount,Order_CancelAmount,Order_Arrive,Order_Remark from PO";
                SqlDataReader reader = cmd.ExecuteReader();
                List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(reader);
                return list;
            }
        }
    }
}
