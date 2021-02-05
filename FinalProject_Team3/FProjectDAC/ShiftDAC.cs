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
        public bool RegisterShift(ShiftVO vo)
        {
            if (!IsCodeValied(vo.Shift_Apply_StartDate, vo.Shift_Apply_EndDate))
            {
                throw new Exception("이미 등록된 스케줄입니다.");
            }
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into [Shift](Facility_Code, Shift_type, Shift_People, Shift_StartTime, Shift_EndTime, Shift_Apply_StartDate,
				                                  	    Shift_Apply_EndDate, Shift_Use, Shift_Last_Modifier, Shift_Last_Modifier_Time, Shift_Remark)
                                    values(@Facility_Code,@Shift_type, @Shift_People, @Shift_StartTime, @Shift_EndTime,@Shift_Apply_StartDate,
					                       @Shift_Apply_EndDate, @Shift_Use, @Shift_Last_Modifier, @Shift_Last_Modifier_Time, @Shift_Remark)";

                cmd.Parameters.AddWithValue("@Facility_Code",vo.Facility_Code);
                cmd.Parameters.AddWithValue("@Shift_type",vo.Shift_type);
                cmd.Parameters.AddWithValue("@Shift_People",vo.Shift_People);
                cmd.Parameters.AddWithValue("@Shift_StartTime",vo.Shift_StartTime);
                cmd.Parameters.AddWithValue("@Shift_EndTime",vo.Shift_EndTime);
                cmd.Parameters.AddWithValue("@Shift_Apply_StartDate",vo.Shift_Apply_StartDate);
                cmd.Parameters.AddWithValue("@Shift_Apply_EndDate",vo.Shift_Apply_EndDate);
                cmd.Parameters.AddWithValue("@Shift_Use",vo.Shift_Use);
                cmd.Parameters.AddWithValue("@Shift_Last_Modifier",vo.Shift_Last_Modifier);
                cmd.Parameters.AddWithValue("@Shift_Last_Modifier_Time",vo.Shift_Last_Modifier_Time);
                cmd.Parameters.AddWithValue("@Shift_Remark",vo.Shift_Remark);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }

        public bool IsCodeValied(DateTime start, DateTime end)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select count(Facility_Code) from [Shift]
					                where Shift_Apply_StartDate=@Shift_Apply_StartDate and Shift_Apply_EndDate =@Shift_Apply_EndDate";

                cmd.Parameters.AddWithValue("@Shift_Apply_StartDate", start);
                cmd.Parameters.AddWithValue("@Shift_Apply_EndDate", end);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result < 1)
                    return true;
                else
                    return false;
            }
        }
    }
}
