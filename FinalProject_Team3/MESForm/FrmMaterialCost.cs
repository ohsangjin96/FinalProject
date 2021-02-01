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
    public partial class FrmMaterialCost : MESForm.BaseForms.frmBaseLists
    {
        
        public string DeptName { get; set; }
        string day = DateTime.Now.ToString("d");
        List<MaterialCostVO> AllList;//자재단가 전체 목록 
        public FrmMaterialCost()
        {
            InitializeComponent();
        }
       
        private void FrmMaterialCost_Load(object sender, EventArgs e)
        {
            //this.dtpDate.Format = DateTimePickerFormat.Custom;
            // this.dtpDate.CustomFormat = " "; //a string with one whitespace
         
            dgvSetting();
            LoadData();
        }
        private void btnInquiry_Click(object sender, EventArgs e)//조회버튼
        {

        }
        private void btnReg_Click(object sender, EventArgs e)//등록
        {
            popUpMaterialCost pop = new popUpMaterialCost(frmMain.OpenMode.Register);
            pop.Uname = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)//수정
        {
            popUpMaterialCost pop = new popUpMaterialCost(frmMain.OpenMode.Update);
            pop.Uname = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)//삭제
        {

        }
        private void btnExcel_Click(object sender, EventArgs e)//엑셀
        {
            string sResult = ExcelExportImport.ExportToDataGridView<MaterialCostVO>((List<MaterialCostVO>)dgvCost.DataSource, "");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)//새로고침
        {
            LoadData();
        }
        #region 메서드

        private void dgvSetting()//그리드뷰 세팅
        {
            CommonUtil.SetInitGridView(dgvCost);
            CommonUtil.AddGridTextColumn(dgvCost, "단가일련번호", "MC_Code", 100, false);//1
            CommonUtil.AddGridTextColumn(dgvCost, "업체", "COM_Code");//2
            CommonUtil.AddGridTextColumn(dgvCost, "업체명", "Com_Name");//3
            CommonUtil.AddGridTextColumn(dgvCost, "품목", "ITEM_Code");//4
            CommonUtil.AddGridTextColumn(dgvCost, "품명", "ITEM_Name");//5
            CommonUtil.AddGridTextColumn(dgvCost, "수량", "ITEM_Unit_Qty");//6
            CommonUtil.AddGridTextColumn(dgvCost, "단위", "ITEM_Unit");//7
            CommonUtil.AddGridTextColumn(dgvCost, "현재단가", "MC_IngCost");//8
            CommonUtil.AddGridTextColumn(dgvCost, "이전단가", "MC_BeforeCost");//9
            CommonUtil.AddGridTextColumn(dgvCost, "시작일", "MC_StartDate");//10
            CommonUtil.AddGridTextColumn(dgvCost, "종료일", "MC_EndDate");//11
            CommonUtil.AddGridTextColumn(dgvCost, "사용유무", "MC_USE");//12
            CommonUtil.AddGridTextColumn(dgvCost, "비고", "MC_Remark");//13
        }
        private void LoadData()//그리드뷰 세팅
        {
            MaterialCostService service = new MaterialCostService();
            AllList = service.GetMCInfo(day);
            service.Dispose();
            dgvCost.DataSource = AllList;
        }
        #endregion
    }
}
