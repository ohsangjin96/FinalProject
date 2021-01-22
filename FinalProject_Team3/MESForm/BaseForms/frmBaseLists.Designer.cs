
namespace MESForm.BaseForms
{
    partial class frmBaseLists
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
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.lblFormName1 = new System.Windows.Forms.Label();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.Controls.Add(this.btnInquiry);
            this.pnlSelect.Location = new System.Drawing.Point(12, 13);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(976, 137);
            this.pnlSelect.TabIndex = 16;
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInquiry.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInquiry.ForeColor = System.Drawing.Color.White;
            this.btnInquiry.Location = new System.Drawing.Point(904, 95);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(64, 34);
            this.btnInquiry.TabIndex = 0;
            this.btnInquiry.Text = "조회";
            this.btnInquiry.UseVisualStyleBackColor = false;
            // 
            // lblFormName1
            // 
            this.lblFormName1.AutoSize = true;
            this.lblFormName1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFormName1.Location = new System.Drawing.Point(12, 170);
            this.lblFormName1.Name = "lblFormName1";
            this.lblFormName1.Size = new System.Drawing.Size(61, 21);
            this.lblFormName1.TabIndex = 18;
            this.lblFormName1.Text = "화면명";
            // 
            // pnlItem
            // 
            this.pnlItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItem.Location = new System.Drawing.Point(12, 200);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(976, 488);
            this.pnlItem.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(420, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 38);
            this.panel1.TabIndex = 19;
            // 
            // frmBaseLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblFormName1);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaseLists";
            this.Text = "frmBaseLists2";
            this.pnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlSelect;
        protected System.Windows.Forms.Button btnInquiry;
        protected System.Windows.Forms.Label lblFormName1;
        protected System.Windows.Forms.Panel pnlItem;
        protected System.Windows.Forms.Panel panel1;
    }
}