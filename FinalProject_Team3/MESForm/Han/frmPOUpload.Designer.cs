
namespace MESForm.Han
{
    partial class frmPOUpload
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
            this.btnExcelUpload = new MESForm.CustomControls.custButtonControl();
            this.btnFrmDownload = new MESForm.CustomControls.custButtonControl();
            this.btnCreate = new MESForm.CustomControls.custButtonControl();
            this.dgvPO = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(633, 12);
            this.pnlSelect.Size = new System.Drawing.Size(24, 22);
            this.pnlSelect.Visible = false;
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(-48, -24);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 35);
            this.lblFormName1.Size = new System.Drawing.Size(183, 21);
            this.lblFormName1.Text = "영업마스터업로드(PO)";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvPO);
            this.pnlItem.Location = new System.Drawing.Point(12, 59);
            this.pnlItem.Size = new System.Drawing.Size(1226, 628);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnFrmDownload);
            this.panel1.Controls.Add(this.btnExcelUpload);
            this.panel1.Location = new System.Drawing.Point(670, 12);
            // 
            // btnExcelUpload
            // 
            this.btnExcelUpload.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcelUpload.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcelUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelUpload.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcelUpload.ForeColor = System.Drawing.Color.Black;
            this.btnExcelUpload.Location = new System.Drawing.Point(468, 6);
            this.btnExcelUpload.Name = "btnExcelUpload";
            this.btnExcelUpload.Size = new System.Drawing.Size(100, 32);
            this.btnExcelUpload.TabIndex = 0;
            this.btnExcelUpload.Text = "엑셀 등록";
            this.btnExcelUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelUpload.UseVisualStyleBackColor = false;
            this.btnExcelUpload.Click += new System.EventHandler(this.btnExcelUpload_Click);
            // 
            // btnFrmDownload
            // 
            this.btnFrmDownload.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFrmDownload.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnFrmDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmDownload.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFrmDownload.ForeColor = System.Drawing.Color.Black;
            this.btnFrmDownload.Location = new System.Drawing.Point(342, 6);
            this.btnFrmDownload.Name = "btnFrmDownload";
            this.btnFrmDownload.Size = new System.Drawing.Size(120, 32);
            this.btnFrmDownload.TabIndex = 1;
            this.btnFrmDownload.Text = "양식다운로드";
            this.btnFrmDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmDownload.UseVisualStyleBackColor = false;
            this.btnFrmDownload.Click += new System.EventHandler(this.btnFrmDownload_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(196, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 32);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "영업마스터 생성";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.dgvPO.Size = new System.Drawing.Size(1226, 628);
            this.dgvPO.TabIndex = 0;
            this.dgvPO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDataGridViewControl1_CellDoubleClick);
            // 
            // frmPOUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmPOUpload";
            this.Text = "영업마스터업로드(PO)";
            this.Load += new System.EventHandler(this.frmPOUpload_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.custDataGridViewControl dgvPO;
        private CustomControls.custButtonControl btnCreate;
        private CustomControls.custButtonControl btnFrmDownload;
        private CustomControls.custButtonControl btnExcelUpload;
    }
}

