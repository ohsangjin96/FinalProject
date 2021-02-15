using FProjectVO;
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
    public partial class frmReg_Order : BaseForms.frmBaseLists
    {
        public frmReg_Order()
        {
            InitializeComponent();
        }
        public string Name { get; set;}

        List<ReOrderVO> list = new List<ReOrderVO>();
        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "납기일", "Reorder_date",200);
            CommonUtil.AddGridTextColumn(dgvList, "품명", "ITEM_Code",200);
            CommonUtil.AddGridTextColumn(dgvList, "수량", "Reorder_Amount");
            CommonUtil.AddGridTextColumn(dgvList, "회사코드", "Com_Code",200);
            CommonUtil.AddGridTextColumn(dgvList, "잔량", "Reorder_Balance");
            CommonUtil.AddGridTextColumn(dgvList, "취소가능량", "Reorder_CanCancel");
            CommonUtil.AddGridTextColumn(dgvList, "PlanID", "Plan_ID",200);
            CommonUtil.AddGridTextColumn(dgvList, "입고창고", "WareHouse_In",200);

        }

        private void frmReg_Order_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            popupOrder frm = new popupOrder();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                list = frm.Curlist;
                dgvList.DataSource = list;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExcelExportToDataGridView(this, dgvList, "");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }

        private void custButtonControl2_Click(object sender, EventArgs e)
        {
            
        }
    }
}