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
    public partial class frmFactory : MESForm.BaseForms.frmBaseLists
    {
        public string DeptName { get; set; }
        public frmFactory()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvFactory);
            CommonUtil.AddGridTextColumn(dgvFactory, "시설군", "Factory_Grade", 80); // 1
            CommonUtil.AddGridTextColumn(dgvFactory, "시설구분", "Factory_Type"); // 2
            CommonUtil.AddGridTextColumn(dgvFactory, "시설코드", "Factory_Code"); // 3
            CommonUtil.AddGridTextColumn(dgvFactory, "시설명", "Factory_Name", 120); // 4
            CommonUtil.AddGridTextColumn(dgvFactory, "상위시설", "Factory_HighRank"); // 5
            CommonUtil.AddGridTextColumn(dgvFactory, "시설설명", "Factory_Explain", 120); // 6
            CommonUtil.AddGridTextColumn(dgvFactory, "유무상구분", "Factory_Credit", 100); // 7
            CommonUtil.AddGridTextColumn(dgvFactory, "순서", "Factory_Order", 60, true, DataGridViewContentAlignment.MiddleRight); // 8
            CommonUtil.AddGridTextColumn(dgvFactory, "수요차감", "Factory_Demand", 80, true, DataGridViewContentAlignment.MiddleCenter); // 9
            CommonUtil.AddGridTextColumn(dgvFactory, "공정차감", "Factory_Process", 80, true, DataGridViewContentAlignment.MiddleCenter); // 10
            CommonUtil.AddGridTextColumn(dgvFactory, "자재차감", "Factory_Material", 80, true, DataGridViewContentAlignment.MiddleCenter); // 11
            CommonUtil.AddGridTextColumn(dgvFactory, "업체", "Com_Code"); // 12
            CommonUtil.AddGridTextColumn(dgvFactory, "업체명", "Com_Name"); // 13
            CommonUtil.AddGridTextColumn(dgvFactory, "사용유무", "Factory_Use", 80, true, DataGridViewContentAlignment.MiddleCenter); // 14
            CommonUtil.AddGridTextColumn(dgvFactory, "수정자", "Factory_Amender", 100, true, DataGridViewContentAlignment.MiddleCenter); // 15
            CommonUtil.AddGridTextColumn(dgvFactory, "수정시간", "Factory_ModdifyDate", 140, true, DataGridViewContentAlignment.MiddleCenter); // 16
            CommonUtil.AddGridTextColumn(dgvFactory, "시설ID", "Factory_ID", 100, false); // 17
        }

        private void LoadData()
        {
            FactoryService service = new FactoryService();
            List<FactoryVO> list = service.GetFactoryGradeList(string.Empty, "전체");
            service.Dispose();
            dgvFactory.DataSource = list;
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            ComboBoxBinding.ComBind(cboFactoryGrade, commonList, "FacGrade000", true, "전체");
            DgvSetting();
            LoadData();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            PopUp.PopUpFactory pop = new PopUp.PopUpFactory(frmMain.OpenMode.Register);
            pop.DeptName = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvFactory.CurrentRow.Index;

            string highRank;

            if (string.IsNullOrEmpty(Convert.ToString(dgvFactory[5, rowIdx].Value)))
                highRank = "없음";
            else
                highRank = Convert.ToString(dgvFactory[5, rowIdx].Value);

            

            FactoryVO vo = new FactoryVO
            {
                Factory_Grade = dgvFactory[1, rowIdx].Value.ToString(),
                Factory_Type = dgvFactory[2, rowIdx].Value.ToString(),
                Factory_Code = dgvFactory[3, rowIdx].Value.ToString(),
                Factory_Name = dgvFactory[4, dgvFactory.CurrentRow.Index].Value.ToString().Trim().Replace("L ", ""),
                Factory_HighRank = highRank,
                Factory_Explain = Convert.ToString(dgvFactory[6, rowIdx].Value),
                Factory_Credit = Convert.ToString(dgvFactory[7, rowIdx].Value),
                Factory_Order = Convert.ToInt32(dgvFactory[8, rowIdx].Value),
                Factory_Demand = Convert.ToString(dgvFactory[9, rowIdx].Value),
                Factory_Process = Convert.ToString(dgvFactory[10, rowIdx].Value),
                Factory_Material = Convert.ToString(dgvFactory[11, rowIdx].Value),
                Com_Code = Convert.ToString(dgvFactory[12, rowIdx].Value),
                Com_Name = Convert.ToString(dgvFactory[13, rowIdx].Value),
                Factory_Use = Convert.ToString(dgvFactory[14, rowIdx].Value),
                Factory_Amender = Convert.ToString(dgvFactory[15, rowIdx].Value),
                Factory_ModdifyDate = Convert.ToString(dgvFactory[16, rowIdx].Value)
            };
            PopUp.PopUpFactory pop = new PopUp.PopUpFactory(frmMain.OpenMode.Update);
            pop.factoryVO = vo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                string factoryName = dgvFactory[4, dgvFactory.CurrentRow.Index].Value.ToString().Trim().Replace("L ", "");
                FactoryService service = new FactoryService();
                bool result = service.DeleteFactory(factoryName);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                    MessageBox.Show($"{factoryName}은(는) 삭제할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void custButtonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string codeOrName = txtFactoryCodeOrName.Text;
            string grade = cboFactoryGrade.Text;

            FactoryService service = new FactoryService();
            List<FactoryVO>  list = service.GetFactoryGradeList(codeOrName, grade);
            dgvFactory.DataSource = list;

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnInquiry.PerformClick();
        }
    }
}
