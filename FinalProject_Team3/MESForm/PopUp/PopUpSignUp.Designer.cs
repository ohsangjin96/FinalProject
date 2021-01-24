namespace MESForm
{
    partial class PopUpSignUp
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
            this.btnIdCheck = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPwdCheck = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(388, 40);
            // 
            // label1
            // 
            this.label1.Text = "회원가입";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(197, 375);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(121, 375);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "가입";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnIdCheck);
            this.pnl.Controls.Add(this.txtPwd);
            this.pnl.Controls.Add(this.txtPwdCheck);
            this.pnl.Controls.Add(this.txtEmail);
            this.pnl.Controls.Add(this.txtName);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cboDept);
            this.pnl.Controls.Add(this.label37);
            this.pnl.Controls.Add(this.label40);
            this.pnl.Controls.Add(this.txtID);
            this.pnl.Size = new System.Drawing.Size(364, 323);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(348, 0);
            // 
            // btnIdCheck
            // 
            this.btnIdCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIdCheck.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIdCheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnIdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCheck.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F);
            this.btnIdCheck.ForeColor = System.Drawing.Color.White;
            this.btnIdCheck.Location = new System.Drawing.Point(273, 15);
            this.btnIdCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIdCheck.Name = "btnIdCheck";
            this.btnIdCheck.Size = new System.Drawing.Size(66, 22);
            this.btnIdCheck.TabIndex = 2;
            this.btnIdCheck.Text = "중복확인";
            this.btnIdCheck.UseVisualStyleBackColor = false;
            this.btnIdCheck.Click += new System.EventHandler(this.btnIdCheck_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtPwd.Location = new System.Drawing.Point(129, 69);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(138, 22);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Tag = "비밀번호";
            // 
            // txtPwdCheck
            // 
            this.txtPwdCheck.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtPwdCheck.Location = new System.Drawing.Point(129, 123);
            this.txtPwdCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwdCheck.Name = "txtPwdCheck";
            this.txtPwdCheck.Size = new System.Drawing.Size(138, 22);
            this.txtPwdCheck.TabIndex = 4;
            this.txtPwdCheck.Tag = "비밀번호확인";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtEmail.Location = new System.Drawing.Point(129, 231);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 22);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Tag = "이메일";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtName.Location = new System.Drawing.Point(129, 177);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 22);
            this.txtName.TabIndex = 5;
            this.txtName.Tag = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(26, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 198;
            this.label5.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 197;
            this.label4.Text = "비밀번호확인";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 196;
            this.label3.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(26, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 195;
            this.label2.Text = "부서";
            // 
            // cboDept
            // 
            this.cboDept.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(129, 286);
            this.cboDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(138, 22);
            this.cboDept.TabIndex = 7;
            this.cboDept.Tag = "부서";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(26, 235);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(39, 14);
            this.label37.TabIndex = 193;
            this.label37.Text = "EMail";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label40.Location = new System.Drawing.Point(26, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(43, 14);
            this.label40.TabIndex = 192;
            this.label40.Text = "아이디";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtID.Location = new System.Drawing.Point(129, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 22);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "아이디";
            // 
            // PopUpSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(388, 423);
            this.Name = "PopUpSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpSignUp_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnIdCheck;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPwdCheck;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDept;
        protected System.Windows.Forms.Label label37;
        protected System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtID;
    }
}
