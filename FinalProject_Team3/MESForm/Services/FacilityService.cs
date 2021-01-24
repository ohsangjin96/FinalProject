using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class FacilityService
    {
        public void Dispose()
        {
            FacilityDAC dac = new FacilityDAC();
            dac.Dispose();
        }

        public List<FacilityVO> GetFacilityList()
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.GetFacilityList();
        }

        public List<FacilityVO> GetFacilityDetailList()
        {
            FacilityDAC dac = new FacilityDAC();
            return dac.GetFacilityDetailList();
        }
    }
}
