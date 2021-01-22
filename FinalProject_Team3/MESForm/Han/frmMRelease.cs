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
    public partial class frmMRelease : Form
    {
        public frmMRelease()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "작업지시서", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "요청일", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목유형", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "요청창고", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "불출일자", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "불출창고", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "현재고", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "표준불출수량", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "계획수량", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "소요량", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "요청수량", "n");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "o");
        }

        private void frmMConfine_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}
