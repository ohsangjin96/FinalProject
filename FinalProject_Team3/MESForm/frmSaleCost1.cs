using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmSaleCost1 : Form
    {
        public frmSaleCost1()
        {
            InitializeComponent();
        }
        private void frmSaleCost_Load(object sender, EventArgs e)
        {
            dgvsetting();
        }

        private void dgvsetting()
        {

            CommonUtil.SetInitGridView(dgvSCost);
            CommonUtil.AddGridTextColumn(dgvSCost, "업체", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "업체명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "품목", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "품명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "규격", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "단위", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "Market", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "현재단가", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "이전단가", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "시작일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "종료일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "사용유무", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvSCost, "비고", "COM_Code");

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSaleCostPopUp frm = new frmSaleCostPopUp();
            frm.ShowDialog();
        }

        
    }
}
