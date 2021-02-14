using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class DemandDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public DemandDAC()
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

        public DataTable GetList(string from, string to)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetDplan_Data";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", (string.IsNullOrEmpty(from)) ? DBNull.Value : (object)from);
                cmd.Parameters.AddWithValue("@EndDate", (string.IsNullOrEmpty(to)) ? DBNull.Value : (object)to);

                //SqlDataReader reader = cmd.ExecuteReader();
                //List<POVO> list = Helper.DataReaderMapToList<POVO>(reader);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public bool Update(DemandVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Demand (Plan_ID, Com_Code, Com_Name, Item_Code, Item_Name, Demand_WO, Demand_FixedDate, Demand_OrderAmount)
                                        values (@Plan_ID, @Com_Code, @Com_Name, @Item_Code, @Item_Name, @Demand_WO, @Demand_FixedDate, @Demand_OrderAmount)";

                    cmd.Parameters.AddWithValue("@Plan_ID", vo.Plan_ID);
                    cmd.Parameters.AddWithValue("@Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Name", vo.Com_Name);
                    cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                    cmd.Parameters.AddWithValue("@Item_Name", vo.Item_Name);
                    cmd.Parameters.AddWithValue("@Demand_WO", vo.Demand_WO);
                    cmd.Parameters.AddWithValue("@Demand_FixedDate", vo.Demand_FixedDate);
                    cmd.Parameters.AddWithValue("@Demand_OrderAmount", vo.Demand_OrderAmount);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool DemandWOCheck(string woID)
        {
            using(SqlCommand cmd= new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(Demand_WO) from Demand where Demand_WO=@woID";

                cmd.Parameters.AddWithValue("@woID", woID);

                int iRowAffect = Convert.ToInt32(cmd.ExecuteScalar());

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<DemandVO> GetDemandAllList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Plan_ID, Com_Code, Com_Name, Item_Code, Item_Name, Demand_WO, Demand_FixedDate, Demand_OrderAmount
                                    from Demand";

                SqlDataReader reader = cmd.ExecuteReader();
                List<DemandVO> list = Helper.DataReaderMapToList<DemandVO>(reader);

                return list;
            }
        }
    }
}