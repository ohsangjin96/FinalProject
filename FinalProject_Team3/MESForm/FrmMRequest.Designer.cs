namespace MESForm
{
    partial class FrmMRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel1 = new MESForm.CustomControls.custButtonControl();
            this.txtWOID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cboFacility = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new MESForm.UserControls.DateTimePicker();
            this.custButtonControl1 = new MESForm.CustomControls.custButtonControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.custButtonControl4 = new MESForm.CustomControls.custButtonControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvList1 = new MESForm.CustomControls.custDataGridViewControl();
            this.dgvList2 = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.dateTimePicker1);
            this.pnlSelect.Controls.Add(this.txtWOID);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.txtItem);
            this.pnlSelect.Controls.Add(this.cboFacility);
            this.pnlSelect.Controls.Add(this.label9);
            this.pnlSelect.Controls.Add(this.label6);
            this.pnlSelect.Size = new System.Drawing.Size(1226, 89);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label6, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label9, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboFacility, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtItem, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtWOID, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dateTimePicker1, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, 43);
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(18, 113);
            this.lblFormName1.Size = new System.Drawing.Size(112, 21);
            this.lblFormName1.Text = "작업지시조회";
            // 
            // pnlItem
            // 
            this.pnlItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItem.Controls.Add(this.dgvList1);
            this.pnlItem.Location = new System.Drawing.Point(12, 150);
            this.pnlItem.Size = new System.Drawing.Size(1226, 350);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.custButtonControl1);
            this.panel1.Controls.Add(this.btnExcel1);
            this.panel1.Location = new System.Drawing.Point(532, 109);
            this.panel1.Size = new System.Drawing.Size(10, 15);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "자재불출";
            // 
            // btnExcel1
            // 
            this.btnExcel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel1.ForeColor = System.Drawing.Color.Black;
            this.btnExcel1.Location = new System.Drawing.Point(-165, 4);
            this.btnExcel1.Name = "btnExcel1";
            this.btnExcel1.Size = new System.Drawing.Size(83, 32);
            this.btnExcel1.TabIndex = 5;
            this.btnExcel1.Text = "엑셀";
            this.btnExcel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel1.UseVisualStyleBackColor = false;
            // 
            // txtWOID
            // 
            this.txtWOID.Location = new System.Drawing.Point(915, 14);
            this.txtWOID.Name = "txtWOID";
            this.txtWOID.Size = new System.Drawing.Size(191, 22);
            this.txtWOID.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "시작일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(442, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "품목";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(542, 14);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(191, 22);
            this.txtItem.TabIndex = 30;
            // 
            // cboFacility
            // 
            this.cboFacility.FormattingEnabled = true;
            this.cboFacility.Location = new System.Drawing.Point(125, 52);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.Size = new System.Drawing.Size(191, 22);
            this.cboFacility.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(29, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "설비";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(815, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "작업지시ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2021, 2, 15, 14, 17, 50, 893);
            this.dateTimePicker1.DtpTo = new System.DateTime(2021, 2, 15, 14, 17, 50, 893);
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // custButtonControl1
            // 
            this.custButtonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custButtonControl1.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl1.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl1.Location = new System.Drawing.Point(-76, 4);
            this.custButtonControl1.Name = "custButtonControl1";
            this.custButtonControl1.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl1.TabIndex = 8;
            this.custButtonControl1.Text = "추가";
            this.custButtonControl1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnExcel);
            this.panel4.Location = new System.Drawing.Point(971, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 41);
            this.panel4.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(95, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "저장";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(184, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.custButtonControl4);
            this.panel3.Location = new System.Drawing.Point(971, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 41);
            this.panel3.TabIndex = 24;
            // 
            // custButtonControl4
            // 
            this.custButtonControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl4.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl4.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl4.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl4.Location = new System.Drawing.Point(184, 3);
            this.custButtonControl4.Name = "custButtonControl4";
            this.custButtonControl4.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl4.TabIndex = 15;
            this.custButtonControl4.Text = "엑셀";
            this.custButtonControl4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl4.UseVisualStyleBackColor = false;
            this.custButtonControl4.Click += new System.EventHandler(this.custButtonControl4_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvList2);
            this.panel2.Location = new System.Drawing.Point(12, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 133);
            this.panel2.TabIndex = 0;
            // 
            // dgvList1
            // 
            this.dgvList1.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvList1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList1.BackgroundColor = System.Drawing.Color.White;
            this.dgvList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvList1.Location = new System.Drawing.Point(0, 0);
            this.dgvList1.Name = "dgvList1";
            this.dgvList1.RowTemplate.Height = 23;
            this.dgvList1.Size = new System.Drawing.Size(1226, 350);
            this.dgvList1.TabIndex = 0;
            this.dgvList1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList1_CellDoubleClick);
            // 
            // dgvList2
            // 
            this.dgvList2.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvList2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvList2.BackgroundColor = System.Drawing.Color.White;
            this.dgvList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList2.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvList2.Location = new System.Drawing.Point(0, 0);
            this.dgvList2.Name = "dgvList2";
            this.dgvList2.RowTemplate.Height = 23;
            this.dgvList2.Size = new System.Drawing.Size(1226, 133);
            this.dgvList2.TabIndex = 0;
            // 
            // FrmMRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FrmMRequest";
            this.Load += new System.EventHandler(this.FrmMRequest_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlItem, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.lblFormName1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        private CustomControls.custButtonControl btnExcel1;
        private System.Windows.Forms.TextBox txtWOID;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cboFacility;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label6;
        private UserControls.DateTimePicker dateTimePicker1;
        private CustomControls.custButtonControl custButtonControl1;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.custButtonControl btnSave;
        private CustomControls.custButtonControl btnExcel;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.custButtonControl custButtonControl4;
        private CustomControls.custDataGridViewControl dgvList1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.custDataGridViewControl dgvList2;
    }
}
