using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm
{
    public partial class ProductPlan : Form
    {
        public ProductPlan()
        {
            InitializeComponent();
        }

        private void ProductPlan_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "공정", "Process", 110);
            CommonUtil.AddGridTextColumn(dgvList, "품목코드", "ItemCode", 100);
            CommonUtil.AddGridTextColumn(dgvList, "품목", "ItemName", 100);
            CommonUtil.AddGridTextColumn(dgvList, "설비명", "Facility_Code", 100);
            for(int i=0; i<12; i++)
            {
                CommonUtil.AddGridTextColumn(dgvList, $"{DateTime.Now.AddDays(i).ToString("yyyy-MM-dd")}","PP_date", 100);
            }
           
        }
    }
}
