﻿using FProjectVO;
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
    public partial class PopUpFactory : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public PopUpFactory()
        {
            InitializeComponent();
        }

        public PopUpFactory(OpenMode mode)
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

        private void ComboBoxBind()
        {
            //ComboBoxBinding.
        }

        private void PopUpFactory_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if(cboFactoryGrade.Text == "전체")
            {

            }

            FactoryVO vo = new FactoryVO
            {
                Factory_Grade = cboFactoryGrade.Text,
                Factory_HighRank = cboFactoryHighRank.Text,
                Factory_Type = cboFactoryType.Text,
                Factory_Name = txtFactoryName.Text,
                Factory_Code = txtFactoryCode.Text,
                Factory_Credit = cboFactoryCredit.Text,
                Factory_Order = Convert.ToInt32(txtFactoryOrder.Text),
                Com_Code = cboComCode.ValueMember.ToString(),
                Com_Name = cboComCode.Text,
                Factory_Demand = cboFactoryDemand.Text,
                Factory_Process = cboFactoryProcess.Text,
                Factory_Material = cboFactoryMaterial.Text,
                Factory_Use = txtFactoryUse.Text,
                Factory_Amender = txtAmender.Text,
                Factory_ModdifyDate = Convert.ToDateTime(txtModdifyDate.Text),
                Factory_Explain = txtExplain.Text
            };

            FactoryService service = new FactoryService();
            if (bRegOrUp)
            {

            }
        }

        private void FactoryPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FactoryPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
