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
using FProjectVO;
using MESForm.Services;
using static MESForm.frmMain;

namespace MESForm.Han
{
    public partial class frmPO : BaseForms.frmBaseLists
    {
        public string WOID { get; set; }          //수정을 위해 선택된 셀의 workorderID

        List<POVO> allList;
        List<CompanyVO> Companylist;

        public frmPO()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvPO);
            CommonUtil.AddGridTextColumn(dgvPO, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(dgvPO, "고객주문번호", "Order_WO");
            CommonUtil.AddGridTextColumn(dgvPO, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(dgvPO, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(dgvPO, "도착지", "Order_Arrive");
            CommonUtil.AddGridTextColumn(dgvPO, "주문유형", "Order_OrderType");
            CommonUtil.AddGridTextColumn(dgvPO, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(dgvPO, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvPO, "생산납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(dgvPO, "주문수량", "Order_OrderAmount");
            CommonUtil.AddGridTextColumn(dgvPO, "출고수량", "Order_RelaseAmount");
            CommonUtil.AddGridTextColumn(dgvPO, "취소수량", "Order_CancelAmount");
        }

        private void LoadData()
        {
            POService service = new POService();
            allList = service.GetPOList();
            service.Dispose();

            dgvPO.DataSource = (from i in allList
                                where i.PO_State == "PO확정"
                                select i).ToList();
        }

        private void ComboBinding()
        {
            //고객사
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();
            
            var Company = (from list in Companylist
                           select list.Com_Name).Distinct().ToList();
            Company.Insert(0, "전체");
            ComboBoxBinding.BindingComboBoxPart(cboCompany, Company, "Com_Name");   
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
            ComboBinding();
            dtpOrder.Enabled = false;
        }

        private void btnDPCreate_Click(object sender, EventArgs e)
        {
            popupD_Plan frm = new popupD_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수요계획 생성이 완료되었습니다");
            }

            btnRefresh.PerformClick();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            popupSO frm = new popupSO(OpenMode.Register);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("등록이 완료되었습니다");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExcelExportToDataGridView(this, dgvPO, string.Empty);
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            cboCompany.Text = null;
            dtpOrder.Value = dateTimePicker1.DtpFrom = dateTimePicker1.DtpTo = DateTime.Now;
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            List<POVO> searchList = new List<POVO>();

            foreach (var i in allList)
            {
                if (i.Order_FixedDate >= dateTimePicker1.DtpFrom && i.Order_FixedDate <= dateTimePicker1.DtpTo)
                {
                    if (cboCompany.Text != "전체" && chkPlanDate.Checked == false)
                    {
                        if (i.Com_Name == cboCompany.Text)
                        {
                            searchList.Add(i);
                        }
                    }
                    else if (cboCompany.Text != "전체" && chkPlanDate.Checked == true)
                    {
                        if (i.Order_Plandate == dtpOrder.Value && i.Com_Name == cboCompany.Text)
                        {
                            searchList.Add(i);
                        }
                    }
                    else if (cboCompany.Text == "전체" && chkPlanDate.Checked == true)
                    {
                        if (i.Order_Plandate.Date == dtpOrder.Value.Date)
                        {
                            searchList.Add(i);
                        }
                    }
                    else
                        searchList.Add(i);
                }
            }
            dgvPO.DataSource = searchList;
        }

        private void custDataGridViewControl1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택한 데이터의 woid 넘기기
            WOID = this.dgvPO.CurrentRow.Cells["Order_WO"].Value.ToString();

            popupSO pop = new popupSO(OpenMode.Update);
            pop.WOID = WOID;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수정이 완료되었습니다.");

                dgvPO.DataSource = null;
                LoadData();
            }
        }

        private void chkPlanDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlanDate.Checked)
                dtpOrder.Enabled = true;
            else
                dtpOrder.Enabled = false;
        }
    }
}