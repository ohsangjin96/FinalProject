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
    public partial class frmWStandby : Form
    {
        public frmWStandby()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주일", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주업체", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품업체", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "검사여부", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고수량", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "잔량", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주유형", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "비고", "m");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주번호", "aa");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "ab");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "규격", "ac");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "단위", "ad");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주수량", "ae");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "잔여수량", "af");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "입고수량", "ag");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주유형", "ah");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "입고일자", "ai");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주일자", "aj");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "검사유무", "ak");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "비고", "al");
        }

        private void frmWStandby_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}
