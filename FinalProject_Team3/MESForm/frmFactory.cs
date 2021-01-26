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
            CommonUtil.AddGridTextColumn(dgvFactory, "시설군", "Factory_Grade"); // 1
            CommonUtil.AddGridTextColumn(dgvFactory, "시설구분", "Factory_Type"); // 2
            CommonUtil.AddGridTextColumn(dgvFactory, "시설코드", "Factory_Code"); // 3
            CommonUtil.AddGridTextColumn(dgvFactory, "시설명", "Factory_Name"); // 4
            CommonUtil.AddGridTextColumn(dgvFactory, "상위시설", "Factory_HighRank"); // 5
            CommonUtil.AddGridTextColumn(dgvFactory, "시설설명", "Factory_Explain"); // 6
            CommonUtil.AddGridTextColumn(dgvFactory, "유무상구분", "Factory_Credit"); // 7
            CommonUtil.AddGridTextColumn(dgvFactory, "순서", "Factory_Order"); // 8
            CommonUtil.AddGridTextColumn(dgvFactory, "수요차감", "Factory_Demand"); // 9
            CommonUtil.AddGridTextColumn(dgvFactory, "공정차감", "Factory_Process"); // 10
            CommonUtil.AddGridTextColumn(dgvFactory, "자재차감", "Factory_Material"); // 11
            CommonUtil.AddGridTextColumn(dgvFactory, "업체", "Com_Code"); // 12
            CommonUtil.AddGridTextColumn(dgvFactory, "업체명", "Com_Name"); // 13
            CommonUtil.AddGridTextColumn(dgvFactory, "사용유무", "Factory_Use"); // 14
            CommonUtil.AddGridTextColumn(dgvFactory, "수정자", "Factory_Amender"); // 15
            CommonUtil.AddGridTextColumn(dgvFactory, "수정시간", "Factory_ModdifyDate"); // 16
            CommonUtil.AddGridTextColumn(dgvFactory, "시설ID", "Factory_ID", 100, false); // 17
        }

        private void LoadData()
        {
            FactoryService service = new FactoryService();
            List<FactoryVO> list = service.GetFactoryGradeList();
            service.Dispose();
            dgvFactory.DataSource = list;
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            DgvSetting();
            LoadData();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            PopUp.PopUpFactory pop = new PopUp.PopUpFactory(frmMain.OpenMode.Register);
            pop.DeptName = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {

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
    }
}
