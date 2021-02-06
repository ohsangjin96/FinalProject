using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class MaterialCostService
    {
        public void Dispose()
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            dac.Dispose();
        }
        public List<MaterialCostVO> GetMCInfo(string day)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.GetMCInfo(day);
        }
        public List<string> GetItemCode(string order)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.GetItemCode(order);
        }
        public bool RegisterMC(MaterialCostVO vo)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.RegisterMC(vo);
        }

        public bool UpdateMC(MaterialCostVO vo)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.UpdateMC(vo);
        }

        public bool DeleteMC(int pk, string itemCode, int BoforeCost)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.DeleteMC(pk, itemCode, BoforeCost);
        }
        public List<MaterialCostVO> GetCostList(string item)
        {
            MaterialCostDAC dac = new MaterialCostDAC();
            return dac.GetCostList(item);
        }
    }
}
