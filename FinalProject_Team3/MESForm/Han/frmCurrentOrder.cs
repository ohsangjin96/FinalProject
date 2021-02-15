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
            CommonUtil.SetInitGridView(dgvReorderList);
            CommonUtil.AddGridTextColumn(dgvReorderList, "발주번호", "Order_ID");
            CommonUtil.AddGridTextColumn(dgvReorderList, "납품업체", "DCom_Name");
            CommonUtil.AddGridTextColumn(dgvReorderList, "주문상태", "Order_State");
            CommonUtil.AddGridTextColumn(dgvReorderList, "품목", "Item_Code");
            CommonUtil.AddGridTextColumn(dgvReorderList, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvReorderList, "규격", "Item_Standard");
            CommonUtil.AddGridTextColumn(dgvReorderList, "단위", "Item_Unit");
            CommonUtil.AddGridTextColumn(dgvReorderList, "납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(dgvReorderList, "발주량", "a");
            CommonUtil.AddGridTextColumn(dgvReorderList, "입고량", "b");
            CommonUtil.AddGridTextColumn(dgvReorderList, "취소량", "c");
            CommonUtil.AddGridTextColumn(dgvReorderList, "취소가능량", "d");
            CommonUtil.AddGridTextColumn(dgvReorderList, "발주일", "e");
            CommonUtil.AddGridTextColumn(dgvReorderList, "담당자", "f");
        }

        private void LoadData()
        {
            //발주테이블에서 데이터 가져오기
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
