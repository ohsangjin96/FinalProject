using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectVO
{
    public class WorkOrderVO
    {
      
       public string Item_Code { get; set; }
       public string Item_Name { get; set; }
       public string WorkOrder_State { get; set; }
       public string Facility_Code { get; set; }
       public string Facility_Name { get; set; }
       public int OrderAmount { get; set; }
       public DateTime FixDate { get; set; }
       public int TackTime { get; set; }
       public string Plan_ID { get; set; }
       public string Com_Code { get; set; }
       public string Com_Name { get; set; }

    }
}
