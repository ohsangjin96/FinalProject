
namespace MESForm.Han
{
    partial class frmCurrentProcess
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
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpS_R = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custDataGridViewControl1 = new MESForm.CustomControls.custDataGridViewControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pnlSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.Controls.Add(this.cboGrade);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.Add(this.cboStock);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.cboWarehouse);
            this.pnlSelect.Controls.Add(this.label6);
            this.pnlSelect.Controls.Add(this.txtItem);
            this.pnlSelect.Controls.Add(this.label5);
            this.pnlSelect.Controls.Add(this.cboItemType);
            this.pnlSelect.Controls.Add(this.label8);
            this.pnlSelect.Controls.Add(this.dtpS_R);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.btnInquiry);
            this.pnlSelect.Location = new System.Drawing.Point(12, 12);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(1226, 81);
            this.pnlSelect.TabIndex = 0;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(922, 45);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(197, 21);
            this.cboGrade.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(824, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "관리등급";
            // 
            // cboStock
            // 
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Location = new System.Drawing.Point(508, 45);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(197, 21);
            this.cboStock.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(435, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "재고량";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(94, 45);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(197, 21);
            this.cboWarehouse.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(22, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "창고";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(508, 15);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(197, 21);
            this.txtItem.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(435, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "품목";
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Location = new System.Drawing.Point(922, 15);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(197, 21);
            this.cboItemType.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(824, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "품목유형";
            // 
            // dtpS_R
            // 
            this.dtpS_R.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpS_R.Location = new System.Drawing.Point(94, 15);
            this.dtpS_R.Name = "dtpS_R";
            this.dtpS_R.Size = new System.Drawing.Size(197, 21);
            this.dtpS_R.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "입출고일";
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInquiry.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("나눔스퀘어OTF Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInquiry.ForeColor = System.Drawing.Color.White;
            this.btnInquiry.Location = new System.Drawing.Point(1139, 48);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnInquiry.TabIndex = 0;
            this.btnInquiry.Text = "조회";
            this.btnInquiry.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.custDataGridViewControl1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 551);
            this.panel1.TabIndex = 8;
            // 
            // custDataGridViewControl1
            // 
            this.custDataGridViewControl1.BackgroundColor = System.Drawing.Color.White;
            this.custDataGridViewControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custDataGridViewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custDataGridViewControl1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custDataGridViewControl1.Location = new System.Drawing.Point(0, 0);
            this.custDataGridViewControl1.Name = "custDataGridViewControl1";
            this.custDataGridViewControl1.RowTemplate.Height = 23;
            this.custDataGridViewControl1.Size = new System.Drawing.Size(1226, 551);
            this.custDataGridViewControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 700);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1063, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 12;
            this.button3.Tag = "-창고재고이력조회팝업";
            this.button3.Text = "이력조회";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(34, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "공정재고현황";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1163, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // frmCurrentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrentProcess";
            this.Text = "공정재고현황";
            this.Load += new System.EventHandler(this.frmCurrentProcess_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlSelect;
        protected System.Windows.Forms.Button btnInquiry;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboItemType;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpS_R;
        private System.Windows.Forms.ComboBox cboWarehouse;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItem;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGrade;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStock;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnExcel;
        private CustomControls.custDataGridViewControl custDataGridViewControl1;
    }
}
