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
using static MESForm.frmMain;

namespace MESForm
{
    public partial class frmCompany : MESForm.BaseForms.frmBaseLists
    {
        public string DeptName { get; set; }
        public frmCompany()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCompany);
            CommonUtil.AddGridTextColumn(dgvCompany, "업체코드", "COM_Code");                  //1
            CommonUtil.AddGridTextColumn(dgvCompany, "업체이름", "COM_Name", 120);             //2
            CommonUtil.AddGridTextColumn(dgvCompany, "업체유형", "COM_Type");                  //3
            CommonUtil.AddGridTextColumn(dgvCompany, "대표자명", "COM_CEO");                   //4
            CommonUtil.AddGridTextColumn(dgvCompany, "사업자등록번호", "Com_CNum", 120);        //5
            CommonUtil.AddGridTextColumn(dgvCompany, "업종", "COM_Category");                  //6
            CommonUtil.AddGridTextColumn(dgvCompany, "업태", "COM_Conditions");                //7
            CommonUtil.AddGridTextColumn(dgvCompany, "담당자", "COM_Charge");                  //8
            CommonUtil.AddGridTextColumn(dgvCompany, "이메일", "COM_Email", 140);              //9
            CommonUtil.AddGridTextColumn(dgvCompany, "거래시작일", "COM_StartDate", 10, false);//10
            CommonUtil.AddGridTextColumn(dgvCompany, "거래종료일", "COM_EndDate", 10, false);  //11
            CommonUtil.AddGridTextColumn(dgvCompany, "전화번호", "COM_Phone", 110);            //12
            CommonUtil.AddGridTextColumn(dgvCompany, "팩스", "COM_Fax", 110);                  //13
            CommonUtil.AddGridTextColumn(dgvCompany, "창고유무", "COM_Warehouse", 10, false);  //14
            CommonUtil.AddGridTextColumn(dgvCompany, "사용유무", "COM_Use");                   //15
            CommonUtil.AddGridTextColumn(dgvCompany, "수정자", "COM_Amender");                 //16
            CommonUtil.AddGridTextColumn(dgvCompany, "수정시간", "COM_ModdifyDate", 140);      //17
            CommonUtil.AddGridTextColumn(dgvCompany, "업체정보", "Com_Info", 10, false);       //18
        }

        private void LoadData()
        {
            CompanyService service = new CompanyService();
            List<CompanyVO> list = service.GetCompanyList();
            service.Dispose();
            dgvCompany.DataSource = list;
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            DgvSetting();
            LoadData();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            PopUp.PopUpCompany pop = new PopUp.PopUpCompany(OpenMode.Register);
            pop.DeptName = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvCompany.CurrentRow.Index;

            CompanyVO vo = new CompanyVO
            {
                Com_Code = Convert.ToString(dgvCompany[1, rowIdx].Value),
                Com_Name = Convert.ToString(dgvCompany[2, rowIdx].Value),
                Com_Type = Convert.ToString(dgvCompany[3, rowIdx].Value),
                Com_CEO = Convert.ToString(dgvCompany[4, rowIdx].Value),
                Com_CNum = Convert.ToString(dgvCompany[5, rowIdx].Value),
                Com_Category = Convert.ToString(dgvCompany[6, rowIdx].Value),
                Com_Conditions = Convert.ToString(dgvCompany[7, rowIdx].Value),
                Com_Charge = Convert.ToString(dgvCompany[8, rowIdx].Value),
                Com_Email = Convert.ToString(dgvCompany[9, rowIdx].Value),
                Com_StartDate = Convert.ToString(dgvCompany[10, rowIdx].Value),
                Com_EndDate = Convert.ToString(dgvCompany[11, rowIdx].Value),
                Com_Phone = Convert.ToString(dgvCompany[12, rowIdx].Value),
                Com_Fax = Convert.ToString(dgvCompany[13, rowIdx].Value),
                Com_Warehouse = Convert.ToString(dgvCompany[14, rowIdx].Value),
                Com_Use = Convert.ToString(dgvCompany[15, rowIdx].Value),
                Com_Amender = Convert.ToString(dgvCompany[16, rowIdx].Value),
                Com_ModdifyDate = Convert.ToString(dgvCompany[17, rowIdx].Value),
                Com_Info = Convert.ToString(dgvCompany[18, rowIdx].Value),
            };

            PopUp.PopUpCompany pop = new PopUp.PopUpCompany(OpenMode.Update);
            pop.companyVO = vo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                string companyCode = dgvCompany[1, dgvCompany.CurrentRow.Index].Value.ToString();
                CompanyService service = new CompanyService();
                bool result = service.DeleteCompany(companyCode);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
