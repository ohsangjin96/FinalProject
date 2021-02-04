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

namespace MESForm
{
    public partial class frmFacility : MESForm.BaseForms.frmBaseLists
    {
        List<FacilityVO> facilityDetailList;
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
            CommonUtil.AddGridTextColumn(dgvFacility, "사용유무", "Facilities_Use", 80); //3
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
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "MES설비", "Facility_MES", 10, false); //7
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "외주여부", "Facility_OutSourcing", 80); //8
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "사용유무", "Facility_Use", 80); //9
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "특이사항", "Facility_Note", 80); //10
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "비고", "Facility_Comment", 80); //11
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정자", "Facility_Amender", 80); //12
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정날짜", "Facility_ModdifyDate", 130); //13
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "품목코드", "Item_Code", 10, false); //14
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비IP", "Facility_IP", 10, false); //15
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비Port", "Facility_Port", 10, false); //16
        }
        
        private void LoadFacilityData()
        {
            FacilityService service = new FacilityService();
            List<FacilityVO> list = service.GetFacilitiesList();
            service.Dispose();
            dgvFacility.DataSource = list;
        }
        private void LoadFacilityDetailData()
        {
            FacilityService service = new FacilityService();
            facilityDetailList = service.GetFacilityDetailList();
            service.Dispose();
            dgvFacilityDetail.DataSource = facilityDetailList;
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
                Facilities_ModdifyDate = dgvFacility[5, rowIdx].Value.ToString(),
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
            int cnt = service.SearchFacility(code);

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
                bool result = service.DeleteFacilities(code);
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

        /// <summary>
        /// 설비군의 데이터 셀 더블클릭 시 해당하는 설비군코드와 일치하는 설비의 목록만 나오도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFacility_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = dgvFacility[1, dgvFacility.CurrentRow.Index].Value.ToString();
            var newList = (from temp in facilityDetailList
                           where temp.Facilities_Code == code
                           select temp).ToList();

            dgvFacilityDetail.DataSource = newList;
        }

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
                Facilities_Code = Convert.ToString(dgvFacilityDetail[1, rowIdx].Value),
                Facility_Code = Convert.ToString(dgvFacilityDetail[2, rowIdx].Value),
                Facility_Name = Convert.ToString(dgvFacilityDetail[3, rowIdx].Value),
                Facility_Exhaustion = Convert.ToString(dgvFacilityDetail[4, rowIdx].Value),
                Facility_Imported = Convert.ToString(dgvFacilityDetail[5, rowIdx].Value),
                Facility_Poor = Convert.ToString(dgvFacilityDetail[6, rowIdx].Value),
                Facility_MES = Convert.ToString(dgvFacilityDetail[7, rowIdx].Value),
                Facility_OutSourcing = Convert.ToString(dgvFacilityDetail[8, rowIdx].Value),
                Facility_Use = Convert.ToString(dgvFacilityDetail[9, rowIdx].Value),
                Facility_Note = Convert.ToString(dgvFacilityDetail[10, rowIdx].Value),
                Facility_Comment = Convert.ToString(dgvFacilityDetail[11, rowIdx].Value),
                Facility_Amender = Convert.ToString(dgvFacilityDetail[12, rowIdx].Value),
                Facility_ModdifyDate = Convert.ToString(dgvFacilityDetail[13, rowIdx].Value),
                Item_Code = Convert.ToString(dgvFacilityDetail[14, rowIdx].Value),
                Facility_IP = Convert.ToString(dgvFacilityDetail[15, rowIdx].Value),
                Facility_Port = Convert.ToString(dgvFacilityDetail[16, rowIdx].Value)
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
            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    FacilityService service = new FacilityService();
                    string code = dgvFacilityDetail[2, dgvFacilityDetail.CurrentRow.Index].Value.ToString();
                    bool result = service.DeleteFacility(code);

                    if (result)
                    {
                        MessageBox.Show(Properties.Resources.DeleteSuccess);
                        LoadFacilityDetailData();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFacilityDetailData();
        }
        #endregion
    }
}
