using FProjectDAC;
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
    }
}
