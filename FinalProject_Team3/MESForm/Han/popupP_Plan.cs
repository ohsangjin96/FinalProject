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
    public partial class popupP_Plan : Form
    {
        public popupP_Plan()
        {
            InitializeComponent();
        }
        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "날짜", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "수량", "b");
        }

        private void popupP_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}
