using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class CommonCodeService
    {
        public void Dispose()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            dac.Dispose();
        }

        // 조회
        public List<CommonCodeVO> GetCommonCodeList()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetCommonCodeList();
        }

        // 등록
        public bool InsertCommonCode(CommonCodeVO vo)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.InsertCommonCode(vo);
        }

        // 수정
        public bool UpdateCommonCode(CommonCodeVO vo)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.UpdateCommonCode(vo);
        }

        // 삭제
        public bool DeleteCommonCode(string code)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.DeleteCommonCode(code);
        }

        // 코드 중복확인
        public bool IsCodeValied(string code)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.IsCodeValied(code);
        }

        // 코드명 중복 확인
        public bool IsCodeNameValied(string name)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.IsCodeNameValied(name);
        }

        // 순서 가져오기
        public int GetSeqValue(string pname)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetSeqValue(pname);
        }
    }
}
