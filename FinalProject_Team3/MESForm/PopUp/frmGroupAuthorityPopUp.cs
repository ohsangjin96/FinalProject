﻿using System;
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
    public partial class frmGroupAuthorityPopUp : Form
    {
        public frmGroupAuthorityPopUp()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGroupRegister_Click(object sender, EventArgs e)
        {
            frmCreateGroupPopUp frm = new frmCreateGroupPopUp();
            frm.Close();
        }
    }
}
