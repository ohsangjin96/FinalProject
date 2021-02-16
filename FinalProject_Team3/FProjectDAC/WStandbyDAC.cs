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

        public List<WStandbyVO> GetWStandbyList(string sDate, string eDate, string itemCode, string comName, string inComName)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select distinct Reorder_Number,
                                           Convert(nvarchar(10), Reorder_OrderDate, 23) Reorder_OrderDate, 
	                                       R.Com_Code, Com_Name, ITEM_Delivery_Company, R.ITEM_Code, I.ITEM_Name,
                                           ITEM_Standard, ITEM_Unit, Reorder_Amount, Reorder_InAmount, Reorder_Balance,
										   Convert(nvarchar(10), (Mtp_Date - BOR_ReadyTime), 23) Order_FixedDate
                                    from Reorder R join Company C on R.Com_Code = C.Com_Code
                                    			   join ITEM I on R.ITEM_Code = I.ITEM_Code 
												   join Material_Take_Plan MP on R.Plan_ID = MP.Plan_ID
												   join BOM BM on BM.Item_Code = R.ITEM_Code
												   join BOR BR on BM.BOM_Parent_Name = BR.Item_Code
									where R.ITEM_Code = MP.ITEM_Code and Reorder_State = '발주상태' and
										  Convert(nvarchar(10), Mtp_Date, 23) between @dtpFrom and @dtpEnd and
                                          Com_Name = ISNULL(@Com_Name, C.Com_Name) and
                                          ITEM_Delivery_Company = ISNULL(@ITEM_Delivery_Company, ITEM_Delivery_Company) and
                                          I.ITEM_Code = ISNULL(@ITEM_Code, I.ITEM_Code)";

                cmd.Parameters.AddWithValue("@dtpFrom", sDate);
                cmd.Parameters.AddWithValue("@dtpEnd", eDate);
                cmd.Parameters.AddWithValue("@ITEM_Code", (string.IsNullOrEmpty(itemCode)) ? DBNull.Value : (object)itemCode);
                cmd.Parameters.AddWithValue("@Com_Name", (string.IsNullOrEmpty(comName)) ? DBNull.Value : (object)comName);
                cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", (string.IsNullOrEmpty(inComName)) ? DBNull.Value : (object)inComName);

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
                        cmd.Parameters.AddWithValue("@Order_FixedDate", Convert.ToDateTime(list[i].Order_FixedDate));
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
