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
                cmd.CommandText = @"select  distinct(fa.Item_Code),Facility_Code,Facility_Name,Facility_IP,Facility_Port,BOM_Level
                                    from Facility_Detail fa ,BOM where BOM.Item_Code = fa.Item_Code
                                    and fa.Item_Code in(select BOM.Item_Code from BOM where fa.Item_Code = @Item_Code)";

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
                cmd.CommandText = @"insert into WorkRegist(WorkOrder_ID, WorkRegist_Start, Item_Code, WorkRegist_State, 
                                    WorkRegist_WorkTime, WorkRegist_NomalQty, WorkRegist_FailQty, FacilityDetail_Code)
                                    values(@WorkOrder_ID, @WorkRegist_Start, @Item_Code, @WorkRegist_State, 
                                    @WorkRegist_WorkTime, @WorkRegist_NomalQty, @WorkRegist_FailQty, @FacilityDetail_Code)";

                cmd.Parameters.Add("@WorkOrder_ID", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_Start", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_State", SqlDbType.NVarChar);
                cmd.Parameters.Add("@WorkRegist_WorkTime", SqlDbType.Int);
                cmd.Parameters.Add("@WorkRegist_NomalQty", SqlDbType.Int);
                cmd.Parameters.Add("@WorkRegist_FailQty", SqlDbType.Int);
                cmd.Parameters.Add("@FacilityDetail_Code", SqlDbType.NVarChar);
                for (int i = 0; i < curlist.Count; i++)
                {
                    cmd.Parameters["@WorkOrder_ID"].Value =curlist[i].WorkOrder_ID;
                    cmd.Parameters["@WorkRegist_Start"].Value=curlist[i].WorkRegist_Start;
                    cmd.Parameters["@Item_Code"].Value=curlist[i].Item_Code;
                    cmd.Parameters["@WorkRegist_State"].Value=curlist[i].WorkRegist_State;
                    cmd.Parameters["@WorkRegist_WorkTime"].Value=curlist[i].WorkRegist_WorkTime;
                    cmd.Parameters["@WorkRegist_NomalQty"].Value=curlist[i].WorkRegist_NomalQty;
                    cmd.Parameters["@WorkRegist_FailQty"].Value=curlist[i].WorkRegist_FailQty;
                    cmd.Parameters["@FacilityDetail_Code"].Value=curlist[i].FacilityDetail_Code;
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
                    cmd.CommandText = @"select WorkRegistID, WorkOrder_ID,Com_Code,WorkRegist.Item_Code, FacilityDetail_Code, WorkRegist_NomalQty,
                                        WorkRegist_FailQty, WorkRegist_WorkTime, WorkRegist_Start, WorkRegist_State
                                        from WorkRegist,PO where WorkOrder_ID = PO.Plan_ID";
        
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<WorkRegistVO> list = Helper.DataReaderMapToList<WorkRegistVO>(reader);

                    return list;
                }
            }
        }
    }

