using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public class SampleDAC : ConnectionAccess
    {
        // Sample DAC
        string strConn;
        SqlConnection conn;
        public SampleDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        // 데이터 조회
        public List<SampleVO> GetSampleList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Id, Name, Age 
                                    from Sample";
                SqlDataReader reader = cmd.ExecuteReader();
                List<SampleVO> list = Helper.DataReaderMapToList<SampleVO>(reader);
                conn.Close();
                return list;
            }
        }

        // 데이터 등록
        public bool InsertSample(SampleVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into Sample(Name, Age)
                                            values(@Name,@Age)";

                    cmd.Parameters.AddWithValue("@Name", vo.Name);
                    cmd.Parameters.AddWithValue("@Age", vo.Age);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 데이터 수정
        public bool UpdateSample(SampleVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update Sample set Name=@Name
                                         where Id =@Id";

                    cmd.Parameters.AddWithValue("@Id", vo.Id);
                    cmd.Parameters.AddWithValue("@Name", vo.Name);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        // 데이터 삭제
        public bool DeleteSample(int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from Sample
                                        where Id =@id";

                    cmd.Parameters.AddWithValue("@CustNum", id);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (iRowAffect > 0)
                        return true;
                    else
                        throw new Exception("삭제할 데이터가 없습니다");
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
