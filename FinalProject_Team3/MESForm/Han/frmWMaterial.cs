using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmWMaterial : MESForm.BaseForms.frmBaseLists
    {
        CheckBox hearderCheckBox = new CheckBox(); //입고대기 헤더체크박스
        CheckBox hearderCheckBox2 = new CheckBox(); //자재입고 헤더체크박스
        List<WMaterialVO> list;
        List<WMaterialVO> newList;

        public frmWMaterial()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            //업체, 납품업체, 품목, 품명, 규격, 품목유형, 단위, 검사여부, 발주수량, 입고량, 잔량, 납기일, 주문상태
            CommonUtil.SetInitGridView(dgvWaitingWarehouse);
            CommonUtil.SetInitGridView(dgvWarehouse);

            #region 체크박스 //1
            //입고대기리스트
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "chk";
            chkCol.HeaderText = "";
            chkCol.Width = 30;
            dgvWaitingWarehouse.Columns.Add(chkCol);

            Point headerCellLocation = dgvWaitingWarehouse.GetCellDisplayRectangle(1, -1, true).Location;

            hearderCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 10);
            hearderCheckBox.BackColor = Color.White;
            hearderCheckBox.Size = new Size(13, 13);
            hearderCheckBox.Click += HearderCheckBox_Click; ;
            dgvWaitingWarehouse.Controls.Add(hearderCheckBox);

            //자재입고
            DataGridViewCheckBoxColumn chkCol2 = new DataGridViewCheckBoxColumn();
            chkCol2.Name = "chk2";
            chkCol2.HeaderText = "";
            chkCol2.Width = 30;
            dgvWarehouse.Columns.Add(chkCol2);

            Point headerCellLocation2 = dgvWarehouse.GetCellDisplayRectangle(1, -1, true).Location;

            hearderCheckBox2.Location = new Point(headerCellLocation2.X + 8, headerCellLocation2.Y + 10);
            hearderCheckBox2.BackColor = Color.White;
            hearderCheckBox2.Size = new Size(13, 13);
            hearderCheckBox2.Click += HearderCheckBox2_Click; ;
            dgvWarehouse.Controls.Add(hearderCheckBox2);
            #endregion

            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "업체", "Com_Name", 150);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납품업체", "ITEM_Delivery_Company", 150);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목", "ITEM_Code", 130);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품명", "ITEM_Name", 180);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목유형", "ITEM_Type", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "단위", "ITEM_Unit", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "검사여부", "Reorder_InspYN", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주수량", "Reorder_Amount", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고량", "Reorder_InAmount", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "잔량", "Reorder_Balance", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납기일", "Order_FixedDate", 140, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "주문상태", "Reorder_State", 100, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주번호", "Reorder_Number", 10, false);

            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목", "ITEM_Code", 130);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품명", "ITEM_Name", 180);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목유형", "ITEM_Type", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단위", "ITEM_Unit", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고창고", "ITEM_WareHouse_IN");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고량", "InQty", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단가", "MC_IngCost", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "비고", "Warehouse_Note");

            dgvWarehouse.Columns["InQty"].ReadOnly = false;
            dgvWarehouse.Columns["Warehouse_Note"].ReadOnly = false;
        }

        #region 헤더 체크박스
        private void HearderCheckBox_Click(object sender, EventArgs e)
        {
            dgvWaitingWarehouse.EndEdit();

            foreach (DataGridViewRow row in dgvWaitingWarehouse.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = hearderCheckBox.Checked;
            }
        }

        private void HearderCheckBox2_Click(object sender, EventArgs e)
        {
            dgvWarehouse.EndEdit();

            foreach (DataGridViewRow row in dgvWarehouse.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk2"];
                chk.Value = hearderCheckBox2.Checked;
            }
        }
        #endregion

        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            ComboBoxBinding.ComBind(cboOrderState, commonList, "OrderState000");
        }

        private void LoadData()
        {
            string sDate = dtpDate.DtpFrom.ToShortDateString();
            string eDate = dtpDate.DtpTo.ToShortDateString();
            string orderState = cboOrderState.Text;
            string itemCode = txtItem.Text;
            string comName = txtCompany.Text;
            string inComName = txtInCompany.Text;

            WMaterialService service = new WMaterialService();
            list = service.GetWMaterialList(sDate, eDate, orderState, itemCode, comName, inComName);

            dgvWaitingWarehouse.DataSource = list;
        }

        private void frmWMaterial2_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            DgvSetting();
            //LoadData();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            newList = new List<WMaterialVO>();
            for (int i = 0; i < dgvWaitingWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWaitingWarehouse["chk", i].Value))
                {
                    newList.Add(list[i]);
                }
            }

            if(newList.Count < 1)
            {
                MessageBox.Show("선택한 품목이 없습니다.");
                return;
            }

            dgvWarehouse.DataSource = newList;
            CheckedFalse(dgvWaitingWarehouse, "chk");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvWaitingWarehouse);
        }

        private void btnWarehousing_Click(object sender, EventArgs e)
        {
            List<WMaterialVO> inList = new List<WMaterialVO>();

            for (int i = 0; i < dgvWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWarehouse["chk2", i].Value))
                {
                    #region 유효성 체크
                    int rbAmount = Convert.ToInt32(dgvWaitingWarehouse["Reorder_Balance", i].Value);
                    int inAmount = Convert.ToInt32(dgvWarehouse["InQty", i].Value);
                    if (inAmount < 1)
                    {
                        MessageBox.Show($"최소 1개의 수량을 입력해주세요.");
                        return;
                    }
                    if (rbAmount < inAmount)
                    {
                        MessageBox.Show($"입력한 입고량이 현재 잔량보다 많습니다.");
                        return;
                    }
                    #endregion

                    inList.Add(newList[i]);
                    inList[i].Warehouse_Note = Convert.ToString(dgvWarehouse["Warehouse_Note", i].Value);
                }
            }

            if (inList.Count < 1)
            {
                MessageBox.Show("선택한 품목이 없습니다.");
                return;
            }

            WMaterialService service = new WMaterialService();
            bool result = service.InsertWareHouse(inList);
            service.Dispose();

            if (result)
            {
                MessageBox.Show("입고처리가 완료되었습니다.");

                CheckedFalse(dgvWarehouse, "chk2");
                dgvWarehouse.DataSource = null;
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            #region 유효성 체크
            List<WMaterialVO> chkList = new List<WMaterialVO>();
            for (int i = 0; i < dgvWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWarehouse["chk2", i].Value))
                {
                    chkList.Add(newList[i]);
                }
            }

            if (newList == null || newList.Count < 1)
            {
                MessageBox.Show("입고처리 중인 데이터가 없습니다.");
                return;
            }

            if (chkList.Count < 1)
            {
                MessageBox.Show("선택한 품목이 없습니다.");
                return;
            }
            #endregion

            for (int i = 0; i < dgvWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWarehouse["chk2", i].Value))
                {
                    newList.Remove(chkList[i]);
                }
            }
            CheckedFalse(dgvWarehouse, "chk2");

            dgvWarehouse.DataSource = null;
            dgvWarehouse.DataSource = newList;
        }

        private void CheckedFalse(DataGridView dgv, string chkCell)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[chkCell];
                chk.Value = false;
            }
            if (hearderCheckBox.Checked)
                hearderCheckBox.Checked = false;
            else if (hearderCheckBox2.Checked)
                hearderCheckBox2.Checked = false;
        }

    }
}
