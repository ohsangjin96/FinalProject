using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class MRealeaseService
    {
        public void Dispose()
        {
            MReleaseDAC dac = new MReleaseDAC();
            dac.Dispose();
        }
        public List<MRealeaseVO> GetList(string dtpfrom, string dtpto, string cboItemType)
        {
            MReleaseDAC dac = new MReleaseDAC();
            return dac.GetList(dtpfrom, dtpto, cboItemType);
        }

        public int QtyCheck(string code)
        {
            MReleaseDAC dac = new MReleaseDAC();
            return dac.QtyCheck(code);
        }

        public bool Release(int WoCode, int WQty, string ITEM_Code, int MR_Code)
        {
            MReleaseDAC dac = new MReleaseDAC();
            return dac.Release(WoCode, WQty, ITEM_Code, MR_Code);
        }
    }
}
