using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class PopUpItem : MESForm.BaseForms.frmPopup
    {
        public PopUpItem()
        {
            InitializeComponent();
        }

        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
