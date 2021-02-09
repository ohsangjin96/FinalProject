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
    public partial class FrmSalesCost : MESForm.BaseForms.frmBaseLists
    {
        public string DeptName { get; set; }
        string day = DateTime.Now.ToString("d");//그리드뷰 데이터 바인딩할때 필요한 파라미터
        List<SalesCostVO> AllList;//자재단가 전체 목록 
        public FrmSalesCost()
        {
            InitializeComponent();
        }

        private void FrmSalesCost_Load(object sender, EventArgs e)
        {
            dtpDate.ShowCheckBox = true;
            dgvSetting();
            //LoadData();
        }

        private void LoadData()
        {
            SalesCostService service = new SalesCostService();
            AllList = service.GeSCInfo(day);
            service.Dispose();
            dgvCost.DataSource = AllList;
        }

        private void dgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCost);
            CommonUtil.AddGridTextColumn(dgvCost, "단가일련번호", "SC_Code", 100, false);//1
            CommonUtil.AddGridTextColumn(dgvCost, "업체", "COM_Code");//2
            CommonUtil.AddGridTextColumn(dgvCost, "업체명", "Com_Name");//3
            CommonUtil.AddGridTextColumn(dgvCost, "품목", "ITEM_Code");//4
            CommonUtil.AddGridTextColumn(dgvCost, "품명", "ITEM_Name");//5
            CommonUtil.AddGridTextColumn(dgvCost, "수량", "ITEM_Unit_Qty");//6
            CommonUtil.AddGridTextColumn(dgvCost, "단위", "ITEM_Unit");//7
            CommonUtil.AddGridTextColumn(dgvCost, "현재단가", "SC_IngCost");//8
            CommonUtil.AddGridTextColumn(dgvCost, "이전단가", "SC_BeforeCost");//9
            CommonUtil.AddGridTextColumn(dgvCost, "시작일", "SC_StartDate");//10
            CommonUtil.AddGridTextColumn(dgvCost, "종료일", "SC_EndDate");//11
            CommonUtil.AddGridTextColumn(dgvCost, "사용유무", "SC_USE");//12
            CommonUtil.AddGridTextColumn(dgvCost, "비고", "SC_Remark");//13
        }

        private void btnInquiry_Click(object sender, EventArgs e)//조회
        {
            if (txtItemCode.Text == string.Empty)
            {
                LoadData();
                return;
            }
            SalesCostService service = new SalesCostService();
            List<SalesCostVO> list = service.GetSelect(txtItemCode.Text);
            dgvCost.DataSource = list;
        }

        private void btnReg_Click(object sender, EventArgs e)//등록
        {
            PopUpSalesCost pop = new PopUpSalesCost(frmMain.OpenMode.Register);
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

            SalesCostVO vo = new SalesCostVO();
            vo.SC_Code = Convert.ToInt32(dgvCost[1, rowIdx].Value.ToString());
            vo.COM_Code = dgvCost[2, rowIdx].Value.ToString();
            vo.Com_Name = dgvCost[3, rowIdx].Value.ToString();
            vo.ITEM_Code = dgvCost[4, rowIdx].Value.ToString();
            vo.ITEM_Name = dgvCost[5, rowIdx].Value.ToString();
            vo.ITEM_Unit_Qty = Convert.ToInt32(dgvCost[6, rowIdx].Value.ToString());
            vo.ITEM_Unit = dgvCost[7, rowIdx].Value.ToString();
            vo.SC_IngCost = Convert.ToInt32(dgvCost[8, rowIdx].Value.ToString());
            vo.SC_BeforeCost = Convert.ToInt32(dgvCost[9, rowIdx].Value.ToString());
            vo.SC_StartDate = Convert.ToDateTime(dgvCost[10, rowIdx].Value.ToString());
            vo.SC_EndDate = Convert.ToDateTime(dgvCost[11, rowIdx].Value.ToString());
            vo.SC_Use = dgvCost[12, rowIdx].Value.ToString();
            vo.SC_Remark = dgvCost[13, rowIdx].Value.ToString();

            PopUpSalesCost pop = new PopUpSalesCost(frmMain.OpenMode.Update);
            pop.SCvo = vo;
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
                SalesCostService service = new SalesCostService();

                bool result = service.DeleteSC(pk, itemCode, BoforeCost);

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

        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침
        {
            txtItemCode.Text = string.Empty;
            LoadData();
        }
    }
}
