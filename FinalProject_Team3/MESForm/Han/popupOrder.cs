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
    public partial class popupOrder : Form
    {
        public popupOrder()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주업체", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체코드", "b");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "PlanID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주업체", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "납기일", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "현재고", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주제안수량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주수량", "j");
        }

        private void popupOrder_Load(object sender, EventArgs e)
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