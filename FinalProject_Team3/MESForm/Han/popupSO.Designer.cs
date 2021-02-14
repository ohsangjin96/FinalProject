
namespace MESForm.Han
{
    partial class popupSO
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
            this.cboGubun = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboItemCode = new System.Windows.Forms.ComboBox();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.txtCancelAmount = new System.Windows.Forms.TextBox();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboArrive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReleaseAmount = new System.Windows.Forms.TextBox();
            this.dtpFixedDate = new System.Windows.Forms.DateTimePicker();
            this.cboMkt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(543, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.Text = "S/O";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(271, 398);
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(195, 398);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.cboMkt);
            this.pnl.Controls.Add(this.dtpFixedDate);
            this.pnl.Controls.Add(this.txtReleaseAmount);
            this.pnl.Controls.Add(this.cboGubun);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.cboItemCode);
            this.pnl.Controls.Add(this.cboCom);
            this.pnl.Controls.Add(this.txtCancelAmount);
            this.pnl.Controls.Add(this.txtOrderAmount);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.txtWO);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cboArrive);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtRemark);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.txtItemName);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(519, 346);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(503, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboGubun
            // 
            this.cboGubun.FormattingEnabled = true;
            this.cboGubun.Location = new System.Drawing.Point(118, 176);
            this.cboGubun.Name = "cboGubun";
            this.cboGubun.Size = new System.Drawing.Size(125, 21);
            this.cboGubun.TabIndex = 107;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(27, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 14);
            this.label15.TabIndex = 106;
            this.label15.Text = "발주구분";
            // 
            // cboItemCode
            // 
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(118, 77);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(125, 21);
            this.cboItemCode.TabIndex = 105;
            this.cboItemCode.SelectedIndexChanged += new System.EventHandler(this.cboItemCode_SelectedIndexChanged);
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(118, 44);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(125, 21);
            this.cboCom.TabIndex = 101;
            // 
            // txtCancelAmount
            // 
            this.txtCancelAmount.Location = new System.Drawing.Point(118, 143);
            this.txtCancelAmount.Name = "txtCancelAmount";
            this.txtCancelAmount.Size = new System.Drawing.Size(125, 21);
            this.txtCancelAmount.TabIndex = 100;
            this.txtCancelAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(118, 110);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(125, 21);
            this.txtOrderAmount.TabIndex = 99;
            this.txtOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(27, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 97;
            this.label13.Text = "취소수량";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(27, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 96;
            this.label12.Text = "주문수량";
            // 
            // txtWO
            // 
            this.txtWO.Location = new System.Drawing.Point(118, 11);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(125, 21);
            this.txtWO.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 94;
            this.label2.Text = "고객주문번호";
            // 
            // cboArrive
            // 
            this.cboArrive.FormattingEnabled = true;
            this.cboArrive.Location = new System.Drawing.Point(365, 44);
            this.cboArrive.Name = "cboArrive";
            this.cboArrive.Size = new System.Drawing.Size(125, 21);
            this.cboArrive.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "고객사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(274, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 81;
            this.label4.Text = "품명";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(118, 214);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(374, 126);
            this.txtRemark.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(274, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 82;
            this.label5.Text = "납기일";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(365, 77);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(125, 21);
            this.txtItemName.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(274, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 83;
            this.label6.Text = "출고수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(274, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 87;
            this.label10.Text = "도착지";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(27, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 88;
            this.label11.Text = "품목";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(27, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 14);
            this.label14.TabIndex = 89;
            this.label14.Text = "비고";
            // 
            // txtReleaseAmount
            // 
            this.txtReleaseAmount.Location = new System.Drawing.Point(365, 110);
            this.txtReleaseAmount.Name = "txtReleaseAmount";
            this.txtReleaseAmount.Size = new System.Drawing.Size(125, 21);
            this.txtReleaseAmount.TabIndex = 108;
            this.txtReleaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFixedDate
            // 
            this.dtpFixedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixedDate.Location = new System.Drawing.Point(365, 11);
            this.dtpFixedDate.Name = "dtpFixedDate";
            this.dtpFixedDate.Size = new System.Drawing.Size(125, 21);
            this.dtpFixedDate.TabIndex = 109;
            this.dtpFixedDate.ValueChanged += new System.EventHandler(this.dtpFixedDate_ValueChanged);
            // 
            // cboMkt
            // 
            this.cboMkt.FormattingEnabled = true;
            this.cboMkt.Location = new System.Drawing.Point(365, 143);
            this.cboMkt.Name = "cboMkt";
            this.cboMkt.Size = new System.Drawing.Size(125, 21);
            this.cboMkt.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(274, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 112;
            this.label7.Text = "Market";
            // 
            // popupSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "popupSO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S/O";
            this.Load += new System.EventHandler(this.popupSO_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ComboBox cboGubun;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.ComboBox cboItemCode;
        protected System.Windows.Forms.ComboBox cboCom;
        protected System.Windows.Forms.TextBox txtCancelAmount;
        protected System.Windows.Forms.TextBox txtOrderAmount;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox txtWO;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox cboArrive;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtItemName;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.TextBox txtReleaseAmount;
        private System.Windows.Forms.DateTimePicker dtpFixedDate;
        protected System.Windows.Forms.ComboBox cboMkt;
        protected System.Windows.Forms.Label label7;
    }
}