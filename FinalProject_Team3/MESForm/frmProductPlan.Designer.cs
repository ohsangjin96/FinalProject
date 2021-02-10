
namespace MESForm
{
    partial class frmProductPlan
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboFacility = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl2 = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.dtpto);
            this.pnlSelect.Controls.Add(this.dtpfrom);
            this.pnlSelect.Controls.Add(this.txtID);
            this.pnlSelect.Controls.Add(this.label5);
            this.pnlSelect.Controls.Add(this.cboFacility);
            this.pnlSelect.Controls.Add(this.label4);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.txtName);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Size = new System.Drawing.Size(1226, 148);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label4, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboFacility, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label5, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtID, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dtpfrom, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dtpto, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, 105);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 172);
            this.lblFormName1.Size = new System.Drawing.Size(78, 21);
            this.lblFormName1.Text = "생성계획";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvList);
            this.pnlItem.Size = new System.Drawing.Size(1226, 509);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.custButtonControl2);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(677, 162);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(30, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "생산계획ID";
            // 
            // cboFacility
            // 
            this.cboFacility.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacility.FormattingEnabled = true;
            this.cboFacility.Location = new System.Drawing.Point(963, 18);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.Size = new System.Drawing.Size(191, 22);
            this.cboFacility.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(858, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "설비";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(445, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "계획날짜";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(133, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "품명";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.GridColor = System.Drawing.Color.DimGray;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1226, 509);
            this.dgvList.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(133, 62);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 28;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(370, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // custButtonControl2
            // 
            this.custButtonControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl2.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl2.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl2.Location = new System.Drawing.Point(267, 3);
            this.custButtonControl2.Name = "custButtonControl2";
            this.custButtonControl2.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl2.TabIndex = 20;
            this.custButtonControl2.Text = "계획확정";
            this.custButtonControl2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl2.UseVisualStyleBackColor = false;
            this.custButtonControl2.Click += new System.EventHandler(this.custButtonControl2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(470, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 32);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(650, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 94;
            this.label3.Text = "~";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(692, 18);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(101, 22);
            this.dtpto.TabIndex = 93;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(536, 18);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(101, 22);
            this.dtpfrom.TabIndex = 92;
            // 
            // frmProductPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 737);
            this.Name = "frmProductPlan";
            this.Text = "생성계획";
            this.Load += new System.EventHandler(this.frmProductPlan_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox cboFacility;
        protected System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvList;
        public System.Windows.Forms.TextBox txtID;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl custButtonControl2;
        private CustomControls.custButtonControl btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
    }
}
