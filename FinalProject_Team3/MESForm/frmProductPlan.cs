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

        List<Product_PlanVO> list = new List<Product_PlanVO>();
        DataTable Data = new DataTable();
        private void frmProductPlan_Load(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            string from = DateTime.Now.ToString("yyyyMMdd");
            string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
            Data= service.GetProductPlan(from,to);
            dgvList.DataSource = Data;
            list = service.GetProductPlanList(from, to);
        }

        private void custButtonControl2_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            service.InsertProductPlanList(list);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Data;

        }
    }
}
