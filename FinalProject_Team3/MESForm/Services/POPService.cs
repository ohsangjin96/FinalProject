using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class POPService
    {
        public List<POPVO> GetPOPList(string Item_Code)
        {
            POPDAC dac = new POPDAC();
            return dac.GetPOPList(Item_Code);
        }
        public bool InsertWorkRegistList(List<WorkRegistVO> curlist)
        {
            POPDAC dac = new POPDAC();
            return dac.InsertWorkRegistList(curlist);
        }
        public List<WorkRegistVO> GetWorkRegist()
        {
            POPDAC dac = new POPDAC();
            return dac.GetWorkRegist();
        }
        public List<WorkRegistVO> GetShipment()
        {
            POPDAC dac = new POPDAC();
            return dac.GetShipment();
        }
        public bool SaveShipment(string Plan_ID)
        {
            POPDAC dac = new POPDAC();
            return dac.SaveShipment(Plan_ID);
        }
    }
}
