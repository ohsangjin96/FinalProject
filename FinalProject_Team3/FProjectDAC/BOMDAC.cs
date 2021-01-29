using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class BOMDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public BOMDAC()
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

        public List<BOMVO> CboInfo()
        {
            using (SqlCommand cmd=new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select CAST(Common_Name as varchar) Code,'use' as Gubun from CommonCode 
                                   where Common_Parent='UseYN000' 
                                   union
                                   select  CAST(Common_Name as varchar) Code,'itemtype' as Gubun from CommonCode
                                   where Common_Parent = 'itemtype000'";

                SqlDataReader reader = cmd.ExecuteReader();
                List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(reader);

                return list;
            }
        }

        public List<BOMVO> GetBOMInfo(string CodeOrName, string use, string type)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_GetBOMInfo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CorName", (string.IsNullOrEmpty(CodeOrName)) ? DBNull.Value : (object)CodeOrName);
                cmd.Parameters.AddWithValue("@ITEM_Type", ((type == "")) ? DBNull.Value : (object)type);
                cmd.Parameters.AddWithValue("@ITME_Use", (use == "") ? DBNull.Value : (object)use);

                SqlDataReader reader = cmd.ExecuteReader();
                List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(reader);

                return list;
            }
        }

        public List<BOMVO> GetParent()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"  select BOM_Code, BOM_Parent_Name, b.Item_Code, i.item_Name, BOM_Spend, BOM_StartDate,
	                                        BOM_EndDate, BOM_Amender, BOM_ModdifyDate, BOM_Auto, BOM_Plan, BOM_Note, BOM_Level,
	                                        ITEM_Type
                                      from bom b inner join item i on b.Item_Code = i.ITEM_Code
                                      ";

                SqlDataReader reader = cmd.ExecuteReader();
                List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(reader);

                return list;
            }
        }
        public string LevelCheck(string name) 
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select distinct item_type from bom b inner join item i on b.Item_Code=i.ITEM_Code
                                    where b.item_Code=@item_Code";
                cmd.Parameters.AddWithValue("@item_Code", name);

                string type = Convert.ToString(cmd.ExecuteScalar());
                return type;

            }
        }
        public bool RegisterBOM(BOMVO vo,string Parent)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into BOM(BOM_Parent_Name, Item_Code, Item_name, BOM_Spend, BOM_StartDate, BOM_EndDate,
			                                        BOM_Amender,BOM_ModdifyDate, BOM_Auto, BOM_Plan, BOM_Note, BOM_Level)
                                    values(@BOM_Parent_Name, @Item_Code, @Item_name, @BOM_Spend, @BOM_StartDate,@BOM_EndDate,
                                           @BOM_Amender, @BOM_ModdifyDate, @BOM_Auto, @BOM_Plan, @BOM_Note, @BOM_Level) ";
                cmd.Parameters.AddWithValue("@BOM_Parent_Name", (vo.BOM_Parent_Name == "없음") ? DBNull.Value : (object)vo.BOM_Parent_Name);
                cmd.Parameters.AddWithValue("@Item_Code", vo.item_code);
                cmd.Parameters.AddWithValue("@Item_name", vo.item_name);
                cmd.Parameters.AddWithValue("@BOM_Spend", vo.BOM_Spend);

                cmd.Parameters.AddWithValue("@BOM_StartDate", vo.BOM_StartDate);
                cmd.Parameters.AddWithValue("@BOM_EndDate", vo.BOM_EndDate);
                cmd.Parameters.AddWithValue("@BOM_Amender", vo.BOM_Amender);
                cmd.Parameters.AddWithValue("@BOM_ModdifyDate", vo.BOM_ModdifyDate);

                cmd.Parameters.AddWithValue("@BOM_Auto", vo.BOM_Auto);
                cmd.Parameters.AddWithValue("@BOM_Plan", vo.BOM_Plan);
                cmd.Parameters.AddWithValue("@BOM_Note", vo.BOM_Note);
                cmd.Parameters.AddWithValue("@BOM_Level", vo.BOM_Level);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }
    }
}
