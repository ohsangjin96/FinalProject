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
