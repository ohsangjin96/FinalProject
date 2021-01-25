using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class POPDAC : ConnectionAccess, IDisposable
    {
            string strConn;
            SqlConnection conn;
            public POPDAC()
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
        public List<POPVO> GetPOPList(string Item_Code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Item_Code,Facility_Code,Facility_Name from Facility_Detail where Item_Code 
                                    in(select BOM.Item_Code from PO,BOM where PO.Item_Code = @BOM_Parent_Code)"; 

                cmd.Parameters.AddWithValue("@BOM_Parent_Code", Item_Code);
                SqlDataReader reader = cmd.ExecuteReader();
                List<POPVO> list = Helper.DataReaderMapToList<POPVO>(reader);

                return list;
            }
        }
    }
}
