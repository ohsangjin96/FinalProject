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
    public partial class FrmBOM : MESForm.BaseForms.frmBaseLists
    {
       public string DeptName { get; set; }
        List<BOMVO> Allist;
        public FrmBOM()
        {
            InitializeComponent();
        }

       
        private void FrmBOM_Load(object sender, EventArgs e)
        {
            
           // cboItemType.Items.Insert(0, "전체");
            Combinding();
            dgvsetting();
            LoadData();
        }

        private void Combinding()
        {
            BOMService service = new BOMService();
            List<BOMVO> comList = service.CboInfo();
            service.Dispose();
            ComboBoxBinding.BOMComboBindingitem(cboUseYN, comList, "use");
            ComboBoxBinding.BOMComboBindingitem(cboItemType, comList, "itemtype");
        }

        private void dgvsetting()
        {
            CommonUtil.SetInitGridView(dgvBom);
            CommonUtil.AddGridTextColumn(dgvBom, "BOM코드", "bom_code",100,false);//
            CommonUtil.AddGridTextColumn(dgvBom, "품목유형", "item_type");//
            CommonUtil.AddGridTextColumn(dgvBom, "상위품목", "BOM_Parent_Name");//
            CommonUtil.AddGridTextColumn(dgvBom, "품목", "item_code");//
            CommonUtil.AddGridTextColumn(dgvBom, "품명", "item_name");//
            CommonUtil.AddGridTextColumn(dgvBom, "소요량", "BOM_Spend");//
            CommonUtil.AddGridTextColumn(dgvBom, "Level", "BOM_Level");//
            CommonUtil.AddGridTextColumn(dgvBom, "시작일자", "BOM_StartDate");//
            CommonUtil.AddGridTextColumn(dgvBom, "종료일자", "BOM_EndDate");//
            CommonUtil.AddGridTextColumn(dgvBom, "사용유무", "ITME_Use");//
            CommonUtil.AddGridTextColumn(dgvBom, "소요계획", "BOM_Plan");//
            CommonUtil.AddGridTextColumn(dgvBom, "자동차감", "BOM_Auto");//
            CommonUtil.AddGridTextColumn(dgvBom, "비고", "BOM_Note",270);//
           
        }

        private void LoadData()
        {
            BOMService service = new BOMService();
            Allist = service.GetBOMInfo(string.Empty, "", "");
            service.Dispose();
            dgvBom.DataSource = Allist;
        }
        private void btnInquiry_Click(object sender, EventArgs e)// 조회버튼
        {
            string CoodOrName = txtItemCodeOrName.Text;
            string UseYN = cboUseYN.Text;
            string Type = cboItemType.Text;

            BOMService service = new BOMService();
            List<BOMVO> selectList = service.GetBOMInfo(CoodOrName, UseYN, Type);
            dgvBom.DataSource = selectList;
        }
        private void btnReg_Click(object sender, EventArgs e)//등록버튼
        {
            PopUpBOM pop = new PopUpBOM(frmMain.OpenMode.Register);
            pop.Uname = DeptName;
            if (pop.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침 버튼
        {
            LoadData();
        }

        private void btncopy_Click(object sender, EventArgs e)//복사버튼
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)//수정버튼
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제버튼
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)//엑셀버튼
        {

        }
    }
}
