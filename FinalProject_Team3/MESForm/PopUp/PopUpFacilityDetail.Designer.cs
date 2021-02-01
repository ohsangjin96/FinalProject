
namespace MESForm.PopUp
{
    partial class PopUpFacilityDetail
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtModdifyDate = new System.Windows.Forms.TextBox();
            this.txtAmender = new System.Windows.Forms.TextBox();
            this.cboOutSourcing = new System.Windows.Forms.ComboBox();
            this.txtFacilityMES = new System.Windows.Forms.TextBox();
            this.cboFacilityUse = new System.Windows.Forms.ComboBox();
            this.cboPoor = new System.Windows.Forms.ComboBox();
            this.cboImported = new System.Windows.Forms.ComboBox();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFacilityCode = new System.Windows.Forms.TextBox();
            this.txtFacilitiesCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacilityComment = new System.Windows.Forms.TextBox();
            this.cboExhaustion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFacilityNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(785, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FacilityDetailPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FacilityDetailPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.Text = "설비";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FacilityDetailPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FacilityDetailPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(395, 524);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(319, 524);
            this.btnSave.TabIndex = 17;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtPort);
            this.pnl.Controls.Add(this.label17);
            this.pnl.Controls.Add(this.txtIP);
            this.pnl.Controls.Add(this.label16);
            this.pnl.Controls.Add(this.cboItemCode);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.txtModdifyDate);
            this.pnl.Controls.Add(this.txtAmender);
            this.pnl.Controls.Add(this.cboOutSourcing);
            this.pnl.Controls.Add(this.txtFacilityMES);
            this.pnl.Controls.Add(this.cboFacilityUse);
            this.pnl.Controls.Add(this.cboPoor);
            this.pnl.Controls.Add(this.cboImported);
            this.pnl.Controls.Add(this.txtFacilityName);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.txtFacilityCode);
            this.pnl.Controls.Add(this.txtFacilitiesCode);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.txtFacilityComment);
            this.pnl.Controls.Add(this.cboExhaustion);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtFacilityNote);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(761, 476);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(745, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            // 
            // txtModdifyDate
            // 
            this.txtModdifyDate.Enabled = false;
            this.txtModdifyDate.Location = new System.Drawing.Point(352, 161);
            this.txtModdifyDate.Name = "txtModdifyDate";
            this.txtModdifyDate.Size = new System.Drawing.Size(140, 22);
            this.txtModdifyDate.TabIndex = 14;
            // 
            // txtAmender
            // 
            this.txtAmender.Enabled = false;
            this.txtAmender.Location = new System.Drawing.Point(108, 161);
            this.txtAmender.Name = "txtAmender";
            this.txtAmender.Size = new System.Drawing.Size(140, 22);
            this.txtAmender.TabIndex = 13;
            // 
            // cboOutSourcing
            // 
            this.cboOutSourcing.FormattingEnabled = true;
            this.cboOutSourcing.Location = new System.Drawing.Point(596, 89);
            this.cboOutSourcing.Name = "cboOutSourcing";
            this.cboOutSourcing.Size = new System.Drawing.Size(140, 22);
            this.cboOutSourcing.TabIndex = 9;
            // 
            // txtFacilityMES
            // 
            this.txtFacilityMES.Location = new System.Drawing.Point(352, 88);
            this.txtFacilityMES.Name = "txtFacilityMES";
            this.txtFacilityMES.Size = new System.Drawing.Size(140, 22);
            this.txtFacilityMES.TabIndex = 8;
            // 
            // cboFacilityUse
            // 
            this.cboFacilityUse.FormattingEnabled = true;
            this.cboFacilityUse.Location = new System.Drawing.Point(108, 88);
            this.cboFacilityUse.Name = "cboFacilityUse";
            this.cboFacilityUse.Size = new System.Drawing.Size(140, 22);
            this.cboFacilityUse.TabIndex = 7;
            // 
            // cboPoor
            // 
            this.cboPoor.FormattingEnabled = true;
            this.cboPoor.Location = new System.Drawing.Point(596, 52);
            this.cboPoor.Name = "cboPoor";
            this.cboPoor.Size = new System.Drawing.Size(140, 22);
            this.cboPoor.TabIndex = 6;
            // 
            // cboImported
            // 
            this.cboImported.FormattingEnabled = true;
            this.cboImported.Location = new System.Drawing.Point(352, 52);
            this.cboImported.Name = "cboImported";
            this.cboImported.Size = new System.Drawing.Size(140, 22);
            this.cboImported.TabIndex = 5;
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Location = new System.Drawing.Point(596, 15);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(140, 22);
            this.txtFacilityName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(511, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 94;
            this.label12.Text = "외주여부";
            // 
            // txtFacilityCode
            // 
            this.txtFacilityCode.Location = new System.Drawing.Point(352, 14);
            this.txtFacilityCode.Name = "txtFacilityCode";
            this.txtFacilityCode.Size = new System.Drawing.Size(140, 22);
            this.txtFacilityCode.TabIndex = 1;
            // 
            // txtFacilitiesCode
            // 
            this.txtFacilitiesCode.Enabled = false;
            this.txtFacilitiesCode.Location = new System.Drawing.Point(108, 14);
            this.txtFacilitiesCode.Name = "txtFacilitiesCode";
            this.txtFacilitiesCode.Size = new System.Drawing.Size(140, 22);
            this.txtFacilitiesCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 91;
            this.label2.Text = "설비군코드";
            // 
            // txtFacilityComment
            // 
            this.txtFacilityComment.Location = new System.Drawing.Point(108, 331);
            this.txtFacilityComment.Multiline = true;
            this.txtFacilityComment.Name = "txtFacilityComment";
            this.txtFacilityComment.Size = new System.Drawing.Size(628, 119);
            this.txtFacilityComment.TabIndex = 16;
            // 
            // cboExhaustion
            // 
            this.cboExhaustion.FormattingEnabled = true;
            this.cboExhaustion.Location = new System.Drawing.Point(108, 52);
            this.cboExhaustion.Name = "cboExhaustion";
            this.cboExhaustion.Size = new System.Drawing.Size(140, 22);
            this.cboExhaustion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 77;
            this.label3.Text = "소진창고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 78;
            this.label4.Text = "사용유무";
            // 
            // txtFacilityNote
            // 
            this.txtFacilityNote.Location = new System.Drawing.Point(108, 197);
            this.txtFacilityNote.Multiline = true;
            this.txtFacilityNote.Name = "txtFacilityNote";
            this.txtFacilityNote.Size = new System.Drawing.Size(628, 128);
            this.txtFacilityNote.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 79;
            this.label5.Text = "수정자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(267, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 80;
            this.label6.Text = "설비코드";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(267, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 81;
            this.label7.Text = "양품창고";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 82;
            this.label8.Text = "MES설비";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 83;
            this.label9.Text = "수정날짜";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(511, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 84;
            this.label10.Text = "설비명";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 85;
            this.label11.Text = "불량창고";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 14);
            this.label15.TabIndex = 87;
            this.label15.Text = "비고";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 86;
            this.label14.Text = "특이사항";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 103;
            this.label13.Text = "제품코드";
            // 
            // cboItemCode
            // 
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(108, 125);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(140, 22);
            this.cboItemCode.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(352, 125);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 22);
            this.txtIP.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 14);
            this.label16.TabIndex = 105;
            this.label16.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(596, 125);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 22);
            this.txtPort.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(511, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 14);
            this.label17.TabIndex = 107;
            this.label17.Text = "Port";
            // 
            // PopUpFacilityDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(785, 576);
            this.Name = "PopUpFacilityDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpFacilityDetail_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TextBox txtModdifyDate;
        protected System.Windows.Forms.TextBox txtAmender;
        protected System.Windows.Forms.ComboBox cboOutSourcing;
        protected System.Windows.Forms.TextBox txtFacilityMES;
        protected System.Windows.Forms.ComboBox cboFacilityUse;
        protected System.Windows.Forms.ComboBox cboPoor;
        protected System.Windows.Forms.ComboBox cboImported;
        protected System.Windows.Forms.TextBox txtFacilityName;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox txtFacilityCode;
        protected System.Windows.Forms.TextBox txtFacilitiesCode;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtFacilityComment;
        protected System.Windows.Forms.ComboBox cboExhaustion;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtFacilityNote;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.ComboBox cboItemCode;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.TextBox txtPort;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.TextBox txtIP;
        protected System.Windows.Forms.Label label16;
    }
}
