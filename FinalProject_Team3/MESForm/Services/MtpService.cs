using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class MtpService
    {
        public void Dispose()
        {
            MtpDAC dac = new MtpDAC();
            dac.Dispose();
        }
        public List<MtpVO> GetMtp()
        {
            MtpDAC dac = new MtpDAC();
            return dac.GetMtp();
        }
        public bool InsertMtp(List<MtpVO> list)
        {
            MtpDAC dac = new MtpDAC();
            return dac.InsertMtp(list);
        }
    }
}
