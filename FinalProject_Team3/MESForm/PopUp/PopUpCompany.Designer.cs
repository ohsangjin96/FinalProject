
namespace MESForm.PopUp
{
    partial class PopUpCompany
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtModdifyDate = new System.Windows.Forms.TextBox();
            this.txtAmender = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.cboCompanyUse = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompanyConditions = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCompanyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChargeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompanyCategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCEOName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCompanyRegNum = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(794, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Text = "업체정보";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(398, 438);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(322, 438);
            this.btnSave.TabIndex = 18;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label19);
            this.pnl.Controls.Add(this.txtCompanyRegNum);
            this.pnl.Controls.Add(this.dtpEndDate);
            this.pnl.Controls.Add(this.dtpStartDate);
            this.pnl.Controls.Add(this.txtModdifyDate);
            this.pnl.Controls.Add(this.txtAmender);
            this.pnl.Controls.Add(this.txtTelNumber);
            this.pnl.Controls.Add(this.txtEmail);
            this.pnl.Controls.Add(this.cboWarehouse);
            this.pnl.Controls.Add(this.cboCompanyUse);
            this.pnl.Controls.Add(this.label18);
            this.pnl.Controls.Add(this.label17);
            this.pnl.Controls.Add(this.label16);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.txtCompanyConditions);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.txtCompanyName);
            this.pnl.Controls.Add(this.txtCompanyCode);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cboCompanyType);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtCompanyInfo);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.txtChargeName);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.txtFaxNumber);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.txtCompanyCategory);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.txtCEOName);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(770, 386);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(754, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(609, 165);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(140, 22);
            this.dtpEndDate.TabIndex = 14;
            this.dtpEndDate.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(362, 168);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(140, 22);
            this.dtpStartDate.TabIndex = 13;
            // 
            // txtModdifyDate
            // 
            this.txtModdifyDate.Enabled = false;
            this.txtModdifyDate.Location = new System.Drawing.Point(362, 205);
            this.txtModdifyDate.Name = "txtModdifyDate";
            this.txtModdifyDate.Size = new System.Drawing.Size(140, 22);
            this.txtModdifyDate.TabIndex = 16;
            // 
            // txtAmender
            // 
            this.txtAmender.Enabled = false;
            this.txtAmender.Location = new System.Drawing.Point(115, 205);
            this.txtAmender.Name = "txtAmender";
            this.txtAmender.Size = new System.Drawing.Size(140, 22);
            this.txtAmender.TabIndex = 15;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(115, 131);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(140, 22);
            this.txtTelNumber.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(609, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(115, 168);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(140, 22);
            this.cboWarehouse.TabIndex = 12;
            // 
            // cboCompanyUse
            // 
            this.cboCompanyUse.FormattingEnabled = true;
            this.cboCompanyUse.Location = new System.Drawing.Point(609, 130);
            this.cboCompanyUse.Name = "cboCompanyUse";
            this.cboCompanyUse.Size = new System.Drawing.Size(140, 22);
            this.cboCompanyUse.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 14);
            this.label18.TabIndex = 107;
            this.label18.Text = "수정날짜";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(271, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 106;
            this.label17.Text = "거래시작일";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 14);
            this.label16.TabIndex = 105;
            this.label16.Text = "수정자";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(518, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 104;
            this.label15.Text = "거래종료일";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(24, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 103;
            this.label13.Text = "창고유무";
            // 
            // txtCompanyConditions
            // 
            this.txtCompanyConditions.Location = new System.Drawing.Point(115, 95);
            this.txtCompanyConditions.Name = "txtCompanyConditions";
            this.txtCompanyConditions.Size = new System.Drawing.Size(140, 22);
            this.txtCompanyConditions.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 101;
            this.label12.Text = "전화번호";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(362, 20);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(140, 22);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(115, 20);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(140, 22);
            this.txtCompanyCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 98;
            this.label2.Text = "업체코드";
            // 
            // cboCompanyType
            // 
            this.cboCompanyType.FormattingEnabled = true;
            this.cboCompanyType.Location = new System.Drawing.Point(609, 20);
            this.cboCompanyType.Name = "cboCompanyType";
            this.cboCompanyType.Size = new System.Drawing.Size(140, 22);
            this.cboCompanyType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 82;
            this.label3.Text = "대표자명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 83;
            this.label4.Text = "담당자명";
            // 
            // txtCompanyInfo
            // 
            this.txtCompanyInfo.Location = new System.Drawing.Point(115, 241);
            this.txtCompanyInfo.Multiline = true;
            this.txtCompanyInfo.Name = "txtCompanyInfo";
            this.txtCompanyInfo.Size = new System.Drawing.Size(634, 128);
            this.txtCompanyInfo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 84;
            this.label5.Text = "팩스";
            // 
            // txtChargeName
            // 
            this.txtChargeName.Location = new System.Drawing.Point(362, 95);
            this.txtChargeName.Name = "txtChargeName";
            this.txtChargeName.Size = new System.Drawing.Size(140, 22);
            this.txtChargeName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(271, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 85;
            this.label6.Text = "업체명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 86;
            this.label7.Text = "업종";
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(362, 130);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(140, 22);
            this.txtFaxNumber.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "이메일";
            // 
            // txtCompanyCategory
            // 
            this.txtCompanyCategory.Location = new System.Drawing.Point(609, 58);
            this.txtCompanyCategory.Name = "txtCompanyCategory";
            this.txtCompanyCategory.Size = new System.Drawing.Size(140, 22);
            this.txtCompanyCategory.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(518, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 88;
            this.label9.Text = "사용유무";
            // 
            // txtCEOName
            // 
            this.txtCEOName.Location = new System.Drawing.Point(115, 57);
            this.txtCEOName.Name = "txtCEOName";
            this.txtCEOName.Size = new System.Drawing.Size(140, 22);
            this.txtCEOName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(518, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 89;
            this.label10.Text = "업체유형";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 90;
            this.label11.Text = "업태";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 91;
            this.label14.Text = "업체정보";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(271, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 14);
            this.label19.TabIndex = 116;
            this.label19.Text = "사업자등록번호";
            // 
            // txtCompanyRegNum
            // 
            this.txtCompanyRegNum.Location = new System.Drawing.Point(362, 57);
            this.txtCompanyRegNum.Name = "txtCompanyRegNum";
            this.txtCompanyRegNum.Size = new System.Drawing.Size(140, 22);
            this.txtCompanyRegNum.TabIndex = 4;
            // 
            // PopUpCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(794, 482);
            this.Name = "PopUpCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpCompany_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtModdifyDate;
        private System.Windows.Forms.TextBox txtAmender;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.ComboBox cboCompanyUse;
        private System.Windows.Forms.TextBox txtCompanyConditions;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private System.Windows.Forms.ComboBox cboCompanyType;
        private System.Windows.Forms.TextBox txtChargeName;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.TextBox txtCompanyCategory;
        private System.Windows.Forms.TextBox txtCEOName;
        private System.Windows.Forms.TextBox txtCompanyRegNum;
        private System.Windows.Forms.TextBox txtCompanyInfo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
    }
}
