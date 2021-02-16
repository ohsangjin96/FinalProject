using FProjectDAC;
using FProjectVO;
using MESForm.Han;
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

        public List<ReOrderOrderVO> SelectOrder(DateTime date)
        {
            ReOrderDAC dac = new ReOrderDAC();
            return dac.SelectOrder(date);
        }
        public bool InsertReOrder(List<ReOrderVO> list)
        {
            ReOrderDAC dac = new ReOrderDAC();
            return dac.InsertReOrder(list);
        }
    }
}
