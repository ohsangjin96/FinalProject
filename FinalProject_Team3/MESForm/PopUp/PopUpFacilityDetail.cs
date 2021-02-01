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
using System.Windows.Forms;
using static MESForm.frmMain;

namespace MESForm.PopUp
{
    public partial class PopUpFacilityDetail : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }
        public string FacilitiesCode { get; set; }

        public FacilityVO facilityVO { get; set; }

        public PopUpFacilityDetail()
        {
            InitializeComponent();
        }

        public PopUpFacilityDetail(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
                txtFacilityCode.Enabled = false;
            }
        }
        private void ComboBoxBind()
        {
            //공통코드 (사용유무)
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();
            ComboBoxBinding.ComBind(cboFacilityUse, commonList, "UseYN000", false);

            //공장관리
            FactoryService factoryService = new FactoryService();
            List<FactoryVO> factoryList = factoryService.GetFactoryList();
            factoryService.Dispose();

            ComboBoxBinding.FactoryTypeBind(cboExhaustion, factoryList, "창고");
            ComboBoxBinding.FactoryTypeBind(cboImported, factoryList, "창고");
            ComboBoxBinding.FactoryTypeBind(cboPoor, factoryList, "불량창고");

            ItemService itemService = new ItemService();
            List<ItemVO> itemList = itemService.GetItemAllList();
            itemService.Dispose();

            itemList = (from temp in itemList
                        where temp.ITEM_Type != "원자재"
                        select temp).ToList();

            cboItemCode.DisplayMember = "ITEM_Code";
            cboItemCode.ValueMember = "ITEM_Name";
            cboItemCode.DataSource = itemList;
        }

        private void PopUpFacilityDetail_Load(object sender, EventArgs e)
        {
            ComboBoxBind();

            if (bRegOrUp)
            {
                txtFacilitiesCode.Text = FacilitiesCode;
                txtAmender.Text = DeptName;
                txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFacilityCode.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비코드를"));
                return;
            }
            else if (txtFacilityName.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비명"));
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilityDetailPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FacilityDetailPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
