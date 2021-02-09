using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FProjectDAC;
using FProjectVO;
using MESForm.Services;
using MESForm.Utils;

namespace MESForm.Han
{
    public partial class frmD_Plan : BaseForms.frmBaseLists
    {
        List<POVO> polist;
        List<CompanyVO> Companylist;

        public frmD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사설비", "Com_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "Item_Name");
        }

        private void ComboBinding()
        {
            POService service = new POService();
            polist = service.GetPOList();
            var planidlist = (from list in polist
                              select list.Plan_ID).ToList();

            planidlist.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboPlanID, planidlist, "Plan_ID");

            //고객사
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();

            var Company = (from list in Companylist
                           select list.Com_Code).Distinct().ToList();
            Company.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboCompany, Company, "Com_Code");

        }

        private void frmD_Plan_Load(object sender, EventArgs e)
        {
            //DGVSetting();

            ComboBinding();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupP_Plan frm = new popupP_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("생산계획 생성이 완료되었습니다");
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string dtpfrom = string.Empty;
            string dtpto = string.Empty;
            //날짜 입력만큼의 데이터 조회
            dtpfrom = dateTimePicker1.DtpFrom.ToShortDateString();
            dtpto = dateTimePicker1.DtpTo.ToShortDateString();

            DemandService service = new DemandService();
            DataTable dt = service.GetList(dtpfrom, dtpto);
            service.Dispose();
            custDataGridViewControl1.DataSource = dt;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //string sResult = ExcelExportImport.ExportToDataGridView<===>((List<===>)custDataGridViewControl1.DataSource, string.Empty);
            //if (sResult.Length > 0)
            //{
            //    MessageBox.Show(sResult);
            //}
        }
    }
}