using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.UserControls
{
    public partial class DateTimePicker : UserControl
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
        }
        public void RefreshDate()
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value= DateTime.Now;
        }
        public DateTime DtpFrom { get { return dtpFrom.Value; } set { dtpFrom.Value = value; } }
        public DateTime DtpTo { get { return dtpTo.Value; } set { dtpTo.Value = value; } }
    }
}
