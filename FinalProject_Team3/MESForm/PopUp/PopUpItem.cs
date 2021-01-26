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
    public partial class PopUpItem : MESForm.BaseForms.frmPopup
    {
        string Manager;
        public string name { get; set; }
        ItemService service = new ItemService();
        List<CommonCodeVO> list;
        List<CompanyVO> Companylist;
        List<FactoryVO> Facrorylist;
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

            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();

            FactoryService factory = new FactoryService();
            Facrorylist = factory.GetFactoryList();

            var OrderCompany = (from list in Companylist
                                where list.Com_Type == "협력업체"
                                select list).Distinct().ToList();
            OrderCompany.Insert(0, new CompanyVO { Com_Name = "선택" });

            var DelCompany = (from list in Companylist
                              where list.Com_Type == "고객사"
                              select list).Distinct().ToList();
            DelCompany.Insert(0, new CompanyVO { Com_Name = "선택" });

            var InFactory=(from flist in Facrorylist
                           where flist.Factory_Grade=="창고"
                           select flist).Distinct().ToList();
            InFactory.Insert(0, new FactoryVO { Factory_Name = "선택" });

            var OutFactory = (from flist in Facrorylist
                             where flist.Factory_Grade == "창고"
                             select flist).Distinct().ToList();
            OutFactory.Insert(0, new FactoryVO { Factory_Name = "선택" });

            ComboBoxBinding.ComBind(cboUnit, list, "Unit000", true, "선택");//단위
            ComboBoxBinding.ComBind(cboIType, list, "ItemType000", true, "선택");//품목유형
            ComboBoxBinding.ComBind(cboImportYN, list, "YN000", true, "선택");//수입검사
            ComboBoxBinding.ComBind(cboProcessYN, list, "YN000", true, "선택");//공정검사
            ComboBoxBinding.ComBind(cboExportYN, list, "YN000", true, "선택");//출하검사
            // 입고 출고 아직
            ComboBoxBinding.ComBind(cboUseYN, list, "UseYN000", true, "선택");//사용유무
            ComboBoxBinding.ComBind(cboDisconYN, list, "YN000", true, "선택");//단종유무
            ComboBoxBinding.ComBind(cboOrderType, list, "OrderType000", true, "선택");//단종유무
            ComboBoxBinding.BindingComboBoxPart(cboOCompany, OrderCompany, "Com_Name");//발주업체
            ComboBoxBinding.BindingComboBoxPart(cboDCompany, DelCompany, "Com_Name");//납품업체
            ComboBoxBinding.BindingComboBoxPart(cboWareIn, InFactory, "Factory_Name");//입고창고
            ComboBoxBinding.BindingComboBoxPart(cboWareOut, OutFactory, "Factory_Name");//출고창고


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
            vo.ITEM_Unit_Qty = Convert.ToInt32(NumUnitQty.Value);
            vo.ITEM_Type = cboIType.Text;
            vo.ITEM_Import_YN = cboImportYN.Text;
            vo.ITEM_Process_YN = cboProcessYN.Text;
            vo.ITEM_Export_YN = cboExportYN.Text;
            vo.ITEM_Delivery_Company = cboDCompany.Text;
            vo.ITEM_Order_Company = cboOCompany.Text;
            vo.ITEM_WareHouse_IN = cboWareIn.Text;
            vo.ITEM_WareHouse_OUT = cboWareOut.Text;
            vo.ITME_LeadTime = Convert.ToInt32(numReadTime.Value);
            vo.ITME_Min_Order_Qty = Convert.ToInt32(numMinOrder.Value);
            vo.ITME_Safe_Qty= Convert.ToInt32(numSaveStock.Value);
            vo.ITME_Manager = txtManager.Text;
            vo.ITME_Last_Modifier = txtModifier.Text;
            vo.ITME_Last_Modifier_Time = Convert.ToDateTime(txtModifierDate.Text);
            vo.ITME_Use = cboUseYN.Text;
            vo.ITEM_Discontinuance = cboDisconYN.Text;
            vo.ITEM_Delivery_Type = cboOrderType.Text;
            vo.ITEM_Remark = txtRemark.Text;

            //서비스에 vo 전달해서 db에 저장
            bool falg = service.RegisterItem(vo);

            if (falg == true)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess+"새로고침 하십시오.");
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생하였습니다.");
            }


        }

        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
