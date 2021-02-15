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
            CommonUtil.AddGridTextColumn(dgvWStock, "품목", "ITEM_Code", 120);
            CommonUtil.AddGridTextColumn(dgvWStock, "품명", "ITEM_Name", 140);
            CommonUtil.AddGridTextColumn(dgvWStock, "품목유형", "ITEM_Type", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWStock, "규격", "ITEM_Standard", 120);
            CommonUtil.AddGridTextColumn(dgvWStock, "재고량", "Warehouse_StockQty", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWStock, "단위", "ITEM_Unit", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWStock, "비고", "Reorder_Note", 140);
        }

        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            FactoryService factoryService = new FactoryService();
            List<FactoryVO> factoryList = factoryService.GetFactoryList();
            factoryService.Dispose();

            factoryList = (from a in factoryList
                           where a.Factory_Type == "자재팀창고"
                           select a).ToList();
            factoryList.Insert(0, new FactoryVO() { Factory_Code = "", Factory_Name = "" });

            ComboBoxBinding.ComBind(cboItemType, commonList, "ItemType000");
            ComboBoxBinding.BindingComboBox<FactoryVO>(cboWarehouse, factoryList, "Factory_Code", "Factory_Name");
        }

        private void LoadData()
        {
            string itemCode = txtItem.Text;
            string itemType = cboItemType.Text;
            string warehouse = cboWarehouse.Text;

            CurrentWStockService service = new CurrentWStockService();
            List<CurrentWStockVO> list = service.GetCurrentWStockList(itemCode, itemType, warehouse);
            service.Dispose();
            dgvWStock.DataSource = list;
        }

        private void frmCurrentWStock_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            DGVSetting();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string itemCode = string.Empty, itemType = string.Empty, warehouse = string.Empty;

            CurrentWStockService service = new CurrentWStockService();
            List<CurrentWStockVO> list = service.GetCurrentWStockList(itemCode, itemType, warehouse);
            service.Dispose();
            dgvWStock.DataSource = list;
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}