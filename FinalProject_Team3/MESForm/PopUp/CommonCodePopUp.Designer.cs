
namespace MESForm.PopUp
{
    partial class CommonCodePopUp
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
            this.dgvCommonCode = new MESForm.CustomControls.custDataGridViewControl();
            this.gboInsert = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).BeginInit();
            this.gboInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(470, 32);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.Text = "공통코드 관리";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommonCodePopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(242, 239);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(166, 239);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dgvCommonCode);
            this.pnl.Location = new System.Drawing.Point(12, 285);
            this.pnl.Size = new System.Drawing.Size(446, 306);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(430, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCommonCode
            // 
            this.dgvCommonCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommonCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommonCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommonCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommonCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvCommonCode.Location = new System.Drawing.Point(0, 0);
            this.dgvCommonCode.Name = "dgvCommonCode";
            this.dgvCommonCode.RowTemplate.Height = 23;
            this.dgvCommonCode.Size = new System.Drawing.Size(446, 306);
            this.dgvCommonCode.TabIndex = 1;
            // 
            // gboInsert
            // 
            this.gboInsert.Controls.Add(this.comboBox1);
            this.gboInsert.Controls.Add(this.label6);
            this.gboInsert.Controls.Add(this.button2);
            this.gboInsert.Controls.Add(this.textBox1);
            this.gboInsert.Controls.Add(this.numericUpDown1);
            this.gboInsert.Controls.Add(this.label9);
            this.gboInsert.Controls.Add(this.button1);
            this.gboInsert.Controls.Add(this.label8);
            this.gboInsert.Controls.Add(this.textBox8);
            this.gboInsert.Controls.Add(this.label7);
            this.gboInsert.Location = new System.Drawing.Point(15, 76);
            this.gboInsert.Name = "gboInsert";
            this.gboInsert.Size = new System.Drawing.Size(443, 160);
            this.gboInsert.TabIndex = 78;
            this.gboInsert.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(44, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "코드";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(333, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 73;
            this.button2.Text = "중복체크";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 21);
            this.textBox1.TabIndex = 45;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(135, 130);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 21);
            this.numericUpDown1.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(44, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "순서";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "중복체크";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "상위코드";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(135, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(173, 21);
            this.textBox8.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(44, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "코드이름";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(383, 47);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 77;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.Location = new System.Drawing.Point(303, 47);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 76;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // CommonCodePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 603);
            this.Controls.Add(this.gboInsert);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnReg);
            this.Name = "CommonCodePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "CommonCodePopUp";
            this.Load += new System.EventHandler(this.CommonCodePopUp_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnReg, 0);
            this.Controls.SetChildIndex(this.btnDel, 0);
            this.Controls.SetChildIndex(this.gboInsert, 0);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).EndInit();
            this.gboInsert.ResumeLayout(false);
            this.gboInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.custDataGridViewControl dgvCommonCode;
        private System.Windows.Forms.GroupBox gboInsert;
        private System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox textBox8;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnReg;
    }
}
