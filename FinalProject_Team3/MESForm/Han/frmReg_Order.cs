using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmReg_Order : BaseForms.frmBaseLists
    {
        public frmReg_Order()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "카테고리", "d");
        }

        private void frmReg_Order_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            popupOrder frm = new popupOrder();
            frm.Show();
        }
    }
}