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
    public partial class popupD_Plan : Form
    {
        public popupD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객WO", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "도착지명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "등록일", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생산납기일", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문수량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소수량", "k");
        }

        private void popupD_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}