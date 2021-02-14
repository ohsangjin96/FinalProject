using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FProjectDAC;
using FProjectVO;

namespace MESForm.Services
{
    public class POService
    {
        public void Dispose()
        {
            PODAC dac = new PODAC();
            dac.Dispose();
        }

        public List<POVO> GetPOList()
        {
            PODAC dac = new PODAC();
            return dac.GetPOList();
        }

        public bool ExcelWOCheck(string order_wo)
        {
            PODAC dac = new PODAC();
            return dac.ExcelWOCheck(order_wo);
        }

        public bool ExcelCompanyCheck(string com_code, string com_name)
        {
            PODAC dac = new PODAC();
            return dac.ExcelCompanyCheck(com_code, com_name);
        }

        public string ExcelItemCheck(string item_name)
        {
            PODAC dac = new PODAC();
            return dac.ExcelItemCheck(item_name);
        }

        public bool RegPOList(POVO vo)
        {
            PODAC dac = new PODAC();
            return dac.RegPOList(vo);
        }

        public bool DelPOList(string planID)
        {
            PODAC dac = new PODAC();
            return dac.DelPOList(planID);
        }

        public List<POVO> GetPOList(string woID)
        {
            PODAC dac = new PODAC();
            return dac.GetPOList(woID);
        }

        public bool UpdatePOList(POVO vo)
        {
            PODAC dac = new PODAC();
            return dac.UpdatePOList(vo);
        }
    }
}
