using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class POPService
    {
        public List<POPVO> GetPOPList(string Item_Code)
        {
            POPDAC dac = new POPDAC();
            return dac.GetPOPList(Item_Code);
        }
    }
}
