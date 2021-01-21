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
    public partial class frmShiftInfo : Form
    {
        public frmShiftInfo()
        {
            InitializeComponent();
        }
        private void frmShiftInfo_Load(object sender, EventArgs e)
        {
            dgvsetting();
        }

        private void dgvsetting()
        {
            CommonUtil.SetInitGridView(dgvShift);
            CommonUtil.AddGridTextColumn(dgvShift, "설비코드", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "설비명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "SHift", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "시작시간", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "완료시간", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "적용시작일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "적용완료일", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "사용유무", "COM_Code");
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmShiftInfoPopUp frm = new frmShiftInfoPopUp();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmShiftInfoPopUp frm = new frmShiftInfoPopUp();
            frm.ShowDialog();
        }

      
    }
}
