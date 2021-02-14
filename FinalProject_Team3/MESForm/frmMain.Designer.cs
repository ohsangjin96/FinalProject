
namespace MESForm
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCommonCode = new System.Windows.Forms.Button();
            this.btnAuthority = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlShipment = new System.Windows.Forms.Panel();
            this.btnShipmentManager = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.pnlProcessRegister = new System.Windows.Forms.Panel();
            this.btnProcessMove = new System.Windows.Forms.Button();
            this.btnProcessRegister = new System.Windows.Forms.Button();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnCurrentProcess = new System.Windows.Forms.Button();
            this.btnWorkOrder = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pnlPurchase = new System.Windows.Forms.Panel();
            this.btnMConfine = new System.Windows.Forms.Button();
            this.btnMC_Request = new System.Windows.Forms.Button();
            this.btnCurrentSR = new System.Windows.Forms.Button();
            this.btnCurrentWS = new System.Windows.Forms.Button();
            this.btnCurrentWM = new System.Windows.Forms.Button();
            this.btnWMaterial = new System.Windows.Forms.Button();
            this.btnExamine = new System.Windows.Forms.Button();
            this.btnWStandby = new System.Windows.Forms.Button();
            this.btnCurrentOrder = new System.Windows.Forms.Button();
            this.btnROrder = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.pnlOrderProduction = new System.Windows.Forms.Panel();
            this.btnProduction_Plan = new System.Windows.Forms.Button();
            this.btnM_Take_Plan = new System.Windows.Forms.Button();
            this.btnOrderProduction = new System.Windows.Forms.Button();
            this.pnlOrderPlan = new System.Windows.Forms.Panel();
            this.btnDemand = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnPOUpload = new System.Windows.Forms.Button();
            this.btnOrderPlan = new System.Windows.Forms.Button();
            this.pnlShift = new System.Windows.Forms.Panel();
            this.btnShiftSchedule = new System.Windows.Forms.Button();
            this.btnShiftInfo = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.pnlSaleCost = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSaleCost = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnlResource = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnFacility = new System.Windows.Forms.Button();
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.모든탭닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstxtExplain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.custTab = new MESForm.CustomControls.custTabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlShipment.SuspendLayout();
            this.pnlProcessRegister.SuspendLayout();
            this.pnlProcess.SuspendLayout();
            this.pnlPurchase.SuspendLayout();
            this.pnlOrderProduction.SuspendLayout();
            this.pnlOrderPlan.SuspendLayout();
            this.pnlShift.SuspendLayout();
            this.pnlSaleCost.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlResource.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnCommonCode);
            this.panel1.Controls.Add(this.btnAuthority);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 95);
            this.panel1.TabIndex = 1;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogout.ForeColor = System.Drawing.Color.Magenta;
            this.lblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblLogout.LinkColor = System.Drawing.Color.Violet;
            this.lblLogout.Location = new System.Drawing.Point(1043, 77);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(55, 14);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "로그아웃";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(816, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCommonCode
            // 
            this.btnCommonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommonCode.BackColor = System.Drawing.Color.Transparent;
            this.btnCommonCode.FlatAppearance.BorderSize = 0;
            this.btnCommonCode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCommonCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCommonCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCommonCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommonCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCommonCode.ForeColor = System.Drawing.Color.White;
            this.btnCommonCode.Image = global::MESForm.Properties.Resources.CommonCode;
            this.btnCommonCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommonCode.Location = new System.Drawing.Point(858, 12);
            this.btnCommonCode.Name = "btnCommonCode";
            this.btnCommonCode.Size = new System.Drawing.Size(117, 48);
            this.btnCommonCode.TabIndex = 2;
            this.btnCommonCode.Text = "        공통코드";
            this.btnCommonCode.UseVisualStyleBackColor = false;
            this.btnCommonCode.Click += new System.EventHandler(this.btnCommonCode_Click);
            // 
            // btnAuthority
            // 
            this.btnAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthority.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthority.FlatAppearance.BorderSize = 0;
            this.btnAuthority.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAuthority.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAuthority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthority.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAuthority.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuthority.Image = global::MESForm.Properties.Resources.Authority;
            this.btnAuthority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthority.Location = new System.Drawing.Point(981, 12);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Size = new System.Drawing.Size(117, 48);
            this.btnAuthority.TabIndex = 1;
            this.btnAuthority.Text = "        권한관리";
            this.btnAuthority.UseVisualStyleBackColor = false;
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::MESForm.Properties.Resources.mainLogo;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(238, 95);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.pnlShipment);
            this.pnlMenu.Controls.Add(this.btnShipment);
            this.pnlMenu.Controls.Add(this.pnlProcessRegister);
            this.pnlMenu.Controls.Add(this.btnProcessRegister);
            this.pnlMenu.Controls.Add(this.pnlProcess);
            this.pnlMenu.Controls.Add(this.btnProcess);
            this.pnlMenu.Controls.Add(this.pnlPurchase);
            this.pnlMenu.Controls.Add(this.btnPurchase);
            this.pnlMenu.Controls.Add(this.pnlOrderProduction);
            this.pnlMenu.Controls.Add(this.btnOrderProduction);
            this.pnlMenu.Controls.Add(this.pnlOrderPlan);
            this.pnlMenu.Controls.Add(this.btnOrderPlan);
            this.pnlMenu.Controls.Add(this.pnlShift);
            this.pnlMenu.Controls.Add(this.btnShift);
            this.pnlMenu.Controls.Add(this.pnlSaleCost);
            this.pnlMenu.Controls.Add(this.btnSaleCost);
            this.pnlMenu.Controls.Add(this.pnlProduct);
            this.pnlMenu.Controls.Add(this.btnProduct);
            this.pnlMenu.Controls.Add(this.pnlResource);
            this.pnlMenu.Controls.Add(this.btnResource);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 95);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(238, 673);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlShipment
            // 
            this.pnlShipment.Controls.Add(this.btnShipmentManager);
            this.pnlShipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShipment.Location = new System.Drawing.Point(0, 1683);
            this.pnlShipment.Name = "pnlShipment";
            this.pnlShipment.Size = new System.Drawing.Size(221, 43);
            this.pnlShipment.TabIndex = 18;
            // 
            // btnShipmentManager
            // 
            this.btnShipmentManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipmentManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipmentManager.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShipmentManager.Location = new System.Drawing.Point(0, 0);
            this.btnShipmentManager.Name = "btnShipmentManager";
            this.btnShipmentManager.Size = new System.Drawing.Size(221, 43);
            this.btnShipmentManager.TabIndex = 17;
            this.btnShipmentManager.Text = "제품 출하 및 마감";
            this.btnShipmentManager.UseVisualStyleBackColor = true;
            this.btnShipmentManager.Click += new System.EventHandler(this.btnShipmentManager_Click);
            this.btnShipmentManager.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnShipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipment.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShipment.Location = new System.Drawing.Point(0, 1640);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(221, 43);
            this.btnShipment.TabIndex = 16;
            this.btnShipment.Text = "출하관리";
            this.btnShipment.UseVisualStyleBackColor = false;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // pnlProcessRegister
            // 
            this.pnlProcessRegister.Controls.Add(this.btnProcessMove);
            this.pnlProcessRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcessRegister.Location = new System.Drawing.Point(0, 1597);
            this.pnlProcessRegister.Name = "pnlProcessRegister";
            this.pnlProcessRegister.Size = new System.Drawing.Size(221, 43);
            this.pnlProcessRegister.TabIndex = 15;
            // 
            // btnProcessMove
            // 
            this.btnProcessMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessMove.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcessMove.Location = new System.Drawing.Point(0, 0);
            this.btnProcessMove.Name = "btnProcessMove";
            this.btnProcessMove.Size = new System.Drawing.Size(221, 43);
            this.btnProcessMove.TabIndex = 2;
            this.btnProcessMove.Text = "공정이동";
            this.btnProcessMove.UseVisualStyleBackColor = true;
            this.btnProcessMove.Click += new System.EventHandler(this.btnProcessMove_Click);
            this.btnProcessMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnProcessRegister
            // 
            this.btnProcessRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnProcessRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessRegister.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcessRegister.Location = new System.Drawing.Point(0, 1554);
            this.btnProcessRegister.Name = "btnProcessRegister";
            this.btnProcessRegister.Size = new System.Drawing.Size(221, 43);
            this.btnProcessRegister.TabIndex = 10;
            this.btnProcessRegister.Text = "공정등록";
            this.btnProcessRegister.UseVisualStyleBackColor = false;
            this.btnProcessRegister.Click += new System.EventHandler(this.btnProcessRegister_Click);
            // 
            // pnlProcess
            // 
            this.pnlProcess.Controls.Add(this.btnPerformance);
            this.pnlProcess.Controls.Add(this.btnCurrentProcess);
            this.pnlProcess.Controls.Add(this.btnWorkOrder);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcess.Location = new System.Drawing.Point(0, 1424);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(221, 130);
            this.pnlProcess.TabIndex = 14;
            // 
            // btnPerformance
            // 
            this.btnPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPerformance.Location = new System.Drawing.Point(0, 86);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(221, 43);
            this.btnPerformance.TabIndex = 4;
            this.btnPerformance.Text = "실적확인";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            this.btnPerformance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCurrentProcess
            // 
            this.btnCurrentProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentProcess.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCurrentProcess.Location = new System.Drawing.Point(0, 43);
            this.btnCurrentProcess.Name = "btnCurrentProcess";
            this.btnCurrentProcess.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentProcess.TabIndex = 3;
            this.btnCurrentProcess.Text = "공정재고현황";
            this.btnCurrentProcess.UseVisualStyleBackColor = true;
            this.btnCurrentProcess.Click += new System.EventHandler(this.btnCurrentProcess_Click);
            this.btnCurrentProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrder.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.btnWorkOrder.Name = "btnWorkOrder";
            this.btnWorkOrder.Size = new System.Drawing.Size(221, 43);
            this.btnWorkOrder.TabIndex = 1;
            this.btnWorkOrder.Text = "작업지시생성";
            this.btnWorkOrder.UseVisualStyleBackColor = true;
            this.btnWorkOrder.Click += new System.EventHandler(this.btnWorkOrder_Click);
            this.btnWorkOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcess.Location = new System.Drawing.Point(0, 1381);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(221, 43);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "공정관리";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pnlPurchase
            // 
            this.pnlPurchase.Controls.Add(this.btnMConfine);
            this.pnlPurchase.Controls.Add(this.btnMC_Request);
            this.pnlPurchase.Controls.Add(this.btnCurrentSR);
            this.pnlPurchase.Controls.Add(this.btnCurrentWS);
            this.pnlPurchase.Controls.Add(this.btnCurrentWM);
            this.pnlPurchase.Controls.Add(this.btnWMaterial);
            this.pnlPurchase.Controls.Add(this.btnExamine);
            this.pnlPurchase.Controls.Add(this.btnWStandby);
            this.pnlPurchase.Controls.Add(this.btnCurrentOrder);
            this.pnlPurchase.Controls.Add(this.btnROrder);
            this.pnlPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchase.Location = new System.Drawing.Point(0, 951);
            this.pnlPurchase.Name = "pnlPurchase";
            this.pnlPurchase.Size = new System.Drawing.Size(221, 430);
            this.pnlPurchase.TabIndex = 13;
            // 
            // btnMConfine
            // 
            this.btnMConfine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMConfine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMConfine.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMConfine.Location = new System.Drawing.Point(0, 387);
            this.btnMConfine.Name = "btnMConfine";
            this.btnMConfine.Size = new System.Drawing.Size(221, 43);
            this.btnMConfine.TabIndex = 9;
            this.btnMConfine.Text = "원자재불출";
            this.btnMConfine.UseVisualStyleBackColor = true;
            this.btnMConfine.Click += new System.EventHandler(this.btnMConfine_Click);
            this.btnMConfine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnMC_Request
            // 
            this.btnMC_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMC_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC_Request.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMC_Request.Location = new System.Drawing.Point(0, 344);
            this.btnMC_Request.Name = "btnMC_Request";
            this.btnMC_Request.Size = new System.Drawing.Size(221, 43);
            this.btnMC_Request.TabIndex = 8;
            this.btnMC_Request.Text = "자재불출요청";
            this.btnMC_Request.UseVisualStyleBackColor = true;
            this.btnMC_Request.Click += new System.EventHandler(this.btnMC_Request_Click);
            this.btnMC_Request.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCurrentSR
            // 
            this.btnCurrentSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentSR.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCurrentSR.Location = new System.Drawing.Point(0, 301);
            this.btnCurrentSR.Name = "btnCurrentSR";
            this.btnCurrentSR.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentSR.TabIndex = 7;
            this.btnCurrentSR.Text = "입출고현황";
            this.btnCurrentSR.UseVisualStyleBackColor = true;
            this.btnCurrentSR.Click += new System.EventHandler(this.btnCurrentSR_Click);
            this.btnCurrentSR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCurrentWS
            // 
            this.btnCurrentWS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentWS.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCurrentWS.Location = new System.Drawing.Point(0, 258);
            this.btnCurrentWS.Name = "btnCurrentWS";
            this.btnCurrentWS.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentWS.TabIndex = 6;
            this.btnCurrentWS.Text = "자재재고현황";
            this.btnCurrentWS.UseVisualStyleBackColor = true;
            this.btnCurrentWS.Click += new System.EventHandler(this.btnCurrentWS_Click);
            this.btnCurrentWS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCurrentWM
            // 
            this.btnCurrentWM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentWM.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCurrentWM.Location = new System.Drawing.Point(0, 215);
            this.btnCurrentWM.Name = "btnCurrentWM";
            this.btnCurrentWM.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentWM.TabIndex = 5;
            this.btnCurrentWM.Text = "자재입고현황";
            this.btnCurrentWM.UseVisualStyleBackColor = true;
            this.btnCurrentWM.Click += new System.EventHandler(this.btnCurrentWM_Click);
            this.btnCurrentWM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnWMaterial
            // 
            this.btnWMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWMaterial.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWMaterial.Location = new System.Drawing.Point(0, 172);
            this.btnWMaterial.Name = "btnWMaterial";
            this.btnWMaterial.Size = new System.Drawing.Size(221, 43);
            this.btnWMaterial.TabIndex = 4;
            this.btnWMaterial.Text = "자재입고";
            this.btnWMaterial.UseVisualStyleBackColor = true;
            this.btnWMaterial.Click += new System.EventHandler(this.btnWMaterial_Click);
            this.btnWMaterial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnExamine
            // 
            this.btnExamine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamine.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExamine.Location = new System.Drawing.Point(0, 129);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(221, 43);
            this.btnExamine.TabIndex = 10;
            this.btnExamine.Text = "수입검사";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            this.btnExamine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnWStandby
            // 
            this.btnWStandby.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWStandby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWStandby.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWStandby.Location = new System.Drawing.Point(0, 86);
            this.btnWStandby.Name = "btnWStandby";
            this.btnWStandby.Size = new System.Drawing.Size(221, 43);
            this.btnWStandby.TabIndex = 3;
            this.btnWStandby.Text = "입고대기";
            this.btnWStandby.UseVisualStyleBackColor = true;
            this.btnWStandby.Click += new System.EventHandler(this.btnWStandby_Click);
            this.btnWStandby.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCurrentOrder
            // 
            this.btnCurrentOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrder.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCurrentOrder.Location = new System.Drawing.Point(0, 43);
            this.btnCurrentOrder.Name = "btnCurrentOrder";
            this.btnCurrentOrder.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentOrder.TabIndex = 2;
            this.btnCurrentOrder.Text = "발주현황";
            this.btnCurrentOrder.UseVisualStyleBackColor = true;
            this.btnCurrentOrder.Click += new System.EventHandler(this.btnCurrentOrder_Click);
            this.btnCurrentOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnROrder
            // 
            this.btnROrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnROrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnROrder.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnROrder.Location = new System.Drawing.Point(0, 0);
            this.btnROrder.Name = "btnROrder";
            this.btnROrder.Size = new System.Drawing.Size(221, 43);
            this.btnROrder.TabIndex = 1;
            this.btnROrder.Text = "정규발주";
            this.btnROrder.UseVisualStyleBackColor = true;
            this.btnROrder.Click += new System.EventHandler(this.btnROrder_Click);
            this.btnROrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPurchase.Location = new System.Drawing.Point(0, 908);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(221, 43);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "구매관리";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // pnlOrderProduction
            // 
            this.pnlOrderProduction.Controls.Add(this.btnProduction_Plan);
            this.pnlOrderProduction.Controls.Add(this.btnM_Take_Plan);
            this.pnlOrderProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderProduction.Location = new System.Drawing.Point(0, 822);
            this.pnlOrderProduction.Name = "pnlOrderProduction";
            this.pnlOrderProduction.Size = new System.Drawing.Size(221, 86);
            this.pnlOrderProduction.TabIndex = 12;
            // 
            // btnProduction_Plan
            // 
            this.btnProduction_Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduction_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction_Plan.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduction_Plan.Location = new System.Drawing.Point(0, 43);
            this.btnProduction_Plan.Name = "btnProduction_Plan";
            this.btnProduction_Plan.Size = new System.Drawing.Size(221, 43);
            this.btnProduction_Plan.TabIndex = 2;
            this.btnProduction_Plan.Text = "생산계획";
            this.btnProduction_Plan.UseVisualStyleBackColor = true;
            this.btnProduction_Plan.Click += new System.EventHandler(this.btnProduction_Plan_Click);
            this.btnProduction_Plan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnM_Take_Plan
            // 
            this.btnM_Take_Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnM_Take_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Take_Plan.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnM_Take_Plan.Location = new System.Drawing.Point(0, 0);
            this.btnM_Take_Plan.Name = "btnM_Take_Plan";
            this.btnM_Take_Plan.Size = new System.Drawing.Size(221, 43);
            this.btnM_Take_Plan.TabIndex = 1;
            this.btnM_Take_Plan.Text = "자재소요계획";
            this.btnM_Take_Plan.UseVisualStyleBackColor = true;
            this.btnM_Take_Plan.Click += new System.EventHandler(this.btnM_Take_Plan_Click);
            this.btnM_Take_Plan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnOrderProduction
            // 
            this.btnOrderProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnOrderProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderProduction.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrderProduction.Location = new System.Drawing.Point(0, 779);
            this.btnOrderProduction.Name = "btnOrderProduction";
            this.btnOrderProduction.Size = new System.Drawing.Size(221, 43);
            this.btnOrderProduction.TabIndex = 7;
            this.btnOrderProduction.Text = "수주/생산관리";
            this.btnOrderProduction.UseVisualStyleBackColor = false;
            this.btnOrderProduction.Click += new System.EventHandler(this.btnOrderProduction_Click);
            // 
            // pnlOrderPlan
            // 
            this.pnlOrderPlan.Controls.Add(this.btnDemand);
            this.pnlOrderPlan.Controls.Add(this.btnPO);
            this.pnlOrderPlan.Controls.Add(this.btnPOUpload);
            this.pnlOrderPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderPlan.Location = new System.Drawing.Point(0, 649);
            this.pnlOrderPlan.Name = "pnlOrderPlan";
            this.pnlOrderPlan.Size = new System.Drawing.Size(221, 130);
            this.pnlOrderPlan.TabIndex = 11;
            // 
            // btnDemand
            // 
            this.btnDemand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemand.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDemand.Location = new System.Drawing.Point(0, 86);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Size = new System.Drawing.Size(221, 43);
            this.btnDemand.TabIndex = 3;
            this.btnDemand.Text = "수요계획";
            this.btnDemand.UseVisualStyleBackColor = true;
            this.btnDemand.Click += new System.EventHandler(this.btnDemand_Click);
            this.btnDemand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnPO
            // 
            this.btnPO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPO.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPO.Location = new System.Drawing.Point(0, 43);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(221, 43);
            this.btnPO.TabIndex = 2;
            this.btnPO.Text = "영업마스터 생성";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            this.btnPO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnPOUpload
            // 
            this.btnPOUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOUpload.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPOUpload.Location = new System.Drawing.Point(0, 0);
            this.btnPOUpload.Name = "btnPOUpload";
            this.btnPOUpload.Size = new System.Drawing.Size(221, 43);
            this.btnPOUpload.TabIndex = 1;
            this.btnPOUpload.Text = "영업마스터 업로드(PO)";
            this.btnPOUpload.UseVisualStyleBackColor = true;
            this.btnPOUpload.Click += new System.EventHandler(this.btnPOUpload_Click);
            this.btnPOUpload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnOrderPlan
            // 
            this.btnOrderPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnOrderPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPlan.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrderPlan.Location = new System.Drawing.Point(0, 606);
            this.btnOrderPlan.Name = "btnOrderPlan";
            this.btnOrderPlan.Size = new System.Drawing.Size(221, 43);
            this.btnOrderPlan.TabIndex = 6;
            this.btnOrderPlan.Text = "수주/계획관리";
            this.btnOrderPlan.UseVisualStyleBackColor = false;
            this.btnOrderPlan.Click += new System.EventHandler(this.btnOrderPlan_Click);
            // 
            // pnlShift
            // 
            this.pnlShift.Controls.Add(this.btnShiftSchedule);
            this.pnlShift.Controls.Add(this.btnShiftInfo);
            this.pnlShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShift.Location = new System.Drawing.Point(0, 519);
            this.pnlShift.Name = "pnlShift";
            this.pnlShift.Size = new System.Drawing.Size(221, 87);
            this.pnlShift.TabIndex = 20;
            // 
            // btnShiftSchedule
            // 
            this.btnShiftSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShiftSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftSchedule.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShiftSchedule.Location = new System.Drawing.Point(0, 43);
            this.btnShiftSchedule.Name = "btnShiftSchedule";
            this.btnShiftSchedule.Size = new System.Drawing.Size(221, 43);
            this.btnShiftSchedule.TabIndex = 2;
            this.btnShiftSchedule.Text = "Shift 스케줄관리";
            this.btnShiftSchedule.UseVisualStyleBackColor = true;
            this.btnShiftSchedule.Click += new System.EventHandler(this.btnShiftSchedule_Click);
            this.btnShiftSchedule.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnShiftInfo
            // 
            this.btnShiftInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShiftInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftInfo.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShiftInfo.Location = new System.Drawing.Point(0, 0);
            this.btnShiftInfo.Name = "btnShiftInfo";
            this.btnShiftInfo.Size = new System.Drawing.Size(221, 43);
            this.btnShiftInfo.TabIndex = 1;
            this.btnShiftInfo.Text = "Shift 기준정보";
            this.btnShiftInfo.UseVisualStyleBackColor = true;
            this.btnShiftInfo.Click += new System.EventHandler(this.btnShiftInfo_Click);
            this.btnShiftInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShift.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShift.Location = new System.Drawing.Point(0, 476);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(221, 43);
            this.btnShift.TabIndex = 19;
            this.btnShift.Text = "근무관리";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // pnlSaleCost
            // 
            this.pnlSaleCost.Controls.Add(this.button7);
            this.pnlSaleCost.Controls.Add(this.button8);
            this.pnlSaleCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaleCost.Location = new System.Drawing.Point(0, 389);
            this.pnlSaleCost.Name = "pnlSaleCost";
            this.pnlSaleCost.Size = new System.Drawing.Size(221, 87);
            this.pnlSaleCost.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(0, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(221, 43);
            this.button7.TabIndex = 2;
            this.button7.Text = "영업단가";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 43);
            this.button8.TabIndex = 1;
            this.button8.Text = "자재단가";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnSaleCost
            // 
            this.btnSaleCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnSaleCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleCost.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaleCost.Location = new System.Drawing.Point(0, 346);
            this.btnSaleCost.Name = "btnSaleCost";
            this.btnSaleCost.Size = new System.Drawing.Size(221, 43);
            this.btnSaleCost.TabIndex = 4;
            this.btnSaleCost.Text = "단가관리";
            this.btnSaleCost.UseVisualStyleBackColor = false;
            this.btnSaleCost.Click += new System.EventHandler(this.btnSaleCost_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.button9);
            this.pnlProduct.Controls.Add(this.button10);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProduct.Location = new System.Drawing.Point(0, 259);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(221, 87);
            this.pnlProduct.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(0, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(221, 43);
            this.button9.TabIndex = 2;
            this.button9.Text = "BOM";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(221, 43);
            this.button10.TabIndex = 1;
            this.button10.Text = "품목관리";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduct.Location = new System.Drawing.Point(0, 216);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(221, 43);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "품목관리";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pnlResource
            // 
            this.pnlResource.Controls.Add(this.button5);
            this.pnlResource.Controls.Add(this.btnCompany);
            this.pnlResource.Controls.Add(this.btnFacility);
            this.pnlResource.Controls.Add(this.btnFactory);
            this.pnlResource.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResource.Location = new System.Drawing.Point(0, 43);
            this.pnlResource.Name = "pnlResource";
            this.pnlResource.Size = new System.Drawing.Size(221, 173);
            this.pnlResource.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(0, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "BOR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnBOR_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnCompany
            // 
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCompany.Location = new System.Drawing.Point(0, 86);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(221, 43);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "업체관리";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            this.btnCompany.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnFacility
            // 
            this.btnFacility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacility.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFacility.Location = new System.Drawing.Point(0, 43);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Size = new System.Drawing.Size(221, 43);
            this.btnFacility.TabIndex = 2;
            this.btnFacility.Text = "설비관리";
            this.btnFacility.UseVisualStyleBackColor = true;
            this.btnFacility.Click += new System.EventHandler(this.btnFacility_Click);
            this.btnFacility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnFactory
            // 
            this.btnFactory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactory.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFactory.Location = new System.Drawing.Point(0, 0);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(221, 43);
            this.btnFactory.TabIndex = 1;
            this.btnFactory.Text = "공장관리";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            this.btnFactory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnResource
            // 
            this.btnResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnResource.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResource.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResource.Location = new System.Drawing.Point(0, 0);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(221, 43);
            this.btnResource.TabIndex = 0;
            this.btnResource.Text = "자원관리";
            this.btnResource.UseVisualStyleBackColor = false;
            this.btnResource.Click += new System.EventHandler(this.btnResource_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모든탭닫기ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // 모든탭닫기ToolStripMenuItem
            // 
            this.모든탭닫기ToolStripMenuItem.Name = "모든탭닫기ToolStripMenuItem";
            this.모든탭닫기ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.모든탭닫기ToolStripMenuItem.Text = "모든 탭 닫기(&L)";
            this.모든탭닫기ToolStripMenuItem.Click += new System.EventHandler(this.모든탭닫기ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.닫기ToolStripMenuItem.Text = "닫기(&C)";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtExplain,
            this.tslblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(238, 746);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstxtExplain
            // 
            this.tstxtExplain.Name = "tstxtExplain";
            this.tstxtExplain.Size = new System.Drawing.Size(793, 17);
            this.tstxtExplain.Spring = true;
            this.tstxtExplain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslblDateTime
            // 
            this.tslblDateTime.Name = "tslblDateTime";
            this.tslblDateTime.Size = new System.Drawing.Size(55, 17);
            this.tslblDateTime.Text = "현재시간";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // custTab
            // 
            this.custTab.ContextMenuStrip = this.contextMenuStrip1;
            this.custTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.custTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.custTab.Location = new System.Drawing.Point(238, 95);
            this.custTab.Name = "custTab";
            this.custTab.SelectedIndex = 0;
            this.custTab.Size = new System.Drawing.Size(863, 24);
            this.custTab.TabIndex = 4;
            this.custTab.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            this.custTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabForms_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 768);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.custTab);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "SmartMOM - made by GDC6 / Team3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlShipment.ResumeLayout(false);
            this.pnlProcessRegister.ResumeLayout(false);
            this.pnlProcess.ResumeLayout(false);
            this.pnlPurchase.ResumeLayout(false);
            this.pnlOrderProduction.ResumeLayout(false);
            this.pnlOrderPlan.ResumeLayout(false);
            this.pnlShift.ResumeLayout(false);
            this.pnlSaleCost.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlResource.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnResource;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pnlResource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnFacility;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Panel pnlSaleCost;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSaleCost;
        private CustomControls.custTabControl custTab;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnOrderProduction;
        private System.Windows.Forms.Button btnOrderPlan;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnProcessRegister;
        private System.Windows.Forms.Panel pnlOrderPlan;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnPOUpload;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.Panel pnlOrderProduction;
        private System.Windows.Forms.Button btnProduction_Plan;
        private System.Windows.Forms.Button btnM_Take_Plan;
        private System.Windows.Forms.Panel pnlPurchase;
        private System.Windows.Forms.Button btnWStandby;
        private System.Windows.Forms.Button btnCurrentOrder;
        private System.Windows.Forms.Button btnROrder;
        private System.Windows.Forms.Button btnWMaterial;
        private System.Windows.Forms.Button btnCurrentWM;
        private System.Windows.Forms.Button btnCurrentSR;
        private System.Windows.Forms.Button btnCurrentWS;
        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.Button btnWorkOrder;
        private System.Windows.Forms.Button btnMC_Request;
        private System.Windows.Forms.Button btnMConfine;
        private System.Windows.Forms.Panel pnlProcessRegister;
        private System.Windows.Forms.Button btnCurrentProcess;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Button btnProcessMove;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Button btnShipmentManager;
        private System.Windows.Forms.Panel pnlShift;
        private System.Windows.Forms.Button btnShiftSchedule;
        private System.Windows.Forms.Button btnShiftInfo;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Panel pnlShipment;
        private System.Windows.Forms.Button btnAuthority;
        private System.Windows.Forms.Button btnCommonCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 모든탭닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblDateTime;
        private System.Windows.Forms.ToolStripStatusLabel tstxtExplain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPerformance;
    }
}

