namespace MESForm
{
    partial class PopUpUserAuthority
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custDataGridViewControl1 = new MESForm.CustomControls.custDataGridViewControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(919, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.Text = "관리자 권한관리";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(462, 498);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(386, 498);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.tabControl1);
            this.pnl.Controls.Add(this.panel1);
            this.pnl.Controls.Add(this.groupBox1);
            this.pnl.Size = new System.Drawing.Size(895, 446);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(879, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLookUp);
            this.groupBox1.Controls.Add(this.cboDept);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리자검색";
            // 
            // btnLookUp
            // 
            this.btnLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLookUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUp.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.btnLookUp.ForeColor = System.Drawing.Color.White;
            this.btnLookUp.Location = new System.Drawing.Point(197, 70);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(71, 25);
            this.btnLookUp.TabIndex = 76;
            this.btnLookUp.Text = "조회";
            this.btnLookUp.UseVisualStyleBackColor = false;
            // 
            // cboDept
            // 
            this.cboDept.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(44, 73);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(127, 22);
            this.cboDept.TabIndex = 75;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtName.Location = new System.Drawing.Point(44, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 22);
            this.txtName.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label3.Location = new System.Drawing.Point(1, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 73;
            this.label3.Text = "부서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 72;
            this.label2.Text = "이름";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.custDataGridViewControl1);
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 327);
            this.panel1.TabIndex = 1;
            // 
            // custDataGridViewControl1
            // 
            this.custDataGridViewControl1.BackgroundColor = System.Drawing.Color.White;
            this.custDataGridViewControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custDataGridViewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custDataGridViewControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custDataGridViewControl1.Location = new System.Drawing.Point(0, 0);
            this.custDataGridViewControl1.Name = "custDataGridViewControl1";
            this.custDataGridViewControl1.RowTemplate.Height = 23;
            this.custDataGridViewControl1.Size = new System.Drawing.Size(274, 327);
            this.custDataGridViewControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(283, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 429);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "관리자권한설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "그룹별권한설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PopUpUserAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(919, 546);
            this.Name = "PopUpUserAuthority";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.custDataGridViewControl custDataGridViewControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
