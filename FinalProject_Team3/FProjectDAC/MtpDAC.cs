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
    public class MtpDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public MtpDAC()
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

        public List<MtpVO> GetMtp()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select demand.Plan_ID,BOM.Item_Code,BOM.Item_name,sum(BOM_Spend*Demand.Demand_OrderAmount) AS Amount, CONVERT(datetime,Left(demand.Plan_ID,8)) AS Plan_Date
                                    from demand,BOM,PO where BOM.BOM_Parent_Name in(select BOM.Item_Code from BOM,PO where BOM.Item_Code in (select BOM.Item_Code from PO,BOM where PO.Item_Code = BOM_Parent_Name))
                                    and PO.PO_State='수요계획'
                                    group by demand.Plan_ID,BOM.Item_Code,BOM.Item_name";

                SqlDataReader reader = cmd.ExecuteReader();
                List<MtpVO> list = Helper.DataReaderMapToList<MtpVO>(reader);

                return list;
            }
        }
        public bool InsertMtp(List<MtpVO> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into Material_Take_Plan(ITEM_Code, ITEM_Name, Mtp_Amount, Plan_ID, Mtp_Date) values(@ITEM_Code, @ITEM_Name, @Mtp_Amount, @Plan_ID, @Mtp_Date)";

                cmd.Parameters.Add("@ITEM_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ITEM_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Mtp_Amount", SqlDbType.Int);
                cmd.Parameters.Add("@Plan_ID", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Mtp_Date", SqlDbType.DateTime);
                for(int i = 0; i<list.Count; i++)
                {
                    cmd.Parameters["@ITEM_Code"].Value = list[i].ITEM_Code;
                    cmd.Parameters["@ITEM_Name"].Value = list[i].ITEM_Name;
                    cmd.Parameters["@Mtp_Amount"].Value = list[i].Amount;
                    cmd.Parameters["@Plan_ID"].Value = list[i].Plan_ID;
                    cmd.Parameters["@Mtp_Date"].Value = list[i].Plan_Date;
                    int Cont = cmd.ExecuteNonQuery();
                    if (Cont < 0)
                        return false;
                }
                cmd.CommandText = @"update PO set PO_State = '자재소요계획확정' where Plan_ID = @Plan_ID";
                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters["@Plan_ID"].Value = list[i].Plan_ID;
                    int Cont = cmd.ExecuteNonQuery();
                    if (Cont < 0)
                        return false;
                }
                    return true;
            }
        }
    }
}







        //public DataSet GetList(string from, string to)
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = conn;
        //        cmd.CommandText = @"";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

//        cmd.Parameters.AddWithValue("@StartDate", (string.IsNullOrEmpty(from)) ? DBNull.Value : (object)from);
//        cmd.Parameters.AddWithValue("@EndDate", (string.IsNullOrEmpty(to)) ? DBNull.Value : (object)to);

//        SqlDataAdapter da = new SqlDataAdapter(cmd);
//        DataSet ds = new DataSet();
//        da.Fill(ds, "result");

//        return ds;
//    }
//}



