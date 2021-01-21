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
    public partial class frmFacility : MESForm.BaseForms.frmBaseListList
    {
        public frmFacility()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvFacility);
            CommonUtil.AddGridTextColumn(dgvFacility, "설비군코드", "Facilities_Code");
            CommonUtil.AddGridTextColumn(dgvFacility, "설비군명", "Facilities_Name");
            CommonUtil.AddGridTextColumn(dgvFacility, "사용유무", "Facilities_Use");
            //CommonUtil.AddGridTextColumn(dgvFacility, "수정자", "Facilities_Amender");
            //CommonUtil.AddGridTextColumn(dgvFacility, "수정날짜", "Facilities_ModdifyDate");
            //CommonUtil.AddGridTextColumn(dgvFacility, "설명", "Facilities_Explain");


            CommonUtil.SetInitGridView(dgvFacilityDetail);
            //CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비군코드", "Facilities_Code");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비코드", "Facility_Code");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "설비명", "Facility_Name");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "소진창고", "Facility_Exhaustion");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "양품창고", "Facility_Imported");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "불량창고", "Facility_Poor");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "MES설비", "Facility_MES");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "외주여부", "Facility_OutSourcing");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정자", "Facility_Amender");
            CommonUtil.AddGridTextColumn(dgvFacilityDetail, "수정날짜", "Facility_ModdifyDate");
        }

        private void frmFacility_Load(object sender, EventArgs e)
        {
            DgvSetting();
        }

        private void btnReg1_Click(object sender, EventArgs e)
        {
            PopUp.FacilityPopUp pop = new PopUp.FacilityPopUp();
            if(pop.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnReg2_Click(object sender, EventArgs e)
        {
            PopUp.FacilityDetailPopUp pop = new PopUp.FacilityDetailPopUp();
            if (pop.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
