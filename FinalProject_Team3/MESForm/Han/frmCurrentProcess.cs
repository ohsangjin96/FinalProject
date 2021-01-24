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
    public partial class frmCurrentProcess : BaseForms.frmBaseLists
    {
        public frmCurrentProcess()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "선택", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고코드", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목타입", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "재고량", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "관리등급", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "비고", "k");
        }

        private void frmCurrentProcess_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            popupStockHistory frm = new popupStockHistory();
            frm.Show();
        }
    }
}