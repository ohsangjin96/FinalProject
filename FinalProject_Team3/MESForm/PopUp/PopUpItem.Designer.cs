namespace MESForm
{
    partial class PopUpItem
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
            this.cboWareIn = new System.Windows.Forms.ComboBox();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.cboWareOut = new System.Windows.Forms.ComboBox();
            this.cboDisconYN = new System.Windows.Forms.ComboBox();
            this.txtUnitQty = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtModifierDate = new System.Windows.Forms.TextBox();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.txtStandard = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtReadTime = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cboDCompany = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.cboOCompany = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cboImportYN = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.cboProcessYN = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cboExportYN = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.cboIType = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtIname = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.numSaveStock = new System.Windows.Forms.NumericUpDown();
            this.numMinOrder = new System.Windows.Forms.NumericUpDown();
            this.pnlTop.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaveStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(708, 40);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.Text = "품목";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Location = new System.Drawing.Point(355, 373);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Click += new System.EventHandler(this.XorCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(279, 373);
            this.btnSave.TabIndex = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.numMinOrder);
            this.pnl.Controls.Add(this.numSaveStock);
            this.pnl.Controls.Add(this.txtManager);
            this.pnl.Controls.Add(this.cboWareIn);
            this.pnl.Controls.Add(this.cboUseYN);
            this.pnl.Controls.Add(this.cboWareOut);
            this.pnl.Controls.Add(this.cboDisconYN);
            this.pnl.Controls.Add(this.txtUnitQty);
            this.pnl.Controls.Add(this.txtRemark);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cboOrderType);
            this.pnl.Controls.Add(this.label29);
            this.pnl.Controls.Add(this.label31);
            this.pnl.Controls.Add(this.label32);
            this.pnl.Controls.Add(this.label33);
            this.pnl.Controls.Add(this.label34);
            this.pnl.Controls.Add(this.txtModifierDate);
            this.pnl.Controls.Add(this.txtModifier);
            this.pnl.Controls.Add(this.txtStandard);
            this.pnl.Controls.Add(this.label36);
            this.pnl.Controls.Add(this.label39);
            this.pnl.Controls.Add(this.label41);
            this.pnl.Controls.Add(this.label42);
            this.pnl.Controls.Add(this.label43);
            this.pnl.Controls.Add(this.txtReadTime);
            this.pnl.Controls.Add(this.label44);
            this.pnl.Controls.Add(this.cboDCompany);
            this.pnl.Controls.Add(this.label45);
            this.pnl.Controls.Add(this.cboOCompany);
            this.pnl.Controls.Add(this.label46);
            this.pnl.Controls.Add(this.cboImportYN);
            this.pnl.Controls.Add(this.label47);
            this.pnl.Controls.Add(this.label48);
            this.pnl.Controls.Add(this.cboProcessYN);
            this.pnl.Controls.Add(this.label49);
            this.pnl.Controls.Add(this.label50);
            this.pnl.Controls.Add(this.cboUnit);
            this.pnl.Controls.Add(this.label51);
            this.pnl.Controls.Add(this.cboExportYN);
            this.pnl.Controls.Add(this.label52);
            this.pnl.Controls.Add(this.label53);
            this.pnl.Controls.Add(this.cboIType);
            this.pnl.Controls.Add(this.label54);
            this.pnl.Controls.Add(this.txtIname);
            this.pnl.Controls.Add(this.label55);
            this.pnl.Controls.Add(this.txtItem);
            this.pnl.Size = new System.Drawing.Size(684, 321);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(668, 0);
            this.btnClose.TabIndex = 22;
            this.btnClose.Click += new System.EventHandler(this.XorCancle_Click);
            // 
            // cboWareIn
            // 
            this.cboWareIn.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboWareIn.FormattingEnabled = true;
            this.cboWareIn.Location = new System.Drawing.Point(556, 84);
            this.cboWareIn.Name = "cboWareIn";
            this.cboWareIn.Size = new System.Drawing.Size(121, 22);
            this.cboWareIn.TabIndex = 11;
            // 
            // cboUseYN
            // 
            this.cboUseYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(328, 131);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(121, 22);
            this.cboUseYN.TabIndex = 16;
            // 
            // cboWareOut
            // 
            this.cboWareOut.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboWareOut.FormattingEnabled = true;
            this.cboWareOut.Location = new System.Drawing.Point(89, 108);
            this.cboWareOut.Name = "cboWareOut";
            this.cboWareOut.Size = new System.Drawing.Size(121, 22);
            this.cboWareOut.TabIndex = 12;
            // 
            // cboDisconYN
            // 
            this.cboDisconYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboDisconYN.FormattingEnabled = true;
            this.cboDisconYN.Location = new System.Drawing.Point(556, 134);
            this.cboDisconYN.Name = "cboDisconYN";
            this.cboDisconYN.Size = new System.Drawing.Size(121, 22);
            this.cboDisconYN.TabIndex = 17;
            // 
            // txtUnitQty
            // 
            this.txtUnitQty.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtUnitQty.Location = new System.Drawing.Point(328, 32);
            this.txtUnitQty.Name = "txtUnitQty";
            this.txtUnitQty.Size = new System.Drawing.Size(121, 22);
            this.txtUnitQty.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtRemark.Location = new System.Drawing.Point(89, 223);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(577, 93);
            this.txtRemark.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 232;
            this.label2.Text = "비고";
            // 
            // cboOrderType
            // 
            this.cboOrderType.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Location = new System.Drawing.Point(89, 179);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(121, 22);
            this.cboOrderType.TabIndex = 18;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(8, 179);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 14);
            this.label29.TabIndex = 230;
            this.label29.Text = "발주방식";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label31.Location = new System.Drawing.Point(468, 133);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 14);
            this.label31.TabIndex = 228;
            this.label31.Text = "단종유무";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label32.Location = new System.Drawing.Point(231, 131);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(55, 14);
            this.label32.TabIndex = 227;
            this.label32.Text = "사용유무";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(231, 155);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 14);
            this.label33.TabIndex = 226;
            this.label33.Text = "수정자";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(468, 157);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(43, 14);
            this.label34.TabIndex = 225;
            this.label34.Text = "수정일";
            // 
            // txtModifierDate
            // 
            this.txtModifierDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifierDate.Location = new System.Drawing.Point(556, 158);
            this.txtModifierDate.Name = "txtModifierDate";
            this.txtModifierDate.ReadOnly = true;
            this.txtModifierDate.Size = new System.Drawing.Size(121, 22);
            this.txtModifierDate.TabIndex = 224;
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtModifier.Location = new System.Drawing.Point(328, 155);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.ReadOnly = true;
            this.txtModifier.Size = new System.Drawing.Size(121, 22);
            this.txtModifier.TabIndex = 223;
            // 
            // txtStandard
            // 
            this.txtStandard.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtStandard.Location = new System.Drawing.Point(556, 13);
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.Size = new System.Drawing.Size(121, 22);
            this.txtStandard.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(8, 155);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 14);
            this.label36.TabIndex = 219;
            this.label36.Text = "담당자";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(8, 131);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 14);
            this.label39.TabIndex = 215;
            this.label39.Text = "안전재고량";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(8, 107);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(55, 14);
            this.label41.TabIndex = 211;
            this.label41.Text = "출고창고";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(231, 107);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(67, 14);
            this.label42.TabIndex = 210;
            this.label42.Text = "Lead Time";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(468, 109);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(67, 14);
            this.label43.TabIndex = 209;
            this.label43.Text = "최소발주량";
            // 
            // txtReadTime
            // 
            this.txtReadTime.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtReadTime.Location = new System.Drawing.Point(328, 105);
            this.txtReadTime.Name = "txtReadTime";
            this.txtReadTime.Size = new System.Drawing.Size(121, 22);
            this.txtReadTime.TabIndex = 13;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(468, 85);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 14);
            this.label44.TabIndex = 207;
            this.label44.Text = "입고창고";
            // 
            // cboDCompany
            // 
            this.cboDCompany.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboDCompany.FormattingEnabled = true;
            this.cboDCompany.Location = new System.Drawing.Point(89, 84);
            this.cboDCompany.Name = "cboDCompany";
            this.cboDCompany.Size = new System.Drawing.Size(121, 22);
            this.cboDCompany.TabIndex = 9;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(8, 83);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 14);
            this.label45.TabIndex = 205;
            this.label45.Text = "남품업체";
            // 
            // cboOCompany
            // 
            this.cboOCompany.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboOCompany.FormattingEnabled = true;
            this.cboOCompany.Location = new System.Drawing.Point(328, 79);
            this.cboOCompany.Name = "cboOCompany";
            this.cboOCompany.Size = new System.Drawing.Size(121, 22);
            this.cboOCompany.TabIndex = 10;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(231, 83);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 14);
            this.label46.TabIndex = 203;
            this.label46.Text = "발주업체";
            // 
            // cboImportYN
            // 
            this.cboImportYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboImportYN.FormattingEnabled = true;
            this.cboImportYN.Location = new System.Drawing.Point(89, 60);
            this.cboImportYN.Name = "cboImportYN";
            this.cboImportYN.Size = new System.Drawing.Size(121, 22);
            this.cboImportYN.TabIndex = 6;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label47.Location = new System.Drawing.Point(8, 59);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(79, 14);
            this.label47.TabIndex = 201;
            this.label47.Text = "수입검사여부";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label48.Location = new System.Drawing.Point(231, 59);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(79, 14);
            this.label48.TabIndex = 200;
            this.label48.Text = "공정검사여부";
            // 
            // cboProcessYN
            // 
            this.cboProcessYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboProcessYN.FormattingEnabled = true;
            this.cboProcessYN.Location = new System.Drawing.Point(328, 56);
            this.cboProcessYN.Name = "cboProcessYN";
            this.cboProcessYN.Size = new System.Drawing.Size(121, 22);
            this.cboProcessYN.TabIndex = 7;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(468, 13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(31, 14);
            this.label49.TabIndex = 198;
            this.label49.Text = "규격";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label50.Location = new System.Drawing.Point(8, 35);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(31, 14);
            this.label50.TabIndex = 197;
            this.label50.Text = "단위";
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(89, 37);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(121, 22);
            this.cboUnit.TabIndex = 3;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(231, 35);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(55, 14);
            this.label51.TabIndex = 195;
            this.label51.Text = "단위수량";
            // 
            // cboExportYN
            // 
            this.cboExportYN.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboExportYN.FormattingEnabled = true;
            this.cboExportYN.Location = new System.Drawing.Point(556, 61);
            this.cboExportYN.Name = "cboExportYN";
            this.cboExportYN.Size = new System.Drawing.Size(121, 22);
            this.cboExportYN.TabIndex = 8;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label52.Location = new System.Drawing.Point(468, 61);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(79, 14);
            this.label52.TabIndex = 187;
            this.label52.Text = "출하검사여부";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label53.Location = new System.Drawing.Point(468, 37);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 14);
            this.label53.TabIndex = 193;
            this.label53.Text = "품목유형";
            // 
            // cboIType
            // 
            this.cboIType.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.cboIType.FormattingEnabled = true;
            this.cboIType.Location = new System.Drawing.Point(556, 37);
            this.cboIType.Name = "cboIType";
            this.cboIType.Size = new System.Drawing.Size(121, 22);
            this.cboIType.TabIndex = 5;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label54.Location = new System.Drawing.Point(231, 11);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(31, 14);
            this.label54.TabIndex = 191;
            this.label54.Text = "품명";
            // 
            // txtIname
            // 
            this.txtIname.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtIname.Location = new System.Drawing.Point(328, 8);
            this.txtIname.Name = "txtIname";
            this.txtIname.Size = new System.Drawing.Size(121, 22);
            this.txtIname.TabIndex = 1;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label55.Location = new System.Drawing.Point(8, 11);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 14);
            this.label55.TabIndex = 189;
            this.label55.Text = "품목";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtItem.Location = new System.Drawing.Point(89, 13);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(121, 22);
            this.txtItem.TabIndex = 0;
            // 
            // txtManager
            // 
            this.txtManager.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F);
            this.txtManager.Location = new System.Drawing.Point(89, 155);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(121, 22);
            this.txtManager.TabIndex = 243;
            // 
            // numSaveStock
            // 
            this.numSaveStock.Location = new System.Drawing.Point(90, 132);
            this.numSaveStock.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSaveStock.Name = "numSaveStock";
            this.numSaveStock.Size = new System.Drawing.Size(121, 22);
            this.numSaveStock.TabIndex = 15;
            this.numSaveStock.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numMinOrder
            // 
            this.numMinOrder.Location = new System.Drawing.Point(556, 109);
            this.numMinOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinOrder.Name = "numMinOrder";
            this.numMinOrder.Size = new System.Drawing.Size(121, 22);
            this.numMinOrder.TabIndex = 14;
            this.numMinOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PopUpItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(708, 410);
            this.Name = "PopUpItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopUpItem_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaveStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWareIn;
        private System.Windows.Forms.ComboBox cboUseYN;
        private System.Windows.Forms.ComboBox cboWareOut;
        private System.Windows.Forms.ComboBox cboDisconYN;
        private System.Windows.Forms.TextBox txtUnitQty;
        private System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOrderType;
        protected System.Windows.Forms.Label label29;
        protected System.Windows.Forms.Label label31;
        protected System.Windows.Forms.Label label32;
        protected System.Windows.Forms.Label label33;
        protected System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtModifierDate;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.TextBox txtStandard;
        protected System.Windows.Forms.Label label36;
        protected System.Windows.Forms.Label label39;
        protected System.Windows.Forms.Label label41;
        protected System.Windows.Forms.Label label42;
        protected System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtReadTime;
        protected System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cboDCompany;
        protected System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cboOCompany;
        protected System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox cboImportYN;
        protected System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox cboProcessYN;
        protected System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cboUnit;
        protected System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cboExportYN;
        protected System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox cboIType;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtIname;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.NumericUpDown numMinOrder;
        private System.Windows.Forms.NumericUpDown numSaveStock;
        private System.Windows.Forms.TextBox txtManager;
    }
}
