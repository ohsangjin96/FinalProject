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
    public partial class CommonPopUp : Form
    {
        public CommonPopUp()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            CommonCodePopUp pop = new CommonCodePopUp();
            if(pop.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
