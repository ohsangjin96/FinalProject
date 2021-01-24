using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESForm.Utils;

namespace MESForm.Han
{
    public partial class frmD_Plan : BaseForms.frmBaseLists
    {
        public frmD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "No", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사설비", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "f");
        }

        private void frmD_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupP_Plan frm = new popupP_Plan();
            frm.Show();
        }
    }
}