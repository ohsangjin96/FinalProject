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

namespace MESForm
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        private void frmItem_Load(object sender, EventArgs e)
        {
            dgvSetting();
        }

        private void dgvSetting()
        {
            CommonUtil.SetInitGridView(dgvitem);
            CommonUtil.AddGridTextColumn(dgvitem, "품목유형", "ITEM_Type");
            CommonUtil.AddGridTextColumn(dgvitem, "품목", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "품명", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "규격", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "단위", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "단위수량", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "수입검사여부", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "공정검사여부", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "출하검사여부", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "단종유무", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "납품업체", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "발주업체", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "입고창고", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "출고창고", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "최소발주량", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "안전재고량", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "사용유무", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "단종유무", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "발주방식", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvitem, "비고", "ITEM_Code");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmItemPopUp frm = new frmItemPopUp();
            
            frm.ShowDialog();
        }
    }
}
