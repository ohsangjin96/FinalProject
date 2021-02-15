using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class WStandbyDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public WStandbyDAC()
        {
            strConn = ConnectionString;
            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public List<WStandbyVO> GetWStandbyList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select distinct Reorder_Number,
                                           Convert(nvarchar(10), Reorder_OrderDate, 23) Reorder_OrderDate, 
	                                       R.Com_Code, C.Com_Name, R.ITEM_Code, I.ITEM_Name, ITEM_Standard, ITEM_Unit,
                                           Reorder_Amount, Reorder_InAmount, Reorder_Balance,
	                                       Convert(nvarchar(10), (Order_FixedDate - BOR_ReadyTime), 23) Order_FixedDate
                                    from Reorder R join Company C on R.Com_Code = C.Com_Code
                                    			   join ITEM I on R.ITEM_Code = I.ITEM_Code 
                                    			   join PO P on R.Plan_ID = P.Plan_ID
												   join BOR B on R.ITEM_Code = B.Item_Code
                                    where Reorder_State = '발주상태'";
                                    
                SqlDataReader reader = cmd.ExecuteReader();
                List<WStandbyVO> list = Helper.DataReaderMapToList<WStandbyVO>(reader);

                return list;
            }
        }

        // 자재입고처리
        public bool InsertWarehouseWaiting(List<WStandbyVO> list)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_WarehouseWaiting";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    int iRowAffect = 0;
                    for (int i=0; i<list.Count; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@Com_Code", list[i].Com_Code);
                        cmd.Parameters.AddWithValue("@Reorder_Number", list[i].Reorder_Number);
                        cmd.Parameters.AddWithValue("@ITEM_Code", list[i].ITEM_Code);
                        cmd.Parameters.AddWithValue("@Warehousing_Date", Convert.ToDateTime(list[i].InDate));
                        cmd.Parameters.AddWithValue("@Warehousing_Note", (string.IsNullOrEmpty(list[i].Reorder_Note)) ? DBNull.Value : (object)list[i].Reorder_Note);
                        iRowAffect = cmd.ExecuteNonQuery();
                    }

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
