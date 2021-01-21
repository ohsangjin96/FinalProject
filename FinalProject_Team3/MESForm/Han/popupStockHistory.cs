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
    public partial class popupStockHistory : Form
    {
        public popupStockHistory()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "수량", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "수정일", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "카테고리", "f");
        }

        private void popupStockHistory_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}