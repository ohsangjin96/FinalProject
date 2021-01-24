using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class Product_PlanService
    {
        public List<Product_PlanVO> GetProduct_PlanList()
        {
            Product_PlanDAC dac = new Product_PlanDAC();
            return dac.GetProduct_PlanList();
        }
    }
}
