﻿using FProjectVO;
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

            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고번호", "Reorder_His_No");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "발주번호", "Reorder_Number", 10, false);
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고일", "Reorder_InDate");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고창고", "ITEM_WareHouse_IN");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "단위", "ITEM_Unit");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "입고량", "Reorder_InAmount");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "취소량", "Reorder_Cancel");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "잔량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "업체", "Com_Name");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "납품업체", "ITEM_Delivery_Company");
            CommonUtil.AddGridTextColumn(dgvWMaterialList, "취소여부", "IsCancel", 10, false);
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

            var warehouseList = (from temp in itemList
                                 select temp.ITEM_WareHouse_IN).Distinct().ToList();
            warehouseList.Insert(0, "");
            var deliveryCompany = (from temp in itemList
                                   select temp.ITEM_Delivery_Company).Distinct().ToList();
            deliveryCompany.Insert(0, "");

            ComboBoxBinding.BindingComboBoxPart<string>(cboWarehouse, warehouseList, "ITEM_WareHouse_IN");
            ComboBoxBinding.BindingComboBoxPart<string>(cboDCompany, deliveryCompany, "ITEM_Delivery_Company");
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
                if(list[i].IsCancel == "Y")
                {
                    dgvWMaterialList.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                }
            }
        }

        private void frmCurrentWMaterial_Load(object sender, EventArgs e)
        {
            DGVSetting();
            //LoadData();

            ComboBoxBind();
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

            for(int i = 0; i < chkList.Count; i++)
            {
                if(chkList[i].IsCancel == "Y")
                {
                    MessageBox.Show("선택된 항목 중 이미 취소 처리가 되었거나 취소된 항목이 있습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CheckedFalse();
                    return;
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