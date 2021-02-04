using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class ShiftService
    {
        public void Dispose()
        {
            ShiftDAC dac = new ShiftDAC();
            dac.Dispose();
        }

        public List<ShiftVO> GetShiftInfo()
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetShiftInfo();
        }

        public List<ShiftVO> GetFacInfo()
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetFacInfo();
        }
        public List<ShiftVO> GetShiftSelect(string type, string fac)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetShiftSelect(type, fac);
        }
    }
}
