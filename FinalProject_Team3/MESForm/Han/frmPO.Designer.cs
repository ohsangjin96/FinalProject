
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboReorder = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new MESForm.UserControls.DateTimePicker();
            this.btnCreate = new MESForm.CustomControls.custButtonControl();
            this.btnReg = new MESForm.CustomControls.custButtonControl();
            this.btnMod = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.custDataGridViewControl1 = new MESForm.CustomControls.custDataGridViewControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.dateTimePicker1);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.cboReorder);
            this.pnlSelect.Controls.Add(this.label9);
            this.pnlSelect.Controls.Add(this.cboCompany);
            this.pnlSelect.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSelect.Size = new System.Drawing.Size(1226, 97);
            this.pnlSelect.Controls.SetChildIndex(this.cboCompany, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label9, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboReorder, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
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
            this.pnlItem.Controls.Add(this.custDataGridViewControl1);
            this.pnlItem.Location = new System.Drawing.Point(12, 161);
            this.pnlItem.Size = new System.Drawing.Size(1226, 526);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(708, 117);
            this.panel1.Size = new System.Drawing.Size(530, 41);
            // 
            // cboReorder
            // 
            this.cboReorder.FormattingEnabled = true;
            this.cboReorder.Location = new System.Drawing.Point(907, 33);
            this.cboReorder.Name = "cboReorder";
            this.cboReorder.Size = new System.Drawing.Size(191, 22);
            this.cboReorder.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(807, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "발주구분";
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(543, 33);
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
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "고객납기일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2021, 2, 3, 15, 17, 25, 647);
            this.dateTimePicker1.DtpTo = new System.DateTime(2021, 2, 3, 15, 17, 25, 629);
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(37, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 32);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "수요계획생성";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(163, 6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(83, 32);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "등록";
            this.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(252, 6);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(83, 32);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "수정";
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(341, 6);
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
            this.btnRefresh.Location = new System.Drawing.Point(430, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // custDataGridViewControl1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.custDataGridViewControl1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.custDataGridViewControl1.BackgroundColor = System.Drawing.Color.White;
            this.custDataGridViewControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custDataGridViewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDataGridViewControl1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custDataGridViewControl1.DefaultCellStyle = dataGridViewCellStyle12;
            this.custDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custDataGridViewControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custDataGridViewControl1.Location = new System.Drawing.Point(0, 0);
            this.custDataGridViewControl1.Name = "custDataGridViewControl1";
            this.custDataGridViewControl1.RowTemplate.Height = 23;
            this.custDataGridViewControl1.Size = new System.Drawing.Size(1226, 526);
            this.custDataGridViewControl1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "no";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
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
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReorder;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCompany;
        protected System.Windows.Forms.Label label3;
        private UserControls.DateTimePicker dateTimePicker1;
        private CustomControls.custButtonControl btnRefresh;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl btnMod;
        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl btnCreate;
        private CustomControls.custDataGridViewControl custDataGridViewControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

