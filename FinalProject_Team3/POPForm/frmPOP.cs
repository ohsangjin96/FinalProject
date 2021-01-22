using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm
{
    public partial class frmPOP : Form
    {
        frmLoginPopUp login;
        public frmPOP()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultCheck frm = new ResultCheck();
            frm.Show();
        }

        private void frmPOP_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
