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
    public partial class frmProcessMove : Form
    {
        public frmProcessMove()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고코드", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "창고명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목타입명", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "현재고", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "이전재고", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "유무상구분", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "비고", "k");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품명", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "규격", "n");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "현재고", "o");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "이동창고", "p");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "이동일자", "q");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "이동수량", "r");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "비고", "s");
        }

        private void frmProcessMove_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}
