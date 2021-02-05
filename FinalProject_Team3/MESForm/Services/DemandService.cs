using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class DemandService
    {
        public void Dispose()
        {
            DemandDAC dac = new DemandDAC();
            dac.Dispose();
        }

        public DataTable GetList(string from, string to)
        {
            DemandDAC dac = new DemandDAC();
            return dac.GetList(from, to);
        }

        public bool Update(DemandVO vo)
        {
            DemandDAC dac = new DemandDAC();
            return dac.Update(vo);
        }
    }
}
