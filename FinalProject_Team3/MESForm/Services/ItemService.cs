using FProjectDAC;
using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESForm.Services
{
    public class ItemService
    {
        public void Dispose()
        {
            ItemDAC dac = new ItemDAC();
            dac.Dispose();
        }
        public List<ItemVO> GetItemAllList()
        {
            ItemDAC dac = new ItemDAC();
            return dac.GetItemAllList();
        }
        public bool ItemCheck(string item)
        {
            ItemDAC dac = new ItemDAC();
            return dac.ItemCheck(item);
        }
        public bool RegisterItem(ItemVO vo)
        {
            ItemDAC dac = new ItemDAC();
            return dac.RegisterItem(vo);
        }
    }
}
