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
            txtName.TextChanged += txtName_Change;
            txtID.TextChanged += txtID_Change;
            cboFacility.SelectedIndexChanged += cboFacility_SelectIndex;
            
        }

        private void cboFacility_SelectIndex(object sender, EventArgs e)
        {
            if (cboFacility.SelectedIndex > 0)
            {
                txtID.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
            else
            {
                txtID.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
        }

        private void txtID_Change(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                cboFacility.Enabled = false;

            }
            else
            {
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
                cboFacility.Enabled = true;
            }

        }

        private void txtName_Change(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                txtID.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                cboFacility.Enabled = false;
               
            }
            else
            {
                txtID.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
                cboFacility.Enabled = true;
            }
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
