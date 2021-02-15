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

        public List<WStandbyVO> GetWStandbyList()
        {
            WStandbyDAC dac = new WStandbyDAC();
            return dac.GetWStandbyList();
        }

        public bool InsertWarehouseWaiting(List<WStandbyVO> list)
        {
            WStandbyDAC dac = new WStandbyDAC();
            return dac.InsertWarehouseWaiting(list);
        }
    }
}
