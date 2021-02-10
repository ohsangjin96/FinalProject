using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class FrmShiftSchedule : MESForm.BaseForms.frmBaseLists
    {
        public FrmShiftSchedule()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //ExcelExportImport.ExcelExportToDataGridView(this, dgvShift);
        }
    }
}
