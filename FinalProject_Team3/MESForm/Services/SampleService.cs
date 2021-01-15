using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class SampleService  
    {
        // 데이터 조회
        public List<SampleVO> GetSampleList()
        {
            SampleDAC dac = new SampleDAC();
            return dac.GetSampleList();
        }

        // 데이터 등록
        public bool InsertSample(SampleVO vo)
        {
            SampleDAC dac = new SampleDAC();
            return dac.InsertSample(vo);
        }

        // 데이터 수정
        public bool UpdateSample(SampleVO vo)
        {
            SampleDAC dac = new SampleDAC();
            return UpdateSample(vo);
        }

        // 데이터 삭제
        public bool DeleteSample(int id)
        {
            SampleDAC dac = new SampleDAC();
            return DeleteSample(id);
        }
    }
}
