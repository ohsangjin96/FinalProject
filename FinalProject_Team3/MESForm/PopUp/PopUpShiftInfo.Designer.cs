namespace MESForm
{
    partial class PopUpShiftInfo
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
            this.label7 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpApplyEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModifierDAte = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.dtpApplyStart = new System.Windows.Forms.DateTimePicker();
            this.txtCompleteDate = new System.Windows.Forms.TextBox();
            this.cboFacCode = new System.Windows.Forms.ComboBox();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(604, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.Text = "Shift";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(305, 424);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(229, 424);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.numPeople);
            this.pnl.Controls.Add(this.txtFacName);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.label55);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.txtModifier);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.dtpApplyEnd);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.txtModifierDAte);
            this.pnl.Controls.Add(this.label16);
            this.pnl.Controls.Add(this.txtRemark);
            this.pnl.Controls.Add(this.label17);
            this.pnl.Controls.Add(this.cboUse);
            this.pnl.Controls.Add(this.txtStartDate);
            this.pnl.Controls.Add(this.cboShift);
            this.pnl.Controls.Add(this.dtpApplyStart);
            this.pnl.Controls.Add(this.txtCompleteDate);
            this.pnl.Controls.Add(this.cboFacCode);
            this.pnl.Size = new System.Drawing.Size(580, 372);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(564, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 187;
            this.label7.Text = "설비코드";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label55.Location = new System.Drawing.Point(10, 183);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 14);
            this.label55.TabIndex = 181;
            this.label55.Text = "사용유무";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(303, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 182;
            this.label2.Text = "적용완료일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(303, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 183;
            this.label3.Text = "완료시간";
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifier.Location = new System.Drawing.Point(107, 228);
            this.txtModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.Size = new System.Drawing.Size(168, 22);
            this.txtModifier.TabIndex = 222;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 184;
            this.label4.Text = "Shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 185;
            this.label5.Text = "적용시작일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 186;
            this.label6.Text = "시작시간";
            // 
            // dtpApplyEnd
            // 
            this.dtpApplyEnd.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpApplyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApplyEnd.Location = new System.Drawing.Point(400, 135);
            this.dtpApplyEnd.Name = "dtpApplyEnd";
            this.dtpApplyEnd.Size = new System.Drawing.Size(168, 22);
            this.dtpApplyEnd.TabIndex = 217;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 189;
            this.label9.Text = "수정자";
            // 
            // txtModifierDAte
            // 
            this.txtModifierDAte.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifierDAte.Location = new System.Drawing.Point(400, 180);
            this.txtModifierDAte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifierDAte.Name = "txtModifierDAte";
            this.txtModifierDAte.Size = new System.Drawing.Size(168, 22);
            this.txtModifierDAte.TabIndex = 216;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 14);
            this.label16.TabIndex = 196;
            this.label16.Text = "비고";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtRemark.Location = new System.Drawing.Point(107, 279);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(460, 80);
            this.txtRemark.TabIndex = 209;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(303, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 14);
            this.label17.TabIndex = 197;
            this.label17.Text = "수정일";
            // 
            // cboUse
            // 
            this.cboUse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(107, 180);
            this.cboUse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(168, 22);
            this.cboUse.TabIndex = 208;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtStartDate.Location = new System.Drawing.Point(107, 93);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(168, 22);
            this.txtStartDate.TabIndex = 207;
            // 
            // cboShift
            // 
            this.cboShift.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(107, 56);
            this.cboShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(168, 22);
            this.cboShift.TabIndex = 205;
            // 
            // dtpApplyStart
            // 
            this.dtpApplyStart.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpApplyStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApplyStart.Location = new System.Drawing.Point(107, 132);
            this.dtpApplyStart.Name = "dtpApplyStart";
            this.dtpApplyStart.Size = new System.Drawing.Size(168, 22);
            this.dtpApplyStart.TabIndex = 204;
            // 
            // txtCompleteDate
            // 
            this.txtCompleteDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtCompleteDate.Location = new System.Drawing.Point(399, 93);
            this.txtCompleteDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompleteDate.Name = "txtCompleteDate";
            this.txtCompleteDate.Size = new System.Drawing.Size(168, 22);
            this.txtCompleteDate.TabIndex = 202;
            // 
            // cboFacCode
            // 
            this.cboFacCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboFacCode.FormattingEnabled = true;
            this.cboFacCode.Location = new System.Drawing.Point(107, 15);
            this.cboFacCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFacCode.Name = "cboFacCode";
            this.cboFacCode.Size = new System.Drawing.Size(168, 22);
            this.cboFacCode.TabIndex = 203;
            this.cboFacCode.SelectedIndexChanged += new System.EventHandler(this.cboFacCode_SelectedIndexChanged);
            // 
            // txtFacName
            // 
            this.txtFacName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtFacName.Location = new System.Drawing.Point(400, 15);
            this.txtFacName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.ReadOnly = true;
            this.txtFacName.Size = new System.Drawing.Size(168, 22);
            this.txtFacName.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(303, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 223;
            this.label8.Text = "설비명";
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(401, 56);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(167, 22);
            this.numPeople.TabIndex = 225;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(303, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 226;
            this.label10.Text = "투입인원";
            // 
            // PopUpShiftInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(604, 472);
            this.Name = "PopUpShiftInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.PopUpShiftInfo_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpApplyEnd;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModifierDAte;
        protected System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboUse;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.DateTimePicker dtpApplyStart;
        private System.Windows.Forms.TextBox txtCompleteDate;
        private System.Windows.Forms.ComboBox cboFacCode;
        private System.Windows.Forms.TextBox txtFacName;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPeople;
    }
}
