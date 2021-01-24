using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class BORService
    {
        public void Dispose()
        {
            BORDAC dac = new BORDAC();
            dac.Dispose();
        }

        public List<BORVO> GetBORList()
        {
            BORDAC dac = new BORDAC();
            return dac.GetBORList();
        }
    }
}
