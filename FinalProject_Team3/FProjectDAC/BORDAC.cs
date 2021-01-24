using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class BORDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public BORDAC()
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

        // 데이터 검색
        public List<BORVO> GetBORList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select I.Item_Code, Item_Name, Process_Type, Process_Name, FD.Facility_Code, Facility_Name,
                                           BOR_TactTime, BOR_Date, BOR_Order, BOR_Transference, BOR_Use, BOR_Note, BOR_Code
                                    from BOR B inner join ITEM I on B.Item_Code = I.ITEM_Code
                                    		   inner join Process P on B.Process_Type = P.Process_Code
                                    		   inner join Facility_Detail FD on B.Facility_Code = FD.Facility_Code";
                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);

                return list;
            }
        }
    }
}
