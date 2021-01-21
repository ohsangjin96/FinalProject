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
    public partial class frmAuthority : Form
    {
        public frmAuthority()
        {
            InitializeComponent();
        }

        private void btnUser_Auth_Click(object sender, EventArgs e)
        {
            frmUserAuthorityPopUp frm = new frmUserAuthorityPopUp();
            frm.ShowDialog();
        }

        private void btnGroup_Auth_Click(object sender, EventArgs e)
        {
            frmGroupAuthorityPopUp frm = new frmGroupAuthorityPopUp();
            frm.ShowDialog();
        }
    }
}
