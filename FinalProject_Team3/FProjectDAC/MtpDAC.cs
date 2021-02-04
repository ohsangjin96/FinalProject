using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
