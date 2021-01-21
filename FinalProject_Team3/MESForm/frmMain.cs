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

namespace MESForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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

        }

        #region 탭 관련 이벤트
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                custTab.Visible = false;
            else
            {
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "                                     ");
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

        private void button9_Click(object sender, EventArgs e)
        {
            frmBOM frm = new frmBOM();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)//자재단가
        {
            frmMaterialCost frm = new frmMaterialCost();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)//영업단가
        {
            frmSaleCost frm = new frmSaleCost();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
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
