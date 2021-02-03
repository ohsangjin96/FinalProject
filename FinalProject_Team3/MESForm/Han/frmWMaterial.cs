using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmWMaterial : MESForm.BaseForms.frmBaseLists
    {
        public frmWMaterial()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvWaitingWarehouse);
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "업체", "Warehouse_Company");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납품업체", "Item_Code");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목", "c");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품명", "d");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "규격", "e");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "품목유형", "f");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "단위", "g");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "검사여부", "h");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "출발처리유무", "i");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "발주수량", "j");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "불량개수", "k");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "통과개수", "l");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "납기일", "m");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고일", "n");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고상태", "o");
            CommonUtil.AddGridTextColumn(dgvWaitingWarehouse, "입고번호", "q");

            CommonUtil.SetInitGridView(dgvWarehouse);
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목", "aa");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품명", "ab");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "규격", "ac");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "품목유형", "ad");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단위", "ae");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고창고", "af");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "입고량", "ag");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "단가", "ah");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "수정자", "ak");
            CommonUtil.AddGridTextColumn(dgvWarehouse, "비고", "al");
        }

        private void frmWMaterial2_Load(object sender, EventArgs e)
        {
            DgvSetting();
        }
    }
}
