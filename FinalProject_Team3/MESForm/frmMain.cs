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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region 탭 관련 이벤트
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            else
            {
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "             ");
                    tp.Parent = tabForms;
                    tp.Tag = this.ActiveMdiChild;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                    this.ActiveMdiChild.Tag = tp;
                }

                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab != null && tabForms.SelectedTab.Tag != null)
            {
                (tabForms.SelectedTab.Tag as Form).Select();
            }
        }

        private void tabForms_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabForms.TabPages.Count; i++)
            {
                var tabRect = tabForms.GetTabRect(i);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmSample frm = new frmSample();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProductPlan frm = new ProductPlan();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
