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

        public List<WMaterialVO> GetWMaterialList(string sDate, string eDate, string orderState, string itemCode, string comName, string inComName)
        {
            WMaterialDAC dac = new WMaterialDAC();
            return dac.GetWMaterialList(sDate, eDate, orderState, itemCode, comName, inComName);
        }

        public bool InsertWareHouse(List<WMaterialVO> list)
        {
            WMaterialDAC dac = new WMaterialDAC();
            return dac.InsertWareHouse(list);
        }
    }
}
