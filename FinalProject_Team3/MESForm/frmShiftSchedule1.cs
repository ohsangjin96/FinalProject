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
    public partial class frmShiftSchedule1 : Form
    {
        public frmShiftSchedule1()
        {
            InitializeComponent();
        }

        private void frmShiftSchedule_Load(object sender, EventArgs e)
        {
            dgvsetting();
        }

        private void dgvsetting()
        {
            CommonUtil.SetInitGridView(dgvShift);
            CommonUtil.AddGridTextColumn(dgvShift, "설비코드", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "설비명", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "Shift", "COM_Code");
            CommonUtil.AddGridTextColumn(dgvShift, "구분", "COM_Code");
        }
    }
}
