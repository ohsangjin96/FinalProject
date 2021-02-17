using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace FProjectDAC
{
    public class ReOrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public ReOrderDAC()
        {
            strConn = this.ConnectionString;
            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        
        public List<ReOrderVO> SelectOrder(DateTime date)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Distinct(BOM.Item_Code),Demand.Plan_ID, BOM.Item_name,Mtp_Amount, ITEM_WareHouse_IN, ITEM_Order_Company, Company.Com_Code
                                    from Material_Take_Plan MT,BOM,Item, Company, Demand
                                    where BOM_Parent_Name in
                                    (select Distinct(BOM.Item_Code) from Demand,BOM
                                      where Demand.Item_Code = BOM_Parent_Name)
										  and Item.ITEM_Code = BOM.Item_Code
										  and  Mt.Mtp_Date >= '2021-02-17'
										  and Item.ITEM_Order_Company = Company.Com_Name
										  and MT.ITEM_Code = BOM.Item_Code
										  and Demand_stated ='자재소요계획확정'";
                cmd.Parameters.AddWithValue("@Order_Plandate", date.ToShortDateString());
                SqlDataReader reader = cmd.ExecuteReader();
                List<ReOrderVO> list = Helper.DataReaderMapToList<ReOrderVO>(reader);
                return list;
            }
        }
        public bool InsertReOrder(List<ReOrderVO> list)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Reorder(Com_Code, ITEM_Code, Reorder_Amount, Reorder_Balance, 
                                                            Reorder_CanCancel, Plan_ID, Reorder_Note, WareHouse_In)
                                        values(@Com_Code, @ITEM_Code, @Reorder_Amount, @Reorder_Balance,
                                               @Reorder_CanCancel, @Plan_ID, @Reorder_Note, @WareHouse_In)";

                    int iRowAffect = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@Com_Code", list[i].Com_Code);
                        cmd.Parameters.AddWithValue("@ITEM_Code", list[i].ITEM_Code);
                        cmd.Parameters.AddWithValue("@Reorder_Amount", list[i].Amount);
                        cmd.Parameters.AddWithValue("@Reorder_Balance", list[i].Amount);
                        cmd.Parameters.AddWithValue("@Reorder_CanCancel", list[i].Amount);
                        cmd.Parameters.AddWithValue("@Plan_ID", list[i].Plan_ID);
                        cmd.Parameters.AddWithValue("@Reorder_Note", (string.IsNullOrEmpty(list[i].Note)) ? DBNull.Value : (object)list[i].Note);
                        cmd.Parameters.AddWithValue("@WareHouse_In", list[i].ITEM_WareHouse_IN);
                        iRowAffect = cmd.ExecuteNonQuery();
                    }
                    cmd.CommandText = @"Update Material_Take_Plan set Mtp_State = '발주완료' where Plan_ID=@Plan_ID";
                    iRowAffect = cmd.ExecuteNonQuery();
                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }
        public List<ReOrderVO> selectReOrder()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Reorder_Number, Com_Code, ITEM_Code, Reorder_Amount, Reorder_InAmount, Reorder_Balance, Reorder_State, Reorder_OrderDate, Reorder_Cancel, Reorder_CanCancel, Plan_ID, Reorder_Note, WareHouse_In from ReOrder";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ReOrderVO> list = Helper.DataReaderMapToList<ReOrderVO>(reader);
                return list;
            }
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
