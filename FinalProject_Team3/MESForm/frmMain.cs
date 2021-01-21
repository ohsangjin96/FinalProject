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

namespace MESForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.panel1.Paint += Panel_Paint;
        }

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

        /// <summary>
        /// MDI 자식폼 구현
        /// </summary>
        /// <typeparam name="T">자식폼</typeparam>
        private void OpenCreateForm<T>() where T : Form, new()
        {
            Cursor currentCursor = this.Cursor;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
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

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custTab.SelectedTab != null && custTab.SelectedTab.Tag != null)
            {
                (custTab.SelectedTab.Tag as Form).Select();
            }
        }

        private void tabForms_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < custTab.TabPages.Count; i++)
            {
                var tabRect = custTab.GetTabRect(i);
                var closeImage = Properties.Resources.close_black;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }
        #endregion

        #region 자원관리

        private void btnFactory_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmFactory>();
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmFacility>();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmCompany>();
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
        private void button10_Click(object sender, EventArgs e)//품목
        {

            OpenCreateForm<frmItem>();
        }
        private void button9_Click(object sender, EventArgs e)//bom
        {
            
            OpenCreateForm<frmBOM>();
        }

        private void button8_Click(object sender, EventArgs e)//자재단가
        {
            OpenCreateForm<frmMaterialCost>();
        }

        private void button7_Click(object sender, EventArgs e)//영업단가
        {
           
            OpenCreateForm<frmSaleCost>();
        }
        private void btnShiftInfo_Click(object sender, EventArgs e)//shift기준정보
        {
            OpenCreateForm<frmShiftInfo>();
        }
        private void btnShiftSchedule_Click(object sender, EventArgs e)//shift스케줄관리
        {
            OpenCreateForm<frmShiftSchedule>();
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
            OpenCreateForm<ProductPlan>();
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
            OpenCreateForm<Han.frmMC_Request>();
        }

        private void btnMConfine_Click(object sender, EventArgs e)
        {
            OpenCreateForm<Han.frmMConfine>();
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

        
    }
}
