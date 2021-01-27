using FProjectVO;
using MESForm.Services;
using POPForm.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm
{
    public partial class frmPOP : Form
    {
        Machin machin;
        delegate void EventHandler(object sender, EventArgs arg);
        public List<WorkRegistVO> curlist { get; set; }
        public frmPOP()
        {
            InitializeComponent();
            curlist = new List<WorkRegistVO>();
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
            CommonUtil.AddGridTextColumn(dgvList, "아이템 코드", "Item_Code", 165);
            CommonUtil.AddGridTextColumn(dgvList, "아이템 이름", "Item_Name", 160);
            CommonUtil.AddGridTextColumn(dgvList, "수량", "Order_OrderAmount", 100);
            CommonUtil.AddGridTextColumn(dgvList, "날짜", "Order_FixedDate", 200);
            
            CommonUtil.SetInitGridView(dgvList2);
            CommonUtil.AddGridTextColumn(dgvList2, "PlanID","Plan_ID", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "작업시작날짜","WorkRegist_Start", 165);
            CommonUtil.AddGridTextColumn(dgvList2, "아이템코드","Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "상태","WorkRegist_State", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "걸린시간","WorkRegist_WorkTime", 120);
            CommonUtil.AddGridTextColumn(dgvList2, "양품","WorkRegist_NomalQty", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "불량","WorkRegist_FailQty", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "설비코드","FacilityDetail_Code", 120);
            this.dgvList.Font = new Font("나눔스퀘어OTF", 15, FontStyle.Regular);
            this.dgvList2.Font = new Font("나눔스퀘어OTF", 15, FontStyle.Regular);

            OrderService service = new OrderService();
            dgvList.DataSource= service.GetOrderList();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = dgvList[0, dgvList.CurrentRow.Index].Value.ToString();
                lblItemName.Text = dgvList[2, dgvList.CurrentRow.Index].Value.ToString();
                lblAmount.Text = dgvList[3, dgvList.CurrentRow.Index].Value.ToString();
                DateTime date = (DateTime)dgvList[4, dgvList.CurrentRow.Index].Value;
                lblFixedDate.Text = date.ToString("yyyy-MM-dd");
                string Item_Code =dgvList[1, dgvList.CurrentRow.Index].Value.ToString();
                POPService service = new POPService();
                List<POPVO> list = service.GetPOPList(Item_Code); 
                for (int i=0; i<list.Count; i++)
                {
                    machin = new Machin();
                
                    machin.Name = $"machin{i}";
                    machin.Location = new Point(0, 4 + i * 105);
                    machin.Facility = list[i].Facility_Name;
                    machin.Name = list[i].Item_Code;
                    
                    machin.Tag = list[i].Facility_Code;
                    machin.MachinRegist += Machin_MachinRegist;
                    splitContainer2.Panel2.Controls.Add(machin);
                }
                

            }
            
        }

        private void Machin_MachinRegist(object sender, WorkRegistEventArgs e)
        {
            curlist.Add(e.Data);
            dgvList2.DataSource = null;
            dgvList2.DataSource = curlist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           foreach(var temp in splitContainer2.Panel2.Controls)
            {
                if (temp is Machin machins)
                {
                    machins.bntActive.PerformClick();
                    
                }
            }
        }
    }
}
