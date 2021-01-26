using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class FactoryService
    {
        public void Dispose()
        {
            FactoryDAC dac = new FactoryDAC();
            dac.Dispose();
        }

        public List<FactoryVO> GetFactoryList()
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.GetFactoryList();
        }

        public List<FactoryVO> GetFactoryGradeList()
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.GetFactoryGradeList();
        }

        public bool InsertFactory(FactoryVO vo)
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.InsertFactory(vo);
        }

        public bool DeleteFactory(string factoryName)
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.DeleteFactory(factoryName);
        }
    }
}
