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
        public List<CompanyVO> GetCompanyList()
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.GetCompanyList();
        }
    }
}
