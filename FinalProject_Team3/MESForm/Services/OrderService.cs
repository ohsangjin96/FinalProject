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
        public List<POPWorkOrderVO> GetSelectWorkOrderList(string date, string dtp)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetSelectWorkOrderList(date, dtp);
        }
        public List<OrderVO> GetOrderList()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrderList();
        }
        public DataTable GetProductPlan(string datefrom, string dateto)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetProductPlan(datefrom, dateto);
        }
        public List<Product_PlanVO> GetProductPlanList(string datefrom, string dateto)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetProductPlanList(datefrom, dateto);
        }
        public bool InsertWorkOrderList(List<WorkOrderVO> list)
        {
            OrderDAC dac = new OrderDAC();
            return dac.InsertWorkOrderList(list);
        }
        public List<WorkOrderVO> GetWorkOrderList(string datefrom, string dateto)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetWorkOrderList(datefrom, dateto);
        }
        public DataTable GetWorkOrder(string datefrom, string dateto)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetWorkOrder(datefrom, dateto);
        }
        public bool InsertProductPlanList(List<Product_PlanVO> list)
        {
            OrderDAC dac = new OrderDAC();
            return dac.InsertProductPlanList(list);
        }
        public DataTable SelectProductPlan(string datefrom, string dateto, string index)
        {
            OrderDAC dac = new OrderDAC();
            return dac.SelectProductPlan(datefrom, dateto, index);
        }
        public DataTable SelectWorkOrder(string datefrom, string dateto, string index)
        {
            OrderDAC dac = new OrderDAC();
            return dac.SelectWorkOrder(datefrom, dateto, index);
        }
    }
}

