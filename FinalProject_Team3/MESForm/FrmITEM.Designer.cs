namespace MESForm
{
    partial class FrmITEM
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
            this.btnReg = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl3 = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl2 = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl1 = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.dgvItem = new MESForm.CustomControls.custDataGridViewControl();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFactoryGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.label9);
            this.pnlSelect.Controls.Add(this.label7);
            this.pnlSelect.Controls.Add(this.label6);
            this.pnlSelect.Controls.Add(this.label5);
            this.pnlSelect.Controls.Add(this.comboBox7);
            this.pnlSelect.Controls.Add(this.comboBox6);
            this.pnlSelect.Controls.Add(this.comboBox5);
            this.pnlSelect.Controls.Add(this.comboBox4);
            this.pnlSelect.Controls.Add(this.comboBox3);
            this.pnlSelect.Controls.Add(this.comboBox2);
            this.pnlSelect.Controls.Add(this.label4);
            this.pnlSelect.Controls.Add(this.cboFactoryGrade);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.textBox1);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.textBox1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboFactoryGrade, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label4, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox4, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox5, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox6, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox7, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label5, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label6, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label7, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label9, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            // 
            // lblFormName1
            // 
            this.lblFormName1.Size = new System.Drawing.Size(78, 21);
            this.lblFormName1.Text = "품목관리";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.custButtonControl3);
            this.panel1.Controls.Add(this.custButtonControl2);
            this.panel1.Controls.Add(this.custButtonControl1);
            this.panel1.Controls.Add(this.btnRefresh);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(122, 3);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(83, 32);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "등록";
            this.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // custButtonControl3
            // 
            this.custButtonControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl3.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl3.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl3.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl3.Location = new System.Drawing.Point(211, 3);
            this.custButtonControl3.Name = "custButtonControl3";
            this.custButtonControl3.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl3.TabIndex = 8;
            this.custButtonControl3.Text = "수정";
            this.custButtonControl3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl3.UseVisualStyleBackColor = false;
            // 
            // custButtonControl2
            // 
            this.custButtonControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl2.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl2.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl2.Location = new System.Drawing.Point(300, 3);
            this.custButtonControl2.Name = "custButtonControl2";
            this.custButtonControl2.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl2.TabIndex = 7;
            this.custButtonControl2.Text = "삭제";
            this.custButtonControl2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl2.UseVisualStyleBackColor = false;
            // 
            // custButtonControl1
            // 
            this.custButtonControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custButtonControl1.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl1.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl1.Location = new System.Drawing.Point(391, 3);
            this.custButtonControl1.Name = "custButtonControl1";
            this.custButtonControl1.Size = new System.Drawing.Size(83, 32);
            this.custButtonControl1.TabIndex = 6;
            this.custButtonControl1.Text = "엑셀";
            this.custButtonControl1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl1.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(480, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvItem.Location = new System.Drawing.Point(0, 0);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(1226, 484);
            this.dgvItem.TabIndex = 1;
            this.dgvItem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvItem_RowPostPaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(445, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "사용여부";
            // 
            // cboFactoryGrade
            // 
            this.cboFactoryGrade.FormattingEnabled = true;
            this.cboFactoryGrade.Location = new System.Drawing.Point(545, 56);
            this.cboFactoryGrade.Name = "cboFactoryGrade";
            this.cboFactoryGrade.Size = new System.Drawing.Size(191, 21);
            this.cboFactoryGrade.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(860, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 37;
            this.label3.Text = "발주업체";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(445, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "출고창고";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "품목";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(545, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(130, 56);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 21);
            this.comboBox3.TabIndex = 42;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(960, 15);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(191, 21);
            this.comboBox4.TabIndex = 43;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(545, 15);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(191, 21);
            this.comboBox5.TabIndex = 44;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(130, 97);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(191, 21);
            this.comboBox6.TabIndex = 45;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(963, 57);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(191, 21);
            this.comboBox7.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(30, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "입고창고";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(30, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 48;
            this.label6.Text = "담당자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(445, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 49;
            this.label7.Text = "품목유형";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(860, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 51;
            this.label9.Text = "납품업체";
            // 
            // FrmITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Name = "FrmITEM";
            this.Text = "품목관리";
            this.Load += new System.EventHandler(this.FrmITEM_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl custButtonControl3;
        private CustomControls.custButtonControl custButtonControl2;
        private CustomControls.custButtonControl custButtonControl1;
        private CustomControls.custButtonControl btnRefresh;
        private CustomControls.custDataGridViewControl dgvItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFactoryGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
