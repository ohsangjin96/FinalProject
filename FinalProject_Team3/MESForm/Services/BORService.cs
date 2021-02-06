using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class BORService
    {
        public void Dispose()
        {
            BORDAC dac = new BORDAC();
            dac.Dispose();
        }

        public List<BORVO> GetBORList()
        {
            BORDAC dac = new BORDAC();
            return dac.GetBORList();
        }

        public List<BORVO> SearchBORList(string item, string route, string facility)
        {
            BORDAC dac = new BORDAC();
            return dac.SearchBORList(item, route, facility);
        }

        public bool InsertBOR(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            return dac.InsertBOR(vo);
        }

        public bool UpdateBOR(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            return dac.UpdateBOR(vo);
        }

        public bool DeleteBOR(string codes)
        {
            BORDAC dac = new BORDAC();
            return dac.DeleteBOR(codes);
        }
    }
}
