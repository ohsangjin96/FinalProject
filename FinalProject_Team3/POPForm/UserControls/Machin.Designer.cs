
namespace POPForm.UserControls
{
    partial class Machin
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bntActive = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.timer_Conn = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.lblPort);
            this.panel4.Controls.Add(this.lblIP);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.lblProgram);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.bntActive);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblFail);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblSuccess);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblFacility);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1047, 105);
            this.panel4.TabIndex = 58;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(457, 80);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 12);
            this.lblPort.TabIndex = 59;
            this.lblPort.Text = "label3";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(368, 80);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(38, 12);
            this.lblIP.TabIndex = 58;
            this.lblIP.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(176, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 30);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "이름";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(146, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "/";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.SystemColors.Highlight;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("나눔스퀘어OTF", 15F);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(949, 63);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 40);
            this.button11.TabIndex = 55;
            this.button11.Text = "로그";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(185, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 30);
            this.label20.TabIndex = 54;
            this.label20.Text = "%";
            // 
            // lblProgram
            // 
            this.lblProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProgram.Location = new System.Drawing.Point(119, 63);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(45, 30);
            this.lblProgram.TabIndex = 53;
            this.lblProgram.Text = "00";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(20, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 30);
            this.label19.TabIndex = 52;
            this.label19.Text = "진행률";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어OTF", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(850, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 40);
            this.button2.TabIndex = 51;
            this.button2.Text = "중지";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntActive
            // 
            this.bntActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntActive.BackColor = System.Drawing.Color.Green;
            this.bntActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntActive.Font = new System.Drawing.Font("나눔스퀘어OTF", 15F);
            this.bntActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntActive.Location = new System.Drawing.Point(755, 62);
            this.bntActive.Name = "bntActive";
            this.bntActive.Size = new System.Drawing.Size(89, 40);
            this.bntActive.TabIndex = 50;
            this.bntActive.Text = "가동";
            this.bntActive.UseVisualStyleBackColor = false;
            this.bntActive.Click += new System.EventHandler(this.bntActive_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(875, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 27);
            this.label14.TabIndex = 5;
            this.label14.Text = "/";
            // 
            // lblFail
            // 
            this.lblFail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFail.AutoSize = true;
            this.lblFail.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFail.Location = new System.Drawing.Point(988, 18);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(45, 30);
            this.lblFail.TabIndex = 4;
            this.lblFail.Text = "00";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(904, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "실패";
            // 
            // lblSuccess
            // 
            this.lblSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSuccess.Location = new System.Drawing.Point(818, 18);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(45, 30);
            this.lblSuccess.TabIndex = 2;
            this.lblSuccess.Text = "00";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(734, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "성공";
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Font = new System.Drawing.Font("나눔스퀘어OTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFacility.Location = new System.Drawing.Point(20, 18);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(120, 30);
            this.lblFacility.TabIndex = 0;
            this.lblFacility.Text = "설비 이름";
            // 
            // Machin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "Machin";
            this.Size = new System.Drawing.Size(1050, 110);
            this.Load += new System.EventHandler(this.Machin_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bntActive;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Timer timer_Conn;
    }
}
