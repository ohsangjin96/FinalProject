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
        public bool RegisterShift(ShiftVO vo)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.RegisterShift(vo);
        }
        public List<ShiftVO> GetTypeSelect(string type)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetTypeSelect(type);
        }
        public List<ShiftVO> GetCodeSelect(string Code)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetCodeSelect(Code);
        }
        public bool UpdateShift(ShiftVO vo)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.UpdateShift(vo);
        }
        public bool DeleteShift(int pk)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.DeleteShift(pk);
        }
        public DataTable GetList(string from, string to, string type, string name)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetList(from, to, type, name);
        }
    }
}
