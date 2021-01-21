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
    public partial class frmCurrentSR : Form
    {
        public frmCurrentSR()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입출고일", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "구분", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "카테고리", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목유형", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주번호", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "수불량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단가", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "금액", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "환종", "l");
        }

        private void frmCurrentSR_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}











