using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
   public class ItemDAC : ConnectionAccess
    {
        string strConn;
        SqlConnection conn;
        public ItemDAC()
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
        public List<ItemVO> GetItemAllList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ITEM_Code, ITEM_Name, ITEM_Standard, ITEM_Unit, ITEM_Unit_Qty, ITEM_Type, ITEM_Import_YN,
                                    ITEM_Process_YN, ITEM_Export_YN, ITEM_Delivery_Company, ITEM_Order_Company, ITEM_WareHouse_IN,
                                    ITEM_WareHouse_OUT, ITME_LeadTime, ITME_Min_Order_Qty, ITME_Safe_Qty, ITME_Manager, ITME_Last_Modifier,
                                    Convert(Date, ITME_Last_Modifier_Time, 23) ITME_Last_Modifier_Time, ITME_Use, 
                                    ITEM_Discontinuance, ITEM_Delivery_Type, ITEM_Remark
                                    from ITEM";
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(reader);

                return list;
                //
                //
            }
        }

        public bool ItemCheck(string item) //품목이름 중복 확인
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "select count(ITEM_Code) from item where ITEM_Code=@ITEM_Code";
                cmd.Parameters.AddWithValue("@ITEM_Code", item);
                
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt == 1)
                    return true;
                else
                    return false;
            }
        }
        // 데이터 등록
        public bool RegisterItem(ItemVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())//품목등록 쿼리
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into
                                        item(ITEM_Code, ITEM_Name, ITEM_Standard, ITEM_Unit, ITEM_Unit_Qty,
				                             ITEM_Type, ITEM_Import_YN, ITEM_Process_YN, ITEM_Export_YN, ITEM_Delivery_Company,
				                             ITEM_Order_Company, ITEM_WareHouse_IN, ITEM_WareHouse_OUT, ITME_LeadTime, ITME_Min_Order_Qty,
				                             ITME_Safe_Qty, ITME_Manager, ITME_Last_Modifier, ITME_Last_Modifier_Time, ITME_Use,
				                             ITEM_Discontinuance, ITEM_Delivery_Type, ITEM_Remark)

                                        values(@ITEM_Code, @ITEM_Name, @ITEM_Standard, @ITEM_Unit, @ITEM_Unit_Qty,
				                               @ITEM_Type, @ITEM_Import_YN, @ITEM_Process_YN, @ITEM_Export_YN, @ITEM_Delivery_Company,
				                               @ITEM_Order_Company, @ITEM_WareHouse_IN, @ITEM_WareHouse_OUT, @ITME_LeadTime, @ITME_Min_Order_Qty,
				                               @ITME_Safe_Qty, @ITME_Manager, @ITME_Last_Modifier, @ITME_Last_Modifier_Time, @ITME_Use,
				                               @ITEM_Discontinuance, @ITEM_Delivery_Type, @ITEM_Remark)";

                    cmd.Parameters.AddWithValue("@ITEM_Code", vo.ITEM_Code);
                    cmd.Parameters.AddWithValue("@ITEM_Name", vo.ITEM_Name);
                    cmd.Parameters.AddWithValue("@ITEM_Standard", vo.ITEM_Standard);
                    cmd.Parameters.AddWithValue("@ITEM_Unit", vo.ITEM_Unit);
                    cmd.Parameters.AddWithValue("@ITEM_Unit_Qty", vo.ITEM_Unit_Qty);

                    cmd.Parameters.AddWithValue("@ITEM_Type", vo.ITEM_Type);
                    cmd.Parameters.AddWithValue("@ITEM_Import_YN", vo.ITEM_Import_YN);
                    cmd.Parameters.AddWithValue("@ITEM_Process_YN", vo.ITEM_Process_YN);
                    cmd.Parameters.AddWithValue("@ITEM_Export_YN", vo.ITEM_Export_YN);
                    cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", vo.ITEM_Delivery_Company);

                    cmd.Parameters.AddWithValue("@ITEM_Order_Company", vo.ITEM_Order_Company);
                    cmd.Parameters.AddWithValue("@ITEM_WareHouse_IN", vo.ITEM_WareHouse_IN);
                    cmd.Parameters.AddWithValue("@ITEM_WareHouse_OUT", vo.ITEM_WareHouse_OUT);
                    cmd.Parameters.AddWithValue("@ITME_LeadTime", vo.ITME_LeadTime);
                    cmd.Parameters.AddWithValue("@ITME_Min_Order_Qty", vo.ITME_Min_Order_Qty);

                    cmd.Parameters.AddWithValue("@ITME_Safe_Qty", vo.ITME_Safe_Qty);
                    cmd.Parameters.AddWithValue("@ITME_Manager", vo.ITME_Manager);
                    cmd.Parameters.AddWithValue("@ITME_Last_Modifier", vo.ITME_Last_Modifier);
                    cmd.Parameters.AddWithValue("@ITME_Last_Modifier_Time", vo.ITME_Last_Modifier_Time);
                    cmd.Parameters.AddWithValue("@ITME_Use", vo.ITME_Use);
                    cmd.Parameters.AddWithValue("@ITEM_Discontinuance", vo.ITEM_Discontinuance);
                    cmd.Parameters.AddWithValue("@ITEM_Delivery_Type", vo.ITEM_Delivery_Type);
                    cmd.Parameters.AddWithValue("@ITEM_Remark", vo.ITEM_Remark);
                    

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public  List<ItemVO> GetCodeInfoByCodeTypes()//코드타입으로 코드정보 조회
        {
            /*파라미터를 꼭 써서 쿼리문을 생성해야 되는 경우
                -사용자가 입력하는 부분(SQL Injection)  
            */

            
            string sql = @"select CAST(Common_Name as varchar) Code,'use' as Gubun from CommonCode  where Common_Parent='UseYN000' -- 사용여부
                           union 
                           select CAST(Com_Name as varchar ) Code,'ordercompany' as Gubun from Company where Com_Type='협력업체' -- 발주업체
                           union 
                           select CAST(Com_Name as varchar) Code,'Deliverycompany' as Gubun from Company where Com_Type='고객사' -- 남풉업체
                           union 
                           select CAST(Factory_Type as varchar) Code, 'factory' as Gubun from Factory where Factory_Grade='창고' --입출고 창고
                           union 
                           select distinct  CAST(ITME_Manager as varchar) Code, 'itemmanager' as Gubun from item  -- 담당자
                           union 
                           select  CAST(Common_Name as varchar) Code,'itemtype' as Gubun from CommonCode  where Common_Parent='itemtype000'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(reader);
                return list;
            }

        }

        public bool DeleteItem(string pk) //삭제
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from item where ITEM_Code=@ITEM_Code";
                    

                    cmd.Parameters.AddWithValue("@ITEM_Code", pk);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    if (iRowAffect > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool UpdateItem(ItemVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_UpdateItem";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ITEM_Code", vo.ITEM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Name", vo.ITEM_Name);
                cmd.Parameters.AddWithValue("@ITEM_Standard", vo.ITEM_Standard);
                cmd.Parameters.AddWithValue("@ITEM_Unit", vo.ITEM_Unit);
                cmd.Parameters.AddWithValue("@ITEM_Unit_Qty", vo.ITEM_Unit_Qty);

                cmd.Parameters.AddWithValue("@ITEM_Type", vo.ITEM_Type);
                cmd.Parameters.AddWithValue("@ITEM_Import_YN", vo.ITEM_Import_YN);
                cmd.Parameters.AddWithValue("@ITEM_Process_YN", vo.ITEM_Process_YN);
                cmd.Parameters.AddWithValue("@ITEM_Export_YN", vo.ITEM_Export_YN);
                cmd.Parameters.AddWithValue("@ITEM_Delivery_Company", vo.ITEM_Delivery_Company);

                cmd.Parameters.AddWithValue("@ITEM_Order_Company", vo.ITEM_Order_Company);
                cmd.Parameters.AddWithValue("@ITEM_WareHouse_IN", vo.ITEM_WareHouse_IN);
                cmd.Parameters.AddWithValue("@ITEM_WareHouse_OUT", vo.ITEM_WareHouse_OUT);
                cmd.Parameters.AddWithValue("@ITME_LeadTime", vo.ITME_LeadTime);
                cmd.Parameters.AddWithValue("@ITME_Min_Order_Qty", vo.ITME_Min_Order_Qty);

                cmd.Parameters.AddWithValue("@ITME_Safe_Qty", vo.ITME_Safe_Qty);
                cmd.Parameters.AddWithValue("@ITME_Manager", vo.ITME_Manager);
                cmd.Parameters.AddWithValue("@ITME_Last_Modifier", vo.ITME_Last_Modifier);
                cmd.Parameters.AddWithValue("@ITME_Last_Modifier_Time", vo.ITME_Last_Modifier_Time);
                cmd.Parameters.AddWithValue("@ITME_Use", vo.ITME_Use);

                cmd.Parameters.AddWithValue("@ITEM_Discontinuance", vo.ITEM_Discontinuance);
                cmd.Parameters.AddWithValue("@ITEM_Delivery_Type", vo.ITEM_Delivery_Type);
                cmd.Parameters.AddWithValue("@ITEM_Remark", vo.ITEM_Remark);
                
                

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0;
            }
        }
    }
}
//