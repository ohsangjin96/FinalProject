using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class BORDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public BORDAC()
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

        // 데이터 검색
        public List<BORVO> GetBORList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select I.Item_Code, Item_Name, BOR_Route, Common_Name as BOR_RouteName, FD.Facility_Code,
                                           Facility_Name, BOR_TactTime,
                                           CONVERT(varchar, BOR_ReadyTime) BOR_ReadyTime, BOR_Order,
                                           CONVERT(varchar, BOR_Transference) BOR_Transference,
                                           BOR_Use, BOR_Note, BOR_Amender,
                                           CONVERT(CHAR(19), BOR_ModdifyDate, 120) BOR_ModdifyDate, BOR_Code
                                    from BOR B inner join ITEM I on B.Item_Code = I.ITEM_Code
                                    		   inner join Facility_Detail FD on B.Facility_Code = FD.Facility_Code
											   inner join CommonCode C on B.BOR_Route = C.Common_Code
                                    order by BOR_Route, FD.Facility_Code, BOR_ModdifyDate";
                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);

                return list;
            }
        }

        // 데이터 검색 (조건)
        public List<BORVO> SearchBORList(string item, string route, string facility)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select I.Item_Code, Item_Name, BOR_Route, Common_Name as BOR_RouteName, FD.Facility_Code,
                                           Facility_Name, BOR_TactTime,
                                           CONVERT(varchar, BOR_ReadyTime) BOR_ReadyTime, BOR_Order,
                                           CONVERT(varchar, BOR_Transference) BOR_Transference,
                                           BOR_Use, BOR_Note, BOR_Amender,
                                           CONVERT(CHAR(19), BOR_ModdifyDate, 120) BOR_ModdifyDate, BOR_Code
                                    from BOR B inner join ITEM I on B.Item_Code = I.ITEM_Code
                                    		   inner join Facility_Detail FD on B.Facility_Code = FD.Facility_Code
											   inner join CommonCode C on B.BOR_Route = C.Common_Code
                                    where I.Item_Code = ISNULL(@Item_Code, I.Item_Code) and
                                    	  BOR_Route = ISNULL(@BOR_Route, BOR_Route) and
                                    	  FD.Facility_Code = ISNULL(@Facility_Code, FD.Facility_Code)
                                    order by BOR_Route, FD.Facility_Code, BOR_ModdifyDate";

                cmd.Parameters.AddWithValue("@Item_Code", (string.IsNullOrEmpty(item)) ? DBNull.Value : (object)item);
                cmd.Parameters.AddWithValue("@BOR_Route", (string.IsNullOrEmpty(route)) ? DBNull.Value : (object)route);
                cmd.Parameters.AddWithValue("@Facility_Code", (string.IsNullOrEmpty(facility)) ? DBNull.Value : (object)facility);

                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);

                return list;
            }
        }

        // 데이터 등록
        public bool InsertBOR(BORVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into BOR (Item_Code, BOR_Route, Facility_Code, BOR_TactTime,
                                                         BOR_ReadyTime, BOR_Order, BOR_Transference,
                                                         BOR_Use, BOR_Note, BOR_Amender)
                                        values (@Item_Code, @BOR_Route, @Facility_Code, @BOR_TactTime, @BOR_ReadyTime,
                                                @BOR_Order, @BOR_Transference, @BOR_Use, @BOR_Note, @BOR_Amender)";

                    cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                    cmd.Parameters.AddWithValue("@BOR_Route", vo.BOR_Route);
                    cmd.Parameters.AddWithValue("@Facility_Code", (string.IsNullOrEmpty(vo.Facility_Code)) ? DBNull.Value : (object)vo.Facility_Code);
                    cmd.Parameters.AddWithValue("@BOR_TactTime", vo.BOR_TactTime);
                    cmd.Parameters.AddWithValue("@BOR_ReadyTime", (vo.BOR_ReadyTime == "") ? DBNull.Value : (object)vo.BOR_ReadyTime);
                    cmd.Parameters.AddWithValue("@BOR_Order", vo.BOR_Order);
                    cmd.Parameters.AddWithValue("@BOR_Transference", (vo.BOR_Transference == "") ? DBNull.Value : (object)vo.BOR_Transference);
                    cmd.Parameters.AddWithValue("@BOR_Use", vo.BOR_Use);
                    cmd.Parameters.AddWithValue("@BOR_Note", (string.IsNullOrEmpty(vo.BOR_Note)) ? DBNull.Value : (object)vo.BOR_Note);
                    cmd.Parameters.AddWithValue("@BOR_Amender", (string.IsNullOrEmpty(vo.BOR_Amender)) ? DBNull.Value : (object)vo.BOR_Amender);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 데이터 수정
        public bool UpdateBOR(BORVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update BOR set BOR_TactTime=@BOR_TactTime, BOR_ReadyTime=@BOR_ReadyTime,
                                                       BOR_Order=@BOR_Order, BOR_Transference=@BOR_Transference,
                                                       BOR_Use=@BOR_Use, BOR_Note=@BOR_Note
                                        where BOR_Code = @BOR_Code";

                    cmd.Parameters.AddWithValue("@BOR_Code", vo.BOR_Code);
                    cmd.Parameters.AddWithValue("@BOR_TactTime", vo.BOR_TactTime);
                    cmd.Parameters.AddWithValue("@BOR_ReadyTime", (vo.BOR_ReadyTime == "") ? DBNull.Value : (object)vo.BOR_ReadyTime);
                    cmd.Parameters.AddWithValue("@BOR_Order", vo.BOR_Order);
                    cmd.Parameters.AddWithValue("@BOR_Transference", (vo.BOR_Transference == "") ? DBNull.Value : (object)vo.BOR_Transference);
                    cmd.Parameters.AddWithValue("@BOR_Use", vo.BOR_Use);
                    cmd.Parameters.AddWithValue("@BOR_Note", (string.IsNullOrEmpty(vo.BOR_Note)) ? DBNull.Value : (object)vo.BOR_Note);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 데이터 삭제
        public bool DeleteBOR(string codes)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_DeleteBOR";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BOR_Codes", codes);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                string str = err.Message;
                throw new Exception(err.Message);
            }
        }
    }
}
