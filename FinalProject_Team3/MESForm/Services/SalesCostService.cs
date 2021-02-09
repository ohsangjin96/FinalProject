using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MESForm.Services
{
    public class SalesCostService
    {
        public void Dispose()
        {
            SalesCostDAC dac = new SalesCostDAC();
            dac.Dispose();
        }
        public List<SalesCostVO> GeSCInfo(string day)
        {
            SalesCostDAC dac = new SalesCostDAC();
            return dac.GetSCInfo(day);
        }
        public List<string> GetItemCode(string order)
        {
            SalesCostDAC dac = new SalesCostDAC();
            return dac.GetItemCode(order);
        }
        public bool RegisterSC(SalesCostVO vo)
        {
            SalesCostDAC dac = new SalesCostDAC();
            return dac.RegisterSC(vo);
        }

        public bool UpdateSC(SalesCostVO vo)
        {
            SalesCostDAC dac = new SalesCostDAC();
            return dac.UpdateSC(vo);
        }
        public bool DeleteSC(int pk, string itemCode, int BoforeCost)
        {
            SalesCostDAC dac = new SalesCostDAC();
            return dac.DeleteSC(pk, itemCode, BoforeCost);
        }
        public List<SalesCostVO> GetSelect(string item)
        {

            SalesCostDAC dac = new SalesCostDAC();
            return dac.GetSelect(item);
        }
    }
}
