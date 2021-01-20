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

        private void button12_Click(object sender, EventArgs e)
        {
            ProductPlan frm = new ProductPlan();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WorkOrder frm = new WorkOrder();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmMatrialOut frm = new frmMatrialOut();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
