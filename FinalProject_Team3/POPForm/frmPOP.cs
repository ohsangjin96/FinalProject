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
    public partial class frmPOP : Form
    {
        
        public frmPOP()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultCheck frm = new ResultCheck();
            frm.Show();
        }

        private void frmPOP_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPOP_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "PlanID", "Plan_ID", 200);
            CommonUtil.AddGridTextColumn(dgvList, "아이템 이름", "Item_Name", 110);
            CommonUtil.AddGridTextColumn(dgvList, "수량", "Order_Amount", 100);
            CommonUtil.AddGridTextColumn(dgvList, "날짜", "Fixed_Date", 109);
            CommonUtil.AddGridTextColumn(dgvList, "아이템 코드", "Item_Code", 109, false);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvList[0, dgvList.CurrentRow.Index].Value.ToString();
            lblItemName.Text = dgvList[1, dgvList.CurrentRow.Index].Value.ToString();
            lblAmount.Text = dgvList[2, dgvList.CurrentRow.Index].Value.ToString();
            lblFixedDate.Text = dgvList[3, dgvList.CurrentRow.Index].Value.ToString();
        }
    }
}
