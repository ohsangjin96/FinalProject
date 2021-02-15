using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class ReOrderService
    {
        public void Dispose()
        {
            ReOrderDAC dac = new ReOrderDAC();
            dac.Dispose();
        }
        public List<ReOrderFactoryVO> SelectFactory()
        {
            ReOrderDAC dac = new ReOrderDAC();
            return dac.SelectFactory();
        }
        public List<ReOrderOrderVO> SelectOrder()
        {
            ReOrderDAC dac = new ReOrderDAC();
            return dac.SelectOrder();
        }
        public List<string> SelectHouse()
        {
            ReOrderDAC dac = new ReOrderDAC();
            return dac.SelectHouse();
        }
    }
}
