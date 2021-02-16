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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmReg_Order : BaseForms.frmBaseLists
    {
        public frmReg_Order()
        {
            InitializeComponent();
        }
        public string Name { get; set;}

        List<ReOrderVO> list = new List<ReOrderVO>();
        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "발주신청일", "Reorder_Orderdate",200);
            CommonUtil.AddGridTextColumn(dgvList, "품명", "ITEM_Code",200);
            CommonUtil.AddGridTextColumn(dgvList, "회사코드", "Com_Code", 200);
            CommonUtil.AddGridTextColumn(dgvList, "수량", "Reorder_Amount");
            CommonUtil.AddGridTextColumn(dgvList, "발주상태", "ReOrder_State", 200);
            CommonUtil.AddGridTextColumn(dgvList, "잔량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvList, "취소가능량", "Reorder_CanCancel");
            CommonUtil.AddGridTextColumn(dgvList, "PlanID", "Plan_ID",200);
            CommonUtil.AddGridTextColumn(dgvList, "입고창고", "WareHouse_In",200);
            
        }

        private void txtID_Textchange(object sender, EventArgs e)
        {
            if (txtID.TextLength == 0)
            {
                CboState.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                CboState.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
              
            }
        }

        private void frmReg_Order_Load(object sender, EventArgs e)
        {
            DGVSetting();
            ReOrderService service = new ReOrderService();
            list = service.selectReOrder();
            dgvList.DataSource = list;
            txtID.TextChanged += txtID_Textchange;
            dtpfrom.Enabled = false;
            dtpto.Enabled = false;
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            
            popupOrder frm = new popupOrder();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ReOrderService service = new ReOrderService();
                list = service.selectReOrder();
                dgvList.DataSource = list;  
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExcelExportToDataGridView(this, dgvList, "");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dtpfrom.Value < dtpto.Value)
                {
                    var selectdata = (from selected in list
                                      where selected.ReOrder_OrderDate > dtpfrom.Value && selected.ReOrder_OrderDate < dtpto.Value
                                      select selected).ToList();
                    
                    dgvList.DataSource = selectdata;
                }
                else
                {
                    MessageBox.Show("날짜를 다시 결정해주세요");
                }
            }
            else
            {
                if (txtID.Enabled)
                {
                    var selectdata = (from selected in list
                                      where selected.Plan_ID == txtID.Text
                                      select selected).ToList();
                    dgvList.DataSource = selectdata;
                }
                else
                {
                    var selectdata = (from selected in list
                                      where selected.ReOrder_State == CboState.Text
                                      select selected).ToList();
                    dgvList.DataSource = selectdata;
                }
            }
        }

        private void CboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboState.SelectedIndex == 0)
            {
                txtID.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtID.Enabled = false;
                CboState.Enabled = false;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = true;
                CboState.Enabled = true;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void custButtonControl1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = list;
        }
    }
}