using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class WMaterialService
    {
        public void Dispose()
        {
            WMaterialDAC dac = new WMaterialDAC();
            dac.Dispose();
        }

        public List<WMaterialVO> GetWMaterialList()
        {
            WMaterialDAC dac = new WMaterialDAC();
            return dac.GetWMaterialList();
        }
    }
}
