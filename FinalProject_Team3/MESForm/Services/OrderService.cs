using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class OrderService
    {
        public List<OrderVO> GetOrderList()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrderList();
        }
        public DataTable GetWorkOrder()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetWorkOrder();
        }
    }
}
