using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MESForm.Services
{
    public class MRequestService
    {
        public void Dispose()
        {
            MRequestDAC dac = new MRequestDAC();
            dac.Dispose();
        }
        public List<MRequestVO> GetMRequestList(string from, string to, string item, string WOID, string Facility)
        {
            MRequestDAC dac = new MRequestDAC();
            return dac.GetMRequestList(from, to, item, WOID, Facility);
        }
        public List<MRequestVO> GetList(string code,int qty)
        {
            MRequestDAC dac = new MRequestDAC();
            return dac.GetList(code,qty);
        }
    }
}
