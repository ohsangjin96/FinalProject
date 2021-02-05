using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmProductPlan : MESForm.BaseForms.frmBaseLists
    {
        public frmProductPlan()
        {
            InitializeComponent();
        }


     
        private void frmProductPlan_Load(object sender, EventArgs e)
        {
            //CommonUtil.SetInitGridView(dgvList);
            //CommonUtil.AddGridTextColumn(dgvList, "공정", "Process_Code", 110);
            //CommonUtil.AddGridTextColumn(dgvList, "품목코드", "ITEM_Code", 100);
            //CommonUtil.AddGridTextColumn(dgvList, "설비코드", "Facility_Code", 100);

            //for (int i = 0; i < 12; i++)
            //{
            //    CommonUtil.AddGridTextColumn(dgvList, $"{DateTime.Now.AddDays(i).ToString("yyyy-MM-dd")}", "PP_date", 100);
            //}
            //Product_PlanService service = new Product_PlanService();
            //List<Product_PlanVO> list = service.GetProduct_PlanList();
            //dgvList.Columns.Contains(list[2].ToString());
            Product_PlanService service = new Product_PlanService();
            dgvList.DataSource = service.GetProduct_Plan();
        }
       
       
    }
}
