
namespace MESForm
{
    partial class frmSample
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
            this.newDataGridViewControl1 = new MESForm.UserControls.NewDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.Text = "나이";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.Text = "이름";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(913, 49);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newDataGridViewControl1);
            // 
            // splitContainer1
            // 
            // 
            // newDataGridViewControl1
            // 
            this.newDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDataGridViewControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newDataGridViewControl1.Location = new System.Drawing.Point(0, 0);
            this.newDataGridViewControl1.Name = "newDataGridViewControl1";
            this.newDataGridViewControl1.Size = new System.Drawing.Size(976, 581);
            this.newDataGridViewControl1.TabIndex = 0;
            // 
            // frmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Name = "frmSample";
            this.Text = "샘플 화면";
            this.Load += new System.EventHandler(this.frmSample_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NewDataGridViewControl newDataGridViewControl1;
    }
}
