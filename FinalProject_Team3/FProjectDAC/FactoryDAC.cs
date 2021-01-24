using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class FactoryDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public FactoryDAC()
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
        public List<FactoryVO> GetFactoryList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Factory_ID, Factory_Grade, Factory_Type, Factory_Code, Factory_Name,
                                    Factory_HighRank, Factory_Explain, Factory_Credit, Factory_Order, Factory_Demand, 
                                    Factory_Process, Factory_Material, Com_Code, Com_Name, Factory_Use, Factory_Amender,
                                    Factory_ModdifyDate
                                    from Factory";
                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);

                return list;
            }
        }
    }
}
