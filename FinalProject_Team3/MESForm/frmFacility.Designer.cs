
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
            this.lblFormName2 = new System.Windows.Forms.Label();
            this.btnReg2 = new MESForm.CustomControls.custButtonControl();
            this.btnUpdate2 = new MESForm.CustomControls.custButtonControl();
            this.btnDelete2 = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReg1 = new MESForm.CustomControls.custButtonControl();
            this.btnUpdate1 = new MESForm.CustomControls.custButtonControl();
            this.btnDelete1 = new MESForm.CustomControls.custButtonControl();
            this.dgvFacility = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlItem2 = new System.Windows.Forms.Panel();
            this.dgvFacilityDetail = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).BeginInit();
            this.pnlItem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(12, 107);
            this.pnlSelect.Size = new System.Drawing.Size(1226, 12);
            this.pnlSelect.Visible = false;
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, -34);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 19);
            this.lblFormName1.Text = "설비군";
            // 
            // pnlItem
            // 
            this.pnlItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlItem.Controls.Add(this.dgvFacility);
            this.pnlItem.Location = new System.Drawing.Point(12, 59);
            this.pnlItem.Size = new System.Drawing.Size(410, 628);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReg2);
            this.panel1.Controls.Add(this.btnUpdate2);
            this.panel1.Controls.Add(this.btnDelete2);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(670, 12);
            // 
            // lblFormName2
            // 
            this.lblFormName2.AutoSize = true;
            this.lblFormName2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFormName2.Location = new System.Drawing.Point(433, 19);
            this.lblFormName2.Name = "lblFormName2";
            this.lblFormName2.Size = new System.Drawing.Size(44, 21);
            this.lblFormName2.TabIndex = 21;
            this.lblFormName2.Text = "설비";
            // 
            // btnReg2
            // 
            this.btnReg2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg2.ForeColor = System.Drawing.Color.Black;
            this.btnReg2.Location = new System.Drawing.Point(127, 3);
            this.btnReg2.Name = "btnReg2";
            this.btnReg2.Size = new System.Drawing.Size(83, 32);
            this.btnReg2.TabIndex = 14;
            this.btnReg2.Text = "등록";
            this.btnReg2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg2.UseVisualStyleBackColor = false;
            this.btnReg2.Click += new System.EventHandler(this.btnReg2_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate2.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate2.Location = new System.Drawing.Point(216, 3);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(83, 32);
            this.btnUpdate2.TabIndex = 13;
            this.btnUpdate2.Text = "수정";
            this.btnUpdate2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate2.UseVisualStyleBackColor = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete2.ForeColor = System.Drawing.Color.Black;
            this.btnDelete2.Location = new System.Drawing.Point(305, 3);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(83, 32);
            this.btnDelete2.TabIndex = 12;
            this.btnDelete2.Text = "삭제";
            this.btnDelete2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(396, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReg1);
            this.panel2.Controls.Add(this.btnUpdate1);
            this.panel2.Controls.Add(this.btnDelete1);
            this.panel2.Location = new System.Drawing.Point(142, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 41);
            this.panel2.TabIndex = 22;
            // 
            // btnReg1
            // 
            this.btnReg1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReg1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReg1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnReg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReg1.ForeColor = System.Drawing.Color.Black;
            this.btnReg1.Location = new System.Drawing.Point(19, 3);
            this.btnReg1.Name = "btnReg1";
            this.btnReg1.Size = new System.Drawing.Size(83, 32);
            this.btnReg1.TabIndex = 17;
            this.btnReg1.Text = "등록";
            this.btnReg1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReg1.UseVisualStyleBackColor = false;
            this.btnReg1.Click += new System.EventHandler(this.btnReg1_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdate1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate1.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate1.Location = new System.Drawing.Point(108, 3);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(83, 32);
            this.btnUpdate1.TabIndex = 16;
            this.btnUpdate1.Text = "수정";
            this.btnUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete1.ForeColor = System.Drawing.Color.Black;
            this.btnDelete1.Location = new System.Drawing.Point(197, 3);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(83, 32);
            this.btnDelete1.TabIndex = 15;
            this.btnDelete1.Text = "삭제";
            this.btnDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
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
            this.dgvFacility.Size = new System.Drawing.Size(410, 628);
            this.dgvFacility.TabIndex = 0;
            this.dgvFacility.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacility_CellDoubleClick);
            // 
            // pnlItem2
            // 
            this.pnlItem2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItem2.Controls.Add(this.dgvFacilityDetail);
            this.pnlItem2.Location = new System.Drawing.Point(437, 59);
            this.pnlItem2.Name = "pnlItem2";
            this.pnlItem2.Size = new System.Drawing.Size(801, 628);
            this.pnlItem2.TabIndex = 20;
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
            this.dgvFacilityDetail.Size = new System.Drawing.Size(801, 628);
            this.dgvFacilityDetail.TabIndex = 0;
            // 
            // frmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFormName2);
            this.Controls.Add(this.pnlItem2);
            this.Name = "frmFacility";
            this.Text = "설비관리";
            this.Load += new System.EventHandler(this.frmFacility_Load);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.pnlItem2, 0);
            this.Controls.SetChildIndex(this.lblFormName2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlItem, 0);
            this.Controls.SetChildIndex(this.lblFormName1, 0);
            this.pnlSelect.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).EndInit();
            this.pnlItem2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFormName2;
        private CustomControls.custButtonControl btnReg2;
        private CustomControls.custButtonControl btnUpdate2;
        private CustomControls.custButtonControl btnDelete2;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.custButtonControl btnReg1;
        private CustomControls.custButtonControl btnUpdate1;
        private CustomControls.custButtonControl btnDelete1;
        private CustomControls.custDataGridViewControl dgvFacility;
        private System.Windows.Forms.Panel pnlItem2;
        private CustomControls.custDataGridViewControl dgvFacilityDetail;
    }
}
