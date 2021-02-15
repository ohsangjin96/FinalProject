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
        
        public List<ReOrderOrderVO> SelectOrder(DateTime date)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Distinct(BOM.Item_Code),Plan_ID,BOM.Item_name,sum(BOM_Spend*PO.Order_OrderAmount) AS Amount,ITEM_WareHouse_IN,Item.ITEM_Order_Company,Company.Com_Code
                                    from PO,BOM,Item,Company
                                    where BOM.BOM_Parent_Name in(select Distinct(BOM.Item_Code) from BOM,PO where BOM.Item_Code in (select Distinct(BOM.Item_Code) from PO,BOM where PO.Item_Code = BOM_Parent_Name))
									and Item.ITEM_Code = BOM.Item_Code
                                    and PO.Order_Plandate = '2021-02-13'
									and Item.ITEM_Order_Company = Company.Com_Name
                                    group by Plan_ID,BOM.Item_Code,BOM.Item_name,ITEM.ITEM_WareHouse_IN,Item.ITEM_Order_Company,Item.ITEM_Order_Company,Company.Com_Code";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ReOrderOrderVO> list = Helper.DataReaderMapToList<ReOrderOrderVO>(reader);
                return list;
            }
        }
        public bool InsertReOrder(List<ReOrderVO> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @" insert into ReOrder(Com_Code, ITEM_Code, Reorder_Amount, Reorder_Balance, 
                                     Reorder_CanCancel, Plan_ID, Reorder_Note, WareHouse_In, ReOrder_FixDate)
                                     values(@Com_Code, @ITEM_Code, @Reorder_Amount, @Reorder_Balance,
                                    @Reorder_CanCancel, @Plan_ID, @Reorder_Note, @WareHouse_In, @ReOrder_FixDate)";
                cmd.Parameters.Add("@Com_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ITEM_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Reorder_Amount", SqlDbType.Int);
                cmd.Parameters.Add("@Reorder_Balance", SqlDbType.Int);
                cmd.Parameters.Add("@Reorder_CanCancel", SqlDbType.Int);
                cmd.Parameters.Add("@Reorder_Note", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WareHouse_In", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ReOrder_FixDate", SqlDbType.DateTime);

                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters["@Com_code"].Value = list[i].Com_Code;
                    cmd.Parameters["@ITEM_Code"].Value = list[i].ITEM_Code;
                    cmd.Parameters["@Reorder_Amount"].Value = list[i].Reorder_Amount;
                    cmd.Parameters["@Reorder_Balance"].Value = list[i].Reorder_Balance;
                    cmd.Parameters["@Reorder_CanCancel"].Value = list[i].Reorder_CanCancel;
                    cmd.Parameters["@Reorder_Note"].Value = list[i].Note;
                    cmd.Parameters["@WareHouse_In"].Value = list[i].WareHouse_In;
                    cmd.Parameters["@ReOrder_FixDate"].Value = list[i].ReOrder_FixDate;
                    int cul = cmd.ExecuteNonQuery();
                    if (cul < 0)
                        return false; 
                }
                return true;
                cmd.CommandText = @"update Demand set Demand_State = '발주완료' where Plan_ID = @Plan_ID";
            }

        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
