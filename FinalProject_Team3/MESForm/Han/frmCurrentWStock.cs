using FProjectVO;
using MESForm.Services;
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
    public partial class frmCurrentWStock : BaseForms.frmBaseLists
    {
        public frmCurrentWStock()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvWStock);
            CommonUtil.AddGridTextColumn(dgvWStock, "창고코드", "Factory_Code");
            CommonUtil.AddGridTextColumn(dgvWStock, "창고", "ITEM_WareHouse_IN");
            CommonUtil.AddGridTextColumn(dgvWStock, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvWStock, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvWStock, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(dgvWStock, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWStock, "재고량", "Warehouse_StockQty");
            CommonUtil.AddGridTextColumn(dgvWStock, "단위", "ITEM_Unit");
            CommonUtil.AddGridTextColumn(dgvWStock, "비고", "Reorder_Note");
        }

        private void LoadData()
        {
            CurrentWStockService service = new CurrentWStockService();
            List<CurrentWStockVO> list = service.GetCurrentWStockList();
            service.Dispose();
            dgvWStock.DataSource = list;
        }

        private void frmCurrentWStock_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
        }
    }
}