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

namespace MESForm
{
    public partial class frmFacility : MESForm.BaseForms.frmBaseLists
    {
        public string DeptName { get; set; }

        public frmFacility()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvFacility);
            CommonUtil.AddGridTextColumn(dgvFacility, "설비군코드", "Facilities_Code"); //1
            CommonUtil.AddGridTextColumn(dgvFacility, "설비군명", "Facilities_Name"); //2
            CommonUtil.AddGridTextColumn(dgvFacility, "사용유무", "Facilities_Use"); //3
            CommonUtil.AddGridTextColumn(dgvFacility, "수정자", "Facilities_Amender", 10, false); //4
            CommonUtil.AddGridTextColumn(dgvFacility, "수정날짜", "Facilities_ModdifyDate", 10, false); //5
            CommonUtil.AddGridTextColumn(dgvFacility, "설명", "Facilities_Explain", 10, false); //6
            
            CommonUtil.SetInitGridView(dgvFacilityDetail);
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비군코드", "Facilities_Code"); //1
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비코드", "Facility_Code"); //2
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비명", "Facility_Name"); //3
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "소진창고", "Facility_Exhaustion"); //4
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "양품창고", "Facility_Imported"); //5
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "불량창고", "Facility_Poor"); //6
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "MES설비", "Facility_MES"); //7
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "외주여부", "Facility_OutSourcing"); //8
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정자", "Facility_Amender"); //9
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정날짜", "Facility_ModdifyDate"); //10
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "사용유무", "Facility_Use"); //11
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "특이사항", "Facility_Note"); //12
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "비고", "Facility_Comment"); //13
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "품목코드", "Item_Code"); //14
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비IP", "Facility_IP"); //15
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비Port", "Facility_Port"); //16
        }
        
        private void LoadFacilityData()
        {
            FacilityService service = new FacilityService();
            List<FacilityVO> list = service.GetFacilityList();
            service.Dispose();
            dgvFacility.DataSource = list;
        }
        private void LoadFacilityDetailData()
        {
            FacilityService service = new FacilityService();
            List<FacilityVO> list = service.GetFacilityDetailList();
            service.Dispose();
            dgvFacilityDetail.DataSource = list;
        }

        private void frmFacility_Load(object sender, EventArgs e)
        {
            DgvSetting();
            LoadFacilityData();
            LoadFacilityDetailData();
        }

        #region 설비군
        private void btnReg1_Click(object sender, EventArgs e)
        {
            PopUp.PopUpFacility pop = new PopUp.PopUpFacility(frmMain.OpenMode.Register);
            pop.DeptName = DeptName;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadFacilityData();
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvFacility.CurrentRow.Index;

            FacilityVO vo = new FacilityVO
            {
                Facilities_Code = dgvFacility[1, rowIdx].Value.ToString(),
                Facilities_Name = dgvFacility[2, rowIdx].Value.ToString(),
                Facilities_Use = dgvFacility[3, rowIdx].Value.ToString(),
                Facilities_Amender = dgvFacility[4, rowIdx].Value.ToString(),
                Facilities_ModdifyDate = Convert.ToDateTime(dgvFacility[5, rowIdx].Value),
                Facilities_Explain = Convert.ToString(dgvFacility[6, rowIdx].Value)
            };

            PopUp.PopUpFacility pop = new PopUp.PopUpFacility(frmMain.OpenMode.Update);
            pop.facilityVO = vo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadFacilityData();
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            string code = dgvFacility[1, dgvFacility.CurrentRow.Index].Value.ToString();
            string name = dgvFacility[2, dgvFacility.CurrentRow.Index].Value.ToString();
            FacilityService service = new FacilityService();
            int cnt = service.SearchFacilityDetaile(code);

            if (cnt != 0)
            {
                if(MessageBox.Show($"{name}을(를) 참조하는 {cnt}개의 설비도 모두 삭제됩니다.\n{Properties.Resources.DeleteCheck}", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    service.Dispose();
                    return;
                }
            }
            else
            {
                if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }


            try
            {
                bool result = service.DeleteFacility(code);
                service.Dispose();

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadFacilityData();
                    LoadFacilityDetailData();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region 설비
        private void btnReg2_Click(object sender, EventArgs e)
        {
            PopUp.PopUpFacilityDetail pop = new PopUp.PopUpFacilityDetail(frmMain.OpenMode.Register);
            pop.DeptName = DeptName;
            pop.FacilitiesCode = dgvFacility[1, dgvFacility.CurrentRow.Index].Value.ToString();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadFacilityDetailData();
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvFacilityDetail.CurrentRow.Index;

            FacilityVO vo = new FacilityVO
            {
                Facility_Code = dgvFacilityDetail[1, rowIdx].Value.ToString(),
                Facilities_Code = dgvFacilityDetail[2, rowIdx].Value.ToString(),
                Facility_Name = dgvFacilityDetail[3, rowIdx].Value.ToString(),
                Facility_Exhaustion = dgvFacilityDetail[4, rowIdx].Value.ToString(),
                Facility_Imported = dgvFacilityDetail[5, rowIdx].Value.ToString(),
                Facility_Poor = Convert.ToString(dgvFacilityDetail[6, rowIdx].Value),
                Facility_MES = Convert.ToString(dgvFacilityDetail[7, rowIdx].Value),
                Facility_OutSourcing = dgvFacilityDetail[8, rowIdx].Value.ToString(),
                Facility_Amender = dgvFacilityDetail[9, rowIdx].Value.ToString(),
                Facility_ModdifyDate = Convert.ToDateTime(dgvFacilityDetail[10, rowIdx].Value),
                Facility_Use = Convert.ToString(dgvFacilityDetail[11, rowIdx].Value),
                Facility_Note = Convert.ToString(dgvFacilityDetail[12, rowIdx].Value),
                Facility_Comment = dgvFacilityDetail[13, rowIdx].Value.ToString(),
                Item_Code = Convert.ToString(dgvFacilityDetail[14, rowIdx].Value),
                Facility_IP = Convert.ToString(dgvFacilityDetail[15, rowIdx].Value),
                Facility_Port = Convert.ToString(dgvFacilityDetail[16, rowIdx].Value),
            };

            PopUp.PopUpFacilityDetail pop = new PopUp.PopUpFacilityDetail(frmMain.OpenMode.Update);
            pop.facilityVO = vo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadFacilityDetailData();
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
