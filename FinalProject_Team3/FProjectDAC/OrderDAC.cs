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
    public class OrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public OrderDAC()
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
        public List<OrderVO> GetOrderList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Plan_ID,Order_Plandate,Order_WO,Com_Code,Com_Type,Order_MKT,Order_OrderType,Order_Group,Order_Gubun,
	 Order_Size,Item_Code,Item_Name,Order_FixedDate,Order_RelaseAmount,Order_OrderAmount,Order_CancelAmount,Order_Arrive,Order_Remark from PO";
                SqlDataReader reader = cmd.ExecuteReader();
                List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(reader);
                return list;
            }
        }
        public DataTable GetWorkOrder(string datefrom, string dateto)
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetOrderInformation";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", datefrom);
                cmd.Parameters.AddWithValue("@EndDate", dateto);

                //SqlDataReader reader = cmd.ExecuteReader();
                //List<POVO> list = Helper.DataReaderMapToList<POVO>(reader);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);

                return ds;

            }
        }
        public List<SeeWorkOrderVO> GetWorkOrderList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetOrderInformationList";
                SqlDataReader reader = cmd.ExecuteReader();
                List<SeeWorkOrderVO> list = Helper.DataReaderMapToList<SeeWorkOrderVO>(reader);
                return list;
            }
        }
        public bool InsertWorkOrderList(List<SeeWorkOrderVO> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into WorkOrder (Item_Code, Item_Name, Facility_Code, Facility_Name, Order_OrderAmount, Order_FixedDate, TackTime, Plan_ID, Com_Code, Com_Name, BOR_Order)
                                   values(@Item_Code, @Item_Name, @Facility_Code, @Facility_Name, @Order_OrderAmount, @Order_FixedDate, @TackTime, @Plan_ID, @Com_Code, @Com_Name, @BOR_Order)";
                cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Item_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Plan_ID", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Order_OrderAmount", SqlDbType.Int);
                cmd.Parameters.Add("@BOR_Order", SqlDbType.Int);
                cmd.Parameters.Add("@TackTime", SqlDbType.Int);
                cmd.Parameters.Add("@Order_FixedDate", SqlDbType.DateTime);
                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters["@Item_Code"].Value = list[i].Item_Code;
                    cmd.Parameters["@Item_Name"].Value = list[i].Item_Name;
                    cmd.Parameters["@Facility_Code"].Value = list[i].Facility_Code;
                    cmd.Parameters["@Facility_Name"].Value = list[i].Facility_Name;
                    cmd.Parameters["@Plan_ID"].Value = list[i].Plan_ID;
                    cmd.Parameters["@Com_Code"].Value = list[i].Com_Code;
                    cmd.Parameters["@Com_Name"].Value = list[i].Com_Name;
                    cmd.Parameters["@Order_OrderAmount"].Value = list[i].Order_OrderAmount;
                    cmd.Parameters["@BOR_Order"].Value = list[i].BOR_Order;
                    cmd.Parameters["@TackTime"].Value = list[i].TackTime;
                    cmd.Parameters["@Order_FixedDate"].Value = list[i].Order_FixedDate;

                    int k = cmd.ExecuteNonQuery();
                    if (k < 0)
                    {
                        return false;
                    }
                }
                return true;

            }
        }
        public List<POPWorkOrderVO> GetSelectWorkOrderList(string date)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select distinct(Item_Code), Item_Name,Order_OrderAmount, Plan_ID, Order_FixedDate from WorkOrder where Order_FixedDate =@date";
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                List<POPWorkOrderVO> list = Helper.DataReaderMapToList<POPWorkOrderVO>(reader);
                return list;
            }

        }
    }
}

