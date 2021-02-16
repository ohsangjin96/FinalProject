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
                cmd.CommandText = @"select  distinct(WorkOrder_ID),fa.Facility_Code,fa.Facility_Name,Facility_IP,Facility_Port,BOM_Level,fa.Item_Code,Plan_ID
                                    from Facility_Detail fa ,BOM,WorkOrder where BOM.Item_Code = fa.Item_Code
                                    and fa.Item_Code in(select BOM.Item_Code from BOM where fa.Item_Code = @Item_Code)
									and fa.Item_Code = WorkOrder.Item_Code
									and fa.Facility_Code = WorkOrder.Facility_Code";

                cmd.Parameters.AddWithValue("@Item_Code", Item_Code);
                SqlDataReader reader = cmd.ExecuteReader();
                List<POPVO> list = Helper.DataReaderMapToList<POPVO>(reader);

                return list;
            }
        }
        public bool InsertWorkRegistList(List<WorkRegistVO> curlist)
        {
            List<int> list = new List<int>();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into WorkRegist(WorkRegist_Start, Item_Code, WorkRegist_State,Plan_ID,
                                    WorkRegist_WorkTime, WorkRegist_NomalQty, WorkRegist_FailQty, FacilityDetail_Code,WorkRegist_OrderAmount)
                                    values(@WorkRegist_Start, @Item_Code, @WorkRegist_State,@Plan_ID,
                                    @WorkRegist_WorkTime, @WorkRegist_NomalQty, @WorkRegist_FailQty, @FacilityDetail_Code,@WorkRegist_OrderAmount)";


                
                cmd.Parameters.Add("@WorkRegist_Start", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_State", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_WorkTime", SqlDbType.Int);
                cmd.Parameters.Add("@WorkRegist_NomalQty", SqlDbType.Int);
                cmd.Parameters.Add("@WorkRegist_FailQty", SqlDbType.Int);
                cmd.Parameters.Add("@FacilityDetail_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Plan_ID", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_OrderAmount", SqlDbType.Int);
                for (int i = 0; i < curlist.Count; i++)
                {
                    
                    cmd.Parameters["@WorkRegist_Start"].Value = curlist[i].WorkRegist_Start;
                    cmd.Parameters["@Item_Code"].Value = curlist[i].Item_Code;
                    cmd.Parameters["@WorkRegist_State"].Value = curlist[i].WorkRegist_State;
                    cmd.Parameters["@WorkRegist_WorkTime"].Value = curlist[i].WorkRegist_WorkTime;
                    cmd.Parameters["@WorkRegist_NomalQty"].Value = curlist[i].WorkRegist_NomalQty;
                    cmd.Parameters["@WorkRegist_FailQty"].Value = curlist[i].WorkRegist_FailQty;
                    cmd.Parameters["@FacilityDetail_Code"].Value = curlist[i].FacilityDetail_Code;
                    cmd.Parameters["@Plan_ID"].Value = curlist[i].Plan_ID;
                    cmd.Parameters["@WorkRegist_OrderAmount"].Value = curlist[i].WorkRegist_OrderAmount;
                    cmd.ExecuteNonQuery();
                }
                if (list.Contains(0))
                    return false;
                else return true;

            }
        }
        public List<WorkRegistVO> GetWorkRegist()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select WorkRegistID,Item_Code, FacilityDetail_Code, WorkRegist_NomalQty,Plan_ID,
                                        WorkRegist_FailQty, WorkRegist_WorkTime, WorkRegist_Start, WorkRegist_State
                                        from WorkRegist where WorkRegist_State='제작완료'";

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkRegistVO> list = Helper.DataReaderMapToList<WorkRegistVO>(reader);

                return list;
            }
        }
       
        public List<WorkRegistVO> GetShipment()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select WorkRegist.Plan_ID,Sum(WorkRegist_NomalQty) AS WorkRegist_NomalQty,Sum(WorkRegist_FailQty) AS WorkRegist_FailQty,WorkRegist_OrderAmount
                                    from WorkRegist
                                    where FacilityDetail_Code
                                    in(
                                    select Distinct(Facility_Code)
                                    from BOR,BOM
                                    where BOR.Item_Code in (select distinct(Item_Code) from BOM where BOM_Level=1)
                                    and LEFT(Facility_Code,8)='Painting')
                                    group by WorkRegist.Plan_ID,WorkRegist_OrderAmount";

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkRegistVO> list = Helper.DataReaderMapToList<WorkRegistVO>(reader);

                return list;
            }
        }
        public bool SaveShipment(string Plan_ID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"Update WorkRegist set WorkRegist_State = '출하완료' where Plan_ID = @Plan_ID";
                cmd.Parameters.AddWithValue("@Plan_ID", Plan_ID);
                int i = cmd.ExecuteNonQuery();
                if (i < 0)
                    return false;
                return true;
            }
        }
    }
}
