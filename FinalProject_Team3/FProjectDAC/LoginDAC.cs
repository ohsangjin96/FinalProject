using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class LoginDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public LoginDAC()
        {
            strConn = this.ConnectionString;
            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
            conn = new SqlConnection(strConn);
            conn.Open();

        }
        public List<LoginVO> LoginInfo(string id, string pwd)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @" select User_ID, User_Pwd, User_Name, User_Email, User_Dept
                                     from [user] where User_ID='q' and User_Pwd=1";
                SqlDataReader reader = cmd.ExecuteReader();
                List<LoginVO> list = Helper.DataReaderMapToList<LoginVO>(reader);
                conn.Close();
                if (list.Count > 0) return list;
                else return null;
            }
        }
    }
}
