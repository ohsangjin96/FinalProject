using MESForm.PopUp;
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
    public partial class frmBOM1 : Form
    {
        public frmBOM1()
        {
            InitializeComponent();
        }
        private void frmBOM_Load(object sender, EventArgs e)
        {
            dgvSetting();
        }

        private void dgvSetting()
        {
            CommonUtil.SetInitGridView(dgvBom);
            CommonUtil.AddGridTextColumn(dgvBom, "상위품목", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "품목", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "품명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "품목유형", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "단위", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "소요량", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "시작일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "종료일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "사용여부", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "소요계획", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "자동차감", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvBom, "규격", "COM_Code");
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmBOMPopUp frm = new frmBOMPopUp();
            frm.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            frmBOMPopUp frm = new frmBOMPopUp();
            frm.ShowDialog();
        }

       
    }
}
