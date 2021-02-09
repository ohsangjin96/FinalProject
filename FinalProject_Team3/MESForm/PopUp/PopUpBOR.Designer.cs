
namespace MESForm.PopUp
{
    partial class PopUpBOR
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
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.cboFacility = new System.Windows.Forms.ComboBox();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTactTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtReadyTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransference = new System.Windows.Forms.TextBox();
            this.lblBorCode = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(541, 34);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BORPopUp_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BORPopUp_MouseMove);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.Text = "BOR";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BORPopUp_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BORPopUp_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(273, 332);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(197, 332);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblBorCode);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.txtTransference);
            this.pnl.Controls.Add(this.cboUse);
            this.pnl.Controls.Add(this.cboFacility);
            this.pnl.Controls.Add(this.cboRoute);
            this.pnl.Controls.Add(this.cboItem);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.txtTactTime);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.txtNote);
            this.pnl.Controls.Add(this.txtReadyTime);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.txtOrder);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label14);
            this.pnl.Size = new System.Drawing.Size(517, 284);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(501, 0);
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            // 
            // cboUse
            // 
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(355, 132);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(140, 22);
            this.cboUse.TabIndex = 7;
            // 
            // cboFacility
            // 
            this.cboFacility.FormattingEnabled = true;
            this.cboFacility.Location = new System.Drawing.Point(107, 56);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.Size = new System.Drawing.Size(140, 22);
            this.cboFacility.TabIndex = 2;
            // 
            // cboRoute
            // 
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(355, 19);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(140, 22);
            this.cboRoute.TabIndex = 1;
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(107, 19);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(140, 22);
            this.cboItem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 73;
            this.label2.Text = "품목";
            // 
            // txtTactTime
            // 
            this.txtTactTime.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTactTime.Location = new System.Drawing.Point(355, 56);
            this.txtTactTime.Name = "txtTactTime";
            this.txtTactTime.Size = new System.Drawing.Size(140, 22);
            this.txtTactTime.TabIndex = 3;
            this.txtTactTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 63;
            this.label3.Text = "설비";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 64;
            this.label4.Text = "공정선행일";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(107, 170);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(388, 94);
            this.txtNote.TabIndex = 8;
            // 
            // txtReadyTime
            // 
            this.txtReadyTime.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtReadyTime.Location = new System.Drawing.Point(107, 94);
            this.txtReadyTime.Name = "txtReadyTime";
            this.txtReadyTime.Size = new System.Drawing.Size(140, 22);
            this.txtReadyTime.TabIndex = 4;
            this.txtReadyTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(261, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "공정";
            // 
            // txtOrder
            // 
            this.txtOrder.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtOrder.Location = new System.Drawing.Point(355, 94);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(140, 22);
            this.txtOrder.TabIndex = 5;
            this.txtOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(261, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 66;
            this.label8.Text = "Tact Time(Sec)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(261, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 67;
            this.label9.Text = "우선순위";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(261, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 68;
            this.label10.Text = "사용유무";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 14);
            this.label14.TabIndex = 69;
            this.label14.Text = "비고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 79;
            this.label5.Text = "수율";
            // 
            // txtTransference
            // 
            this.txtTransference.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTransference.Location = new System.Drawing.Point(107, 132);
            this.txtTransference.Name = "txtTransference";
            this.txtTransference.Size = new System.Drawing.Size(140, 22);
            this.txtTransference.TabIndex = 6;
            this.txtTransference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // lblBorCode
            // 
            this.lblBorCode.Location = new System.Drawing.Point(12, 252);
            this.lblBorCode.Name = "lblBorCode";
            this.lblBorCode.Size = new System.Drawing.Size(38, 23);
            this.lblBorCode.TabIndex = 108;
            this.lblBorCode.Visible = false;
            // 
            // PopUpBOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(541, 377);
            this.Name = "PopUpBOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpBOR_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboUse;
        private System.Windows.Forms.ComboBox cboFacility;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.ComboBox cboItem;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtTactTime;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtNote;
        protected System.Windows.Forms.TextBox txtReadyTime;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txtOrder;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtTransference;
        private System.Windows.Forms.Label lblBorCode;
    }
}
