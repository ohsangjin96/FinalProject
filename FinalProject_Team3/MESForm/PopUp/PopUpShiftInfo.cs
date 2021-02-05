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

namespace MESForm
{
    public partial class PopUpShiftInfo : MESForm.BaseForms.frmPopup
    {
        bool bRegOrUp;
        public string Uname { get; set; }
        public List<CommonCodeVO> comList { get; set; }//시프트 리스트
        public List<FacilityVO> FacList { get; set; }//설비 리스트
        public PopUpShiftInfo()
        {
            InitializeComponent();
        }
        public PopUpShiftInfo(OpenMode mode)
        {
            InitializeComponent();
            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpShiftInfo_Load(object sender, EventArgs e)
        {
            ComBind();
            txtModifier.Text = Uname;
            txtModifierDAte.Text = DateTime.Now.ToString("d");
        }

        private void ComBind()
        {
            CommonCodeService service1 = new CommonCodeService();
            List<CommonCodeVO> CommonList = service1.GetCommonCodeList();
            service1.Dispose();

            var Shift = (from a in comList
                       where a.Common_Parent == "Shift000"  //Common_Parent의 코드명
                       select a).ToList();
            Shift.Insert(0, new CommonCodeVO { Common_Name = "선택" });


            var use = (from a in CommonList
                     where a.Common_Parent == "UseYN000"  //Common_Parent의 코드명
                     select a).ToList();
            use.Insert(0, new CommonCodeVO { Common_Name = "선택" });

            ComboBoxBinding.BindingComboBox(cboShift, Shift, "Common_Name", "Common_Name");
            ComboBoxBinding.BindingComboBox(cboFacCode, FacList, "Facility_Name", "Facility_Code");
            ComboBoxBinding.BindingComboBox(cboUse, use, "Common_Name", "Common_Name");
        }

        private void cboFacCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFacCode.SelectedIndex < 0 || cboFacCode.Text=="전체") return;

            txtFacName.Text = cboFacCode.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 검사
            if(cboFacCode.Text=="전체" || cboShift.Text=="선택" || numPeople.Value==0 || txtStartDate.Text==string.Empty ||
               txtCompleteDate.Text == string.Empty)
            {
                MessageBox.Show(Properties.Resources.ErrNotEntered);
                return;
            }
            if (dtpApplyStart.Value==dtpApplyEnd.Value)
            {
                MessageBox.Show("적용시작일자와 적용종료일자가 같을 수 없습니다 다시 설정하여 주십시오.");
                return;
            }
            if (dtpApplyStart.Value > dtpApplyEnd.Value)
            {
                MessageBox.Show(" 적용종료일자가 적용시작일자 전일 수 없습니다 다시 설정하여 주십시오.");
                return;
            }
            try
            {
                //vo 전달
                ShiftVO vo = new ShiftVO();
                vo.Facility_Code  = cboFacCode.Text;
                vo.Shift_type = cboShift.Text;
                vo.Shift_People =  Convert.ToInt32(numPeople.Value);
                vo.Shift_StartTime  = txtStartDate.Text;
                vo.Shift_EndTime =   txtCompleteDate.Text;
                vo.Shift_Apply_StartDate  = dtpApplyStart.Value;
                vo.Shift_Apply_EndDate =  dtpApplyEnd.Value;
                vo.Shift_Use  = cboUse.Text;
                vo.Shift_Last_Modifier =  txtModifier.Text;
                vo.Shift_Last_Modifier_Time = Convert.ToDateTime(txtModifierDAte.Text);
                vo.Shift_Remark  = txtRemark.Text;
                if (!bRegOrUp)
                {
                   //폼에서 스케줄 코드를 프로퍼티로 받아서 할당
                }

                //서비스
                ShiftService service = new ShiftService();
                if (bRegOrUp)
                {

                    service.RegisterShift(vo);
                    
                }
                if (!bRegOrUp)
                {

                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
           
           
        }
    }
}
