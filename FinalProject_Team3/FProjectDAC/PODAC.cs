﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FProjectVO;

namespace FProjectDAC
{
    public class PODAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public PODAC()
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

        public List<POVO> GetPOList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Order_Plandate, Order_WO, P.Com_Code, C.Com_Type,C.Com_Name, Order_MKT, Order_OrderType, Order_Group, Order_Gubun,
                                           Order_Size, I.Item_Code, I.ITEM_Type ,I.Item_Name, Order_FixedDate, Order_RelaseAmount, Order_OrderAmount,
                                           Order_CancelAmount, Order_Arrive, Order_Remark, Plan_ID, PO_State
                                    from PO P left outer join Company C on P.Com_Code = C.Com_Code
		                                      left outer join ITEM I on P.Item_Code = I.Item_Code";

                SqlDataReader reader = cmd.ExecuteReader();
                List<POVO> list = Helper.DataReaderMapToList<POVO>(reader);

                return list;
            }
        }

        public bool ExcelWOCheck(string order_wo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(Order_WO) from PO where Order_WO=@Order_WO";

                cmd.Parameters.AddWithValue("@Order_WO", order_wo);

                int iRowAffect = Convert.ToInt32(cmd.ExecuteScalar());

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool ExcelCompanyCheck(string com_code, string com_name)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(Com_Code) from Company where Com_Code=@Com_Code and Com_Name=@Com_Name";

                cmd.Parameters.AddWithValue("@Com_Code", com_code);
                cmd.Parameters.AddWithValue("@Com_Name", com_name);

                int iRowAffect = Convert.ToInt32(cmd.ExecuteScalar());

                if (iRowAffect > 0)
                    return true;
                else
                    return false;
            }
        }

        public string ExcelItemCheck(string item_name)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code from ITEM where ITEM_Name=@ITEM_Name";

                cmd.Parameters.AddWithValue("@ITEM_Name", item_name);

                string item_code = null;

                item_code = (cmd.ExecuteScalar() != null) ? cmd.ExecuteScalar().ToString() : null;

                return item_code;
            }
        }

        public bool RegPOList(POVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into
                                        PO(Order_Plandate, Order_WO, Com_Code, Com_Type, Order_MKT, Order_OrderType, Order_Group, Order_Gubun, Order_Size, Item_Code, Item_Name, Order_FixedDate, Order_RelaseAmount, Order_OrderAmount, Order_CancelAmount, Order_Arrive, Order_Remark, Plan_ID)
                                        values(@Order_Plandate, @Order_WO, @Com_Code, @Com_Type, @Order_MKT, @Order_OrderType, @Order_Group, @Order_Gubun, @Order_Size, @Item_Code, @Item_Name, @Order_FixedDate, @Order_RelaseAmount, @Order_OrderAmount, @Order_CancelAmount, @Order_Arrive, @Order_Remark, @Plan_ID)";

                    cmd.Parameters.AddWithValue("@Order_Plandate",vo.Order_Plandate);
                    cmd.Parameters.AddWithValue("@Order_WO", vo.Order_WO);
                    cmd.Parameters.AddWithValue("@Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Type", vo.Com_Type);
                    cmd.Parameters.AddWithValue("@Order_MKT", vo.Order_MKT);
                    cmd.Parameters.AddWithValue("@Order_OrderType", vo.Order_OrderType);
                    cmd.Parameters.AddWithValue("@Order_Group", vo.Order_Group);
                    cmd.Parameters.AddWithValue("@Order_Gubun", vo.Order_Gubun);
                    cmd.Parameters.AddWithValue("@Order_Size", vo.Order_Size);
                    cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                    cmd.Parameters.AddWithValue("@Item_Name", vo.Item_Name);
                    cmd.Parameters.AddWithValue("@Order_FixedDate", vo.Order_FixedDate);
                    cmd.Parameters.AddWithValue("@Order_RelaseAmount", vo.Order_RelaseAmount);
                    cmd.Parameters.AddWithValue("@Order_OrderAmount", vo.Order_OrderAmount);
                    cmd.Parameters.AddWithValue("@Order_CancelAmount", vo.Order_CancelAmount);
                    cmd.Parameters.AddWithValue("@Order_Arrive", vo.Order_Arrive);
                    cmd.Parameters.AddWithValue("@Order_Remark", vo.Order_Remark);
                    cmd.Parameters.AddWithValue("@Plan_ID", vo.Plan_ID);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool DelPOList(string planID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from PO where Plan_ID = @Plan_ID";

                    cmd.Parameters.AddWithValue("@Plan_ID", planID);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    if (iRowAffect > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        //PO
        public List<POVO> GetPOList(string woID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Order_Plandate, Order_WO, P.Com_Code, C.Com_Type,C.Com_Name, Order_MKT, Order_OrderType, Order_Group, Order_Gubun,
                                           Order_Size, I.Item_Code, I.ITEM_Type ,I.Item_Name, Order_FixedDate, Order_RelaseAmount, Order_OrderAmount,
                                           Order_CancelAmount, Order_Arrive, Order_Remark, Plan_ID
                                    from PO P left outer join Company C on P.Com_Code = C.Com_Code
		                                      left outer join ITEM I on P.Item_Code = I.Item_Code
                                    where Order_WO=@Order_WO";

                cmd.Parameters.AddWithValue("@Order_WO", woID);

                SqlDataReader reader = cmd.ExecuteReader();
                List<POVO> list = Helper.DataReaderMapToList<POVO>(reader);

                return list;
            }
        }

        public bool UpdatePOList(POVO vo)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update PO 
                                        set    Com_Code=@Com_Code, Com_Type=@Com_Type, 
                                               Item_Code=@Item_Code, Item_Name=@Item_Name, Order_FixedDate=@Order_FixedDate, Order_RelaseAmount=@Order_RelaseAmount,
                                               Order_OrderAmount=@Order_OrderAmount, Order_Arrive=@Order_Arrive, 
                                               Order_Remark=@Order_Remark
                                        where  Order_WO=@Order_WO";

                    cmd.Parameters.AddWithValue("@Com_Code",vo.Com_Code);
                    cmd.Parameters.AddWithValue("@Com_Type",vo.Com_Type);
                    cmd.Parameters.AddWithValue("@Item_Code",vo.Item_Code);
                    cmd.Parameters.AddWithValue("@Item_Name",vo.Item_Name);
                    cmd.Parameters.AddWithValue("@Order_FixedDate",vo.Order_FixedDate);
                    cmd.Parameters.AddWithValue("@Order_RelaseAmount",vo.Order_RelaseAmount);
                    cmd.Parameters.AddWithValue("@Order_OrderAmount",vo.Order_OrderAmount);
                    cmd.Parameters.AddWithValue("@Order_Arrive",vo.Order_Arrive);
                    cmd.Parameters.AddWithValue("@Order_Remark",vo.Order_Remark);

                    cmd.Parameters.AddWithValue("@Order_WO",vo.Order_WO);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

    }
}