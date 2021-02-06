using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmWorkOrder : MESForm.BaseForms.frmBaseLists
    {
        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            dgvList.DataSource=service.GetWorkOrder();
        }
    }
}
