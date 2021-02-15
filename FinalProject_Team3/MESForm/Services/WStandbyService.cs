using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class WStandbyService
    {
        public void Dispose()
        {
            WStandbyDAC dac = new WStandbyDAC();
            dac.Dispose();
        }

        public List<WStandbyVO> GetWStandbyList(string sDate, string eDate, string itemCode, string comName, string inComName)
        {
            WStandbyDAC dac = new WStandbyDAC();
            return dac.GetWStandbyList(sDate, eDate, itemCode, comName, inComName);
        }

        public bool InsertWarehouseWaiting(List<WStandbyVO> list)
        {
            WStandbyDAC dac = new WStandbyDAC();
            return dac.InsertWarehouseWaiting(list);
        }
    }
}
