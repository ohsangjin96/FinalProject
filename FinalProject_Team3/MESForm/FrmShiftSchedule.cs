﻿using FProjectVO;
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
    public partial class FrmShiftSchedule : MESForm.BaseForms.frmBaseLists
    {
        List<ShiftVO> AllList;
        List<CommonCodeVO> CommonList;//시프트 리스트
        public FrmShiftSchedule()
        {
            InitializeComponent();
            CommonUtil.AddGridTextColumn(dgvShift, "No", "RowNo", 50, true, DataGridViewContentAlignment.MiddleLeft);
          
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvShift);
        }

        private void FrmShiftSchedule_Load(object sender, EventArgs e)
        {
            ComBind();
        }

        private void ComBind() //콤보박스 바인딩
        {
            //쉬프트 타입
            CommonCodeService service1 = new CommonCodeService();
            CommonList = service1.GetCommonCodeList();
            service1.Dispose();

            var use = (from a in CommonList
                       where a.Common_Parent == "Shift000"  //Common_Parent의 코드명
                       select a).ToList();
            

            //쉬프트 이름 
            ShiftService service = new ShiftService();
            AllList = service.GetShiftInfo();
            service.Dispose();

            var name = (from a in AllList
                        select a.Facility_Name).Distinct().ToList();
            name.Insert(0, "전체");


            ComboBoxBinding.BindingComboBox(cboShift, use, "Common_Name", "Common_Name");
            ComboBoxBinding.BindingComboBox(cboFacCode, name, "Facility_Name", "Facility_Name");
        }

        private void btnRefresh_Click(object sender, EventArgs e) //새로고침
        {
            
            cboFacCode.SelectedIndex = 0;
            cboShift.SelectedIndex = 0;
            dateTimePicker1.RefreshDate();
        }

        private void btnInquiry_Click(object sender, EventArgs e) //조회
        {
            string dtpfrom = string.Empty;
            string dtpto = string.Empty;
            //날짜 입력만큼의 데이터 조회
            dtpfrom = dateTimePicker1.DtpFrom.ToShortDateString();
            dtpto = dateTimePicker1.DtpTo.ToShortDateString();

            ShiftService service = new ShiftService();
            DataTable dt = service.GetList(dtpfrom, dtpto,cboShift.Text,cboFacCode.Text);
            service.Dispose();
            dgvShift.DataSource = dt;


            dgvShift.Columns[1].HeaderText = "Shift";
            dgvShift.Columns[2].Visible = false;
            dgvShift.Columns[4].Visible = false;

        }
    }
}
