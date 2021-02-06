using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
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

namespace MESForm
{
    public partial class FrmShift : MESForm.BaseForms.frmBaseLists
    {
        List<ShiftVO> AllList;
        List<CommonCodeVO> CommonList;//시프트 리스트
        List<FacilityVO> FacList;//설비코드 리스트
        public string DeptName { get; set; }
        public FrmShift()
        {
            InitializeComponent();
        }
        private void FrmShift_Load(object sender, EventArgs e)
        {
            ComBind();
            dgvSetting();
            LoadData();
        }

        private void ComBind()
        {

            FacilityService service = new FacilityService();
            FacList = service.GetFacilityDetailList();
            service.Dispose();
            FacList.Insert(0, new FacilityVO { Facility_Code = "전체" });

            CommonCodeService service1 = new CommonCodeService();
            CommonList = service1.GetCommonCodeList();
            service1.Dispose();

            var use = (from a in CommonList
                       where a.Common_Parent == "Shift000"  //Common_Parent의 코드명
                       select a).ToList();
            use.Insert(0, new CommonCodeVO { Common_Name = "전체" });

            ComboBoxBinding.BindingComboBox(cboShift, use, "Common_Name", "Common_Name");
            ComboBoxBinding.BindingComboBox(cboFacCode, FacList, "Facility_Name", "Facility_Code");

        }

        private void dgvSetting()
        {
            CommonUtil.SetInitGridView(dgvShift);
            CommonUtil.AddGridTextColumn(dgvShift, "Shift코드", "Shift_Code", 100, false);//1
            CommonUtil.AddGridTextColumn(dgvShift, "설비코드", "Facility_Code");//2
            CommonUtil.AddGridTextColumn(dgvShift, "설비명", "Facility_Name");//3
            CommonUtil.AddGridTextColumn(dgvShift, "Shift", "Shift_type");//4
            CommonUtil.AddGridTextColumn(dgvShift, "시작일자", "Shift_StartTime");//5
            CommonUtil.AddGridTextColumn(dgvShift, "종료일자", "Shift_EndTime");//6
            CommonUtil.AddGridTextColumn(dgvShift, "적용시작일자", "Shift_Apply_StartDate");//7
            CommonUtil.AddGridTextColumn(dgvShift, "적용완료일자", "Shift_Apply_EndDate");//8
            CommonUtil.AddGridTextColumn(dgvShift, "투입인원", "Shift_People");//9
            CommonUtil.AddGridTextColumn(dgvShift, "사용유무", "Shift_Use");//10
            CommonUtil.AddGridTextColumn(dgvShift, "수정자", "Shift_Last_Modifier");//11
            CommonUtil.AddGridTextColumn(dgvShift, "수정일자", "Shift_Last_Modifier_Time");//12
            CommonUtil.AddGridTextColumn(dgvShift, "비고", "Shift_Remark");//13
            //
        }
        private void LoadData()
        {

            ShiftService service = new ShiftService();
            AllList = service.GetShiftInfo();
            service.Dispose();
            dgvShift.DataSource = AllList;

        }

        private void btnReg_Click(object sender, EventArgs e)//등록
        {
            PopUpShiftInfo pop = new PopUpShiftInfo(frmMain.OpenMode.Register);
            pop.Uname = DeptName;
            pop.comList = CommonList;
            pop.FacList = FacList;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }
        private void btnInquiry_Click(object sender, EventArgs e)//조회
        {
            ShiftService service = new ShiftService();

            if (cboShift.Text == "전체" && cboFacCode.Text == "전체")
            {
                LoadData();
                return;
            }
            if (cboShift.Text != "전체" && cboFacCode.Text == "전체")
            {
                List<ShiftVO> TypeList = service.GetTypeSelect(cboShift.Text);
                service.Dispose();
                dgvShift.DataSource = TypeList;
                return;
            }

            if (cboShift.Text == "전체" && cboFacCode.Text != "전체")
            {
                List<ShiftVO> CodeList = service.GetCodeSelect(cboFacCode.Text);
                service.Dispose();
                dgvShift.DataSource = CodeList;
                return;
            }


            List<ShiftVO> SList = service.GetShiftSelect(cboShift.Text, cboFacCode.Text);
            service.Dispose();
            dgvShift.DataSource = SList;
        }
        private void btnUpdate_Click(object sender, EventArgs e)//수정
        {
            int rowIdx = dgvShift.CurrentRow.Index;

            ShiftVO vo = new ShiftVO();
            vo.Shift_Code= Convert.ToInt32(dgvShift[1, rowIdx].Value.ToString());
            vo.Facility_Code = dgvShift[2, rowIdx].Value.ToString();
            vo.Facility_Name = dgvShift[3, rowIdx].Value.ToString();
            vo.Shift_type = dgvShift[4, rowIdx].Value.ToString();
            vo.Shift_StartTime = dgvShift[5, rowIdx].Value.ToString();
            vo.Shift_EndTime = dgvShift[6, rowIdx].Value.ToString();
            vo.Shift_Apply_StartDate = Convert.ToDateTime(dgvShift[7, rowIdx].Value.ToString());
            vo.Shift_Apply_EndDate = Convert.ToDateTime(dgvShift[8, rowIdx].Value.ToString());
            vo.Shift_People= Convert.ToInt32(dgvShift[9, rowIdx].Value.ToString());
            vo.Shift_Use= dgvShift[10, rowIdx].Value.ToString();
            vo.Shift_Last_Modifier= dgvShift[11, rowIdx].Value.ToString();
            vo.Shift_Last_Modifier_Time= Convert.ToDateTime(dgvShift[12, rowIdx].Value.ToString());
            vo.Shift_Remark= dgvShift[13, rowIdx].Value.ToString();

            PopUpShiftInfo pop = new PopUpShiftInfo(frmMain.OpenMode.Update);
            pop.UList = vo;
            pop.Uname = DeptName;
            pop.comList = CommonList;
            pop.FacList = FacList;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제
        {
            int rowIdx = dgvShift.CurrentRow.Index;
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                int pk = Convert.ToInt32(dgvShift[1, rowIdx].Value.ToString());

                ShiftService service = new ShiftService();

                bool bFlag = service.DeleteShift(pk);
                if (bFlag)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("삭제 도중 오류가 발생하였습니다.");
                }
            }
            
        }

        private void btnExcel_Click(object sender, EventArgs e)//엑셀
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침
        {
            LoadData();
        }


    }
}
