namespace MESForm.PopUp
{
    partial class frmUserAuthorityPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Auth = new System.Windows.Forms.DataGridView();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auth)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(919, 64);
            this.pnlTop.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::MESForm.Properties.Resources.close_black;
            this.button1.Location = new System.Drawing.Point(869, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 42);
            this.button1.TabIndex = 103;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 권한관리";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Auth);
            this.groupBox1.Controls.Add(this.btnLookUp);
            this.groupBox1.Controls.Add(this.cboDept);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어OTF", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 471);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리자 검색";
            // 
            // dgv_Auth
            // 
            this.dgv_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Auth.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Auth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Auth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Auth.GridColor = System.Drawing.Color.White;
            this.dgv_Auth.Location = new System.Drawing.Point(0, 132);
            this.dgv_Auth.Name = "dgv_Auth";
            this.dgv_Auth.RowTemplate.Height = 23;
            this.dgv_Auth.Size = new System.Drawing.Size(361, 339);
            this.dgv_Auth.TabIndex = 72;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLookUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUp.Font = new System.Drawing.Font("나눔스퀘어OTF", 10F);
            this.btnLookUp.ForeColor = System.Drawing.Color.White;
            this.btnLookUp.Location = new System.Drawing.Point(199, 70);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(71, 25);
            this.btnLookUp.TabIndex = 71;
            this.btnLookUp.Text = "조회";
            this.btnLookUp.UseVisualStyleBackColor = false;
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(55, 70);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(127, 22);
            this.cboDept.TabIndex = 70;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 23);
            this.txtName.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "부서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "이름";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 10F);
            this.tabControl1.Location = new System.Drawing.Point(367, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 471);
            this.tabControl1.TabIndex = 67;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "관리자권한설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "관리자그룹설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmUserAuthorityPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserAuthorityPopUp";
            this.Text = "frmUserAuthorityPopUp";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auth)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.DataGridView dgv_Auth;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}