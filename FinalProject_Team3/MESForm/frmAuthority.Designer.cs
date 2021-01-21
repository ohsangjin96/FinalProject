namespace MESForm
{
    partial class frmAuthority
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
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.dgv_Auth = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUser_Auth = new System.Windows.Forms.Button();
            this.btnGroup_Auth = new System.Windows.Forms.Button();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.Controls.Add(this.txtName);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.btnLookUp);
            this.pnlSelect.Location = new System.Drawing.Point(1, 3);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(1248, 72);
            this.pnlSelect.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F);
            this.txtName.Location = new System.Drawing.Point(76, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 21);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 11F);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "관리자명";
            // 
            // btnLookUp
            // 
            this.btnLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLookUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUp.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F);
            this.btnLookUp.ForeColor = System.Drawing.Color.White;
            this.btnLookUp.Location = new System.Drawing.Point(227, 14);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(71, 25);
            this.btnLookUp.TabIndex = 0;
            this.btnLookUp.Text = "조회";
            this.btnLookUp.UseVisualStyleBackColor = false;
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
            this.dgv_Auth.Location = new System.Drawing.Point(1, 189);
            this.dgv_Auth.Name = "dgv_Auth";
            this.dgv_Auth.RowTemplate.Height = 23;
            this.dgv_Auth.Size = new System.Drawing.Size(1246, 473);
            this.dgv_Auth.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MESForm.Properties.Resources.menubar_16x16;
            this.pictureBox1.Location = new System.Drawing.Point(12, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 15F);
            this.label2.Location = new System.Drawing.Point(43, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "권한관리";
            // 
            // btnUser_Auth
            // 
            this.btnUser_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser_Auth.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUser_Auth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnUser_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser_Auth.Font = new System.Drawing.Font("나눔스퀘어OTF", 10F);
            this.btnUser_Auth.ForeColor = System.Drawing.Color.White;
            this.btnUser_Auth.Location = new System.Drawing.Point(1007, 161);
            this.btnUser_Auth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser_Auth.Name = "btnUser_Auth";
            this.btnUser_Auth.Size = new System.Drawing.Size(117, 25);
            this.btnUser_Auth.TabIndex = 5;
            this.btnUser_Auth.Text = "관리자 권한관리";
            this.btnUser_Auth.UseVisualStyleBackColor = false;
            // 
            // btnGroup_Auth
            // 
            this.btnGroup_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGroup_Auth.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGroup_Auth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnGroup_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup_Auth.Font = new System.Drawing.Font("나눔스퀘어OTF", 10F);
            this.btnGroup_Auth.ForeColor = System.Drawing.Color.White;
            this.btnGroup_Auth.Location = new System.Drawing.Point(1130, 161);
            this.btnGroup_Auth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup_Auth.Name = "btnGroup_Auth";
            this.btnGroup_Auth.Size = new System.Drawing.Size(117, 25);
            this.btnGroup_Auth.TabIndex = 6;
            this.btnGroup_Auth.Text = "그룹별 권한메뉴";
            this.btnGroup_Auth.UseVisualStyleBackColor = false;
            // 
            // frmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 662);
            this.Controls.Add(this.btnGroup_Auth);
            this.Controls.Add(this.btnUser_Auth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Auth);
            this.Controls.Add(this.pnlSelect);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAuthority";
            this.Text = "frmAuthority";
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlSelect;
        protected System.Windows.Forms.Button btnLookUp;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Auth;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnUser_Auth;
        protected System.Windows.Forms.Button btnGroup_Auth;
    }
}