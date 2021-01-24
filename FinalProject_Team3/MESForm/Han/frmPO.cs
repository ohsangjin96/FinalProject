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
    public partial class frmPO : BaseForms.frmBaseLists
    {
        public frmPO()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "No", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객WO", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "도착지명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문유형", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객품목", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생산납기일", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문수량", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소수량", "n");
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupD_Plan frm = new popupD_Plan();
            frm.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            popupSO frm = new popupSO();
            frm.Show();
        }
    }
}