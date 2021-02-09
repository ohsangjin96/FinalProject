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
using static MESForm.frmMain;

namespace MESForm
{
    public partial class frmBOR : MESForm.BaseForms.frmBaseLists
    {
        CheckBox hearderCheckBox = new CheckBox(); //헤더체크박스

        public string DeptName { get; set; }

        public frmBOR()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvBOR);

            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "chk";
            chkCol.HeaderText = "";
            chkCol.Width = 30;
            dgvBOR.Columns.Add(chkCol); //1

            Point headerCellLocation = dgvBOR.GetCellDisplayRectangle(1, -1, true).Location;

            hearderCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 10);
            hearderCheckBox.BackColor = Color.White;
            hearderCheckBox.Size = new Size(13, 13);
            hearderCheckBox.Click += HearderCheckBox_Click; ;
            dgvBOR.Controls.Add(hearderCheckBox);

            CommonUtil.AddGridTextColumn(dgvBOR, "품목", "Item_Code", 120); //2
            CommonUtil.AddGridTextColumn(dgvBOR, "품명", "Item_Name", 220); //3
            CommonUtil.AddGridTextColumn(dgvBOR, "공정", "BOR_Route", 120); //4
            CommonUtil.AddGridTextColumn(dgvBOR, "공정명", "BOR_RouteName"); //5
            CommonUtil.AddGridTextColumn(dgvBOR, "설비", "Facility_Code"); //6
            CommonUtil.AddGridTextColumn(dgvBOR, "설비명", "Facility_Name"); //7
            CommonUtil.AddGridTextColumn(dgvBOR, "TactTime(Sec)", "BOR_TactTime", 100, true, DataGridViewContentAlignment.MiddleRight); //8
            CommonUtil.AddGridTextColumn(dgvBOR, "우선순위", "BOR_Order", 100, true, DataGridViewContentAlignment.MiddleRight); //9
            CommonUtil.AddGridTextColumn(dgvBOR, "공정선행일(Day)", "BOR_ReadyTime", 110, true, DataGridViewContentAlignment.MiddleRight); //10
            CommonUtil.AddGridTextColumn(dgvBOR, "수율", "BOR_Transference", 10, false); //11
            CommonUtil.AddGridTextColumn(dgvBOR, "사용유무", "BOR_Use", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvBOR, "비고", "BOR_Note", 120); //13
            CommonUtil.AddGridTextColumn(dgvBOR, "수정자", "BOR_Amender", 100, true, DataGridViewContentAlignment.MiddleCenter); //14
            CommonUtil.AddGridTextColumn(dgvBOR, "수정날짜", "BOR_ModdifyDate", 140, true, DataGridViewContentAlignment.MiddleCenter); //15
            CommonUtil.AddGridTextColumn(dgvBOR, "BOR코드", "BOR_Code", 10, false); //16
        }

        private void HearderCheckBox_Click(object sender, EventArgs e)
        {
            dgvBOR.EndEdit();

            foreach (DataGridViewRow row in dgvBOR.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = hearderCheckBox.Checked;
            }
        }

        private void LoadData()
        {
            BORService service = new BORService();
            List<BORVO> list = service.GetBORList();
            service.Dispose();
            dgvBOR.DataSource = list;
        }

        private void frmBOR_Load(object sender, EventArgs e)
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();
            ComboBoxBinding.ComBind(cboRoute, commonList, "B-Route");

            DgvSetting();
            //LoadData();
        }

        /// <summary>
        /// 검색 조건에 따른 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            string route = Convert.ToString(cboRoute.SelectedValue);
            string facility = txtFacility.Text;

            BORService service = new BORService();
            List<BORVO> list = service.SearchBORList(item, route, facility);
            service.Dispose();

            dgvBOR.DataSource = list;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            PopUp.PopUpBOR pop = new PopUp.PopUpBOR(OpenMode.Register);
            pop.DeptName = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvBOR.CurrentRow.Index;

            PopUp.PopUpBOR pop = new PopUp.PopUpBOR(OpenMode.Update);

            BORVO vo = new BORVO
            {
                BOR_Code = Convert.ToInt32(dgvBOR[16, rowIdx].Value),
                Item_Name = Convert.ToString(dgvBOR[3, rowIdx].Value),
                BOR_RouteName = Convert.ToString(dgvBOR[5, rowIdx].Value),
                Facility_Name = Convert.ToString(dgvBOR[7, rowIdx].Value),
                BOR_TactTime = Convert.ToInt32(dgvBOR[8, rowIdx].Value),
                BOR_Order = Convert.ToInt32(dgvBOR[9, rowIdx].Value),
                BOR_ReadyTime = Convert.ToString(dgvBOR[10, rowIdx].Value),
                BOR_Transference = Convert.ToString(dgvBOR[11, rowIdx].Value),
                BOR_Use = Convert.ToString(dgvBOR[12, rowIdx].Value),
                BOR_Note = Convert.ToString(dgvBOR[13, rowIdx].Value)
            };
            pop.borVO = vo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> codeList = new List<int>();
                for (int i = 0; i < dgvBOR.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvBOR["chk", i].Value))
                    {
                        codeList.Add(Convert.ToInt32(dgvBOR[16, i].Value));
                    }
                }
                string codes = string.Join("@", codeList.ToArray());

                BORService service = new BORService();
                bool result = service.DeleteBOR(codes);
                service.Dispose();

                //체크박스 모두 해제
                CheckedFalse();
                LoadData();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvBOR);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CheckedFalse()
        {
            foreach (DataGridViewRow row in dgvBOR.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = false;
            }
            if (hearderCheckBox.Checked)
                hearderCheckBox.Checked = false;
        }
    }
}
