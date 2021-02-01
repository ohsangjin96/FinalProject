namespace MESForm
{
    partial class popUpMaterialCost
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtModifyDate = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtBeginCost = new System.Windows.Forms.TextBox();
            this.txtIngCost = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(549, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.Text = "자재단가등록";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(277, 423);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(201, 423);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cboUse);
            this.pnl.Controls.Add(this.dtpEnd);
            this.pnl.Controls.Add(this.txtIngCost);
            this.pnl.Controls.Add(this.txtBeginCost);
            this.pnl.Controls.Add(this.dtpStart);
            this.pnl.Controls.Add(this.cboItem);
            this.pnl.Controls.Add(this.cboCompany);
            this.pnl.Controls.Add(this.txtRemark);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label39);
            this.pnl.Controls.Add(this.txtModifyDate);
            this.pnl.Controls.Add(this.label41);
            this.pnl.Controls.Add(this.label42);
            this.pnl.Controls.Add(this.txtModifier);
            this.pnl.Controls.Add(this.label45);
            this.pnl.Controls.Add(this.label46);
            this.pnl.Controls.Add(this.label47);
            this.pnl.Controls.Add(this.label48);
            this.pnl.Controls.Add(this.label54);
            this.pnl.Controls.Add(this.label55);
            this.pnl.Size = new System.Drawing.Size(525, 371);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(509, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(109, 107);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(138, 22);
            this.dtpStart.TabIndex = 230;
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(369, 12);
            this.cboItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(138, 22);
            this.cboItem.TabIndex = 229;
            // 
            // cboCompany
            // 
            this.cboCompany.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(111, 13);
            this.cboCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(138, 22);
            this.cboCompany.TabIndex = 228;
            this.cboCompany.SelectedIndexChanged += new System.EventHandler(this.cboCompany_SelectedIndexChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtRemark.Location = new System.Drawing.Point(109, 243);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(398, 120);
            this.txtRemark.TabIndex = 226;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 225;
            this.label2.Text = "비고";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(277, 153);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(43, 14);
            this.label39.TabIndex = 224;
            this.label39.Text = "수정일";
            // 
            // txtModifyDate
            // 
            this.txtModifyDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifyDate.Location = new System.Drawing.Point(369, 153);
            this.txtModifyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifyDate.Name = "txtModifyDate";
            this.txtModifyDate.ReadOnly = true;
            this.txtModifyDate.Size = new System.Drawing.Size(138, 22);
            this.txtModifyDate.TabIndex = 223;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(22, 207);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(55, 14);
            this.label41.TabIndex = 222;
            this.label41.Text = "사용유무";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(22, 159);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 14);
            this.label42.TabIndex = 221;
            this.label42.Text = "수정자";
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifier.Location = new System.Drawing.Point(111, 154);
            this.txtModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.ReadOnly = true;
            this.txtModifier.Size = new System.Drawing.Size(138, 22);
            this.txtModifier.TabIndex = 220;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label45.Location = new System.Drawing.Point(22, 111);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(43, 14);
            this.label45.TabIndex = 219;
            this.label45.Text = "시작일";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(277, 107);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(43, 14);
            this.label46.TabIndex = 217;
            this.label46.Text = "종료일";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label47.Location = new System.Drawing.Point(18, 63);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(55, 14);
            this.label47.TabIndex = 215;
            this.label47.Text = "현재단가";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label48.Location = new System.Drawing.Point(277, 61);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(55, 14);
            this.label48.TabIndex = 214;
            this.label48.Text = "이전단가";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label54.Location = new System.Drawing.Point(277, 15);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(31, 14);
            this.label54.TabIndex = 210;
            this.label54.Text = "품목";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label55.Location = new System.Drawing.Point(18, 15);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 14);
            this.label55.TabIndex = 209;
            this.label55.Text = "업체";
            // 
            // txtBeginCost
            // 
            this.txtBeginCost.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtBeginCost.Location = new System.Drawing.Point(369, 59);
            this.txtBeginCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBeginCost.Name = "txtBeginCost";
            this.txtBeginCost.Size = new System.Drawing.Size(138, 22);
            this.txtBeginCost.TabIndex = 231;
            // 
            // txtIngCost
            // 
            this.txtIngCost.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtIngCost.Location = new System.Drawing.Point(109, 60);
            this.txtIngCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIngCost.Name = "txtIngCost";
            this.txtIngCost.Size = new System.Drawing.Size(138, 22);
            this.txtIngCost.TabIndex = 232;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(369, 106);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(138, 22);
            this.dtpEnd.TabIndex = 233;
            // 
            // cboUse
            // 
            this.cboUse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(111, 201);
            this.cboUse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(138, 22);
            this.cboUse.TabIndex = 234;
            // 
            // popUpMaterialCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(549, 471);
            this.Name = "popUpMaterialCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.popUpMaterialCost_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtModifyDate;
        protected System.Windows.Forms.Label label41;
        protected System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtModifier;
        protected System.Windows.Forms.Label label45;
        protected System.Windows.Forms.Label label46;
        protected System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox cboUse;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtIngCost;
        private System.Windows.Forms.TextBox txtBeginCost;
    }
}
