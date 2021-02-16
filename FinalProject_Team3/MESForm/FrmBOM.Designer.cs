namespace MESForm
{
    partial class FrmBOM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReg = new MESForm.CustomControls.custButtonControl();
            this.btnUpdate = new MESForm.CustomControls.custButtonControl();
            this.btnDelete = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.lblFactoryGrade = new System.Windows.Forms.Label();
            this.txtItemCodeOrName = new System.Windows.Forms.TextBox();
            this.lblFactoryCode = new System.Windows.Forms.Label();
            this.dgvBom = new MESForm.CustomControls.custDataGridViewControl();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncopy = new MESForm.CustomControls.custButtonControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.cboUseYN);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.cboItemType);
            this.pnlSelect.Controls.Add(this.lblFactoryGrade);
            this.pnlSelect.Controls.Add(this.txtItemCodeOrName);
            this.pnlSelect.Controls.Add(this.lblFactoryCode);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSelect.Size = new System.Drawing.Size(1576, 95);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblFactoryCode, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtItemCodeOrName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblFactoryGrade, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboItemType, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboUseYN, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1484, 36);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(15, 147);
            this.lblFormName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormName1.Size = new System.Drawing.Size(64, 27);
            this.lblFormName1.Text = "BOM";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvBom);
            this.pnlItem.Location = new System.Drawing.Point(15, 181);
            this.pnlItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItem.Size = new System.Drawing.Size(1576, 747);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncopy);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(886, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(706, 53);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(18, 4);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(107, 41);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "등록";
            this.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(247, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(361, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(478, 4);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(107, 41);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(593, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 41);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboItemType
            // 
            this.cboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Location = new System.Drawing.Point(642, 35);
            this.cboItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(244, 26);
            this.cboItemType.TabIndex = 33;
            // 
            // lblFactoryGrade
            // 
            this.lblFactoryGrade.AutoSize = true;
            this.lblFactoryGrade.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFactoryGrade.Location = new System.Drawing.Point(489, 39);
            this.lblFactoryGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactoryGrade.Name = "lblFactoryGrade";
            this.lblFactoryGrade.Size = new System.Drawing.Size(69, 19);
            this.lblFactoryGrade.TabIndex = 32;
            this.lblFactoryGrade.Text = "품목유형";
            // 
            // txtItemCodeOrName
            // 
            this.txtItemCodeOrName.Location = new System.Drawing.Point(161, 35);
            this.txtItemCodeOrName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemCodeOrName.Name = "txtItemCodeOrName";
            this.txtItemCodeOrName.Size = new System.Drawing.Size(244, 26);
            this.txtItemCodeOrName.TabIndex = 31;
            // 
            // lblFactoryCode
            // 
            this.lblFactoryCode.AutoSize = true;
            this.lblFactoryCode.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFactoryCode.Location = new System.Drawing.Point(39, 39);
            this.lblFactoryCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactoryCode.Name = "lblFactoryCode";
            this.lblFactoryCode.Size = new System.Drawing.Size(61, 19);
            this.lblFactoryCode.TabIndex = 30;
            this.lblFactoryCode.Text = "품목/명";
            // 
            // dgvBom
            // 
            this.dgvBom.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBom.BackgroundColor = System.Drawing.Color.White;
            this.dgvBom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBom.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvBom.Location = new System.Drawing.Point(0, 0);
            this.dgvBom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.RowHeadersWidth = 51;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.Size = new System.Drawing.Size(1576, 747);
            this.dgvBom.TabIndex = 0;
            // 
            // cboUseYN
            // 
            this.cboUseYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(1122, 35);
            this.cboUseYN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(244, 26);
            this.cboUseYN.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(969, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "사용유무";
            // 
            // btncopy
            // 
            this.btncopy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btncopy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btncopy.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btncopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopy.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btncopy.ForeColor = System.Drawing.Color.Black;
            this.btncopy.Location = new System.Drawing.Point(132, 4);
            this.btncopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(107, 41);
            this.btncopy.TabIndex = 15;
            this.btncopy.Text = "복사";
            this.btncopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncopy.UseVisualStyleBackColor = false;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // FrmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1607, 900);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBOM";
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.FrmBOM_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl btnUpdate;
        private CustomControls.custButtonControl btnDelete;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl btnRefresh;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.Label lblFactoryGrade;
        private System.Windows.Forms.TextBox txtItemCodeOrName;
        private System.Windows.Forms.Label lblFactoryCode;
        private CustomControls.custDataGridViewControl dgvBom;
      
        private System.Windows.Forms.ComboBox cboUseYN;
        private System.Windows.Forms.Label label1;
      
        private CustomControls.custButtonControl btncopy;
       
    }
}
