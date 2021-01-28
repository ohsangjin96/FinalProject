using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class FacilityService
    {
        public void Dispose()
        {
            FacilityDAC dac = new FacilityDAC();
            dac.Dispose();
        }

        #region 설비군
        //데이터 불러오기
        public List<FacilityVO> GetFacilityList()
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.GetFacilityList();
        }

        //데이터 등록
        public bool InsertFacility(FacilityVO vo)
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.InsertFacility(vo);
        }

        //데이터 수정
        public bool UpdateFacility(FacilityVO vo)
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.UpdateFacility(vo);
        }

        //데이터 삭제
        public bool DeleteFacility(string code)
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.DeleteFacility(code);
        }

        // 선택한 설비에 대한 설비군이 존재하는지 검색
        public int SearchFacilityDetaile(string code)
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.SearchFacilityDetaile(code);
        }
        #endregion

        #region 설비
        //설비 데이터 불러오기
        public List<FacilityVO> GetFacilityDetailList()
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.GetFacilityDetailList();
        }
        #endregion
    }
}
