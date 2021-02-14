using FProjectVO;
using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MESForm.Utils;

namespace MESForm
{
    public partial class frmWorkOrder : MESForm.BaseForms.frmBaseLists
    {
        List<WorkOrderVO> list;
        List<WorkOrderVO> selectlist;
        DataTable Data = new DataTable();
        bool bflag = true;
        public frmWorkOrder()
        {
            InitializeComponent();
            txtName.TextChanged += txtName_Textchange;
            txtFa.TextChanged += txtFa_Textchange;
            txtID.TextChanged += txtID_Textchange;
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

        private void txtFa_Textchange(object sender, EventArgs e)
        {
            if (txtFa.TextLength == 0)
            {
                txtID.Enabled = true;
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                txtID.Enabled = false;
                txtFa.Enabled = false;
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
                txtFa.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                txtFa.Enabled = false;
                txtFa.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtFa.Text = "";
            }

        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            dtpfrom.Enabled = false;
            dtpto.Enabled = false;
            OrderService service = new OrderService();
            string from = DateTime.Now.ToString("yyyyMMdd");
            string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
            Data = service.GetWorkOrder(from, to);
            dgvList.DataSource = Data;
            list = service.GetWorkOrderList(from, to);
        }
        private void custButtonControl3_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            if (bflag)
            {
                bool aflag = service.InsertWorkOrderList(list);
                if (!aflag)
                {
                    MessageBox.Show("작업지시확정에 실패했습니다.");
                }
            }
            else
            {
                bool aflag = service.InsertWorkOrderList(selectlist);
                if (!aflag)
                {
                    MessageBox.Show("작업지시확정에 실패했습니다.");
                }
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            if (checkBox1.Checked)
            {
                if (dtpfrom.Value < dtpto.Value)
                {
                    string datefrom = dtpfrom.Value.ToString("yyyyMMdd");
                    string dateto = dtpto.Value.ToString("yyyyMMdd");
                    dgvList.DataSource = service.GetWorkOrder(datefrom, dateto);
                    list = service.GetWorkOrderList(datefrom, dateto);
                }
                else
                {
                    MessageBox.Show("날짜를 다시 결정해주세요");
                }
            }
            else
            {
                if (txtName.Enabled)
                {
                    string from = DateTime.Now.ToString("yyyyMMdd");
                    string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
                    dgvList.DataSource = service.SelectWorkOrder(from, to, txtName.Text);
                    var selectdata = (from selected in list
                                      where selected.Item_Name == txtName.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                else
                {
                    string from = DateTime.Now.ToString("yyyyMMdd");
                    string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
                    dgvList.DataSource = service.SelectWorkOrder(from, to, txtFa.Text);
                    var selectdata = (from selected in list
                                      where selected.Facility_Name == txtFa.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                bflag = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtFa.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void custButtonControl1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Data;
            bflag = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList);
        }
    }
}
