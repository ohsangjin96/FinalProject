using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class LogVO
    {
        public int LogNumber { get; set; }
        public string LogFacility { get; set; }
        public int LogSuccess { get; set; }
        public int LogFail { get; set; }
        public int LogProgram { get; set; }
        public DateTime LogDate { get; set; }

    }
}
