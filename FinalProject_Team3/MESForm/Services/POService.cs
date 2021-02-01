using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FProjectDAC;
using FProjectVO;

namespace MESForm.Services
{
    public class POService
    {
        public void Dispose()
        {
            PODAC dac = new PODAC();
            dac.Dispose();
        }

        public List<POVO> GetPOList()
        {
            PODAC dac = new PODAC();
            return dac.GetPOList();
        }

        public bool RegPOList(POVO vo)
        {
            PODAC dac = new PODAC();
            return dac.RegPOList(vo);
        }

        public bool DelPOList(string planID)
        {
            PODAC dac = new PODAC();
            return dac.DelPOList(planID);
        }
    }
}
