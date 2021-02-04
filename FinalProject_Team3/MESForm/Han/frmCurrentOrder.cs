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
    public partial class frmCurrentOrder : BaseForms.frmBaseLists
    {
        public frmCurrentOrder()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주번호", "Order_ID");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품업체", "DCom_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문상태", "Order_State");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "Item_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "Item_Standard");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "Item_Unit");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주량", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고량", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소량", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소가능량", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주일", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주자", "f");
        }

        private void frmCurrentOrder_Load(object sender, EventArgs e)
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
