using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmSample : MESForm.BaseForms.frmBaseList
    {
        public frmSample()
        {
            InitializeComponent();
        }

        private void frmSample_Load(object sender, EventArgs e)
        {
            //SampleService service = new SampleService();
            //service.GetSampleList();
        }
    }
}
