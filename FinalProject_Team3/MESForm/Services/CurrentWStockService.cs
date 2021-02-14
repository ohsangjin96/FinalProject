using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class CurrentWStockService
    {
        public void Dispose()
        {
            CurrentWStockDAC dac = new CurrentWStockDAC();
            dac.Dispose();
        }

        public List<CurrentWStockVO> GetCurrentWStockList()
        {
            CurrentWStockDAC dac = new CurrentWStockDAC();
            return dac.GetCurrentWStockList();
        }
    }
}
