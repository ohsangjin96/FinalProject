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
        #region d
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Standard { get; set; }
        public string ITEM_Unit { get; set; }
        public int ITEM_Unit_Qty { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Import_YN { get; set; }
        public string ITEM_Process_YN { get; set; }
        public string ITEM_Export_YN { get; set; }
        public string ITEM_Delivery_Company { get; set; }
        public string ITEM_Order_Company { get; set; }
        public string ITEM_WareHouse_IN { get; set; }
        public string ITEM_WareHouse_OUT { get; set; }
        public int ITME_LeadTime { get; set; }
        public int ITME_Min_Order_Qty { get; set; }
        public int ITME_Safe_Qty { get; set; }
        public string ITME_Manager { get; set; }
        public string ITME_Last_Modifier { get; set; }
        public DateTime ITME_Last_Modifier_Time { get; set; }
        public string ITME_Use { get; set; }
        public string ITEM_Discontinuance { get; set; }
        public string ITEM_Delivery_Type { get; set; }
        public string ITEM_Remark { get; set; }
        #endregion

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
            txtModifierDate.Text = DateTime.Now.ToString("d");
            
            txtManager.Text = Manager;
            txtModifier.Text = Manager;
            

            ComboBinding();
            EditBinding();

        }

        private void EditBinding()//수정데이터 바인딩
        {
            txtItem.Text = ITEM_Code;
            txtIname.Text = ITEM_Name;
            txtStandard.Text = ITEM_Standard;
            cboUnit.Text = ITEM_Unit;
            NumUnitQty.Value = ITEM_Unit_Qty;
            cboIType.Text = ITEM_Type;
            cboImportYN.Text = ITEM_Import_YN;
            cboProcessYN.Text = ITEM_Process_YN;
            cboExportYN.Text = ITEM_Export_YN;
            cboDCompany.Text = ITEM_Delivery_Company;
            cboOCompany.Text = ITEM_Order_Company;
            cboWareIn.Text = ITEM_WareHouse_IN;
            cboWareOut.Text = ITEM_WareHouse_OUT;
            numReadTime.Value = ITME_LeadTime;
            numMinOrder.Value = ITME_Min_Order_Qty;
            numSaveStock.Value = ITME_Safe_Qty;
            txtManager.Text = ITME_Manager;
            txtModifier.Text = ITME_Last_Modifier;
            txtModifierDate.Text = Convert.ToString(ITME_Last_Modifier_Time);
            cboUseYN.Text = ITME_Use;
            cboDisconYN.Text = ITEM_Discontinuance;
            cboOrderType.Text = ITEM_Delivery_Type;
            txtRemark.Text = ITEM_Remark;

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
            OrderCompany.Insert(0, new CompanyVO { Com_Name = "" });

            var DelCompany = (from list in Companylist
                              where list.Com_Type == "고객사"
                              select list).Distinct().ToList();
            DelCompany.Insert(0, new CompanyVO { Com_Name = "" });

            var InFactory = (from flist in Facrorylist
                             where flist.Factory_Grade == "창고"
                             select flist).Distinct().ToList();
            InFactory.Insert(0, new FactoryVO { Factory_Name = "" });

            var OutFactory = (from flist in Facrorylist
                              where flist.Factory_Grade == "창고"
                              select flist).Distinct().ToList();
            OutFactory.Insert(0, new FactoryVO { Factory_Name = "" });


            ComboBoxBinding.ComBind(cboUnit, list, "Unit000", true);//단위
            ComboBoxBinding.ComBind(cboIType, list, "ItemType000", true);//품목유형
            ComboBoxBinding.ComBind(cboImportYN, list, "YN000", true);//수입검사
            ComboBoxBinding.ComBind(cboProcessYN, list, "YN000", true);//공정검사
            ComboBoxBinding.ComBind(cboExportYN, list, "YN000", true);//출하검사
            // 입고 출고 아직
            ComboBoxBinding.ComBind(cboUseYN, list, "UseYN000", true);//사용유무
            ComboBoxBinding.ComBind(cboDisconYN, list, "YN000", true);//단종유무
            ComboBoxBinding.ComBind(cboOrderType, list, "OrderType000", true);//단종유무
            ComboBoxBinding.BindingComboBoxPart(cboOCompany, OrderCompany, "Com_Name");//발주업체
            ComboBoxBinding.BindingComboBoxPart(cboDCompany, DelCompany, "Com_Name");//납품업체
            ComboBoxBinding.BindingComboBoxPart(cboWareIn, InFactory, "Factory_Name");//입고창고
            ComboBoxBinding.BindingComboBoxPart(cboWareOut, OutFactory, "Factory_Name");//출고창고

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "")
            {

            }
            //유효성 체크
            if (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtIname.Text) || cboUnit.Text == "" ||
                cboIType.Text == "" || cboImportYN.Text == "" || cboProcessYN.Text == "" |
                cboExportYN.Text == "" || cboUseYN.Text == "" || cboDisconYN.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrNotEntered);
                return;
            }
            //품목이 중복될 경우 
            bool bFlag = service.ItemCheck(txtItem.Text);
            if (bFlag == true)
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
            vo.ITME_Safe_Qty = Convert.ToInt32(numSaveStock.Value);
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
                MessageBox.Show(Properties.Resources.SaveSuccess + "새로고침 하십시오.");
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
