using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class LogService
    {
        public void insertLog(LogVO vo)
        {
            LogDAC dac = new LogDAC();
            dac.insertLog(vo);
        }
    }
}
