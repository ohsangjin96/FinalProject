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

namespace MESForm.Han
{
    public partial class frmPO : BaseForms.frmBaseLists
    {
        List<POVO> allList;

        List<CommonCodeVO> Commoncodelist;
        List<CompanyVO> Companylist;
        List<POVO> OrderTypelist;
        List<FactoryVO> Factorylist;

        public frmPO()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객WO", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "도착지", "Order_Arrive");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문유형", "Order_OrderType");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "ITEM_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생산납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문수량", "Order_OrderAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "Order_RelaseAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소수량", "Order_CancelAmount");
        }

        private void LoadPOData()
        {
            POService service = new POService();
            allList = service.GetPOList();
            service.Dispose();
            custDataGridViewControl1.DataSource = allList;
        }

        private void ComboBinding()
        {
            CommonCodeService service = new CommonCodeService();
            Commoncodelist = service.GetCommonCodeList();

            POService ordertype = new POService();
            OrderTypelist = ordertype.GetPOList();

            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();

            var Ordertype = (from list in OrderTypelist
                             where list.Order_OrderType!=null
                             select list.Order_OrderType).Distinct().ToList();
            Ordertype.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboReorder, Ordertype, "Order_OrderType");   //고객사

            var Company = (from list in Companylist
                           where list.Com_Type!=null
                           select list.Com_Type).Distinct().ToList();
            Company.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboCompany, Company, "Com_Type");   //고객사

        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadPOData();
            ComboBinding();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupD_Plan frm = new popupD_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("수요계획저장이 완료되었습니다");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            popupSO frm = new popupSO();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("등록이 완료되었습니다");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExportToDataGridView<POVO>((List<POVO>)custDataGridViewControl1.DataSource,string.Empty);
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPOData();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            
        }

    }
}