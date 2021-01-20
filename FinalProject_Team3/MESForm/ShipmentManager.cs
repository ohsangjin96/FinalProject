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
    public partial class ShipmentManager : Form
    {
        public ShipmentManager()
        {
            InitializeComponent();
        }

        private void ShipmentManager_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList1);
            CommonUtil.AddGridTextColumn(dgvList1, "주문코드", "Order_ID", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "고객사", "Com_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "품목", "Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "품명", "Item_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "주문수량", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgvList1, "출하수량", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgvList1, "매출확정수량", "Order_Qty", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "매출확정금액", "Order_date", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "매출확정일", "Facility_date", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "출하상태", "Order_State", 150);
            CommonUtil.SetInitGridView(dgvList2);
            CommonUtil.AddGridTextColumn(dgvList2, "주문코드", "Order_ID", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "고객사", "Com_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "품목", "Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "품명", "Item_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "주문수량", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgvList2, "출하수량", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgvList2, "매출확정수량", "Order_Qty", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "매출확정금액", "Order_date", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "매출확정일", "Facility_date", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "출하상태", "Order_State", 150);
        }
    }
}
