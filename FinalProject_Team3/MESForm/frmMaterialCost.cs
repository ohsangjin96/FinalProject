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
    public partial class frmMaterialCost : Form
    {
        public frmMaterialCost()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmMaterialCostPopUp frm = new frmMaterialCostPopUp();
            frm.ShowDialog();
        }
    }
}
