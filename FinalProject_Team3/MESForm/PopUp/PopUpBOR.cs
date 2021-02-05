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
    public partial class PopUpBOR : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }
        public BORVO borVO { get; set; }

        public PopUpBOR()
        {
            InitializeComponent();
        }

        public PopUpBOR(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
                cboItem.Enabled = false;
                cboRoute.Enabled = false;
                cboFacility.Enabled = false;
            }
        }
        
        /// <summary>
        /// 기존에 등록된 데이터를 가져와, 텍스트박스 및 콤보박스에 값을 입력시키는 메서드
        /// </summary>
        private void GetFacilitiesInfo()
        {
            cboItem.Text = borVO.Item_Name;
            cboRoute.Text = borVO.BOR_RouteName;
            cboFacility.Text = borVO.Facility_Name;
            txtTactTime.Text = Convert.ToString(borVO.BOR_TactTime);
            txtReadyTime.Text = Convert.ToString(borVO.BOR_ReadyTime);
            txtOrder.Text = Convert.ToString(borVO.BOR_Order);
            txtTransference.Text = Convert.ToString(borVO.BOR_Transference);
            cboUse.Text = borVO.BOR_Use;
            txtNote.Text = borVO.BOR_Note;
            lblBorCode.Text = Convert.ToString(borVO.BOR_Code);
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();
            ComboBoxBinding.ComBind(cboRoute, commonList, "B-Route", false);
            ComboBoxBinding.ComBind(cboUse, commonList, "UseYN000", false);
            cboUse.SelectedIndex = 1;

            FacilityService facilityService = new FacilityService();
            List<FacilityVO> facilityList = facilityService.GetFacilityDetailList();
            facilityService.Dispose();

            facilityList = (from a in facilityList
                            orderby a.Facility_Name
                            select a).ToList();

            ComboBoxBinding.BindingComboBox(cboFacility, facilityList ,"Facility_Code", "Facility_Name");

            ItemService itemService = new ItemService();
            List<ItemVO> itemList = itemService.GetItemAllList();
            itemService.Dispose();
            ComboBoxBinding.ItemBind(cboItem, itemList, false);
        }

        private void PopUpBOR_Load(object sender, EventArgs e)
        {
            ComboBoxBind();

            if (!bRegOrUp)
            {
                GetFacilitiesInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 유효성체크
            if (string.IsNullOrEmpty(txtTactTime.Text))
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "Tact Time을"));
                return;
            }
            else if (string.IsNullOrEmpty(txtOrder.Text))
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "우선순위를"));
                return;
            }
            #endregion
            try
            {
                BORVO vo = new BORVO
                {
                    Item_Code = cboItem.SelectedValue.ToString(),
                    BOR_Route = cboRoute.SelectedValue.ToString(),
                    Facility_Code = cboFacility.SelectedValue.ToString(),
                    BOR_TactTime = Convert.ToInt32(txtTactTime.Text),
                    BOR_ReadyTime = txtReadyTime.Text,
                    BOR_Order = Convert.ToInt32(txtOrder.Text),
                    BOR_Transference = txtTransference.Text,
                    BOR_Use = cboUse.Text,
                    BOR_Note = txtNote.Text,
                    BOR_Amender = DeptName,
                };

                BORService service = new BORService();
                if (bRegOrUp) //등록
                {
                    service.InsertBOR(vo);
                }
                else //수정
                {
                    vo.BOR_Code = Convert.ToInt32(lblBorCode.Text);
                    service.UpdateBOR(vo);
                }
                service.Dispose();

                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                //if (err.Message == "이미 등록된 설비군코드입니다.")
                //{
                //    txtFacilitiesCode.Focus();
                //    txtFacilitiesCode.SelectAll();
                //}
                //else if (err.Message == "이미 등록된 설비군명입니다.")
                //{
                //    txtFacilitiesName.Focus();
                //    txtFacilitiesName.SelectAll();
                //}

                MessageBox.Show(err.Message);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BORPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void BORPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void txtTactTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((TextBox)sender).Name == "txtTransference")
            {
                //숫자, 백스페이스, 소수점(.)만 입력가능
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //숫자, 백스페이스만 입력가능
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
