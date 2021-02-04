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
    public partial class frmExamine : BaseForms.frmBaseLists
    {
        public frmExamine()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "번호", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "검사일", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체명", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "최종결과", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품수량", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "불량수량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "비고", "j");
        }

        private void frmExamine_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //string sResult = ExcelExportImport.ExportToDataGridView<-->((List<-->)custDataGridViewControl1.DataSource, string.Empty);
            //if (sResult.Length > 0)
            //{
            //    MessageBox.Show(sResult);
            //}
        }
    }
}