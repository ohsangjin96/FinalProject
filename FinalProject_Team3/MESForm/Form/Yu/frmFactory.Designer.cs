
namespace MESForm
{
    partial class frmFactory
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
            this.dgvFactory = new MESForm.CustomControls.custDataGridViewControl();
            this.btnReg = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl3 = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl2 = new MESForm.CustomControls.custButtonControl();
            this.custButtonControl1 = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 163);
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvFactory);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.custButtonControl3);
            this.panel1.Controls.Add(this.custButtonControl2);
            this.panel1.Controls.Add(this.custButtonControl1);
            this.panel1.Controls.Add(this.btnRefresh);
            // 
            // dgvFactory
            // 
            this.dgvFactory.BackgroundColor = System.Drawing.Color.White;
            this.dgvFactory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFactory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactory.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvFactory.Location = new System.Drawing.Point(0, 0);
            this.dgvFactory.Name = "dgvFactory";
            this.dgvFactory.Size = new System.Drawing.Size(1226, 484);
            this.dgvFactory.TabIndex = 0;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg.ForeColor = System.Drawing.Color.Black;
            this.btnReg.Location = new System.Drawing.Point(127, 3);
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
            this.custButtonControl3.Location = new System.Drawing.Point(216, 3);
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
            this.custButtonControl2.Location = new System.Drawing.Point(305, 3);
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
            this.custButtonControl1.Location = new System.Drawing.Point(396, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(485, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // frmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Name = "frmFactory";
            this.Text = "공장관리";
            this.Load += new System.EventHandler(this.frmFactory_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.custDataGridViewControl dgvFactory;
        private CustomControls.custButtonControl btnReg;
        private CustomControls.custButtonControl custButtonControl3;
        private CustomControls.custButtonControl custButtonControl2;
        private CustomControls.custButtonControl custButtonControl1;
        private CustomControls.custButtonControl btnRefresh;
    }
}
