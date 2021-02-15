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
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주수량", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "수령날짜", "d");
        }

        private void frmReg_Order_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            popupOrder frm = new popupOrder();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExcelExportToDataGridView(this, custDataGridViewControl1, "");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
    }
}