
namespace MESForm
{
    partial class frmCompany
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
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvCompany = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.textBox2);
            this.pnlSelect.Controls.Add(this.label18);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.textBox1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.comboBox1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label18, 0);
            this.pnlSelect.Controls.SetChildIndex(this.textBox2, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(596, 10);
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            // 
            // label2
            // 
            this.label2.Text = "업체명";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.Text = "업체코드";
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCompany);
            // 
            // splitContainer1
            // 
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(529, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "업체유형";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 21);
            this.textBox2.TabIndex = 6;
            // 
            // dgvCompany
            // 
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvCompany.Location = new System.Drawing.Point(0, 0);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.Size = new System.Drawing.Size(976, 599);
            this.dgvCompany.TabIndex = 15;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Name = "frmCompany";
            this.Text = "업체관리";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private CustomControls.custDataGridViewControl dgvCompany;
    }
}
