using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
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
        List<ItemVO> AllList;
        List<CommonCodeVO> Commonlist;
        List<CompanyVO> Companylist;
        List<FactoryVO> Facrorylist;

        public string Uname { get; set; } //이름을 받아옴
        public FrmITEM()
        {
            InitializeComponent();
        }
        private void FrmITEM_Load(object sender, EventArgs e)
        {
          
            Dgvsetting();
            ComBinding();
           // selectCombobox();
        }

        private void selectCombobox()//뷰를 이용한 콤보박스 바인딩
        {
           // string[] gubun = { "use", "ordercompany", "Deliverycompany", "factory", "itemmanager", "itemtype"};
            ItemService service = new ItemService();
            List<ItemVO> selectList = service.GetCodeInfoByCodeTypes();
            service.Dispose();
            ComboBoxBinding.ComboBindingitem(cboUseYN, selectList, "use");
            ComboBoxBinding.ComboBindingitem(cboManager, selectList, "itemmanager");
            ComboBoxBinding.ComboBindingitem(cboItemType, selectList, "itemtype");
            ComboBoxBinding.ComboBindingitem(cboOrderCompany, selectList, "ordercompany");
            ComboBoxBinding.ComboBindingitem(cboDelCompany, selectList, "Deliverycompany");
            ComboBoxBinding.ComboBindingitem(cboWareHouseIN, selectList, "factory");
            ComboBoxBinding.ComboBindingitem(cboWareHouseOUT, selectList, "factory");

           
        }

        private void Dgvsetting() //그리드뷰 데이터 세팅
        {
            CommonUtil.AddGridImageColumn(dgvItem,Resources.Action_Edit_12x12, "Edit");
            CommonUtil.SetInitGridView(dgvItem);
            CommonUtil.AddGridTextColumn(dgvItem, "품목유형", "ITEM_Type");//2
            CommonUtil.AddGridTextColumn(dgvItem, "품목", "ITEM_Code");//3
            CommonUtil.AddGridTextColumn(dgvItem, "품명", "ITEM_Name");//4
            CommonUtil.AddGridTextColumn(dgvItem, "규격", "ITEM_Standard");//5
            CommonUtil.AddGridTextColumn(dgvItem, "단위", "ITEM_Unit");//6
            CommonUtil.AddGridTextColumn(dgvItem, "단위수량", "ITEM_Unit_Qty");//7
            CommonUtil.AddGridTextColumn(dgvItem, "수입검사여부", "ITEM_Import_YN");//8
            CommonUtil.AddGridTextColumn(dgvItem, "공정검사여부", "ITEM_Process_YN");//9
            CommonUtil.AddGridTextColumn(dgvItem, "출하검사여부", "ITEM_Export_YN");//10
            CommonUtil.AddGridTextColumn(dgvItem, "납품업체", "ITEM_Delivery_Company");//11
            CommonUtil.AddGridTextColumn(dgvItem, "발주업체", "ITEM_Order_Company");//12
            CommonUtil.AddGridTextColumn(dgvItem, "입고창고", "ITEM_WareHouse_IN");//13
            CommonUtil.AddGridTextColumn(dgvItem, "출고창고", "ITEM_WareHouse_OUT");//14
            CommonUtil.AddGridTextColumn(dgvItem, "LeadTime", "ITME_LeadTime", 100,false) ;//15
            CommonUtil.AddGridTextColumn(dgvItem, "최소발주량", "ITME_Min_Order_Qty");//16
            CommonUtil.AddGridTextColumn(dgvItem, "안전재고량", "ITME_Safe_Qty");//17
            CommonUtil.AddGridTextColumn(dgvItem, "담당자", "ITME_Manager", 100, false);//18
            CommonUtil.AddGridTextColumn(dgvItem, "사용유무", "ITME_Use");//19
            CommonUtil.AddGridTextColumn(dgvItem, "단종유무", "ITEM_Discontinuance");//20
            CommonUtil.AddGridTextColumn(dgvItem, "발주방식", "ITEM_Delivery_Type");//21
            CommonUtil.AddGridTextColumn(dgvItem, "최종수정자", "ITME_Last_Modifier", 100, false);//22
            CommonUtil.AddGridTextColumn(dgvItem, "최종수정일자", "ITME_Last_Modifier_Time", 100, false);//23
            CommonUtil.AddGridTextColumn(dgvItem, "비고", "ITEM_Remark", 100, false);//24
           LoadData();
        
        }
        
        private void LoadData()//그리드뷰 데이터 로드
        {
            ItemService service = new ItemService();
            AllList = service.GetItemAllList();
            service.Dispose();
            dgvItem.DataSource = AllList;
        }

        private void ComBinding()//콤보박스 바인딩 (보류)
        {
            CommonCodeService Common = new CommonCodeService();
            Commonlist = Common.GetCommonCodeList();
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();
            FactoryService factory = new FactoryService();
            Facrorylist = factory.GetFactoryList();

            var Manager = (from list in AllList
                           where list.ITME_Manager != null
                           select list.ITME_Manager).Distinct().ToList();//담당자
            Manager.Insert(0, "선택");

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
            PopUpItem pop = new PopUpItem(frmMain.OpenMode.Register);
            pop.Uname = Uname;
            if (pop.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e) //수정버튼
        {
            PopUpItem frm = new PopUpItem(frmMain.OpenMode.Update);
            frm.ITEM_Type = dgvItem[2, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Code = dgvItem[3, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Name = dgvItem[4, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Standard = dgvItem[5, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Unit = dgvItem[6, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Unit_Qty = Convert.ToInt32(dgvItem[7, dgvItem.CurrentRow.Index].Value.ToString().Trim());
            frm.ITEM_Import_YN = dgvItem[8, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Process_YN = dgvItem[9, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Export_YN = dgvItem[10, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Delivery_Company = dgvItem[11, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Order_Company = dgvItem[12, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_WareHouse_IN = dgvItem[13, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_WareHouse_OUT = dgvItem[14, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITME_LeadTime = Convert.ToInt32(dgvItem[15, dgvItem.CurrentRow.Index].Value.ToString().Trim());
            frm.ITME_Min_Order_Qty = Convert.ToInt32(dgvItem[16, dgvItem.CurrentRow.Index].Value.ToString().Trim());
            frm.ITME_Safe_Qty = Convert.ToInt32(dgvItem[17, dgvItem.CurrentRow.Index].Value.ToString().Trim());
            frm.ITME_Manager = dgvItem[18, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITME_Use = dgvItem[19, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Discontinuance = dgvItem[20, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITEM_Delivery_Type = dgvItem[21, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITME_Last_Modifier = dgvItem[22, dgvItem.CurrentRow.Index].Value.ToString().Trim();
            frm.ITME_Last_Modifier_Time = Convert.ToDateTime(dgvItem[23, dgvItem.CurrentRow.Index].Value.ToString().Trim());
            frm.ITEM_Remark = dgvItem[24, dgvItem.CurrentRow.Index].Value.ToString().Trim();

            frm.ShowDialog();

        }
        private void btnDelete_Click(object sender, EventArgs e)//삭제버튼
        {
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                string ItemName = dgvItem[3, dgvItem.CurrentRow.Index].Value.ToString().Trim();
                ItemService service = new ItemService();
                bool result = service.DeleteItem(ItemName);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                    MessageBox.Show($"{ItemName}은(는) 삭제할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침 버튼
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

        private void btnExcel_Click(object sender, EventArgs e)//엑셀버튼
        {
            string sResult = ExcelExportImport.ExportToDataGridView<ItemVO>((List<ItemVO>)dgvItem.DataSource,"");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }

       
       
    }
}
