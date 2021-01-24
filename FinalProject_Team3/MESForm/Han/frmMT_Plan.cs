using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmMT_Plan : BaseForms.frmBaseLists
    {
        public frmMT_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "카테고리", "d");
        }

        private void frmMT_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}