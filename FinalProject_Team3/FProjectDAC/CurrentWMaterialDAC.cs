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

        public List<CurrentWMaterialVO> GetCurrentWMaterialList(CurrentWMaterialVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ROW_NUMBER() OVER (Order by Reorder_His_No desc) RowNo, Reorder_His_No,
                                           RH.Reorder_Number, Reorder_InDate, Reorder_InType, ITEM_WareHouse_IN,
                                           I.ITEM_Code, ITEM_Name, ITEM_Standard, ITEM_Unit, RH.Reorder_InAmount, 
                                           RH.Reorder_Cancel, Reorder_Balance, Com_Name, ITEM_Delivery_Company,
                                           IsCancel
                                    from Reorder_His RH join Reorder R on RH.Reorder_Number = R.Reorder_Number
					                                    join ITEM I on RH.ITEM_Code = I.ITEM_Code
									where Reorder_InDate between @FromDate and @ToDate and
										  ITEM_Delivery_Company = ISNULL(@ITEM_Delivery_Company, ITEM_Delivery_Company) and
										  ITEM_WareHouse_IN = ISNULL(@ITEM_WareHouse_IN, ITEM_WareHouse_IN) and
										  I.ITEM_Code = ISNULL(@ITEM_Code, I.ITEM_Code)
                                    order by Reorder_His_No desc";
                cmd.Parameters.AddWithValue("@FromDate", vo.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", vo.ToDate);
                cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", (string.IsNullOrEmpty(vo.ITEM_Delivery_Company)) ? DBNull.Value : (object)vo.ITEM_Delivery_Company);
                cmd.Parameters.AddWithValue("@ITEM_WareHouse_IN", (string.IsNullOrEmpty(vo.ITEM_WareHouse_IN)) ? DBNull.Value : (object)vo.ITEM_WareHouse_IN);
                cmd.Parameters.AddWithValue("@ITEM_Code", (string.IsNullOrEmpty(vo.ITEM_Code)) ? DBNull.Value : (object)vo.ITEM_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<CurrentWMaterialVO> list = Helper.DataReaderMapToList<CurrentWMaterialVO>(reader);

                return list;
            }
        }

        public bool CancelWearing(List<CurrentWMaterialVO> list)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_CancelWearing";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    int iRowAffect = 0;
                    for (int i=0; i< list.Count; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@Reorder_His_No", list[i].Reorder_His_No);
                        cmd.Parameters.AddWithValue("@Reorder_Number", list[i].Reorder_Number);
                        cmd.Parameters.AddWithValue("@ITEM_Code", list[i].ITEM_Code);
                        cmd.Parameters.AddWithValue("@Com_Name", list[i].Com_Name);
                        cmd.Parameters.AddWithValue("@Reorder_Cancel", list[i].Reorder_InAmount);
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
