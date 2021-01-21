
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShipmentManager = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnProcessMove = new System.Windows.Forms.Button();
            this.btnProcessRegister = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCurrentProcess = new System.Windows.Forms.Button();
            this.btnWorkOrder = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnProduction_Plan = new System.Windows.Forms.Button();
            this.btnM_Take_Plan = new System.Windows.Forms.Button();
            this.btnOrderProduction = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDemand = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnPOUpload = new System.Windows.Forms.Button();
            this.btnOrderPlan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnFacility = new System.Windows.Forms.Button();
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.custTab = new MESForm.CustomControls.custTabControl();
            this.label41 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 95);
            this.panel1.TabIndex = 1;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::MESForm.Properties.Resources.mainLogo;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(238, 95);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnShipmentManager);
            this.panel2.Controls.Add(this.btnShipment);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.btnProcessRegister);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.btnPurchase);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnOrderProduction);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnOrderPlan);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnResource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 673);
            this.panel2.TabIndex = 2;
            // 
            // btnShipmentManager
            // 
            this.btnShipmentManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipmentManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipmentManager.Location = new System.Drawing.Point(0, 1509);
            this.btnShipmentManager.Name = "btnShipmentManager";
            this.btnShipmentManager.Size = new System.Drawing.Size(221, 43);
            this.btnShipmentManager.TabIndex = 17;
            this.btnShipmentManager.Text = "제품 출하 및 마감";
            this.btnShipmentManager.UseVisualStyleBackColor = true;
            this.btnShipmentManager.Click += new System.EventHandler(this.btnShipmentManager_Click);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipment.Location = new System.Drawing.Point(0, 1466);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(221, 43);
            this.btnShipment.TabIndex = 16;
            this.btnShipment.Text = "출하관리";
            this.btnShipment.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnProcessMove);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 1423);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(221, 43);
            this.panel10.TabIndex = 15;
            // 
            // btnProcessMove
            // 
            this.btnProcessMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessMove.Location = new System.Drawing.Point(0, 0);
            this.btnProcessMove.Name = "btnProcessMove";
            this.btnProcessMove.Size = new System.Drawing.Size(221, 43);
            this.btnProcessMove.TabIndex = 2;
            this.btnProcessMove.Text = "공정이동";
            this.btnProcessMove.UseVisualStyleBackColor = true;
            this.btnProcessMove.Click += new System.EventHandler(this.btnProcessMove_Click);
            // 
            // btnProcessRegister
            // 
            this.btnProcessRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcessRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessRegister.Location = new System.Drawing.Point(0, 1380);
            this.btnProcessRegister.Name = "btnProcessRegister";
            this.btnProcessRegister.Size = new System.Drawing.Size(221, 43);
            this.btnProcessRegister.TabIndex = 10;
            this.btnProcessRegister.Text = "공정등록";
            this.btnProcessRegister.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCurrentProcess);
            this.panel9.Controls.Add(this.btnWorkOrder);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 1294);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 86);
            this.panel9.TabIndex = 14;
            // 
            // btnCurrentProcess
            // 
            this.btnCurrentProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentProcess.Location = new System.Drawing.Point(0, 43);
            this.btnCurrentProcess.Name = "btnCurrentProcess";
            this.btnCurrentProcess.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentProcess.TabIndex = 3;
            this.btnCurrentProcess.Text = "공정재고현황";
            this.btnCurrentProcess.UseVisualStyleBackColor = true;
            this.btnCurrentProcess.Click += new System.EventHandler(this.btnCurrentProcess_Click);
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.btnWorkOrder.Name = "btnWorkOrder";
            this.btnWorkOrder.Size = new System.Drawing.Size(221, 43);
            this.btnWorkOrder.TabIndex = 1;
            this.btnWorkOrder.Text = "작업지시생성";
            this.btnWorkOrder.UseVisualStyleBackColor = true;
            this.btnWorkOrder.Click += new System.EventHandler(this.btnWorkOrder_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(0, 1251);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(221, 43);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "공정관리";
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnMConfine);
            this.panel8.Controls.Add(this.btnMC_Request);
            this.panel8.Controls.Add(this.btnCurrentSR);
            this.panel8.Controls.Add(this.btnCurrentWS);
            this.panel8.Controls.Add(this.btnCurrentWM);
            this.panel8.Controls.Add(this.btnWMaterial);
            this.panel8.Controls.Add(this.btnExamine);
            this.panel8.Controls.Add(this.btnWStandby);
            this.panel8.Controls.Add(this.btnCurrentOrder);
            this.panel8.Controls.Add(this.btnROrder);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 821);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(221, 430);
            this.panel8.TabIndex = 13;
            // 
            // btnMConfine
            // 
            this.btnMConfine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMConfine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMConfine.Location = new System.Drawing.Point(0, 387);
            this.btnMConfine.Name = "btnMConfine";
            this.btnMConfine.Size = new System.Drawing.Size(221, 43);
            this.btnMConfine.TabIndex = 9;
            this.btnMConfine.Text = "원자재불출";
            this.btnMConfine.UseVisualStyleBackColor = true;
            this.btnMConfine.Click += new System.EventHandler(this.btnMConfine_Click);
            // 
            // btnMC_Request
            // 
            this.btnMC_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMC_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC_Request.Location = new System.Drawing.Point(0, 344);
            this.btnMC_Request.Name = "btnMC_Request";
            this.btnMC_Request.Size = new System.Drawing.Size(221, 43);
            this.btnMC_Request.TabIndex = 8;
            this.btnMC_Request.Text = "자재불출요청";
            this.btnMC_Request.UseVisualStyleBackColor = true;
            this.btnMC_Request.Click += new System.EventHandler(this.btnMC_Request_Click);
            // 
            // btnCurrentSR
            // 
            this.btnCurrentSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentSR.Location = new System.Drawing.Point(0, 301);
            this.btnCurrentSR.Name = "btnCurrentSR";
            this.btnCurrentSR.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentSR.TabIndex = 7;
            this.btnCurrentSR.Text = "입출고현황";
            this.btnCurrentSR.UseVisualStyleBackColor = true;
            this.btnCurrentSR.Click += new System.EventHandler(this.btnCurrentSR_Click);
            // 
            // btnCurrentWS
            // 
            this.btnCurrentWS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentWS.Location = new System.Drawing.Point(0, 258);
            this.btnCurrentWS.Name = "btnCurrentWS";
            this.btnCurrentWS.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentWS.TabIndex = 6;
            this.btnCurrentWS.Text = "자재재고현황";
            this.btnCurrentWS.UseVisualStyleBackColor = true;
            this.btnCurrentWS.Click += new System.EventHandler(this.btnCurrentWS_Click);
            // 
            // btnCurrentWM
            // 
            this.btnCurrentWM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentWM.Location = new System.Drawing.Point(0, 215);
            this.btnCurrentWM.Name = "btnCurrentWM";
            this.btnCurrentWM.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentWM.TabIndex = 5;
            this.btnCurrentWM.Text = "자재입고현황";
            this.btnCurrentWM.UseVisualStyleBackColor = true;
            this.btnCurrentWM.Click += new System.EventHandler(this.btnCurrentWM_Click);
            // 
            // btnWMaterial
            // 
            this.btnWMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWMaterial.Location = new System.Drawing.Point(0, 172);
            this.btnWMaterial.Name = "btnWMaterial";
            this.btnWMaterial.Size = new System.Drawing.Size(221, 43);
            this.btnWMaterial.TabIndex = 4;
            this.btnWMaterial.Text = "자재입고";
            this.btnWMaterial.UseVisualStyleBackColor = true;
            this.btnWMaterial.Click += new System.EventHandler(this.btnWMaterial_Click);
            // 
            // btnExamine
            // 
            this.btnExamine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamine.Location = new System.Drawing.Point(0, 129);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(221, 43);
            this.btnExamine.TabIndex = 10;
            this.btnExamine.Text = "수입검사";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // btnWStandby
            // 
            this.btnWStandby.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWStandby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWStandby.Location = new System.Drawing.Point(0, 86);
            this.btnWStandby.Name = "btnWStandby";
            this.btnWStandby.Size = new System.Drawing.Size(221, 43);
            this.btnWStandby.TabIndex = 3;
            this.btnWStandby.Text = "입고대기";
            this.btnWStandby.UseVisualStyleBackColor = true;
            this.btnWStandby.Click += new System.EventHandler(this.btnWStandby_Click);
            // 
            // btnCurrentOrder
            // 
            this.btnCurrentOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrder.Location = new System.Drawing.Point(0, 43);
            this.btnCurrentOrder.Name = "btnCurrentOrder";
            this.btnCurrentOrder.Size = new System.Drawing.Size(221, 43);
            this.btnCurrentOrder.TabIndex = 2;
            this.btnCurrentOrder.Text = "발주현황";
            this.btnCurrentOrder.UseVisualStyleBackColor = true;
            this.btnCurrentOrder.Click += new System.EventHandler(this.btnCurrentOrder_Click);
            // 
            // btnROrder
            // 
            this.btnROrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnROrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnROrder.Location = new System.Drawing.Point(0, 0);
            this.btnROrder.Name = "btnROrder";
            this.btnROrder.Size = new System.Drawing.Size(221, 43);
            this.btnROrder.TabIndex = 1;
            this.btnROrder.Text = "정규발주";
            this.btnROrder.UseVisualStyleBackColor = true;
            this.btnROrder.Click += new System.EventHandler(this.btnROrder_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Location = new System.Drawing.Point(0, 778);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(221, 43);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "구매관리";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnProduction_Plan);
            this.panel7.Controls.Add(this.btnM_Take_Plan);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 692);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(221, 86);
            this.panel7.TabIndex = 12;
            // 
            // btnProduction_Plan
            // 
            this.btnProduction_Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduction_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction_Plan.Location = new System.Drawing.Point(0, 43);
            this.btnProduction_Plan.Name = "btnProduction_Plan";
            this.btnProduction_Plan.Size = new System.Drawing.Size(221, 43);
            this.btnProduction_Plan.TabIndex = 2;
            this.btnProduction_Plan.Text = "생산계획";
            this.btnProduction_Plan.UseVisualStyleBackColor = true;
            this.btnProduction_Plan.Click += new System.EventHandler(this.btnProduction_Plan_Click);
            // 
            // btnM_Take_Plan
            // 
            this.btnM_Take_Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnM_Take_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Take_Plan.Location = new System.Drawing.Point(0, 0);
            this.btnM_Take_Plan.Name = "btnM_Take_Plan";
            this.btnM_Take_Plan.Size = new System.Drawing.Size(221, 43);
            this.btnM_Take_Plan.TabIndex = 1;
            this.btnM_Take_Plan.Text = "자재소요계획";
            this.btnM_Take_Plan.UseVisualStyleBackColor = true;
            this.btnM_Take_Plan.Click += new System.EventHandler(this.btnM_Take_Plan_Click);
            // 
            // btnOrderProduction
            // 
            this.btnOrderProduction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderProduction.Location = new System.Drawing.Point(0, 649);
            this.btnOrderProduction.Name = "btnOrderProduction";
            this.btnOrderProduction.Size = new System.Drawing.Size(221, 43);
            this.btnOrderProduction.TabIndex = 7;
            this.btnOrderProduction.Text = "수주/생산관리";
            this.btnOrderProduction.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDemand);
            this.panel6.Controls.Add(this.btnPO);
            this.panel6.Controls.Add(this.btnPOUpload);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 519);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 130);
            this.panel6.TabIndex = 11;
            // 
            // btnDemand
            // 
            this.btnDemand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemand.Location = new System.Drawing.Point(0, 86);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Size = new System.Drawing.Size(221, 43);
            this.btnDemand.TabIndex = 3;
            this.btnDemand.Text = "수요계획";
            this.btnDemand.UseVisualStyleBackColor = true;
            this.btnDemand.Click += new System.EventHandler(this.btnDemand_Click);
            // 
            // btnPO
            // 
            this.btnPO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPO.Location = new System.Drawing.Point(0, 43);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(221, 43);
            this.btnPO.TabIndex = 2;
            this.btnPO.Text = "영업마스터 생성";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnPOUpload
            // 
            this.btnPOUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOUpload.Location = new System.Drawing.Point(0, 0);
            this.btnPOUpload.Name = "btnPOUpload";
            this.btnPOUpload.Size = new System.Drawing.Size(221, 43);
            this.btnPOUpload.TabIndex = 1;
            this.btnPOUpload.Text = "영업마스터 업로드(PO)";
            this.btnPOUpload.UseVisualStyleBackColor = true;
            this.btnPOUpload.Click += new System.EventHandler(this.btnPOUpload_Click);
            // 
            // btnOrderPlan
            // 
            this.btnOrderPlan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPlan.Location = new System.Drawing.Point(0, 476);
            this.btnOrderPlan.Name = "btnOrderPlan";
            this.btnOrderPlan.Size = new System.Drawing.Size(221, 43);
            this.btnOrderPlan.TabIndex = 6;
            this.btnOrderPlan.Text = "수주/계획관리";
            this.btnOrderPlan.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 87);
            this.panel5.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(221, 43);
            this.button7.TabIndex = 2;
            this.button7.Text = "영업단가";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 43);
            this.button8.TabIndex = 1;
            this.button8.Text = "자재단가";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 346);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(221, 43);
            this.button11.TabIndex = 4;
            this.button11.Text = "단가관리";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 87);
            this.panel4.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(221, 43);
            this.button9.TabIndex = 2;
            this.button9.Text = "BOM";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(221, 43);
            this.button10.TabIndex = 1;
            this.button10.Text = "품목관리";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Location = new System.Drawing.Point(0, 216);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(221, 43);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "품목관리";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnCompany);
            this.panel3.Controls.Add(this.btnFacility);
            this.panel3.Controls.Add(this.btnFactory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 173);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "BOR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnBOR_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Location = new System.Drawing.Point(0, 86);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(221, 43);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "업체관리";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnFacility
            // 
            this.btnFacility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacility.Location = new System.Drawing.Point(0, 43);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Size = new System.Drawing.Size(221, 43);
            this.btnFacility.TabIndex = 2;
            this.btnFacility.Text = "설비관리";
            this.btnFacility.UseVisualStyleBackColor = true;
            this.btnFacility.Click += new System.EventHandler(this.btnFacility_Click);
            // 
            // btnFactory
            // 
            this.btnFactory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactory.Location = new System.Drawing.Point(0, 0);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(221, 43);
            this.btnFactory.TabIndex = 1;
            this.btnFactory.Text = "공장관리";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // btnResource
            // 
            this.btnResource.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResource.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResource.Location = new System.Drawing.Point(0, 0);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(221, 43);
            this.btnResource.TabIndex = 0;
            this.btnResource.Text = "자원관리";
            this.btnResource.UseVisualStyleBackColor = false;
            // 
            // custTab
            // 
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
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label41.Font = new System.Drawing.Font("나눔스퀘어OTF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(238, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(863, 95);
            this.label41.TabIndex = 3;
            this.label41.Text = "* * * * MES 프로그램 * * * *";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 768);
            this.Controls.Add(this.custTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnFacility;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private CustomControls.custTabControl custTab;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnOrderProduction;
        private System.Windows.Forms.Button btnOrderPlan;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnProcessRegister;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnPOUpload;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnProduction_Plan;
        private System.Windows.Forms.Button btnM_Take_Plan;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnWStandby;
        private System.Windows.Forms.Button btnCurrentOrder;
        private System.Windows.Forms.Button btnROrder;
        private System.Windows.Forms.Button btnWMaterial;
        private System.Windows.Forms.Button btnCurrentWM;
        private System.Windows.Forms.Button btnCurrentSR;
        private System.Windows.Forms.Button btnCurrentWS;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnWorkOrder;
        private System.Windows.Forms.Button btnMC_Request;
        private System.Windows.Forms.Button btnMConfine;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCurrentProcess;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Button btnProcessMove;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Button btnShipmentManager;
        private System.Windows.Forms.Label label41;
    }
}

