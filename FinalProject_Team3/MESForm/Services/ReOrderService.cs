using FProjectDAC;
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

    }
}
