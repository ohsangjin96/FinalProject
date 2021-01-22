﻿using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm.PopUp
{
    public partial class PopUpCommonCode : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;

        bool bRegCheck = true;

        public PopUpCommonCode()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCommonCode);
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드", "Common_Code");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드명", "Common_Name");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "상위코드", "Common_Parent");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "순서", "Common_Seq");
        }

        private void CommonCodePopUp_Load(object sender, EventArgs e)
        {
            gboInsert.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            pnl.Location = gboInsert.Location;
            pnl.Size = new Size(446, 555);
            DgvSetting();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (bRegCheck)
            {
                gboInsert.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                pnl.Location = new Point(12, 308);
                pnl.Size = new Size(446, 329);
                bRegCheck = false;
            }
            else
            {
                //446, 306
                gboInsert.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                pnl.Location = gboInsert.Location;
                pnl.Size = new Size(446, 555);
                bRegCheck = true;
            }
        }

        private void CommonCodePopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void CommonCodePopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}