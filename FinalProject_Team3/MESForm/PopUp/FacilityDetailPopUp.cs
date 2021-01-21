using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.PopUp
{
    public partial class FacilityDetailPopUp : Form
    {
        private Point mousePoint;

        public FacilityDetailPopUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilityDetailPopUp_MouseDown(object sender, MouseEventArgs e)
        {
           mousePoint = new Point(e.X, e.Y);
        }

        private void FacilityDetailPopUp_MouseMove(object sender, MouseEventArgs e)
        {
           if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
