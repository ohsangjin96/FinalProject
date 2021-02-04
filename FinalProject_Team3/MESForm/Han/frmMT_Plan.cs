using FProjectVO;
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
    public partial class frmMT_Plan : BaseForms.frmBaseLists
    {
        public frmMT_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "ITEM_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "카테고리", "Mtp_Category");
        }

        private void frmMT_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExportToDataGridView<===>((List<===>)custDataGridViewControl1.DataSource, string.Empty);
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
    }
}