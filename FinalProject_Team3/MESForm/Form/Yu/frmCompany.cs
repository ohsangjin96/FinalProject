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
    public partial class frmCompany : MESForm.BaseForms.frmBaseLists
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCompany);
            CommonUtil.AddGridTextColumn(dgvCompany, "업체코드", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvCompany, "업체이름", "COM_Name");
            CommonUtil.AddGridTextColumn(dgvCompany, "업체유형", "COM_Type");
            CommonUtil.AddGridTextColumn(dgvCompany, "대표자명", "COM_CEO");
            CommonUtil.AddGridTextColumn(dgvCompany, "업종", "COM_Category");
            CommonUtil.AddGridTextColumn(dgvCompany, "업태", "COM_Conditions");
            CommonUtil.AddGridTextColumn(dgvCompany, "담당자", "COM_Charge");
            CommonUtil.AddGridTextColumn(dgvCompany, "이메일", "COM_Email");
            CommonUtil.AddGridTextColumn(dgvCompany, "거래시작일", "COM_StartDate");
            CommonUtil.AddGridTextColumn(dgvCompany, "거래종료일", "COM_EndDate");
            CommonUtil.AddGridTextColumn(dgvCompany, "전화번호", "COM_Phone");
            CommonUtil.AddGridTextColumn(dgvCompany, "팩스", "COM_Fax");
            CommonUtil.AddGridTextColumn(dgvCompany, "창고유무", "COM_Warehouse");
            CommonUtil.AddGridTextColumn(dgvCompany, "사용유무", "COM_Use");
            CommonUtil.AddGridTextColumn(dgvCompany, "수정자", "COM_Amender");
            CommonUtil.AddGridTextColumn(dgvCompany, "수정시간", "COM_ModdifyDate");
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            DgvSetting();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            PopUp.PopUpCompany pop = new PopUp.PopUpCompany();
            if (pop.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
