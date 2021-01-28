﻿using FProjectVO;
using System;
using System.Collections.Generic;
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
                cmd.CommandText = @"select Item_Code,Facility_Code,Facility_Name from Facility_Detail where Item_Code 
                                    in(select BOM.Item_Code from PO,BOM where PO.Item_Code = @BOM_Parent_Code)";

                cmd.Parameters.AddWithValue("@BOM_Parent_Code", Item_Code);
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
                cmd.CommandText = @"insert into WorkRegist(WorkOrder_ID, WorkRegist_Start, Item_Code, Item_Name, WorkRegist_State, 
                                    WorkRegist_WorkTime, WorkRegist_NomalQty, WorkRegist_FailQty, FacilityDetail_Code)
                                    values(@WorkOrder_ID, @WorkRegist_Start, @Item_Code, @Item_Name, @WorkRegist_State, 
                                    @WorkRegist_WorkTime, @WorkRegist_NomalQty, @WorkRegist_FailQty, @FacilityDetail_Code)";
                                    

                for (int i = 0; i < curlist.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@WorkOrder_ID", curlist[i].Plan_ID);
                    cmd.Parameters.AddWithValue("@WorkRegist_Start", curlist[i].WorkRegist_Start);
                    cmd.Parameters.AddWithValue("@Item_Code", curlist[i].Item_Code);
                    cmd.Parameters.AddWithValue("@Item_Name", curlist[i].Item_Code);
                    cmd.Parameters.AddWithValue("@WorkRegist_State", curlist[i].WorkRegist_State);
                    cmd.Parameters.AddWithValue("@WorkRegist_WorkTime", curlist[i].WorkRegist_WorkTime);
                    cmd.Parameters.AddWithValue("@WorkRegist_NomalQty", curlist[i].WorkRegist_NomalQty);
                    cmd.Parameters.AddWithValue("@WorkRegist_FailQty", curlist[i].WorkRegist_FailQty);
                    cmd.Parameters.AddWithValue("@FacilityDetail_Code", curlist[i].FacilityDetail_Code);
                    cmd.ExecuteNonQuery();
                }
                if (list.Contains(0))
                    return false;
                else return true;

            }
        }
    }
}
