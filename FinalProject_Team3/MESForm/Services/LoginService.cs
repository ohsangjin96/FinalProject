using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class LoginService
    {
        public List<LoginVO> LoginInfo(string id, string pwd)
        {
            LoginDAC dac = new LoginDAC();
            return dac.LoginInfo(id, pwd);
        }
    }
}
