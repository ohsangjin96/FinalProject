using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class SignUpDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public SignUpDAC()
        {
            strConn = this.ConnectionString;
            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
            conn = new SqlConnection(strConn);
            conn.Open();

        }

        public bool IDCheck(string id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from [User] where User_ID=@User_ID ";

                cmd.Parameters.AddWithValue("@User_ID", id);
                
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt == 1)
                    return true;
                else
                    return false;
            }

        }
        //RegisterSignUp
        public bool RegisterSignUp(SignUpVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into [User](User_ID, User_Pwd, User_Name, User_Email, User_Dept)
                                    values(@User_ID, @User_Pwd, @User_Name, @User_Email, @User_Dept)";

                cmd.Parameters.AddWithValue("@User_ID", vo.User_ID);
                cmd.Parameters.AddWithValue("@User_Pwd", vo.User_Pwd);
                cmd.Parameters.AddWithValue("@User_Name", vo.User_Name);
                cmd.Parameters.AddWithValue("@User_Email", vo.User_Email);
                cmd.Parameters.AddWithValue("@User_Dept", vo.User_Dept);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

       
    }
}
