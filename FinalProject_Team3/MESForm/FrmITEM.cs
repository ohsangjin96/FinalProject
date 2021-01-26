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
        string Manager;
        //public string Manager { get; set; }

        List<ItemVO> AllList;
        List<CommonCodeVO> Commonlist;
        List<CompanyVO> Companylist;
        List<FactoryVO> Facrorylist;
        CheckBox hearderCheckBox = new CheckBox(); //체크박스

        public FrmITEM(string manager)
        {
            InitializeComponent();
            Manager = manager;
        }
        private void FrmITEM_Load(object sender, EventArgs e)
        {
            //로드
            Dgvsetting();
           // ComBinding();
            selectCombobox();
        }

        private void selectCombobox()
        {
            string[] gubun = { "use", "ordercompany", "Deliverycompany", "factory", "itemmanager", "itemtype"};
            ItemService service = new ItemService();
            List<ItemVO> selectList = service.GetCodeInfoByCodeTypes(gubun);

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

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)//그리드뷰 버튼 클릭 이벤트
        {
            var senderGrid = (custDataGridViewControl)sender;
            int rowIndex = dgvItem.CurrentRow.Index;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {

                PopUpItem frm = new PopUpItem(Manager);
                frm.ITEM_Code = AllList[rowIndex].ITEM_Code;
                frm.ITEM_Name = AllList[rowIndex].ITEM_Name;
                frm.ITEM_Standard = AllList[rowIndex].ITEM_Standard;
                frm.ITEM_Unit = AllList[rowIndex].ITEM_Unit;
                frm.ITEM_Unit_Qty = AllList[rowIndex].ITEM_Unit_Qty;
                frm.ITEM_Type = AllList[rowIndex].ITEM_Type;
                frm.ITEM_Import_YN = AllList[rowIndex].ITEM_Import_YN;
                frm.ITEM_Process_YN = AllList[rowIndex].ITEM_Process_YN;
                frm.ITEM_Export_YN = AllList[rowIndex].ITEM_Export_YN;
                frm.ITEM_Delivery_Company = AllList[rowIndex].ITEM_Delivery_Company;
                frm.ITEM_Order_Company = AllList[rowIndex].ITEM_Order_Company;
                frm.ITEM_WareHouse_IN = AllList[rowIndex].ITEM_WareHouse_IN;
                frm.ITEM_WareHouse_OUT = AllList[rowIndex].ITEM_WareHouse_OUT;
                frm.ITME_LeadTime = AllList[rowIndex].ITME_LeadTime;
                frm.ITME_Min_Order_Qty = AllList[rowIndex].ITME_Min_Order_Qty;
                frm.ITME_Safe_Qty = AllList[rowIndex].ITME_Safe_Qty;
                frm.ITME_Manager = AllList[rowIndex].ITME_Manager;
                frm.ITME_Last_Modifier = AllList[rowIndex].ITME_Last_Modifier;
                frm.ITME_Last_Modifier_Time = AllList[rowIndex].ITME_Last_Modifier_Time;
                frm.ITME_Use = AllList[rowIndex].ITME_Use;
                frm.ITEM_Discontinuance = AllList[rowIndex].ITEM_Discontinuance;
                frm.ITEM_Delivery_Type = AllList[rowIndex].ITEM_Delivery_Type;
                frm.ITEM_Remark = AllList[rowIndex].ITEM_Remark;
                frm.ShowDialog();
            }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           var senderGrid = (custDataGridViewControl)sender;
            int rowIndex = dgvItem.CurrentRow.Index;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {

                PopUpItem frm = new PopUpItem(Manager);
                frm.ITEM_Code = AllList[rowIndex].ITEM_Code;
                frm.ITEM_Name = AllList[rowIndex].ITEM_Name;
                frm.ITEM_Standard = AllList[rowIndex].ITEM_Standard;
                frm.ITEM_Unit = AllList[rowIndex].ITEM_Unit;
                frm.ITEM_Unit_Qty = AllList[rowIndex].ITEM_Unit_Qty;
                frm.ITEM_Type = AllList[rowIndex].ITEM_Type;
                frm.ITEM_Import_YN = AllList[rowIndex].ITEM_Import_YN;
                frm.ITEM_Process_YN = AllList[rowIndex].ITEM_Process_YN;
                frm.ITEM_Export_YN = AllList[rowIndex].ITEM_Export_YN;
                frm.ITEM_Delivery_Company = AllList[rowIndex].ITEM_Delivery_Company;
                frm.ITEM_Order_Company = AllList[rowIndex].ITEM_Order_Company;
                frm.ITEM_WareHouse_IN = AllList[rowIndex].ITEM_WareHouse_IN;
                frm.ITEM_WareHouse_OUT = AllList[rowIndex].ITEM_WareHouse_OUT;
                frm.ITME_LeadTime = AllList[rowIndex].ITME_LeadTime;
                frm.ITME_Min_Order_Qty = AllList[rowIndex].ITME_Min_Order_Qty;
                frm.ITME_Safe_Qty = AllList[rowIndex].ITME_Safe_Qty;
                frm.ITME_Manager = AllList[rowIndex].ITME_Manager;
                frm.ITME_Last_Modifier = AllList[rowIndex].ITME_Last_Modifier;
                frm.ITME_Last_Modifier_Time = AllList[rowIndex].ITME_Last_Modifier_Time;
                frm.ITME_Use = AllList[rowIndex].ITME_Use;
                frm.ITEM_Discontinuance = AllList[rowIndex].ITEM_Discontinuance;
                frm.ITEM_Delivery_Type = AllList[rowIndex].ITEM_Delivery_Type;
                frm.ITEM_Remark = AllList[rowIndex].ITEM_Remark;
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제버튼
        {
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                string factoryName = dgvItem[3, dgvItem.CurrentRow.Index].Value.ToString().Trim();
                ItemService service = new ItemService();
               bool result = service.DeleteItem(factoryName);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                    MessageBox.Show($"{factoryName}은(는) 삭제할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
