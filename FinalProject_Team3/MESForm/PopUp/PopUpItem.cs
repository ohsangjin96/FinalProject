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
    public partial class PopUpItem : MESForm.BaseForms.frmPopup
    {
    
        string Manager;
        ItemService service = new ItemService();
        List<CommonCodeVO> list;
        public PopUpItem(string manager)
        {
            InitializeComponent();
            Manager = manager;
        }
        private void PopUpItem_Load(object sender, EventArgs e)
        {
            txtManager.Text = Manager;
            txtModifier.Text = Manager;
            txtModifierDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            ComboBinding();
        }

        private void ComboBinding()//콤보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();
            list = service.GetCommonCodeList();
            ComboBoxBinding.ComBind(cboUnit, list, "Unit000", true, "선택");//단위
            ComboBoxBinding.ComBind(cboIType, list, "ItemType000", true, "선택");//품목유형
            ComboBoxBinding.ComBind(cboImportYN, list, "YN000", true, "선택");//수입검사
            ComboBoxBinding.ComBind(cboProcessYN, list, "YN000", true, "선택");//공정검사
            ComboBoxBinding.ComBind(cboExportYN, list, "YN000", true, "선택");//출하검사
            //남풉 발주 입고 출고
            ComboBoxBinding.ComBind(cboUseYN, list, "UseYN000", true, "선택");//사용유무
            ComboBoxBinding.ComBind(cboDisconYN, list, "YN000", true, "선택");//단종유무
            ComboBoxBinding.ComBind(cboOrderType, list, "OrderType000", true, "선택");//단종유무

        }

        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (string.IsNullOrEmpty(txtItem.Text)&& string.IsNullOrEmpty(txtIname.Text)&& string.IsNullOrEmpty(cboUnit.Text)&&
                string.IsNullOrEmpty(cboIType.Text)&& string.IsNullOrEmpty(cboImportYN.Text)&& string.IsNullOrEmpty(cboProcessYN.Text)&&
                string.IsNullOrEmpty(cboExportYN.Text)&& string.IsNullOrEmpty(cboUseYN.Text)&& string.IsNullOrEmpty(cboDisconYN.Text))
            {
                MessageBox.Show(Properties.Resources.ErrNotEntered);
                return;
            }
            //품목이 중복될 경우 
            bool bFlag = service.ItemCheck(txtItem.Text);
            if (bFlag==true)
            {
                MessageBox.Show(Properties.Resources.ErrAlreadyReg.Replace("@@", "품목"));
                return;
            }
            //vo 객채 생성
            ItemVO vo = new ItemVO();
            vo.ITEM_Code = txtItem.Text;
            vo.ITEM_Name = txtIname.Text;
            vo.ITEM_Standard = txtStandard.Text;
            vo.ITEM_Unit = cboUnit.Text;
            vo.ITEM_Unit_Qty = int.Parse(txtUnitQty.Text);
            vo.ITEM_Type = cboIType.Text;
            vo.ITEM_Import_YN = cboImportYN.Text;
            vo.ITEM_Process_YN = cboProcessYN.Text;
            vo.ITEM_Export_YN = cboExportYN.Text;
            vo.ITEM_Delivery_Company = cboDCompany.Text;
            vo.ITEM_Order_Company = cboOCompany.Text;
            vo.ITEM_WareHouse_IN = cboWareIn.Text;
            vo.ITEM_WareHouse_OUT = cboWareOut.Text;
            vo.ITME_LeadTime = int.Parse(txtReadTime.Text);
            vo.ITME_Min_Order_Qty = Convert.ToInt32(numMinOrder.Value);
            vo.ITME_Safe_Qty= Convert.ToInt32(numSaveStock.Value);
            vo.ITME_Manager = txtManager.Text;
            vo.ITME_Last_Modifier = txtModifier.Text;
            vo.ITME_Last_Modifier_Time = Convert.ToDateTime(txtModifierDate.Text);
            vo.ITME_Use = cboUseYN.Text;
            vo.ITEM_Discontinuance = cboDisconYN.Text;
            vo.ITEM_Delivery_Type = cboOrderType.Text;
            vo.ITEM_Remark = txtRemark.Text;





        }
    }
}
