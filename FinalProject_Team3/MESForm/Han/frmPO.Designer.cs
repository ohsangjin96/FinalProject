
namespace MESForm.Han
{
    partial class frmPO
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new MESForm.UserControls.DateTimePicker();
            this.btnDPCreate = new MESForm.CustomControls.custButtonControl();
            this.btnReg = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.dgvPO = new MESForm.CustomControls.custDataGridViewControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.chkPlanDate = new System.Windows.Forms.CheckBox();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.chkPlanDate);
            this.pnlSelect.Controls.Add(this.dtpOrder);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.dateTimePicker1);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.cboCompany);
            this.pnlSelect.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSelect.Size = new System.Drawing.Size(1226, 97);
            this.pnlSelect.Controls.SetChildIndex(this.cboCompany, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dtpOrder, 0);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.chkPlanDate, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, 51);
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 137);
            this.lblFormName1.Size = new System.Drawing.Size(95, 21);
            this.lblFormName1.Text = "영업마스터";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvPO);
            this.pnlItem.Location = new System.Drawing.Point(12, 161);
            this.pnlItem.Size = new System.Drawing.Size(1226, 526);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnDPCreate);
            this.panel1.Location = new System.Drawing.Point(763, 117);
            this.panel1.Size = new System.Drawing.Size(475, 41);
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(543, 32);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(191, 22);
            this.cboCompany.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(443, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "고객사";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "납기일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2021, 2, 16, 13, 55, 9, 300);
            this.dateTimePicker1.DtpTo = new System.DateTime(2021, 2, 16, 13, 55, 9, 300);
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnDPCreate
            // 
            this.btnDPCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDPCreate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnDPCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDPCreate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDPCreate.ForeColor = System.Drawing.Color.Black;
            this.btnDPCreate.Location = new System.Drawing.Point(70, 6);
            this.btnDPCreate.Name = "btnDPCreate";
            this.btnDPCreate.Size = new System.Drawing.Size(120, 32);
            this.btnDPCreate.TabIndex = 0;
            this.btnDPCreate.Text = "수요계획생성";
            this.btnDPCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDPCreate.UseVisualStyleBackColor = false;
            this.btnDPCreate.Click += new System.EventHandler(this.btnDPCreate_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(196, 6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(83, 32);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "등록";
            this.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(285, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(374, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvPO
            // 
            this.dgvPO.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPO.BackgroundColor = System.Drawing.Color.White;
            this.dgvPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPO.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPO.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvPO.Location = new System.Drawing.Point(0, 0);
            this.dgvPO.Name = "dgvPO";
            this.dgvPO.RowTemplate.Height = 23;
            this.dgvPO.Size = new System.Drawing.Size(1226, 526);
            this.dgvPO.TabIndex = 0;
            this.dgvPO.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDataGridViewControl1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(836, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "등록일";
            // 
            // dtpOrder
            // 
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(936, 32);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(191, 22);
            this.dtpOrder.TabIndex = 23;
            // 
            // chkPlanDate
            // 
            this.chkPlanDate.AutoSize = true;
            this.chkPlanDate.Location = new System.Drawing.Point(915, 37);
            this.chkPlanDate.Name = "chkPlanDate";
            this.chkPlanDate.Size = new System.Drawing.Size(15, 14);
            this.chkPlanDate.TabIndex = 24;
            this.chkPlanDate.UseVisualStyleBackColor = true;
            this.chkPlanDate.CheckedChanged += new System.EventHandler(this.chkPlanDate_CheckedChanged);
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmPO";
            this.Text = "영업마스터";
            this.Load += new System.EventHandler(this.frmPO_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCompany;
        protected System.Windows.Forms.Label label3;
        private UserControls.DateTimePicker dateTimePicker1;
        private CustomControls.custButtonControl btnRefresh;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl btnDPCreate;
        private CustomControls.custDataGridViewControl dgvPO;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPlanDate;
    }
}

