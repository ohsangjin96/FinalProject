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
        public List<CommonCodeVO> comList { get; set; }
        public List<FacilityVO> FacList { get; set; }
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
    }
}
