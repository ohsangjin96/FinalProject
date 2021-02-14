using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    
        public class LogDAC : ConnectionAccess, IDisposable
        {
            string strConn;
            SqlConnection conn;
            public LogDAC()
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
        public void insertLog(LogVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into DataLog(LogFacility,LogSuccess,LogFail,LogProgram,WorkOrderID) 
                                    values(@LogFacility,@LogSuccess,@LogFail,@LogProgram,@WorkOrderID)";
                cmd.Parameters.AddWithValue("@LogFacility", vo.LogFacility);
                cmd.Parameters.AddWithValue("@LogSuccess", vo.LogSuccess);
                cmd.Parameters.AddWithValue("@LogFail", vo.LogFail);
                cmd.Parameters.AddWithValue("@LogProgram", vo.LogProgram);
                cmd.Parameters.AddWithValue("@WorkOrderID", vo.WorkOrderID);

                cmd.ExecuteNonQuery();
            }
        }          
    }
}

