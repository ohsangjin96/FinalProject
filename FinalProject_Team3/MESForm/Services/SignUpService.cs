using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class SignUpService
    {
        public bool RegisterSignUp(SignUpVO vo)
        {
            SignUpDAC dac = new SignUpDAC();
            return dac.RegisterSignUp(vo);
        }
        public bool IDCheck(string id)
        {
            SignUpDAC dac = new SignUpDAC();
            return dac.IDCheck(id);
        }
    }
}
