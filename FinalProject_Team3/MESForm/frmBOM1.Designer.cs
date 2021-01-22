namespace MESForm
{
    partial class frmBOM1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOM1));
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelect.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSelect.Controls.Add(this.comboBox1);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.dateTimePicker1);
            this.pnlSelect.Controls.Add(this.comboBox3);
            this.pnlSelect.Controls.Add(this.label4);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.textBox1);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.btnInquiry);
            this.pnlSelect.Location = new System.Drawing.Point(1, 5);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(1240, 85);
            this.pnlSelect.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(944, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "사용유무";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(654, 21);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "전개방식";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "기준일자";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "품목";
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInquiry.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F);
            this.btnInquiry.ForeColor = System.Drawing.Color.White;
            this.btnInquiry.Location = new System.Drawing.Point(1151, 48);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(86, 36);
            this.btnInquiry.TabIndex = 0;
            this.btnInquiry.Text = "조회";
            this.btnInquiry.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 14F);
            this.label10.Location = new System.Drawing.Point(33, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "BOM";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1162, 111);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1000, 111);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 25);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(1081, 111);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(919, 111);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 25);
            this.btnCopy.TabIndex = 35;
            this.btnCopy.Text = "복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(837, 111);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 25);
            this.btnRegister.TabIndex = 34;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgvBom
            // 
            this.dgvBom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBom.BackgroundColor = System.Drawing.Color.White;
            this.dgvBom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.GridColor = System.Drawing.Color.DimGray;
            this.dgvBom.Location = new System.Drawing.Point(-31, 137);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.Size = new System.Drawing.Size(1268, 389);
            this.dgvBom.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvBom);
            this.Controls.Add(this.pnlSelect);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBOM";
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlSelect;
        protected System.Windows.Forms.ComboBox comboBox3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button btnRefresh;
        protected System.Windows.Forms.Button btnExcel;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnCopy;
        protected System.Windows.Forms.Button btnRegister;
        protected System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label3;
    }
}