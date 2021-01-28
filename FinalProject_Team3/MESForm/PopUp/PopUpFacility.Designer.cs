
namespace MESForm.PopUp
{
    partial class PopUpFacility
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
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModdifyDate = new System.Windows.Forms.TextBox();
            this.txtAmender = new System.Windows.Forms.TextBox();
            this.txtFacilitiesCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFacilitiesName = new System.Windows.Forms.TextBox();
            this.cboFacilitiesUse = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(341, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FacilityPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FacilityPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.Text = "설비군";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FacilityPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FacilityPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(173, 383);
            this.btnCancel.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(97, 383);
            this.btnSave.TabIndex = 6;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cboFacilitiesUse);
            this.pnl.Controls.Add(this.txtExplain);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.txtModdifyDate);
            this.pnl.Controls.Add(this.txtAmender);
            this.pnl.Controls.Add(this.txtFacilitiesCode);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.txtFacilitiesName);
            this.pnl.Size = new System.Drawing.Size(317, 336);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(301, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(31, 243);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(265, 84);
            this.txtExplain.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 79;
            this.label7.Text = "시설설명";
            // 
            // txtModdifyDate
            // 
            this.txtModdifyDate.Enabled = false;
            this.txtModdifyDate.Location = new System.Drawing.Point(146, 174);
            this.txtModdifyDate.Name = "txtModdifyDate";
            this.txtModdifyDate.Size = new System.Drawing.Size(150, 22);
            this.txtModdifyDate.TabIndex = 4;
            // 
            // txtAmender
            // 
            this.txtAmender.Enabled = false;
            this.txtAmender.Location = new System.Drawing.Point(146, 137);
            this.txtAmender.Name = "txtAmender";
            this.txtAmender.Size = new System.Drawing.Size(150, 22);
            this.txtAmender.TabIndex = 3;
            // 
            // txtFacilitiesCode
            // 
            this.txtFacilitiesCode.Location = new System.Drawing.Point(146, 24);
            this.txtFacilitiesCode.Name = "txtFacilitiesCode";
            this.txtFacilitiesCode.Size = new System.Drawing.Size(150, 22);
            this.txtFacilitiesCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 75;
            this.label2.Text = "설비군코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 69;
            this.label3.Text = "설비군명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "사용유무";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 71;
            this.label5.Text = "수정자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 72;
            this.label6.Text = "수정시간";
            // 
            // txtFacilitiesName
            // 
            this.txtFacilitiesName.Location = new System.Drawing.Point(146, 61);
            this.txtFacilitiesName.Name = "txtFacilitiesName";
            this.txtFacilitiesName.Size = new System.Drawing.Size(150, 22);
            this.txtFacilitiesName.TabIndex = 1;
            // 
            // cboFacilitiesUse
            // 
            this.cboFacilitiesUse.FormattingEnabled = true;
            this.cboFacilitiesUse.Location = new System.Drawing.Point(146, 99);
            this.cboFacilitiesUse.Name = "cboFacilitiesUse";
            this.cboFacilitiesUse.Size = new System.Drawing.Size(150, 22);
            this.cboFacilitiesUse.TabIndex = 2;
            // 
            // PopUpFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(341, 444);
            this.Name = "PopUpFacility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpFacility_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txtModdifyDate;
        protected System.Windows.Forms.TextBox txtAmender;
        protected System.Windows.Forms.TextBox txtFacilitiesCode;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtFacilitiesName;
        private System.Windows.Forms.ComboBox cboFacilitiesUse;
    }
}
