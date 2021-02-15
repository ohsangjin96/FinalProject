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
    public partial class frmCurrentWMaterial : BaseForms.frmBaseLists
    {
        CheckBox hearderCheckBox = new CheckBox();
        List<CurrentWMaterialVO> list;

        public frmCurrentWMaterial()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvWMaterialList);

            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "chk";
            chkCol.HeaderText = "";
            chkCol.Width = 30;
            dgvWMaterialList.Columns.Add(chkCol);

            Point headerCellLocation = dgvWMaterialList.GetCellDisplayRectangle(1, -1, true).Location;

            hearderCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 10);
            hearderCheckBox.BackColor = Color.White;
            hearderCheckBox.Size = new Size(13, 13);
            hearderCheckBox.Click += HearderCheckBox_Click;
            dgvWMaterialList.Controls.Add(hearderCheckBox);

            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고번호", "Warehousing_His_No");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "발주번호", "Reorder_Number", 10, false);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고일", "Warehousing_Date", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고창고", "ITEM_WareHouse_IN", 130);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "품목", "ITEM_Code", 130);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "품명", "ITEM_Name", 180);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "규격", "ITEM_Standard", 120);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "단위", "ITEM_Unit", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고량", "Warehousing_InAmount", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "취소량", "Reorder_Cancel", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "잔량", "Reorder_Balance", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "업체", "Com_Name", 170);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "납품업체", "ITEM_Delivery_Company", 170);
        }

        private void HearderCheckBox_Click(object sender, EventArgs e)
        {
            dgvWMaterialList.EndEdit();

            foreach (DataGridViewRow row in dgvWMaterialList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = hearderCheckBox.Checked;
            }
        }

        private void ComboBoxBind()
        {
            ItemService service = new ItemService();
            List<ItemVO> itemList = service.GetWarehouseDeliveryCompanyList();
            service.Dispose();

            CompanyService companyService = new CompanyService();
            List<CompanyVO> companyList = companyService.GetCompanyList();
            companyService.Dispose();

            var warehouseList = (from temp in itemList
                                 select temp.ITEM_WareHouse_IN).Distinct().ToList();
            warehouseList.Insert(0, "");

            ComboBoxBinding.BindingComboBoxPart<string>(cboWarehouse, warehouseList, "ITEM_WareHouse_IN");
            ComboBoxBinding.CompanyBind(cboDCompany, companyList);
        }

        public void LoadData()
        {
            CurrentWMaterialVO vo = new CurrentWMaterialVO
            {
                FromDate = dtpDate.DtpFrom.ToShortDateString(),
                ToDate = dtpDate.DtpTo.ToShortDateString(),
                ITEM_Delivery_Company = cboDCompany.Text,
                ITEM_WareHouse_IN = cboWarehouse.Text,
                ITEM_Code = txtItem.Text
            };

            CurrentWMaterialService service = new CurrentWMaterialService();
            list = service.GetCurrentWMaterialList(vo);
            service.Dispose();

            dgvWMaterialList.DataSource = list;

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Warehousing_InAmount == 0)
                {
                    dgvWMaterialList.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                }
            }
        }

        private void frmCurrentWMaterial_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            DGVSetting();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            LoadData();
            CheckedFalse();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvWMaterialList);
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            List<CurrentWMaterialVO> chkList = new List<CurrentWMaterialVO>();
            for (int i = 0; i < dgvWMaterialList.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWMaterialList["chk", i].Value))
                {
                    chkList.Add(list[i]);
                }
            }

            CurrentWMaterialService service = new CurrentWMaterialService();
            bool result = service.CancelWearing(chkList);
            service.Dispose();

            if (result)
            {
                MessageBox.Show("입고취소가 완료되었습니다.");
                CheckedFalse();
                LoadData();
            }
        }

        private void CheckedFalse()
        {
            foreach (DataGridViewRow row in dgvWMaterialList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = false;
            }
            if (hearderCheckBox.Checked)
                hearderCheckBox.Checked = false;
        }
    }
}