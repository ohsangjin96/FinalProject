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
            dtpDate.ShowCheckBox = true;
            dgvSetting();
            //LoadData();
        }
        private void btnInquiry_Click(object sender, EventArgs e)//조회버튼
        {
            if (txtItemCode.Text==string.Empty)
            {
                LoadData();
                return;
            }
            MaterialCostService service = new MaterialCostService();
            List<MaterialCostVO> list = service.GetCostList(txtItemCode.Text);
            dgvCost.DataSource = list;
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
            int rowIdx = dgvCost.CurrentRow.Index;

            MaterialCostVO vo = new MaterialCostVO();
            vo.MC_Code = Convert.ToInt32(dgvCost[1, rowIdx].Value.ToString());
            vo.COM_Code = dgvCost[2, rowIdx].Value.ToString();
            vo.Com_Name= dgvCost[3, rowIdx].Value.ToString();
            vo.ITEM_Code = dgvCost[4, rowIdx].Value.ToString();
            vo.ITEM_Name = dgvCost[5, rowIdx].Value.ToString();
            vo.ITEM_Unit_Qty = Convert.ToInt32(dgvCost[6, rowIdx].Value.ToString());
            vo.ITEM_Unit = dgvCost[7, rowIdx].Value.ToString();
            vo.MC_IngCost = Convert.ToInt32(dgvCost[8, rowIdx].Value.ToString());
            vo.MC_BeforeCost = Convert.ToInt32(dgvCost[9, rowIdx].Value.ToString());
            vo.MC_StartDate = Convert.ToDateTime(dgvCost[10, rowIdx].Value.ToString());
            vo.MC_EndDate = Convert.ToDateTime(dgvCost[11, rowIdx].Value.ToString());
            vo.MC_USE= dgvCost[12, rowIdx].Value.ToString();
            vo.MC_Remark = dgvCost[13, rowIdx].Value.ToString();

            popUpMaterialCost pop = new popUpMaterialCost(frmMain.OpenMode.Update);
            pop.MCvo = vo;
            pop.Uname = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)//삭제
        {
            int rowIdx = dgvCost.CurrentRow.Index;
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            else
            {
                int pk = Convert.ToInt32(dgvCost[1, rowIdx].Value.ToString());
                string itemCode = dgvCost[4, rowIdx].Value.ToString();
                int BoforeCost = Convert.ToInt32(dgvCost[9, rowIdx].Value.ToString());
                MaterialCostService service = new MaterialCostService();

                bool result = service.DeleteMC(pk, itemCode, BoforeCost);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("삭제 도중 오류가 발생하였습니다.");
                }
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)//엑셀
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvCost);
        }
        private void btnRefresh_Click(object sender, EventArgs e)//새로고침
        {
            txtItemCode.Text = string.Empty;
            dtpDate.Checked = true;
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
           
            dtpDate.Checked = false;
        }
    }
}
