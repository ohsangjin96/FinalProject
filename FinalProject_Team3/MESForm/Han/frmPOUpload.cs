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
    public partial class frmPOUpload : Form
    {
        public frmPOUpload()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanDate", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "순번", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "WorkOrderID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체CODE", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품처", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "MCT", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주구분", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "GROUP", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "구분", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "사이즈", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고P/NO", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "계획수량합계", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납기일", "n");
        }

        private void frmPOUpload_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}