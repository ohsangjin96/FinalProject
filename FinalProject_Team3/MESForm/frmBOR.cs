using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmBOR : MESForm.BaseForms.frmBaseList
    {
        public frmBOR()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvBOR);
            //CommonUtil.AddGridTextColumn(dgvBOR, "BOR코드", "BOR_Code");
            CommonUtil.AddGridTextColumn(dgvBOR, "품목", "Item_Code");
            CommonUtil.AddGridTextColumn(dgvBOR, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvBOR, "공정", "Process_Type");
            CommonUtil.AddGridTextColumn(dgvBOR, "공정명", "Process_Name");
            CommonUtil.AddGridTextColumn(dgvBOR, "설비", "Facility_Code");
            CommonUtil.AddGridTextColumn(dgvBOR, "설비명", "Facility_Name");
            CommonUtil.AddGridTextColumn(dgvBOR, "TactTime(Sec)", "BOR_TactTime");
            //CommonUtil.AddGridTextColumn(dgvBOR, "대기시간", "BOR_Date");
            CommonUtil.AddGridTextColumn(dgvBOR, "우선순위", "BOR_Order");
            CommonUtil.AddGridTextColumn(dgvBOR, "수율", "BOR_Transference");
            CommonUtil.AddGridTextColumn(dgvBOR, "사용유무", "BOR_Use");
            CommonUtil.AddGridTextColumn(dgvBOR, "비고", "BOR_Note");
        }

        private void frmBOR_Load(object sender, EventArgs e)
        {
            DgvSetting();
        }
    }
}
