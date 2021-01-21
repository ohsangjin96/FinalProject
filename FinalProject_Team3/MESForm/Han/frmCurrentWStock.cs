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
    public partial class frmCurrentWStock : Form
    {
        public frmCurrentWStock()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고코드", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목유형", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "재고량", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "관리등급", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "비고", "j");
        }

        private void frmCurrentWStock_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}