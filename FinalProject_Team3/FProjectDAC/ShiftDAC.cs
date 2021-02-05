using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class ShiftDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public ShiftDAC()
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

        public List<ShiftVO> GetShiftInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Shift_Code,f.Facility_Code,Facility_Name,Shift_type,Shift_StartTime,Shift_EndTime,
	                                       Shift_Apply_StartDate,Shift_Apply_EndDate,Shift_People,Shift_Use,Shift_Last_Modifier,
		                                   Shift_Last_Modifier_Time,Shift_Remark
                                    from [Shift] S inner join  Facility_Detail F on s.Facility_Code=f.Facility_Code";

                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(reader);

                return list;
            }
        }

        public List<ShiftVO> GetFacInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"  select Facility_Code,Facility_name from Facility_Detail";

                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(reader);

                return list;
            }
        }

        public List<ShiftVO> GetShiftSelect(string type, string fac)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Shift_Code,s.Facility_Code,Facility_Name,Shift_type,Shift_StartTime,Shift_EndTime,
	                                       Shift_Apply_StartDate,Shift_Apply_EndDate,Shift_People,Shift_Use,Shift_Last_Modifier,
		                                   Shift_Last_Modifier_Time,Shift_Remark
                                    from [Shift] S inner join  Facility_Detail F on s.Facility_Code=f.Facility_Code
                                    where Shift_type=@Shift_type and s.Facility_Code=@Facility_Code";

                cmd.Parameters.AddWithValue("@Shift_type", type);
                cmd.Parameters.AddWithValue("@Facility_Code", fac);

                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(reader);

                return list;
            }
        }
    }
}
