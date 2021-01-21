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
    public partial class frmMaterialCost : Form
    {
        public frmMaterialCost()
        {
            InitializeComponent();
        }
        private void frmMaterialCost_Load(object sender, EventArgs e)
        {
            dgvsetting();
        }

        private void dgvsetting()
        {
            CommonUtil.SetInitGridView(dgvMCost);
            CommonUtil.AddGridTextColumn(dgvMCost, "업체", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "업체명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "품목", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "품명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "규격", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "단위", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "Market", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "현재단가", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "이전단가", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "시작일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "종료일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "사용유무", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvMCost, "비고", "COM_Code");
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmMaterialCostPopUp frm = new frmMaterialCostPopUp();
            frm.ShowDialog();
        }

        
    }
}
