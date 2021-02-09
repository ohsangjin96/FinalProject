using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class SalesCostDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public SalesCostDAC()
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

        public List<SalesCostVO> GetSCInfo(string day)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"Select SC_Code,s.COM_Code, c.Com_Name,s.ITEM_Code,i.ITEM_Name,i.ITEM_Unit_Qty,i.ITEM_Unit,
                                           SC_IngCost,SC_BeforeCost,Convert(Date, SC_StartDate, 23) SC_StartDate,Convert(Date, SC_EndDate, 23)
                                           SC_EndDate, SC_Remark,SC_USE
                                    from Sale_Cost S inner join item i on s.ITEM_Code=i.ITEM_Code
                                   				     inner join Company C on s.COM_Code=c.Com_Code
                                    where @day >= S.SC_StartDate and @day<=S.SC_EndDate";
                cmd.Parameters.AddWithValue("@day", day);
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesCostVO> list = Helper.DataReaderMapToList<SalesCostVO>(reader);

                return list;
            }
        }

        public List<string> GetItemCode(string order)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code 
                                    from item i inner join company c on i.ITEM_Delivery_Company=c.Com_Name
                                    where i.ITEM_Delivery_Company=@ITEM_Delivery_Company";

                cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", order);

                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                return list;
            }
        }
        public bool RegisterSC(SalesCostVO vo)
        {
            if (!IsCodeValied(vo.ITEM_Code, vo.SC_BeforeCost))
            {
                throw new Exception("이미 등록된 품목입니다.");
            }

            try
            {
                using (SqlCommand cmd= new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Sale_Cost(SC_IngCost, SC_BeforeCost, SC_StartDate, SC_EndDate, SC_Last_Modifier,
	        					                              SC_Last_Modifier_Time, SC_USE, SC_Remark, COM_Code, ITEM_Code)
                                   values(@SC_IngCost, @SC_BeforeCost,@SC_StartDate,@SC_EndDate,@SC_Last_Modifier,
                                   	      @SC_Last_Modifier_Time, @SC_USE, @SC_Remark, @COM_Code, @ITEM_Code)";

                    cmd.Parameters.AddWithValue("@SC_IngCost", vo.SC_IngCost);
                    cmd.Parameters.AddWithValue("@SC_BeforeCost", vo.SC_BeforeCost);
                    cmd.Parameters.AddWithValue("@SC_StartDate", vo.SC_StartDate);
                    cmd.Parameters.AddWithValue("@SC_EndDate", vo.SC_EndDate);
                    cmd.Parameters.AddWithValue("@SC_Last_Modifier", vo.SC_Last_Modifier);
                    cmd.Parameters.AddWithValue("@SC_Last_Modifier_Time", vo.SC_Last_Modifier_Time);
                    cmd.Parameters.AddWithValue("@SC_USE", vo.SC_Use);
                    cmd.Parameters.AddWithValue("@SC_Remark", vo.SC_Remark);
                    cmd.Parameters.AddWithValue("@COM_Code", vo.COM_Code);
                    cmd.Parameters.AddWithValue("@ITEM_Code", vo.ITEM_Code);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
                
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool IsCodeValied(string item, int Scost)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @" select count(*) from Sale_Cost
                                     where ITEM_Code=@ITEM_Code and SC_BeforeCost=@SC_BeforeCost";

                cmd.Parameters.AddWithValue("@ITEM_Code", item);
                cmd.Parameters.AddWithValue("@SC_BeforeCost", Scost);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateSC(SalesCostVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_UpdateSC";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SC_Code", vo.SC_Code);
                cmd.Parameters.AddWithValue("@SC_IngCost", vo.SC_IngCost);
                cmd.Parameters.AddWithValue("@SC_BeforeCost", vo.SC_BeforeCost);
                cmd.Parameters.AddWithValue("@SC_StartDate", vo.SC_StartDate);
                cmd.Parameters.AddWithValue("@SC_Last_Modifier", vo.SC_Last_Modifier);
                cmd.Parameters.AddWithValue("@SC_Last_Modifier_Time", vo.SC_Last_Modifier_Time);
                cmd.Parameters.AddWithValue("@SC_USE", vo.SC_Use);
                cmd.Parameters.AddWithValue("@SC_Remark", vo.SC_Remark);
                cmd.Parameters.AddWithValue("@COM_Code", vo.COM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Code", vo.ITEM_Code);



                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

        public bool DeleteSC(int pk, string  itemCode, int BoforeCost)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_DeleteSC";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SC_Code", pk);
                cmd.Parameters.AddWithValue("@item_code", itemCode);
                cmd.Parameters.AddWithValue("@SC_BeforeCost", BoforeCost);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

        public List<SalesCostVO> GetSelect(string item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"Select SC_Code,s.COM_Code, c.Com_Name,s.ITEM_Code,i.ITEM_Name,i.ITEM_Unit_Qty,i.ITEM_Unit,
                                           SC_IngCost,SC_BeforeCost,Convert(Date, SC_StartDate, 23) SC_StartDate,Convert(Date, SC_EndDate, 23)
                                           SC_EndDate, SC_Remark,SC_USE
                                    from Sale_Cost S inner join item i on s.ITEM_Code=i.ITEM_Code
                                   				     inner join Company C on s.COM_Code=c.Com_Code
                                    where s.ITEM_Code=@ITEM_Code";

                cmd.Parameters.AddWithValue("@item_code", item);

                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesCostVO> list = Helper.DataReaderMapToList<SalesCostVO>(reader);

                return list;
            }

        }
    }
}
