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

namespace MESForm.PopUp
{
    public partial class PopUpFacility : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }
        public FacilityVO facilityVO { get; set; }

        public PopUpFacility()
        {
            InitializeComponent();
        }

        public PopUpFacility(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
                txtFacilitiesCode.Enabled = false;
            }
        }
        
        /// <summary>
        /// 수정하기 위해 기존의 데이터를 불러오는 메서드
        /// </summary>
        private void GetFactoryInfo()
        {
            txtFacilitiesCode.Text = facilityVO.Facilities_Code;
            txtFacilitiesName.Text = facilityVO.Facilities_Name;
            cboFacilitiesUse.Text = facilityVO.Facilities_Use;
            txtAmender.Text = facilityVO.Facilities_Amender;
            txtModdifyDate.Text = facilityVO.Facilities_ModdifyDate.ToString();
            txtExplain.Text = facilityVO.Facilities_Explain;
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();
            ComboBoxBinding.ComBind(cboFacilitiesUse, commonList, "UseYN000", false);
        }

        private void PopUpFacility_Load(object sender, EventArgs e)
        {
            ComboBoxBind();

            if (bRegOrUp)
            {
                txtAmender.Text = DeptName;
                txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                GetFactoryInfo();
            }
        }

        /// <summary>
        /// 데이터 등록(bRegOrUp = true) 및 수정(bRegOrUp = false) 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (txtFacilitiesCode.Text == "") // 시설명 미입력
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비군코드를"));
                return;
            }

            else if (txtFacilitiesName.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비군명을"));
                return;
            }

            try
            {
                FacilityVO vo = new FacilityVO
                {
                    Facilities_Code = txtFacilitiesCode.Text,
                    Facilities_Name = txtFacilitiesName.Text,
                    Facilities_Use = cboFacilitiesUse.Text,
                    Facilities_Amender = txtAmender.Text,
                    Facilities_ModdifyDate = Convert.ToDateTime(txtModdifyDate.Text),
                    Facilities_Explain = txtExplain.Text
                };

                FacilityService service = new FacilityService();
                if (bRegOrUp) //등록
                {
                    service.InsertFacility(vo);
                }
                else //수정
                {
                    service.UpdateFacility(vo);
                }
                service.Dispose();

                DialogResult = DialogResult.OK;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);

                MessageBox.Show(err.Message);
                if (err.Message == "이미 등록된 설비군코드입니다.")
                {
                    txtFacilitiesCode.Focus();
                    txtFacilitiesCode.SelectAll();
                }
                else if (err.Message == "이미 등록된 설비군명입니다.")
                {
                    txtFacilitiesName.Focus();
                    txtFacilitiesName.SelectAll();
                }
            }
        }

        /// <summary>
        /// 취소버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilityPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FacilityPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
