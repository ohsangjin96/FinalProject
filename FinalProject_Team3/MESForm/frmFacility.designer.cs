
namespace MESForm
{
    partial class frmFacility
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
            this.dgvFacility = new MESForm.CustomControls.custDataGridViewControl();
            this.dgvFacilityDetail = new MESForm.CustomControls.custDataGridViewControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(578, 3);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(416, 3);
            // 
            // btnDel2
            // 
            this.btnDel2.Location = new System.Drawing.Point(497, 3);
            // 
            // btnMod2
            // 
            this.btnMod2.Location = new System.Drawing.Point(335, 3);
            // 
            // btnReg2
            // 
            this.btnReg2.Location = new System.Drawing.Point(254, 3);
            this.btnReg2.Click += new System.EventHandler(this.btnReg2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.Text = "설비군명";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.Text = "설비군코드";
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnDel1
            // 
            this.btnDel1.Location = new System.Drawing.Point(253, 3);
            // 
            // btnMod1
            // 
            this.btnMod1.Location = new System.Drawing.Point(174, 3);
            // 
            // btnReg1
            // 
            this.btnReg1.Location = new System.Drawing.Point(93, 3);
            this.btnReg1.Click += new System.EventHandler(this.btnReg1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Size = new System.Drawing.Size(1000, 729);
            this.splitContainer2.SplitterDistance = 331;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFacility);
            this.panel1.Size = new System.Drawing.Size(316, 676);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFacilityDetail);
            this.panel2.Size = new System.Drawing.Size(650, 676);
            // 
            // dgvFacility
            // 
            this.dgvFacility.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacility.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvFacility.Location = new System.Drawing.Point(0, 0);
            this.dgvFacility.Name = "dgvFacility";
            this.dgvFacility.RowTemplate.Height = 23;
            this.dgvFacility.Size = new System.Drawing.Size(316, 676);
            this.dgvFacility.TabIndex = 4;
            // 
            // dgvFacilityDetail
            // 
            this.dgvFacilityDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacilityDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacilityDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacilityDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacilityDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvFacilityDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvFacilityDetail.Name = "dgvFacilityDetail";
            this.dgvFacilityDetail.RowTemplate.Height = 23;
            this.dgvFacilityDetail.Size = new System.Drawing.Size(650, 676);
            this.dgvFacilityDetail.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "설비군";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "설비";
            // 
            // frmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Name = "frmFacility";
            this.Text = "설비관리";
            this.Load += new System.EventHandler(this.frmFacility_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.custDataGridViewControl dgvFacility;
        private CustomControls.custDataGridViewControl dgvFacilityDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
