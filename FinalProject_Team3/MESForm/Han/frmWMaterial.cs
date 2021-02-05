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

namespace MESForm.Han
{
    public partial class frmWMaterial : MESForm.BaseForms.frmBaseLists
    {
        public frmWMaterial()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            //업체, 납품업체, 품목, 품명, 규격, 품목유형, 단위, 검사여부, 발주수량, 입고량, 잔량, 납기일, 주문상태
            CommonUtil.SetInitGridView(dgvWaitingWarehouse);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "업체", "Com_Name");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납품업체", "ITEM_Delivery_Company");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "단위", "ITEM_Unit");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "검사여부", "Reorder_InspYN");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주수량", "Reorder_Amount");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고수량", "Reorder_InAmount");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "잔량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "주문상태", "Reorder_State");

            CommonUtil.SetInitGridView(dgvWarehouse);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목", "aa");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품명", "ab");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "규격", "ac");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목유형", "ad");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단위", "ae");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고창고", "af");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고량", "ag");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단가", "ah");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "수정자", "ak");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "비고", "al");
        }

        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            CompanyService companyService = new CompanyService();
            List<CompanyVO> companyList = companyService.GetCompanyList();
            commonService.Dispose();

            ComboBoxBinding.ComBind(cboOrderState, commonList, "OrderState000");
            ComboBoxBinding.CompanyBind(cboCompany, companyList);
        }

        private void frmWMaterial2_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            DgvSetting();
        }
    }
}
