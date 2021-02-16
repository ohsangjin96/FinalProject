using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class MReleaseDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public MReleaseDAC()
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
        public List<MRealeaseVO> GetList(string dtpfrom, string dtpto, string cboItemType)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select MR_Code, requestDate  ,m.Item_Code, m.Item_name,i.ITEM_Type, m.Item_Standard, m.Item_Unit, m.item_Order_Company,i.ITEM_WareHouse_IN, Qty, RegDate ,MR_State ,WorkOrder_ID
                                   from MRequest_His m inner join item i on m.Item_Code=i.ITEM_Code
                                   where MR_State='N' and requestDate between @requestDateA and @requestDateB
	                               and ITEM_Type=isnull(@ITEM_Type,ITEM_Type)";

                cmd.Parameters.AddWithValue("@requestDateA", dtpfrom);
                cmd.Parameters.AddWithValue("@requestDateB", dtpto);
                cmd.Parameters.AddWithValue("@ITEM_Type", ((cboItemType == "전체")) ? DBNull.Value : (object)cboItemType);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MRealeaseVO> list = Helper.DataReaderMapToList<MRealeaseVO>(reader);

                return list;
            }
        }

        public int QtyCheck(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"  select Warehouse_StockQty from Warehouse w inner join MRequest_His m on w.ITEM_Code=m.Item_Code
                                     where m.Item_Code=@Item_Code";
                cmd.Parameters.AddWithValue("@Item_Code", code);

                int qty = Convert.ToInt32(cmd.ExecuteScalar());

                if (qty < 50)
                {
                    return 0;
                }
                else return qty;
            }
        }

        public bool Release(int WoCode, int WQty, string ITEM_Code, int MR_Code) // 작지번호 수량 품목 불출번호
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_Update_MRelease";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@WoCode", WoCode);
                cmd.Parameters.AddWithValue("@WQty", WQty);
                cmd.Parameters.AddWithValue("@ITEM_Code", ITEM_Code);
                cmd.Parameters.AddWithValue("@MR_Code", MR_Code);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

    }
}
