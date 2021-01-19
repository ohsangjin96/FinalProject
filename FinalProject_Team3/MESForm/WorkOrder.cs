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
    public partial class WorkOrder : Form
    {
        public WorkOrder()
        {
            InitializeComponent();
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "생산코드", "Product_ID", 150);
            CommonUtil.AddGridTextColumn(dgvList, "공정명", "Process_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList, "공정코드", "Process_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList, "설비명", "Facility_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgvList, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgvList, "주문갯수", "Order_Qty", 150);
            CommonUtil.AddGridTextColumn(dgvList, "계획시작일", "Order_date", 150);
            CommonUtil.AddGridTextColumn(dgvList, "소요시간", "Facility_date", 150);
            CommonUtil.AddGridTextColumn(dgvList, "작업상태", "Order_State", 150);
        }   
    }
}
