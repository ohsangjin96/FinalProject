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
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "도착지", "Order_Arrive");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문유형", "Order_OrderType");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생산납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문수량", "Order_OrderAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "Order_RelaseAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소수량", "Order_CancelAmount");
        }

        private void LoadData()
        {
            POService service = new POService();
            allList = service.GetPOList();
            service.Dispose();

            custDataGridViewControl1.DataSource = allList;
        }

        private void ComboBinding()
        {
            //고객사
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();
            
            var Company = (from list in Companylist
                           where list.Com_Code!= null
                           select list.Com_Code).Distinct().ToList();
            Company.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboCompany, Company, "Com_Code");   
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
            ComboBinding();
        }

        private void btnDPCreate_Click(object sender, EventArgs e)
        {
            popupD_Plan frm = new popupD_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수요계획 생성이 완료되었습니다");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            popupSO frm = new popupSO(OpenMode.Register);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("등록이 완료되었습니다");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e) //T 타입 어떤 것??
        {
            string sResult = ExcelExportImport.ExportToDataGridView<string>((List<string>)custDataGridViewControl1.DataSource,string.Empty);
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
            
        }

        private void custDataGridViewControl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택한 데이터의 woid 넘기기
            WOID = this.custDataGridViewControl1.CurrentRow.Cells["Order_WO"].Value.ToString();

            popupSO pop = new popupSO(OpenMode.Update);
            pop.WOID = WOID;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수정이 완료되었습니다.");

                custDataGridViewControl1.DataSource = null;
                LoadData();
            }
        }
    }
}