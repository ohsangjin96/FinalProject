
namespace MESForm.Han
{
    partial class popupStockHistory
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.custDataGridViewControl1 = new MESForm.CustomControls.custDataGridViewControl();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(330, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(730, 32);
            this.pnlTop.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "창고재고이력조회";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.custDataGridViewControl1);
            this.panel2.Location = new System.Drawing.Point(15, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 464);
            this.panel2.TabIndex = 56;
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
            this.custDataGridViewControl1.Size = new System.Drawing.Size(703, 464);
            this.custDataGridViewControl1.TabIndex = 0;
            // 
            // popupStockHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupStockHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "창고재고이력조회";
            this.Load += new System.EventHandler(this.popupStockHistory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridViewControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Panel pnlTop;
        protected System.Windows.Forms.Label label1;
        private CustomControls.custDataGridViewControl custDataGridViewControl1;
    }
}