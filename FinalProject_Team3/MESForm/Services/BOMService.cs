using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class BOMService
    {
        public void Dispose()
        {
            BOMDAC dac = new BOMDAC();
            dac.Dispose();
        }
        public List<BOMVO> CboInfo()
        {
            BOMDAC dac = new BOMDAC();
            return dac.CboInfo();
        }

        public List<BOMVO> GetBOMInfo(string CodeOrName, string use, string type)
        {
            BOMDAC dac = new BOMDAC();
            return dac.GetBOMInfo(CodeOrName, use, type);
        }
        public List<BOMVO> GetParent()
        {
            BOMDAC dac = new BOMDAC();
            return dac.GetParent();
        }
        public string LevelCheck(string name)
        {
            BOMDAC dac = new BOMDAC();
            return dac.LevelCheck(name);
        }
        public bool RegisterBOM(BOMVO vo)
        {
            BOMDAC dac = new BOMDAC();
            return dac.RegisterBOM(vo);
        }
        public bool UpdateBOM(BOMVO vo)
        {
            BOMDAC dac = new BOMDAC();
            return dac.UpdateBOM(vo);
        }
        public bool DeleteBOM(int pk)
        {
            BOMDAC dac = new BOMDAC();
            return dac.DeleteBOM(pk);
        }
        public bool ParentCheck(string parent)
        {
            BOMDAC dac = new BOMDAC();
            return dac.ParentCheck(parent);
        }
    }
}
