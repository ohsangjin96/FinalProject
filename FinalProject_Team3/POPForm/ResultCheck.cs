using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm
{
    public partial class ResultCheck : Form
    {
        public ResultCheck()
        {
            InitializeComponent();
        }

        private void ResultCheck_Load(object sender, EventArgs e)
        {
            //CommonUtil.SetInitGridView(dgvList1);
            //CommonUtil.AddGridTextColumn(dgvList1, "작업코드", "Order_ID", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "고객사", "Com_Name", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "품목", "Item_Code", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "품명", "Item_Name", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "주문수량", "Item_Code", 80);
            //CommonUtil.AddGridTextColumn(dgvList1, "양품수량", "Item_Name", 80);
            //CommonUtil.AddGridTextColumn(dgvList1, "불량수량", "Item_Name", 80);
            //CommonUtil.AddGridTextColumn(dgvList1, "작업시간", "Order_Qty", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "작업상태", "Order_date", 100);
            //CommonUtil.AddGridTextColumn(dgvList1, "시작일", "Facility_date", 100);
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
