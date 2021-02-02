using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class MaterialCostDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public MaterialCostDAC()
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

        public List<MaterialCostVO> GetMCInfo(string day)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select MC_Code, m.COM_Code, c.Com_Name,m.ITEM_Code,i.ITEM_Name,i.ITEM_Unit_Qty,i.ITEM_Unit,
		                                  MC_IngCost,MC_BeforeCost,Convert(Date, MC_StartDate, 23) MC_StartDate,Convert(Date, MC_EndDate, 23) MC_EndDate,
		                                  MC_Remark,MC_USE
		                                  from Material_Cost M inner join item  i on m.ITEM_Code=i.ITEM_Code
						                                       inner join Company C on m.COM_Code=c.Com_Code
						                  where @day >= m.MC_StartDate and @day<=m.MC_EndDate";
                cmd.Parameters.AddWithValue("@day", day);
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialCostVO> list = Helper.DataReaderMapToList<MaterialCostVO>(reader);

                return list;
            }
        }
        public List<string> GetItemCode(string order)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code 
                                   from item i inner join company c on i.ITEM_Order_Company=c.Com_Name
                                   where i.ITEM_Order_Company=@ITEM_Order_Company";

                cmd.Parameters.AddWithValue("@ITEM_Order_Company", order);


                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0]));
                }
                return list;
            }
        }

        public bool RegisterMC(MaterialCostVO vo)
        {
            if (!IsCodeValied(vo.ITEM_Code, vo.MC_BeforeCost))
            {
                throw new Exception("이미 등록된 품목입니다.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Material_Cost(MC_IngCost, MC_BeforeCost, MC_StartDate, MC_EndDate, MC_Last_Modifier,
	        					                              MC_Last_Modifier_Time, MC_USE, MC_Remark, COM_Code, ITEM_Code)
                                   values(@MC_IngCost, @MC_BeforeCost,@MC_StartDate,@MC_EndDate,@MC_Last_Modifier,
                                   	      @MC_Last_Modifier_Time, @MC_USE, @MC_Remark, @COM_Code, @ITEM_Code)";

                    cmd.Parameters.AddWithValue("@MC_IngCost", vo.MC_IngCost);
                    cmd.Parameters.AddWithValue("@MC_BeforeCost", vo.MC_BeforeCost);
                    cmd.Parameters.AddWithValue("@MC_StartDate", vo.MC_StartDate);
                    cmd.Parameters.AddWithValue("@MC_EndDate", vo.MC_EndDate);
                    cmd.Parameters.AddWithValue("@MC_Last_Modifier", vo.MC_Last_Modifier);
                    cmd.Parameters.AddWithValue("@MC_Last_Modifier_Time", vo.MC_Last_Modifier_Time);
                    cmd.Parameters.AddWithValue("@MC_USE", vo.MC_USE);
                    cmd.Parameters.AddWithValue("@MC_Remark", vo.MC_Remark);
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




        public bool IsCodeValied(string item, int Bcost)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @" select count(*) from Material_Cost
                                     where ITEM_Code=@ITEM_Code and MC_BeforeCost=@MC_BeforeCost";

                cmd.Parameters.AddWithValue("@ITEM_Code", item);
                cmd.Parameters.AddWithValue("@MC_BeforeCost", Bcost);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }
        public bool UpdateMC(MaterialCostVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_UpdateSC";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MC_Code", vo.MC_Code);
                cmd.Parameters.AddWithValue("@MC_IngCost", vo.MC_IngCost);
                cmd.Parameters.AddWithValue("@MC_BeforeCost",vo.MC_BeforeCost);
                cmd.Parameters.AddWithValue("@MC_StartDate", vo.MC_StartDate);
                cmd.Parameters.AddWithValue("@MC_Last_Modifier", vo.MC_Last_Modifier);
                cmd.Parameters.AddWithValue("@MC_Last_Modifier_Time", vo.MC_Last_Modifier_Time);
                cmd.Parameters.AddWithValue("@MC_USE", vo.MC_USE);
                cmd.Parameters.AddWithValue("@MC_Remark", vo.MC_Remark);
                cmd.Parameters.AddWithValue("@COM_Code", vo.COM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Code",vo.ITEM_Code);



                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

        public bool DeleteMC(int pk, string  itemCode,int  BoforeCost)
        {
            using (SqlCommand cmd= new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_DeleteMC";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MC_Code", pk);
                cmd.Parameters.AddWithValue("@item_code", itemCode);
                cmd.Parameters.AddWithValue("@MC_BeforeCost", BoforeCost);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }
    }
}
