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
    public partial class FrmITEM : MESForm.BaseForms.frmBaseLists
    {
        string Manager;
        //public string Manager { get; set; }

        List<ItemVO> AllList;
        List<CommonCodeVO> Commonlist;
        List<CompanyVO> Companylist;
        List<FactoryVO> Facrorylist;

        public FrmITEM(string manager)
        {
            InitializeComponent();
            Manager = manager;
        }
        private void FrmITEM_Load(object sender, EventArgs e)
        {
            //로드
            Dgvsetting();
            ComBinding();
        }

       
        private void Dgvsetting()
        {
          
            CommonUtil.SetInitGridView(dgvItem);
            CommonUtil.AddGridTextColumn(dgvItem, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(dgvItem, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvItem, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvItem, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvItem, "단위", "ITEM_Unit");
            CommonUtil.AddGridTextColumn(dgvItem, "단위수량", "ITEM_Unit_Qty");
            CommonUtil.AddGridTextColumn(dgvItem, "수입검사여부", "ITEM_Import_YN");
            CommonUtil.AddGridTextColumn(dgvItem, "공정검사여부", "ITEM_Process_YN");
            CommonUtil.AddGridTextColumn(dgvItem, "출하검사여부", "ITEM_Export_YN");
            CommonUtil.AddGridTextColumn(dgvItem, "납품업체", "ITEM_Delivery_Company");
            CommonUtil.AddGridTextColumn(dgvItem, "발주업체", "ITEM_Order_Company");
            CommonUtil.AddGridTextColumn(dgvItem, "입고창고", "ITEM_WareHouse_IN");
            CommonUtil.AddGridTextColumn(dgvItem, "출고창고", "ITEM_WareHouse_OUT");
            CommonUtil.AddGridTextColumn(dgvItem, "LeadTime", "ITME_LeadTime", 100,false) ;
            CommonUtil.AddGridTextColumn(dgvItem, "최소발주량", "ITME_Min_Order_Qty");
            CommonUtil.AddGridTextColumn(dgvItem, "안전재고량", "ITME_Safe_Qty");
            CommonUtil.AddGridTextColumn(dgvItem, "담당자", "ITME_Manager", 100, false);
            CommonUtil.AddGridTextColumn(dgvItem, "사용유무", "ITME_Use");
            CommonUtil.AddGridTextColumn(dgvItem, "단종유무", "ITEM_Discontinuance");
            CommonUtil.AddGridTextColumn(dgvItem, "발주방식", "ITEM_Delivery_Type");
            CommonUtil.AddGridTextColumn(dgvItem, "최종수정자", "ITME_Last_Modifier", 100, false);
            CommonUtil.AddGridTextColumn(dgvItem, "최종수정일자", "ITME_Last_Modifier_Time", 100, false);
            CommonUtil.AddGridTextColumn(dgvItem, "비고", "ITEM_Remark", 100, false);
            LoadData();
        
        }

        private void LoadData()
        {
            ItemService service = new ItemService();
            AllList = service.GetItemAllList();
            service.Dispose();
            dgvItem.DataSource = AllList;
        }

        private void ComBinding()//콤보박스 바인딩
        {
            CommonCodeService Common = new CommonCodeService();
            Commonlist = Common.GetCommonCodeList();
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();
            FactoryService factory = new FactoryService();
            Facrorylist = factory.GetFactoryList();

            var Manager = (from list in AllList
                        where list.ITME_Manager !=null
                        select list.ITME_Manager).Distinct().ToList();//담당자
            Manager.Insert(0,"선택");

            var OrderCompany = (from list in Companylist
                                where list.Com_Type == "협력업체"
                                select list).Distinct().ToList();
            OrderCompany.Insert(0, new CompanyVO { Com_Name = "선택" });

            var DelCompany= (from list in Companylist
                             where list.Com_Type == "고객사"
                             select list).Distinct().ToList();
            DelCompany.Insert(0, new CompanyVO { Com_Name = "선택" });

            var InFactory = (from flist in Facrorylist
                             where flist.Factory_Grade == "창고"
                             select flist).Distinct().ToList();
            InFactory.Insert(0, new FactoryVO { Factory_Name = "선택" });

            ComboBoxBinding.ComBind(cboUseYN, Commonlist, "UseYN000", true, "선택");//사용유무
            ComboBoxBinding.BindingComboBoxPart(cboManager, Manager, "ITME_Manager");//담당자
            ComboBoxBinding.ComBind(cboItemType, Commonlist, "ItemType000", true, "선택");//품목유형
            ComboBoxBinding.BindingComboBoxPart(cboOrderCompany, OrderCompany, "Com_Name");//발주업체
            ComboBoxBinding.BindingComboBoxPart(cboDelCompany, DelCompany, "Com_Name");//납품업체
            ComboBoxBinding.BindingComboBoxPart(cboWareHouseIN, InFactory, "Factory_Name");//입고창고
            ComboBoxBinding.BindingComboBoxPart(cboWareHouseOUT, InFactory, "Factory_Name");//출고창고
        }

        private void btnReg_Click(object sender, EventArgs e)//등록버튼
        {
            PopUpItem pop = new PopUpItem(Manager);
            pop.ShowDialog();
        }

        private void dgvItem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//열번호매기기
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnInquiry_Click(object sender, EventArgs e)//조회버튼
        {
            //dgvItem.DataSource = null;
            //dgvItem.DataSource = (from All in AllList 
            //                            where All.ITEM_Code.Contains(txtItem.Text) &&
            //                                  All.ITME_Use.Contains(cboUseYN.Text) &&
            //                                  All.ITEM_Order_Company.Contains(cboOrderCompany.Text) &&
            //                                  All.ITEM_WareHouse_IN.Contains(cboWareHouseIN.Text)&&
            //                                  All.ITEM_WareHouse_OUT.Contains(cboWareHouseOUT.Text) &&
            //                                  All.ITEM_Delivery_Company.Contains(cboDelCompany.Text) &&
            //                                  All.ITME_Manager.Contains(cboManager.Text) &&
            //                                  All.ITEM_Type.Contains(cboItemType.Text)
            //                      select All).ToList();
        }
    }
}
