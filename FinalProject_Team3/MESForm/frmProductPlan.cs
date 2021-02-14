using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmProductPlan : MESForm.BaseForms.frmBaseLists
    {
        bool bflag = true;
        public frmProductPlan()
        {
            InitializeComponent();

            txtName.TextChanged += txtName_Textchange;
            txtFa.TextChanged += txtFA_Textchange;
            txtID.TextChanged += txtID_Textchange;

            CommonUtil.AddGridTextColumn(dgvList, "No", "RowNo", 50, true, DataGridViewContentAlignment.MiddleCenter);

        }

        private void txtID_Textchange(object sender, EventArgs e)
        {
            if (txtID.TextLength == 0)
            {
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                txtFa.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtName.Text = "";
            }
        }

        private void txtFA_Textchange(object sender, EventArgs e)
        {
            if (txtFa.TextLength == 0)
            {
                txtID.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                txtID.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtName.Text = "";
            }
        }

        private void txtName_Textchange(object sender, EventArgs e)
        {

            if (txtName.TextLength == 0)
            {
                txtID.Enabled = true;
                txtFa.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                txtFa.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtFa.Text = "";
            }
        }

        List<Product_PlanVO> list = new List<Product_PlanVO>();
        List<Product_PlanVO> selectlist = new List<Product_PlanVO>();
        DataTable Data = new DataTable();
        private void frmProductPlan_Load(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            string from = DateTime.Now.ToString("yyyyMMdd");
            string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
            Data = service.GetProductPlan(from, to);
            dgvList.DataSource = Data;
            list = service.GetProductPlanList(from, to);
            dtpfrom.Enabled = false;
            dtpto.Enabled = false;
        }

        private void custButtonControl2_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            if (bflag)
                service.InsertProductPlanList(list);
            else
                service.InsertProductPlanList(selectlist);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtID.Enabled = false;
                txtFa.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = true;
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Data;
            bflag = true;
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dtpfrom.Value < dtpto.Value)
                {
                    string from = dtpfrom.Value.ToString("yyyyMMdd");
                    string to = dtpfrom.Value.ToString("yyyyMMdd");
                    OrderService service = new OrderService();
                    dgvList.DataSource = service.GetProductPlan(from, to);
                    selectlist = service.GetProductPlanList(from, to);
                }
                else
                {
                    MessageBox.Show("날짜를 다시 결정해주세요");
                }

            }
            else
            {
                OrderService service = new OrderService();
                string from = DateTime.Now.ToString("yyyyMMdd");
                string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
                if (txtName.Enabled)
                {
                    dgvList.DataSource = service.SelectProductPlan(from, to, txtName.Text);
                    var selectdata = (from selected in list
                                      where selected.Item_Name == txtName.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                else if(txtFa.Enabled)
                {
                    dgvList.DataSource = service.SelectProductPlan(from, to, txtFa.Text);
                    var selectdata = (from selected in list
                                      where selected.Facility_Name == txtFa.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                else
                {
                    dgvList.DataSource = service.SelectProductPlan(from, to, txtID.Text);
                    var selectdata = (from selected in list
                                      where selected.Plan_ID == txtID.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
            }
            bflag = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList);
        }
    }
}
