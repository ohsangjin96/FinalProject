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
    public partial class frmMR_Request : BaseForms.frmBaseLists
    {
        public frmMR_Request()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "No", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "계획시작일자", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "작업지시ID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "설비명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "소진창고", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "지시수량", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "상태명", "j");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품명", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "규격", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "요청창고", "n");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "요청일", "o");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "재고량", "p");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "표준불출수량", "q");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "계획요청수량", "r");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "요청수량", "s");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "출고수량", "t");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "취소수량", "u");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "잔량", "v");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "사유", "w");
        }

        private void frmMC_Request_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}
