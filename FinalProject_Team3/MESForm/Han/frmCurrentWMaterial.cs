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

        public void LoadData()
        {
            CurrentWMaterialService service = new CurrentWMaterialService();
            List<CurrentWMaterialVO> list = service.GetCurrentWMaterialList();
            service.Dispose();

            dgvWMaterialList.DataSource = list;
        }

        private void frmCurrentWMaterial_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
        }
    }
}