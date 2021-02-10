using FProjectVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class CurrentWMaterialDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public CurrentWMaterialDAC()
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

        public List<CurrentWMaterialVO> GetCurrentWMaterialList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ROW_NUMBER() OVER (Order by Reorder_His_No desc) RowNo, Reorder_His_No,
                                           Reorder_InDate, ITEM_WareHouse_IN, I.ITEM_Code, ITEM_Name,
                                           ITEM_Standard, ITEM_Unit, RH.Reorder_InAmount, RH.Reorder_Cancel, 
                                           Reorder_Balance, Com_Name, ITEM_Delivery_Company
                                    from Reorder_His RH join Reorder R on RH.Reorder_Number = R.Reorder_Number
					                                    join ITEM I on RH.ITEM_Code = I.ITEM_Code
                                    order by Reorder_His_No desc";

                SqlDataReader reader = cmd.ExecuteReader();
                List<CurrentWMaterialVO> list = Helper.DataReaderMapToList<CurrentWMaterialVO>(reader);

                return list;
            }
        }
    }
}
