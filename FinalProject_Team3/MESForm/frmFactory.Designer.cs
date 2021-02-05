
namespace MESForm
{
    partial class frmFactory
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
            this.custButtonControl1 = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.lblFactoryCode = new System.Windows.Forms.Label();
            this.txtFactoryCodeOrName = new System.Windows.Forms.TextBox();
            this.lblFactoryGrade = new System.Windows.Forms.Label();
            this.cboFactoryGrade = new System.Windows.Forms.ComboBox();
            this.dgvFactory = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.cboFactoryGrade);
            this.pnlSelect.Controls.Add(this.lblFactoryGrade);
            this.pnlSelect.Controls.Add(this.txtFactoryCodeOrName);
            this.pnlSelect.Controls.Add(this.lblFactoryCode);
            this.pnlSelect.Size = new System.Drawing.Size(1226, 74);
            this.pnlSelect.Controls.SetChildIndex(this.lblFactoryCode, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtFactoryCodeOrName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblFactoryGrade, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboFactoryGrade, 0);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, 28);
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 101);
            this.lblFormName1.Size = new System.Drawing.Size(78, 21);
            this.lblFormName1.Text = "공장관리";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvFactory);
            this.pnlItem.Location = new System.Drawing.Point(12, 141);
            this.pnlItem.Size = new System.Drawing.Size(1226, 546);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.custButtonControl1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(670, 94);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(127, 3);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(83, 32);
            this.btnReg.TabIndex = 9;
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
            this.btnUpdate.Location = new System.Drawing.Point(216, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 32);
            this.btnUpdate.TabIndex = 8;
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
            this.btnDelete.Location = new System.Drawing.Point(305, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // custButtonControl1
            // 
            this.custButtonControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl1.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl1.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl1.Location = new System.Drawing.Point(396, 3);
            this.custButtonControl1.Name = "custButtonControl1";
            this.custButtonControl1.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl1.TabIndex = 6;
            this.custButtonControl1.Text = "엑셀";
            this.custButtonControl1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl1.UseVisualStyleBackColor = false;
            this.custButtonControl1.Click += new System.EventHandler(this.custButtonControl1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(485, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblFactoryCode
            // 
            this.lblFactoryCode.AutoSize = true;
            this.lblFactoryCode.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFactoryCode.Location = new System.Drawing.Point(30, 30);
            this.lblFactoryCode.Name = "lblFactoryCode";
            this.lblFactoryCode.Size = new System.Drawing.Size(73, 14);
            this.lblFactoryCode.TabIndex = 23;
            this.lblFactoryCode.Text = "시설코드/명";
            // 
            // txtFactoryCodeOrName
            // 
            this.txtFactoryCodeOrName.Location = new System.Drawing.Point(130, 27);
            this.txtFactoryCodeOrName.Name = "txtFactoryCodeOrName";
            this.txtFactoryCodeOrName.Size = new System.Drawing.Size(191, 22);
            this.txtFactoryCodeOrName.TabIndex = 24;
            this.txtFactoryCodeOrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblFactoryGrade
            // 
            this.lblFactoryGrade.AutoSize = true;
            this.lblFactoryGrade.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFactoryGrade.Location = new System.Drawing.Point(445, 30);
            this.lblFactoryGrade.Name = "lblFactoryGrade";
            this.lblFactoryGrade.Size = new System.Drawing.Size(43, 14);
            this.lblFactoryGrade.TabIndex = 25;
            this.lblFactoryGrade.Text = "시설군";
            // 
            // cboFactoryGrade
            // 
            this.cboFactoryGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactoryGrade.FormattingEnabled = true;
            this.cboFactoryGrade.Location = new System.Drawing.Point(545, 27);
            this.cboFactoryGrade.Name = "cboFactoryGrade";
            this.cboFactoryGrade.Size = new System.Drawing.Size(191, 22);
            this.cboFactoryGrade.TabIndex = 29;
            this.cboFactoryGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // dgvFactory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFactory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactory.BackgroundColor = System.Drawing.Color.White;
            this.dgvFactory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactory.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvFactory.Location = new System.Drawing.Point(0, 0);
            this.dgvFactory.Name = "dgvFactory";
            this.dgvFactory.RowTemplate.Height = 23;
            this.dgvFactory.Size = new System.Drawing.Size(1226, 546);
            this.dgvFactory.TabIndex = 0;
            // 
            // frmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Name = "frmFactory";
            this.Text = "공장관리";
            this.Load += new System.EventHandler(this.frmFactory_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl btnUpdate;
        private CustomControls.custButtonControl btnDelete;
        private CustomControls.custButtonControl custButtonControl1;
        private CustomControls.custButtonControl btnRefresh;
        private System.Windows.Forms.ComboBox cboFactoryGrade;
        private System.Windows.Forms.Label lblFactoryGrade;
        private System.Windows.Forms.TextBox txtFactoryCodeOrName;
        private System.Windows.Forms.Label lblFactoryCode;
        private CustomControls.custDataGridViewControl dgvFactory;
    }
}
