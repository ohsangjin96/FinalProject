using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class CompanyService
    {
        public void Dispose()
        {
            CompanyDAC dac = new CompanyDAC();
            dac.Dispose();
        }

        //조회
        public List<CompanyVO> GetCompanyList()
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.GetCompanyList();
        }

        // 등록
        public bool InsertCompany(CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.InsertCompany(vo);
        }

        //수정
        public bool UpdateCompany(CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.UpdateCompany(vo);
        }

        //삭제
        public bool DeleteCompany(string companyCode)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.DeleteCompany(companyCode);
        }
    }
}
