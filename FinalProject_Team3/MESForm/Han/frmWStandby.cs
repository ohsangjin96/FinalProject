using FProjectVO;
using MESForm.CustomControls;
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
    public partial class frmWStandby : BaseForms.frmBaseLists
    {
        CheckBox hearderCheckBox = new CheckBox(); //헤더체크박스
        CheckBox hearderCheckBox2 = new CheckBox();
        List<WStandbyVO> list;
        List<WStandbyVO> newList;

        public frmWStandby()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
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
            hearderCheckBox2.Click += HearderCheckBox2_Click;
            dgvWarehouse.Controls.Add(hearderCheckBox2);
            #endregion

            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주일", "Reorder_OrderDate");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주업체", "Com_Name");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납품업체", "ITEM_Delivery_Company");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "단위", "ITEM_Unit");
            //CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "검사여부", "");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주량", "Reorder_Amount");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고수량", "Reorder_InAmount");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "잔량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납기일자", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "비고", "Reorder_Note");

            //CommonUtil.AddGridTextColumn(dgvWarehouse, "발주번호", "aa");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품명", "ITEM_Name");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "규격", "ITEM_Standard");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단위", "ITEM_Unit");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "발주수량", "Reorder_Amount");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "잔여수량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고수량", "InQty");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고일자", "InDate");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "발주일자", "Reorder_OrderDate");
            //CommonUtil.AddGridTextColumn(dgvWarehouse, "검사유무", "ak");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "비고", "Reorder_Note");

            dgvWarehouse.Columns["InDate"].ReadOnly = false;
        }

        #region 헤더체크박스
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

        private void ComboBoxBind()
        {
            CompanyService companyService = new CompanyService();
            List<CompanyVO> companyList = companyService.GetCompanyList();
            List<CompanyVO> companyList2 = companyService.GetCompanyList();
            companyService.Dispose();

            ComboBoxBinding.CompanyBind(cboCompany, companyList);
            ComboBoxBinding.CompanyBind(cboInCompany, companyList2);
        }

        private void LoadData()
        {
            string sDate = dtpDate.DtpFrom.ToShortDateString();
            string eDate = dtpDate.DtpTo.ToShortDateString();
            string itemCode = txtItem.Text;
            string comName = cboCompany.Text;
            string inComName = cboInCompany.Text;

            WStandbyService service = new WStandbyService();
            list = service.GetWStandbyList(sDate, eDate, itemCode, comName, inComName);
            service.Dispose();
            dgvWaitingWarehouse.DataSource = list;
        }

        private void frmWStandby_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            DGVSetting();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            newList = new List<WStandbyVO>();
            for (int i = 0; i < dgvWaitingWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWaitingWarehouse["chk", i].Value))
                {
                    newList.Add(list[i]);
                }
            }

            if (newList.Count < 1)
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
            List<WStandbyVO> inList = new List<WStandbyVO>();

            for (int i = 0; i < dgvWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWarehouse["chk2", i].Value))
                {
                    #region 유효성 체크
                    string inDate = Convert.ToString(dgvWarehouse["InDate", i].Value);
                    if (string.IsNullOrEmpty(inDate))
                    {
                        MessageBox.Show($"납기일을 입력하지 않은 품목이 있습니다.");
                        return;
                    }
                    #endregion

                    inList.Add(newList[i]);
                }
            }

            if (inList.Count < 1)
            {
                MessageBox.Show("선택한 품목이 없습니다.");
                return;
            }


            WStandbyService service = new WStandbyService();
            bool result = service.InsertWarehouseWaiting(inList);
            service.Dispose();

            if (result)
            {
                MessageBox.Show("입고대기처리가 완료되었습니다.");

                CheckedFalse(dgvWarehouse, "chk2");
                dgvWarehouse.DataSource = null;
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            #region 유효성 체크
            List<WStandbyVO> chkList = new List<WStandbyVO>();
            for (int i = 0; i < dgvWarehouse.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvWarehouse["chk2", i].Value))
                {
                    chkList.Add(newList[i]);
                }
            }

            if (newList == null || newList.Count < 1)
            {
                MessageBox.Show("입고대기처리 중인 데이터가 없습니다.");
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
    }
}
