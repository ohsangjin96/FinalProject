
namespace MESForm.Han
{
    partial class frmCurrentWStock
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custButtonControl1 = new MESForm.CustomControls.custButtonControl();
            this.btnExcel = new MESForm.CustomControls.custButtonControl();
            this.btnRefresh = new MESForm.CustomControls.custButtonControl();
            this.dateTimePicker1 = new MESForm.UserControls.DateTimePicker();
            this.dgvWStock = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlSelect.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.dateTimePicker1);
            this.pnlSelect.Controls.Add(this.cboStock);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.cboItemType);
            this.pnlSelect.Controls.Add(this.txtItem);
            this.pnlSelect.Controls.Add(this.label6);
            this.pnlSelect.Controls.Add(this.label5);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.label8);
            this.pnlSelect.Controls.Add(this.txtWarehouse);
            this.pnlSelect.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSelect.Size = new System.Drawing.Size(1226, 108);
            this.pnlSelect.Controls.SetChildIndex(this.txtWarehouse, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label8, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label1, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label5, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label6, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtItem, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboItemType, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboStock, 0);
            this.pnlSelect.Controls.SetChildIndex(this.btnInquiry, 0);
            this.pnlSelect.Controls.SetChildIndex(this.dateTimePicker1, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.Location = new System.Drawing.Point(1154, 62);
            // 
            // lblFormName1
            // 
            this.lblFormName1.Location = new System.Drawing.Point(12, 151);
            this.lblFormName1.Size = new System.Drawing.Size(112, 21);
            this.lblFormName1.Text = "자재재고현황";
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.dgvWStock);
            this.pnlItem.Location = new System.Drawing.Point(12, 175);
            this.pnlItem.Size = new System.Drawing.Size(1226, 512);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.custButtonControl1);
            this.panel1.Location = new System.Drawing.Point(670, 128);
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Location = new System.Drawing.Point(960, 23);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(191, 22);
            this.cboItemType.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(860, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "품목유형";
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Location = new System.Drawing.Point(130, 64);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(191, 22);
            this.txtWarehouse.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(30, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "창고";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(545, 23);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(191, 22);
            this.txtItem.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(445, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "품목";
            // 
            // cboStock
            // 
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Location = new System.Drawing.Point(545, 64);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(191, 22);
            this.cboStock.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(445, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "재고량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "입출고일";
            // 
            // custButtonControl1
            // 
            this.custButtonControl1.BackColor = System.Drawing.Color.LightSlateGray;
            this.custButtonControl1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.custButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButtonControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custButtonControl1.ForeColor = System.Drawing.Color.Black;
            this.custButtonControl1.Location = new System.Drawing.Point(273, 6);
            this.custButtonControl1.Name = "custButtonControl1";
            this.custButtonControl1.Size = new System.Drawing.Size(100, 32);
            this.custButtonControl1.TabIndex = 0;
            this.custButtonControl1.Text = "이력조회";
            this.custButtonControl1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custButtonControl1.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(379, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 32);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(468, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2021, 2, 10, 13, 19, 54, 603);
            this.dateTimePicker1.DtpTo = new System.DateTime(2021, 2, 10, 13, 19, 54, 603);
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 33);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dgvWStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvWStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvWStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWStock.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWStock.Location = new System.Drawing.Point(0, 0);
            this.dgvWStock.Name = "dgvWStock";
            this.dgvWStock.RowTemplate.Height = 23;
            this.dgvWStock.Size = new System.Drawing.Size(1226, 512);
            this.dgvWStock.TabIndex = 0;
            // 
            // frmCurrentWStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmCurrentWStock";
            this.Text = "자재재고현황";
            this.Load += new System.EventHandler(this.frmCurrentWStock_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStock;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItem;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemType;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWarehouse;
        protected System.Windows.Forms.Label label5;
        private UserControls.DateTimePicker dateTimePicker1;
        private CustomControls.custButtonControl btnRefresh;
        private CustomControls.custButtonControl btnExcel;
        private CustomControls.custButtonControl custButtonControl1;
        private CustomControls.custDataGridViewControl dgvWStock;
    }
}
