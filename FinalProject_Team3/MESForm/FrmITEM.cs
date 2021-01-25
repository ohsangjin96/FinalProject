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
    public partial class FrmITEM : MESForm.BaseForms.frmBaseLists
    {
        string Manager;

        List<ItemVO> AllList;
     
        public FrmITEM(string  manager)
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
            /*
                 사용미사용
                -> 수입,공정,출하
                YN
                =사용유무,단종유무
                품목유형
                =>품목유형
                발주방식
                =발주방식
             */
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
    }
}
