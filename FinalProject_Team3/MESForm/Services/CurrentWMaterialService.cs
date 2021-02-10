using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class CurrentWMaterialService
    {
        public void Dispose()
        {
            CurrentWMaterialDAC dac = new CurrentWMaterialDAC();
            dac.Dispose();
        }

        public List<CurrentWMaterialVO> GetCurrentWMaterialList(CurrentWMaterialVO vo)
        {
            CurrentWMaterialDAC dac = new CurrentWMaterialDAC();
            return dac.GetCurrentWMaterialList(vo);
        }

        public bool CancelWearing(List<CurrentWMaterialVO> list)
        {
            CurrentWMaterialDAC dac = new CurrentWMaterialDAC();
            return dac.CancelWearing(list);
        }
    }
}
