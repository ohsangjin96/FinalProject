
namespace MESForm.PopUp
{
    partial class PopUpFactory
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
            this.cboFactoryMaterial = new System.Windows.Forms.ComboBox();
            this.cboFactoryProcess = new System.Windows.Forms.ComboBox();
            this.cboFactoryDemand = new System.Windows.Forms.ComboBox();
            this.cboComCode = new System.Windows.Forms.ComboBox();
            this.cboFactoryCredit = new System.Windows.Forms.ComboBox();
            this.cboFactoryType = new System.Windows.Forms.ComboBox();
            this.cboFactoryHighRank = new System.Windows.Forms.ComboBox();
            this.cboFactoryGrade = new System.Windows.Forms.ComboBox();
            this.txtAmender = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModdifyDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFactoryOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFactoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFactoryCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboFactoryUse = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(576, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FactoryPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FactoryPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Text = "공장정보";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FactoryPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FactoryPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(291, 437);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(215, 437);
            this.btnSave.TabIndex = 15;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cboFactoryUse);
            this.pnl.Controls.Add(this.cboFactoryMaterial);
            this.pnl.Controls.Add(this.cboFactoryProcess);
            this.pnl.Controls.Add(this.cboFactoryDemand);
            this.pnl.Controls.Add(this.cboComCode);
            this.pnl.Controls.Add(this.cboFactoryCredit);
            this.pnl.Controls.Add(this.cboFactoryType);
            this.pnl.Controls.Add(this.cboFactoryHighRank);
            this.pnl.Controls.Add(this.cboFactoryGrade);
            this.pnl.Controls.Add(this.txtAmender);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.txtModdifyDate);
            this.pnl.Controls.Add(this.label16);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.txtFactoryOrder);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.txtFactoryName);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtExplain);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.txtFactoryCode);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(552, 390);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(536, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            // 
            // cboFactoryMaterial
            // 
            this.cboFactoryMaterial.FormattingEnabled = true;
            this.cboFactoryMaterial.Location = new System.Drawing.Point(119, 204);
            this.cboFactoryMaterial.Name = "cboFactoryMaterial";
            this.cboFactoryMaterial.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryMaterial.TabIndex = 10;
            // 
            // cboFactoryProcess
            // 
            this.cboFactoryProcess.FormattingEnabled = true;
            this.cboFactoryProcess.Location = new System.Drawing.Point(379, 167);
            this.cboFactoryProcess.Name = "cboFactoryProcess";
            this.cboFactoryProcess.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryProcess.TabIndex = 9;
            // 
            // cboFactoryDemand
            // 
            this.cboFactoryDemand.FormattingEnabled = true;
            this.cboFactoryDemand.Location = new System.Drawing.Point(119, 167);
            this.cboFactoryDemand.Name = "cboFactoryDemand";
            this.cboFactoryDemand.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryDemand.TabIndex = 8;
            // 
            // cboComCode
            // 
            this.cboComCode.FormattingEnabled = true;
            this.cboComCode.Location = new System.Drawing.Point(379, 128);
            this.cboComCode.Name = "cboComCode";
            this.cboComCode.Size = new System.Drawing.Size(140, 22);
            this.cboComCode.TabIndex = 7;
            // 
            // cboFactoryCredit
            // 
            this.cboFactoryCredit.FormattingEnabled = true;
            this.cboFactoryCredit.Location = new System.Drawing.Point(379, 92);
            this.cboFactoryCredit.Name = "cboFactoryCredit";
            this.cboFactoryCredit.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryCredit.TabIndex = 5;
            // 
            // cboFactoryType
            // 
            this.cboFactoryType.FormattingEnabled = true;
            this.cboFactoryType.Location = new System.Drawing.Point(119, 54);
            this.cboFactoryType.Name = "cboFactoryType";
            this.cboFactoryType.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryType.TabIndex = 2;
            // 
            // cboFactoryHighRank
            // 
            this.cboFactoryHighRank.FormattingEnabled = true;
            this.cboFactoryHighRank.Location = new System.Drawing.Point(379, 16);
            this.cboFactoryHighRank.Name = "cboFactoryHighRank";
            this.cboFactoryHighRank.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryHighRank.TabIndex = 1;
            // 
            // cboFactoryGrade
            // 
            this.cboFactoryGrade.FormattingEnabled = true;
            this.cboFactoryGrade.Location = new System.Drawing.Point(119, 16);
            this.cboFactoryGrade.Name = "cboFactoryGrade";
            this.cboFactoryGrade.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryGrade.TabIndex = 0;
            // 
            // txtAmender
            // 
            this.txtAmender.Enabled = false;
            this.txtAmender.Location = new System.Drawing.Point(119, 242);
            this.txtAmender.Name = "txtAmender";
            this.txtAmender.Size = new System.Drawing.Size(140, 22);
            this.txtAmender.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(288, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 14);
            this.label15.TabIndex = 100;
            this.label15.Text = "수정시간";
            // 
            // txtModdifyDate
            // 
            this.txtModdifyDate.Enabled = false;
            this.txtModdifyDate.Location = new System.Drawing.Point(379, 242);
            this.txtModdifyDate.Name = "txtModdifyDate";
            this.txtModdifyDate.Size = new System.Drawing.Size(140, 22);
            this.txtModdifyDate.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 14);
            this.label16.TabIndex = 99;
            this.label16.Text = "수정자";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(288, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 97;
            this.label12.Text = "사용유무";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 96;
            this.label13.Text = "자재차감";
            // 
            // txtFactoryOrder
            // 
            this.txtFactoryOrder.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtFactoryOrder.Location = new System.Drawing.Point(119, 128);
            this.txtFactoryOrder.Name = "txtFactoryOrder";
            this.txtFactoryOrder.Size = new System.Drawing.Size(140, 22);
            this.txtFactoryOrder.TabIndex = 6;
            this.txtFactoryOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactoryOrder_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 92;
            this.label2.Text = "시설군";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 93;
            this.label11.Text = "공정차감";
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.Location = new System.Drawing.Point(379, 53);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.Size = new System.Drawing.Size(140, 22);
            this.txtFactoryName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(28, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 81;
            this.label3.Text = "시설구분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "시설코드";
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(119, 279);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(400, 94);
            this.txtExplain.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 83;
            this.label5.Text = "순서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 84;
            this.label6.Text = "수요차감";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(288, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 85;
            this.label7.Text = "상위시설";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(288, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 86;
            this.label8.Text = "시설명";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 87;
            this.label9.Text = "유무상구분";
            // 
            // txtFactoryCode
            // 
            this.txtFactoryCode.Location = new System.Drawing.Point(119, 92);
            this.txtFactoryCode.Name = "txtFactoryCode";
            this.txtFactoryCode.Size = new System.Drawing.Size(140, 22);
            this.txtFactoryCode.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 88;
            this.label10.Text = "업체";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 89;
            this.label14.Text = "시설설명";
            // 
            // cboFactoryUse
            // 
            this.cboFactoryUse.FormattingEnabled = true;
            this.cboFactoryUse.Location = new System.Drawing.Point(379, 204);
            this.cboFactoryUse.Name = "cboFactoryUse";
            this.cboFactoryUse.Size = new System.Drawing.Size(140, 22);
            this.cboFactoryUse.TabIndex = 11;
            // 
            // PopUpFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(576, 487);
            this.Name = "PopUpFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpFactory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFactoryMaterial;
        private System.Windows.Forms.ComboBox cboFactoryProcess;
        private System.Windows.Forms.ComboBox cboFactoryDemand;
        private System.Windows.Forms.ComboBox cboComCode;
        private System.Windows.Forms.ComboBox cboFactoryCredit;
        private System.Windows.Forms.ComboBox cboFactoryType;
        private System.Windows.Forms.ComboBox cboFactoryHighRank;
        private System.Windows.Forms.ComboBox cboFactoryGrade;
        protected System.Windows.Forms.TextBox txtAmender;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.TextBox txtModdifyDate;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.TextBox txtFactoryOrder;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.TextBox txtFactoryName;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtExplain;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txtFactoryCode;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboFactoryUse;
    }
}
