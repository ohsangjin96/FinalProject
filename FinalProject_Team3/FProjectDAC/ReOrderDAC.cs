using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public List<ReOrderFactoryVO> SelectFactory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Com_Code, Com_Name from Company where Com_Type = '협력업체' and Com_Conditions = '물류'";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ReOrderFactoryVO> list = Helper.DataReaderMapToList<ReOrderFactoryVO>(reader);
                return list;
            }
        }
        public List<ReOrderOrderVO> SelectOrder()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Plan_ID,BOM.Item_Code,BOM.Item_name,sum(BOM_Spend*PO.Order_OrderAmount) AS Amount
                                    from PO,BOM
                                    where BOM.BOM_Parent_Name in(select BOM.Item_Code from BOM,PO where BOM.Item_Code in (select BOM.Item_Code from PO,BOM where PO.Item_Code = BOM_Parent_Name))
                                    and PO.Order_Plandate = '2021-02-13'
                                    group by Plan_ID,BOM.Item_Code,BOM.Item_name";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ReOrderOrderVO> list = Helper.DataReaderMapToList<ReOrderOrderVO>(reader);
                return list;
            }
        }
        public List<string> SelectHouse()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Factory_Name from Factory where Factory_Type = '자재팀창고'";
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                int i = 0;
                while (reader.Read())
                {
                    list.Add(reader[i].ToString());
                    i++;
                }
                return list;
            }

        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
