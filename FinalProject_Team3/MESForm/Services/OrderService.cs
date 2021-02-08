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
        public DataTable GetWorkOrder(string datefrom, string dateto)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetWorkOrder(datefrom, dateto);
        }
        public List<SeeWorkOrderVO> GetWorkOrderList()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetWorkOrderList();
        }
        public bool InsertWorkOrderList(List<SeeWorkOrderVO> list)
        {
            OrderDAC dac = new OrderDAC();
            return dac.InsertWorkOrderList(list);
        }
        public List<POPWorkOrderVO> GetSelectWorkOrderList(string date)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetSelectWorkOrderList(date);
        }
    }
}

