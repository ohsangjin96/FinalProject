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
                cmd.Parameters.AddWithValue("@ITEM_Type", (type == "") ? DBNull.Value : (object)type);
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
                cmd.CommandText = @"  select BOM_Code, BOM_Parent_Name, b.Item_Code, b.item_Name, BOM_Spend, BOM_StartDate,
	                                        BOM_EndDate, BOM_Amender, BOM_ModdifyDate, BOM_Auto, BOM_Plan, BOM_Note, BOM_Level,
	                                        ITEM_Type
                                      from bom b inner join item i on b.Item_Code = i.ITEM_Code
                                      ";

                SqlDataReader reader = cmd.ExecuteReader();
                List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(reader);

                return list;
            }
        }
    }
}
