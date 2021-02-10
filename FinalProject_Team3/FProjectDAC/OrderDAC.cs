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
        public DataTable GetProductPlan(string datefrom, string dateto)
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
        public List<Product_PlanVO> GetProductPlanList(string datefrom, string dateto)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetOrderInformationList";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", datefrom);
                cmd.Parameters.AddWithValue("@EndDate", dateto);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Product_PlanVO> list = Helper.DataReaderMapToList<Product_PlanVO>(reader);
                return list;
            }
        }
        public bool InsertProductPlanList(List<Product_PlanVO> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into Product_Plan(Item_Code, Item_Name, Facility_Code, Facility_Name,OrderAmount, FixDate, Com_Code, Com_Name,Plan_ID)
                                   values(@Item_Code, @Item_Name, @Facility_Code, @Facility_Name, @OrderAmount, @FixDate, @Com_Code, @Com_Name,@Plan_ID)";
                cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Item_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@OrderAmount", SqlDbType.Int);
                cmd.Parameters.Add("@FixDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Plan_ID", SqlDbType.NVarChar);
                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters["@Item_Code"].Value = list[i].Item_Code;
                    cmd.Parameters["@Item_Name"].Value = list[i].Item_Name;
                    cmd.Parameters["@Facility_Code"].Value = list[i].Facility_Code;
                    cmd.Parameters["@Facility_Name"].Value = list[i].Facility_Name;
                    cmd.Parameters["@Com_Code"].Value = list[i].Com_Code;
                    cmd.Parameters["@Com_Name"].Value = list[i].Com_Name;
                    cmd.Parameters["@OrderAmount"].Value = list[i].OrderAmount;
                    cmd.Parameters["@FixDate"].Value = list[i].FixDate;
                    cmd.Parameters["@Plan_ID"].Value = list[i].Plan_ID;
                    int k = cmd.ExecuteNonQuery();
                    if (k < 0)
                    {
                        return false;
                    }
                }
                cmd.CommandText = @"Update PO set State = '생산확정' where PO.Plan_ID = @Plan_ID";
                int a = cmd.ExecuteNonQuery();
                if (a < 0)
                    return false;
  
                return true;
            }
        }
        public List<WorkOrderVO> GetWorkOrderList(string datefrom, string dateto)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetWorkOrderList";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDate", datefrom);
                cmd.Parameters.AddWithValue("@EndDate", dateto);
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);
                return list;
            }
        }

        public bool InsertWorkOrderList(List<WorkOrderVO> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into WorkOrder(Item_Code, Item_Name, Facility_Code, Facility_Name, OrderAmount, FixDate, TackTime, Plan_ID, Com_Code, Com_Name)
                                    values (@Item_Code, @Item_Name, @Facility_Code, @Facility_Name, @OrderAmount, @FixDate, @TackTime, @Plan_ID, @Com_Code, @Com_Name)";
                cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Item_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Facility_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Plan_ID", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Com_Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@OrderAmount", SqlDbType.Int);
                cmd.Parameters.Add("@TackTime", SqlDbType.Int);
                cmd.Parameters.Add("@FixDate", SqlDbType.DateTime);
                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters["@Item_Code"].Value = list[i].Item_Code;
                    cmd.Parameters["@Item_Name"].Value = list[i].Item_Name;
                    cmd.Parameters["@Facility_Code"].Value = list[i].Facility_Code;
                    cmd.Parameters["@Facility_Name"].Value = list[i].Facility_Name;
                    cmd.Parameters["@Plan_ID"].Value = list[i].Plan_ID;
                    cmd.Parameters["@Com_Code"].Value = list[i].Com_Code;
                    cmd.Parameters["@Com_Name"].Value = list[i].Com_Name;
                    cmd.Parameters["@OrderAmount"].Value = list[i].OrderAmount;
                    cmd.Parameters["@TackTime"].Value = list[i].TackTime;
                    cmd.Parameters["@FixDate"].Value = list[i].FixDate;

                    int k = cmd.ExecuteNonQuery();
                    if (k < 0)
                    {
                        return false;
                    }
                }
                cmd.CommandText = @"Update Product_Plan set PP_State = '지시확정' where Product_Plan.Plan_ID = @Plan_ID";
                int a = cmd.ExecuteNonQuery();
                if (a < 0)
                    return false;
                return true;

            }
        }
        public DataTable GetWorkOrder(string datefrom, string dateto)
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetWorkOrder";
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

