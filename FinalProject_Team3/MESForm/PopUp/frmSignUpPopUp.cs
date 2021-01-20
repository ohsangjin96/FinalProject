using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.PopUp
{
    public partial class frmSignUpPopUp : Form
    {
        public frmSignUpPopUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        //x , 취소버튼 클릭 시 이벤트
        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
