using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class WMaterialDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public WMaterialDAC()
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

        public List<WMaterialVO> GetWMaterialList()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select C.Com_Name, ITEM_Delivery_Company, R.ITEM_Code, I.ITEM_Name, ITEM_Standard,
                                           ITEM_Type, ITEM_Unit, Reorder_InspYN, Reorder_Amount, Reorder_InAmount,
                                           Reorder_Balance , Order_FixedDate, Reorder_State, Reorder_Number,
                                           ITEM_WareHouse_IN, MC_IngCost, Factory_Code
                                    from Reorder R join Company C on R.Com_Code = C.Com_Code
                                    			   join ITEM I on R.ITEM_Code = I.ITEM_Code
                                    			   join PO P on R.Plan_ID = P.Plan_ID
			                                       join Material_Cost MC on I.ITEM_Code = MC.ITEM_Code
			                                       join Factory F on F.Factory_Name = I.ITEM_WareHouse_IN
                                    where MC_BeforeCost = 0";
                                    
                SqlDataReader reader = cmd.ExecuteReader();
                List<WMaterialVO> list = Helper.DataReaderMapToList<WMaterialVO>(reader);

                return list;
            }
        }
    }
}
