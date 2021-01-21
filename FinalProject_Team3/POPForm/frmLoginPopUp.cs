using MESForm;
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
    public partial class frmLoginPopUp : Form
    {
        public frmLoginPopUp()
        {
            InitializeComponent();
        }

       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUpPopUp frm = new frmSignUpPopUp();
            frm.ShowDialog();
        }

        //x , 취소버튼 클릭 시 이벤트
        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmPOP frm = new frmPOP();
            this.Hide();
            frm.Show();
        }
    }
}
