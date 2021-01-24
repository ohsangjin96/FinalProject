
namespace MESForm.PopUp
{
    partial class PopUpCompany
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConditions = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCEO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(785, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Text = "업체정보";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompanyPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(393, 438);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(317, 438);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label19);
            this.pnl.Controls.Add(this.textBox1);
            this.pnl.Controls.Add(this.dateTimePicker2);
            this.pnl.Controls.Add(this.dateTimePicker1);
            this.pnl.Controls.Add(this.textBox12);
            this.pnl.Controls.Add(this.textBox11);
            this.pnl.Controls.Add(this.textBox10);
            this.pnl.Controls.Add(this.textBox8);
            this.pnl.Controls.Add(this.comboBox2);
            this.pnl.Controls.Add(this.comboBox1);
            this.pnl.Controls.Add(this.label18);
            this.pnl.Controls.Add(this.label17);
            this.pnl.Controls.Add(this.label16);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.txtConditions);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.txtName);
            this.pnl.Controls.Add(this.txtCode);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cboType);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.textBox7);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.textBox6);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.textBox4);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.txtCategory);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.txtCEO);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(761, 386);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(745, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(609, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker2.TabIndex = 115;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 114;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(362, 205);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(166, 22);
            this.textBox12.TabIndex = 113;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(115, 205);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 22);
            this.textBox11.TabIndex = 112;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(115, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 22);
            this.textBox10.TabIndex = 111;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(609, 95);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 22);
            this.textBox8.TabIndex = 110;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 22);
            this.comboBox2.TabIndex = 109;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 22);
            this.comboBox1.TabIndex = 108;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 14);
            this.label18.TabIndex = 107;
            this.label18.Text = "수정날짜";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(271, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 106;
            this.label17.Text = "거래시작일";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 14);
            this.label16.TabIndex = 105;
            this.label16.Text = "수정자";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(518, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 104;
            this.label15.Text = "거래종료일";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(24, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 103;
            this.label13.Text = "창고유무";
            // 
            // txtConditions
            // 
            this.txtConditions.Location = new System.Drawing.Point(115, 95);
            this.txtConditions.Name = "txtConditions";
            this.txtConditions.Size = new System.Drawing.Size(125, 22);
            this.txtConditions.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 101;
            this.label12.Text = "전화번호";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(362, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 100;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(115, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(125, 22);
            this.txtCode.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 98;
            this.label2.Text = "업체코드";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(609, 20);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(125, 22);
            this.cboType.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 82;
            this.label3.Text = "대표자명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 83;
            this.label4.Text = "담당자명";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(115, 241);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(619, 128);
            this.textBox7.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 84;
            this.label5.Text = "팩스";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(362, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 22);
            this.textBox6.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(271, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 85;
            this.label6.Text = "업체명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 86;
            this.label7.Text = "업종";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 22);
            this.textBox4.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "이메일";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(609, 58);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(125, 22);
            this.txtCategory.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(518, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 88;
            this.label9.Text = "사용유무";
            // 
            // txtCEO
            // 
            this.txtCEO.Location = new System.Drawing.Point(115, 57);
            this.txtCEO.Name = "txtCEO";
            this.txtCEO.Size = new System.Drawing.Size(125, 22);
            this.txtCEO.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(518, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 89;
            this.label10.Text = "업체유형";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 90;
            this.label11.Text = "업태";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 91;
            this.label14.Text = "업체정보";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(271, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 14);
            this.label19.TabIndex = 116;
            this.label19.Text = "사업자등록번호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 117;
            // 
            // PopUpCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(785, 482);
            this.Name = "PopUpCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.TextBox textBox12;
        protected System.Windows.Forms.TextBox textBox11;
        protected System.Windows.Forms.TextBox textBox10;
        protected System.Windows.Forms.TextBox textBox8;
        protected System.Windows.Forms.ComboBox comboBox2;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.TextBox txtConditions;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox cboType;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox textBox7;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textBox6;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox textBox4;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtCategory;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txtCEO;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.TextBox textBox1;
    }
}
