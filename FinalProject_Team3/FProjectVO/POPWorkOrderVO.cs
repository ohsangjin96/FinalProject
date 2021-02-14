using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class POPWorkOrderVO
    {
       
       public string Item_Code { get; set; }
       public string Item_Name { get; set; }
       public int OrderAmount { get; set; }
       public string Plan_ID { get; set; }
       public DateTime FixDate { get; set; }
    }
}
