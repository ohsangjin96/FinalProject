using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class WMaterialDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public WMaterialDAC()
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

        #region 입고처리
        //입고대기리스트 목록
        public List<WMaterialVO> GetWMaterialList(string sDate, string eDate, string itemCode, string comName, string inComName)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                //    cmd.CommandText = @"select ROW_NUMBER() OVER (Order by Reorder_Number desc) RowNo, C.Com_Name, ITEM_Delivery_Company, R.ITEM_Code, I.ITEM_Name, ITEM_Standard,
                //                               ITEM_Type, ITEM_Unit, Reorder_InspYN, Reorder_Amount, Reorder_InAmount,
                //                               Reorder_Balance , Order_FixedDate, Reorder_State, Reorder_Number,
                //                               ITEM_WareHouse_IN, MC_IngCost, Factory_Code, Reorder_Note
                //                        from Reorder R join Company C on R.Com_Code = C.Com_Code
                //                        			   join ITEM I on R.ITEM_Code = I.ITEM_Code
                //                        			   join PO P on R.Plan_ID = P.Plan_ID
                //                              join Material_Cost MC on I.ITEM_Code = MC.ITEM_Code
                //                              join Factory F on F.Factory_Name = I.ITEM_WareHouse_IN
                //                        where MC_BeforeCost = 0 and Reorder_State != '입고완료' and
                //                              Order_FixedDate between @dtpFrom and @dtpEnd and
                //Reorder_State = ISNULL(@Reorder_State, Reorder_State) and
                //I.ITEM_Code = ISNULL(@ITEM_Code, I.ITEM_Code) and
                //C.Com_Name = ISNULL(@Com_Name, C.Com_Name) and
                //ITEM_Delivery_Company = ISNULL(@ITEM_Delivery_Company, ITEM_Delivery_Company)";

                cmd.CommandText = @"select distinct C.Com_Name, ITEM_Delivery_Company, WT.ITEM_Code, I.ITEM_Name,
                                           ITEM_Standard, ITEM_Type, ITEM_Unit, Reorder_Amount, Reorder_InAmount,
                                           Reorder_Balance , Reorder_State, WT.Reorder_Number,
                                           Warehousing_Date, Warehousing_Note, (Order_FixedDate - BOR_ReadyTime) Order_FixedDate,
										   ITEM_WareHouse_IN, MC_IngCost, Factory_Code
									from Warehousing WT join Company C on WT.Com_Code = C.Com_Code
									                          join ITEM I on WT.ITEM_Code = I.ITEM_Code
															  join Reorder R on WT.Reorder_Number = R.Reorder_Number
														      join Material_Cost MC on WT.ITEM_Code = MC.ITEM_Code
                                    						  join PO P on R.Plan_ID = P.Plan_ID
															  join BOR B on WT.ITEM_Code = B.Item_Code
															  join Factory F on F.Factory_Name = I.ITEM_WareHouse_IN
									where MC_BeforeCost = 0 and Reorder_State != '입고완료' and
                                          Order_FixedDate between @dtpFrom and @dtpEnd and
                                          I.ITEM_Code = ISNULL(@ITEM_Code, I.ITEM_Code) and
                                          C.Com_Name = ISNULL(@Com_Name, C.Com_Name) and
                                          ITEM_Delivery_Company = ISNULL(@ITEM_Delivery_Company, ITEM_Delivery_Company)";

                cmd.Parameters.AddWithValue("@dtpFrom", sDate);
                cmd.Parameters.AddWithValue("@dtpEnd", eDate);
                cmd.Parameters.AddWithValue("@ITEM_Code", (string.IsNullOrEmpty(itemCode)) ? DBNull.Value : (object)itemCode);
                cmd.Parameters.AddWithValue("@Com_Name", (string.IsNullOrEmpty(comName)) ? DBNull.Value : (object)comName);
                cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", (string.IsNullOrEmpty(inComName)) ? DBNull.Value : (object)inComName);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WMaterialVO> list = Helper.DataReaderMapToList<WMaterialVO>(reader);

                return list;
            }
        }

        //입고처리
        #endregion
        public bool InsertWareHouse(List<WMaterialVO> list)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_InsertWareHouse";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    int iRowAffect = 0;
                    for (int i=0; i<list.Count; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@ITEM_Code", list[i].ITEM_Code);
                        cmd.Parameters.AddWithValue("@Reorder_Number", list[i].Reorder_Number);
                        cmd.Parameters.AddWithValue("@Com_Name", list[i].Com_Name);
                        cmd.Parameters.AddWithValue("@Factory_Code", list[i].Factory_Code);
                        cmd.Parameters.AddWithValue("@Reorder_Amount", list[i].Reorder_Amount);
                        cmd.Parameters.AddWithValue("@InQty", list[i].InQty);
                        cmd.Parameters.AddWithValue("@Warehousing_Date", list[i].Warehousing_Date);
                        iRowAffect = cmd.ExecuteNonQuery();
                    }

                    //int iRowAffect = cmd.ExecuteNonQuery();

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
