
namespace MESForm.PopUp
{
    partial class PopUpCommonCode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboInsert = new System.Windows.Forms.GroupBox();
            this.cboParentCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.nudSeq = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCodeVal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvCommonCode = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.gboInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(515, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.Text = "공통코드 관리";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(264, 260);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(188, 260);
            this.btnSave.TabIndex = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dgvCommonCode);
            this.pnl.Location = new System.Drawing.Point(12, 308);
            this.pnl.Size = new System.Drawing.Size(491, 329);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(475, 0);
            // 
            // gboInsert
            // 
            this.gboInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboInsert.Controls.Add(this.cboParentCode);
            this.gboInsert.Controls.Add(this.label6);
            this.gboInsert.Controls.Add(this.txtCodeName);
            this.gboInsert.Controls.Add(this.nudSeq);
            this.gboInsert.Controls.Add(this.label9);
            this.gboInsert.Controls.Add(this.btnCodeVal);
            this.gboInsert.Controls.Add(this.label8);
            this.gboInsert.Controls.Add(this.txtCode);
            this.gboInsert.Controls.Add(this.label7);
            this.gboInsert.Location = new System.Drawing.Point(12, 82);
            this.gboInsert.Name = "gboInsert";
            this.gboInsert.Size = new System.Drawing.Size(491, 172);
            this.gboInsert.TabIndex = 78;
            this.gboInsert.TabStop = false;
            // 
            // cboParentCode
            // 
            this.cboParentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParentCode.FormattingEnabled = true;
            this.cboParentCode.Location = new System.Drawing.Point(161, 100);
            this.cboParentCode.Name = "cboParentCode";
            this.cboParentCode.Size = new System.Drawing.Size(173, 22);
            this.cboParentCode.TabIndex = 6;
            this.cboParentCode.SelectedIndexChanged += new System.EventHandler(this.cboParentCode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(70, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 52;
            this.label6.Text = "코드";
            // 
            // txtCodeName
            // 
            this.txtCodeName.Location = new System.Drawing.Point(161, 61);
            this.txtCodeName.MaxLength = 20;
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.Size = new System.Drawing.Size(173, 22);
            this.txtCodeName.TabIndex = 5;
            // 
            // nudSeq
            // 
            this.nudSeq.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudSeq.Location = new System.Drawing.Point(161, 139);
            this.nudSeq.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSeq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeq.Name = "nudSeq";
            this.nudSeq.Size = new System.Drawing.Size(68, 22);
            this.nudSeq.TabIndex = 7;
            this.nudSeq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(70, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 32;
            this.label9.Text = "순서";
            // 
            // btnCodeVal
            // 
            this.btnCodeVal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCodeVal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCodeVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodeVal.ForeColor = System.Drawing.Color.White;
            this.btnCodeVal.Location = new System.Drawing.Point(359, 23);
            this.btnCodeVal.Name = "btnCodeVal";
            this.btnCodeVal.Size = new System.Drawing.Size(70, 25);
            this.btnCodeVal.TabIndex = 4;
            this.btnCodeVal.Text = "중복확인";
            this.btnCodeVal.UseVisualStyleBackColor = false;
            this.btnCodeVal.Click += new System.EventHandler(this.btnCodeVal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "상위코드";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(161, 24);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(173, 22);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(70, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "코드명";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(428, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.Location = new System.Drawing.Point(266, 51);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 25);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(347, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvCommonCode
            // 
            this.dgvCommonCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommonCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommonCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommonCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommonCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvCommonCode.Location = new System.Drawing.Point(0, 0);
            this.dgvCommonCode.Name = "dgvCommonCode";
            this.dgvCommonCode.RowTemplate.Height = 23;
            this.dgvCommonCode.Size = new System.Drawing.Size(491, 329);
            this.dgvCommonCode.TabIndex = 0;
            this.dgvCommonCode.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommonCode_CellDoubleClick);
            // 
            // PopUpCommonCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(515, 649);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gboInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReg);
            this.Name = "PopUpCommonCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "CommonCodePopUp";
            this.Load += new System.EventHandler(this.CommonCodePopUp_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnReg, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gboInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.gboInsert.ResumeLayout(false);
            this.gboInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboInsert;
        private System.Windows.Forms.ComboBox cboParentCode;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtCodeName;
        private System.Windows.Forms.NumericUpDown nudSeq;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Button btnCodeVal;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.Button btnReg;
        protected System.Windows.Forms.Button btnUpdate;
        private CustomControls.custDataGridViewControl dgvCommonCode;
    }
}
