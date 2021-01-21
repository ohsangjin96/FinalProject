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
    public partial class frmWMaterial : Form
    {
        public frmWMaterial()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품업체", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목유형", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "검사여부", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출발처리유무", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주수량", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출발수량", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "잔량", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납기일", "m");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출발일", "n");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출발상태", "o");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문상태", "p");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생성일", "q");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "aa");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품명", "ab");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "규격", "ac");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목유형", "ad");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "단위", "ae");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "입고창고", "af");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "입고량", "ag");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "단가", "ah");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "Market", "ai");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "환종", "aj");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "수정자", "ak");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "비고", "al");
        }

        private void frmWMaterial_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}