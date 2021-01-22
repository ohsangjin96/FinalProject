using MESForm.PopUp;
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
    public partial class frmBOM : Form
    {
        public frmBOM()
        {
            InitializeComponent();
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
