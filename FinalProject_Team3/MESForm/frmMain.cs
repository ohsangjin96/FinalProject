using FProjectDAC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MESForm.Services;
using FProjectVO;

namespace MESForm
{
    public partial class frmMain : Form
    {
        //팝업 창을 띄었을 때 등록인지 수정인지
        public enum OpenMode { Register, Update,Copy }

        Cursor currentCursor = Cursors.Default; //기본 커서 저장을 위한 변수 선언

        //로그인 정보 가져오기
        public LoginVO DeptInfo { get; set; }

        public frmMain()
        {
            InitializeComponent();

            this.panel1.Paint += Panel_Paint;
        }

        /// <summary>
        /// 메인화면 상단 패널 디자인(그라데이션)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(244, 247, 245);
            Color middleColor = Color.FromArgb(60, 75, 140);
            Color endColor = Color.FromArgb(12, 30, 107);

            LinearGradientBrush br = new LinearGradientBrush(this.panel1.ClientRectangle, Color.White, Color.White, 0, false);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 2f, 1 };
            cb.Colors = new[] { startColor, middleColor, endColor };
            br.InterpolationColors = cb;
            br.RotateTransform(45);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        #region 폼 중복실행 방지
        //Mdi 중복 방지
        private void OpenCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    custTab.SelectedTab = (TabPage)this.ActiveMdiChild.Tag;
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;
            T frm = new T();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Cursor = currentCursor;
        }

        //값을 넘길 때
        private bool OpenFormMdi(Type t)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == t)
                {
                    form.Activate();
                    custTab.SelectedTab = (TabPage)this.ActiveMdiChild.Tag;
                    return true;
                }
            }
            return false;
        }

        //MDI 중복 확인 2
        private void MdiOpenCheck<T>(T frm) where T : Form
        {
            this.Cursor = Cursors.WaitCursor;
            if (OpenFormMdi(frm.GetType()))
                frm.Dispose();
            else
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            this.Cursor = currentCursor;
        }
        #endregion

        /// <summary>
        /// 메인화면 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            LogMenu();

            HideSubMenu();
        }

        #region 상위 버튼 클릭
        private void btnResource_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlResource);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProduct);
        }

        private void btnSaleCost_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSaleCost);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlShift);
        }

        private void btnOrderPlan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlOrderPlan);
        }

        private void btnOrderProduction_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlOrderProduction);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlPurchase);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProcess);
        }

        private void btnProcessRegister_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProcessRegister);
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlShipment);
        }
        #endregion

        #region 하위메뉴 숨기기
        private void HideSubMenu()
        {
            pnlResource.Visible = false;
            pnlSaleCost.Visible = false;
            pnlShift.Visible = false;
            pnlProduct.Visible = false;
            pnlOrderPlan.Visible = false;
            pnlOrderProduction.Visible = false;
            pnlPurchase.Visible = false;
            pnlProcess.Visible = false;
            pnlProcessRegister.Visible = false;
            pnlShipment.Visible = false;
        }

        // 선택한 메뉴의 하위메뉴 보이기
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region 탭 관련 이벤트
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                custTab.Visible = false;
            else
            {
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "                              ");
                    tp.Parent = custTab;
                    tp.Tag = this.ActiveMdiChild;
                    custTab.SelectedTab = tp;

                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                    this.ActiveMdiChild.Tag = tp;
                }

                if (!custTab.Visible) custTab.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void 모든탭닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormClose();
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custTab.SelectedTab != null && custTab.SelectedTab.Tag != null)
            {
                (custTab.SelectedTab.Tag as Form).Select();
            }
        }

        private void tabForms_MouseDown(object sender, MouseEventArgs e)
        {
            // 마우스 우클릭시 해당 탭 페이지 선택
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < custTab.TabPages.Count; i++)
                {
                    Rectangle r = custTab.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        custTab.SelectedIndex = i;
                    }
                }
            }
            for (var i = 0; i < custTab.TabPages.Count; i++)
            {
                var tabRect = custTab.GetTabRect(i);
                var closeImage = Properties.Resources.close_black;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (e.Button == MouseButtons.Left) //  x버튼 마우스 왼쪽 클릭때만 닫기
                {
                    if (imageRect.Contains(e.Location))
                    {
                        this.ActiveMdiChild.Close();
                        break;
                    }
                }
            }
        }

        // 열린 MDI창 모두 닫기
        private void MdiFormClose()
        {
            custTab.TabPages.Clear();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }
        #endregion

        //공통코드
        private void btnCommonCode_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Tag == "CommonCodePopUp")
                {
                    frm.Activate();
                    return;
                }
            }
            PopUp.PopUpCommonCode pop = new PopUp.PopUpCommonCode();
            pop.Show();
        }

        #region 자원관리

        private void btnFactory_Click(object sender, EventArgs e)
        {
            frmFactory frm = new frmFactory();
            frm.DeptName = DeptInfo.User_Name;

            MdiOpenCheck(frm);
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            frmFacility frm = new frmFacility();
            frm.DeptName = DeptInfo.User_Name;

            MdiOpenCheck(frm);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.DeptName = DeptInfo.User_Name;

            MdiOpenCheck(frm);
        }

        private void btnBOR_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmBOR>();
        }

        #endregion

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmAuthority>();
        }

        private void button9_Click(object sender, EventArgs e)//bom
        {

            FrmBOM frm = new FrmBOM();
            frm.DeptName = DeptInfo.User_Name;

            if (OpenFormMdi(frm.GetType()))
                frm.Dispose();
            else
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)//자재단가
        {
            OpenCreateForm<frmMaterialCost1>();
        }

        private void button7_Click(object sender, EventArgs e)//영업단가
        {

            OpenCreateForm<frmSaleCost1>();
        }
        private void btnShiftInfo_Click(object sender, EventArgs e)//shift기준정보
        {
            OpenCreateForm<frmShiftInfo1>();
        }
        private void btnShiftSchedule_Click(object sender, EventArgs e)//shift스케줄관리
        {
            OpenCreateForm<frmShiftSchedule1>();
        }

        #region 수주/계획관리
        private void btnPOUpload_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmPOUpload>();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmPO>();
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmD_Plan>();
        }

        #endregion

        #region 수주/생산관리
        private void btnM_Take_Plan_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmMT_Plan>();
        }

        private void btnProduction_Plan_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmProductPlan>();
        }
        #endregion

        #region 구매관리
        private void btnROrder_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmReg_Order>();
        }

        private void btnCurrentOrder_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmCurrentOrder>();
        }

        private void btnWStandby_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmWStandby>();
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmExamine>();
        }

        private void btnWMaterial_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmWMaterial>();
        }

        private void btnCurrentWM_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmCurrentWMaterial>();
        }

        private void btnCurrentWS_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmCurrentWStock>();
        }

        private void btnCurrentSR_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmCurrentSR>();
        }

        private void btnMC_Request_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmMR_Request>();
        }

        private void btnMConfine_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmMRelease>();
        }
        #endregion

        #region 공정관리
        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            OpenCreateForm<WorkOrder>();
        }

        private void btnCurrentProcess_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmCurrentProcess>();
        }
        #endregion

        #region 공정등록
        private void btnProcessMove_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmProcessMove>();
        }
        #endregion

        #region 출하관리
        private void btnShipmentManager_Click(object sender, EventArgs e)
        {
            OpenCreateForm<ShipmentManager>();
        }




        #endregion

        //x 누르면 프로그램 종료

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("로그아웃을 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                e.Cancel = true;
                this.Hide();
                LogMenu();
            }
            else
                e.Cancel = true;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃을 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                this.Hide();
                HideSubMenu();
                MdiFormClose();
                LogMenu();
            }
            else
                return;
        }

        private void LogMenu()
        {
            PopUpLogin frm = new PopUpLogin();
            if (frm.ShowDialog(this) != DialogResult.OK)
            {
                Environment.Exit(0);
            }

            LoginService service = new LoginService();
            List<LoginVO> Login = service.LoginInfo(DeptInfo.User_ID, DeptInfo.User_Pwd);
            service.Dispose();

            lblName.Text = $"{DeptInfo.User_Dept} - {DeptInfo.User_Name}";
            //lblName.Text = DeptInfo.User_Name;
            //lblDept.Text = DeptInfo.User_Dept;
            this.Show();



        }
        private void button10_Click(object sender, EventArgs e)//품목
        {
            FrmITEM frm = new FrmITEM();
            frm.Uname = DeptInfo.User_Name;

            if (OpenFormMdi(frm.GetType()))
                frm.Dispose();
            else
            {
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslblDateTime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
    }
}
