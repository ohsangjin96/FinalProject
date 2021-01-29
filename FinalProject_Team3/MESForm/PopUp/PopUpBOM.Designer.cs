namespace MESForm
{
    partial class PopUpBOM
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
            this.label55 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModifiDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboParent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboAuto = new System.Windows.Forms.ComboBox();
            this.numSpend = new System.Windows.Forms.NumericUpDown();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(536, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.Text = "BOM";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(271, 497);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(195, 497);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.numLevel);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.txtItemName);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.numSpend);
            this.pnl.Controls.Add(this.label55);
            this.pnl.Controls.Add(this.txtNote);
            this.pnl.Controls.Add(this.label45);
            this.pnl.Controls.Add(this.dtpEndDate);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.dtpStartDate);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtModifier);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.txtModifiDay);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.cboParent);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.cboItemCode);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.cboUseYN);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.cboPlan);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.cboAuto);
            this.pnl.Size = new System.Drawing.Size(512, 445);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(496, 0);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label55.Location = new System.Drawing.Point(13, 27);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 14);
            this.label55.TabIndex = 163;
            this.label55.Text = "상위품명";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtNote.Location = new System.Drawing.Point(82, 314);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(407, 119);
            this.txtNote.TabIndex = 184;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(262, 172);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(43, 14);
            this.label45.TabIndex = 164;
            this.label45.Text = "수정자";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(331, 121);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(161, 22);
            this.dtpEndDate.TabIndex = 183;
            this.dtpEndDate.Value = new System.DateTime(9998, 1, 1, 23, 41, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 165;
            this.label2.Text = "소요계획";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(82, 121);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(161, 22);
            this.dtpStartDate.TabIndex = 182;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 166;
            this.label3.Text = "사용유무";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 167;
            this.label4.Text = "시작일";
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifier.Location = new System.Drawing.Point(331, 172);
            this.txtModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.ReadOnly = true;
            this.txtModifier.Size = new System.Drawing.Size(161, 22);
            this.txtModifier.TabIndex = 180;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(262, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 168;
            this.label5.Text = "자동차감";
            // 
            // txtModifiDay
            // 
            this.txtModifiDay.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifiDay.Location = new System.Drawing.Point(82, 219);
            this.txtModifiDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifiDay.Name = "txtModifiDay";
            this.txtModifiDay.ReadOnly = true;
            this.txtModifiDay.Size = new System.Drawing.Size(161, 22);
            this.txtModifiDay.TabIndex = 179;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(262, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 169;
            this.label6.Text = "품목";
            // 
            // cboParent
            // 
            this.cboParent.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboParent.FormattingEnabled = true;
            this.cboParent.Location = new System.Drawing.Point(82, 27);
            this.cboParent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParent.Name = "cboParent";
            this.cboParent.Size = new System.Drawing.Size(161, 22);
            this.cboParent.TabIndex = 178;
            this.cboParent.SelectedIndexChanged += new System.EventHandler(this.cboParent_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(262, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 170;
            this.label7.Text = "종료일";
            // 
            // cboItemCode
            // 
            this.cboItemCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(331, 27);
            this.cboItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(161, 22);
            this.cboItemCode.TabIndex = 177;
            this.cboItemCode.SelectedIndexChanged += new System.EventHandler(this.cboItemCode_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(262, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 171;
            this.label8.Text = "소요량";
            // 
            // cboUseYN
            // 
            this.cboUseYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(82, 172);
            this.cboUseYN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(161, 22);
            this.cboUseYN.TabIndex = 176;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 172;
            this.label9.Text = "수정일";
            // 
            // cboPlan
            // 
            this.cboPlan.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(82, 267);
            this.cboPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(161, 22);
            this.cboPlan.TabIndex = 175;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 173;
            this.label10.Text = "비고";
            // 
            // cboAuto
            // 
            this.cboAuto.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboAuto.FormattingEnabled = true;
            this.cboAuto.Location = new System.Drawing.Point(331, 219);
            this.cboAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboAuto.Name = "cboAuto";
            this.cboAuto.Size = new System.Drawing.Size(161, 22);
            this.cboAuto.TabIndex = 174;
            // 
            // numSpend
            // 
            this.numSpend.Location = new System.Drawing.Point(331, 77);
            this.numSpend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpend.Name = "numSpend";
            this.numSpend.Size = new System.Drawing.Size(161, 22);
            this.numSpend.TabIndex = 247;
            this.numSpend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtItemName.Location = new System.Drawing.Point(82, 76);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(161, 22);
            this.txtItemName.TabIndex = 249;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 248;
            this.label11.Text = "품명";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(262, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 14);
            this.label12.TabIndex = 250;
            this.label12.Text = "Level";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(331, 273);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.ReadOnly = true;
            this.numLevel.Size = new System.Drawing.Size(161, 22);
            this.numLevel.TabIndex = 251;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PopUpBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(536, 545);
            this.Name = "PopUpBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpBOM_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtNote;
        protected System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModifiDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboParent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboItemCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUseYN;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPlan;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboAuto;
        private System.Windows.Forms.NumericUpDown numSpend;
        private System.Windows.Forms.TextBox txtItemName;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numLevel;
    }
}
