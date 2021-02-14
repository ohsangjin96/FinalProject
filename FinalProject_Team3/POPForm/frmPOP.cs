using FProjectVO;
using MachinServer;
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
        int k = 0;
        List<POPVO> list = new List<POPVO>();
        List<OrderVO> orderlist = new List<OrderVO>();
        List<string> FindList = new List<string>();
        LoginVO Vo = new LoginVO();
        public frmPOP(LoginVO vo)
        {
            InitializeComponent();
            Vo = vo;
            curlist = new List<WorkRegistVO>();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultCheck frm = new ResultCheck();
            frm.Show();
        }
        private void frmPOP_Load(object sender, EventArgs e)
        {
            lblName.Text = Vo.User_Name;
           
            label3.Text = "2021-02-11";
            CommonUtil.SetInitGridView(dgvList);
            
            CommonUtil.AddGridTextColumn(dgvList, "품목", "Item_Code", 165);
            CommonUtil.AddGridTextColumn(dgvList, "품명", "Item_Name", 160);
            CommonUtil.AddGridTextColumn(dgvList, "수량", "OrderAmount", 100);
            CommonUtil.AddGridTextColumn(dgvList, "날짜", "FixDate", 200);
            CommonUtil.AddGridTextColumn(dgvList, "날짜", "Plan_ID", 200,false);
            CommonUtil.SetInitGridView(dgvList2);
            
            CommonUtil.AddGridTextColumn(dgvList2, "작업시작날짜", "WorkRegist_Start", 165);
            CommonUtil.AddGridTextColumn(dgvList2, "품목", "Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "상태", "WorkRegist_State", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "걸린시간", "WorkRegist_WorkTime", 120);
            CommonUtil.AddGridTextColumn(dgvList2, "양품", "WorkRegist_NomalQty", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "불량", "WorkRegist_FailQty", 100);
            CommonUtil.AddGridTextColumn(dgvList2, "설비코드", "FacilityDetail_Code", 120);
           
            this.dgvList.Font = new Font("나눔스퀘어OTF", 15, FontStyle.Regular);
            this.dgvList2.Font = new Font("나눔스퀘어OTF", 15, FontStyle.Regular);

            OrderService service = new OrderService();
            dgvList.DataSource = service.GetSelectWorkOrderList("2021-02-11",Vo.User_Dept);
        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Item_Code = dgvList[0, dgvList.CurrentRow.Index].Value.ToString();
            int qty = Convert.ToInt32(dgvList[2, dgvList.CurrentRow.Index].Value);
            if (e.RowIndex >= 0) 
            {
                
                POPService service = new POPService();
                list = service.GetPOPList(Item_Code);
                
                if (splitContainer2.Panel1.Controls.Contains(machin))
                {
                    if (!FindList.Contains(Item_Code))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            machin = new Machin();
                            machin.Location = new Point(0, 83 + k * 105);
                            machin.Facility = list[i].Facility_Name;
                            machin.Name = list[i].Item_Code;
                            machin.Tag = list[i].Facility_Code;
                            machin.IP = list[i].Facility_IP;
                            machin.Port = list[i].Facility_Port;
                            machin.BOM_Level = list[i].BOM_Level.ToString();
                            machin.MachinRegist += Machin_MachinRegist;
                            machin.WorkOrder_ID = list[i].WorkOrder_ID;
                            machin.Qty = qty;
                            machin.Plan_ID = list[i].plan_ID;
                            FindList.Add(machin.Name);
                            splitContainer2.Panel1.Controls.Add(machin);
                            k++;
                        }
                    }
           
                    
                }
                else
                {
                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        machin = new Machin();
                        machin.Location = new Point(0, 83 + k * 105);
                        machin.Facility = list[i].Facility_Name;
                        machin.Name = list[i].Item_Code;
                        machin.Tag = list[i].Facility_Code;
                        machin.IP = list[i].Facility_IP;
                        machin.Port = list[i].Facility_Port;
                        machin.BOM_Level = list[i].BOM_Level.ToString();
                        machin.WorkOrder_ID = list[i].WorkOrder_ID;
                        machin.Plan_ID = list[i].plan_ID;
                        machin.MachinRegist += Machin_MachinRegist;
                        machin.Qty = qty;
                        FindList.Add(machin.Name);
                        splitContainer2.Panel1.Controls.Add(machin);
                        k++;
                    }
                }
            }
            else
            {

            }
        }
    
            

        private void Machin_MachinRegist(object sender, WorkRegistEventArgs e)
        {
            curlist.Add(e.Data);
            dgvList2.DataSource = null;
            dgvList2.DataSource = curlist;
            btnRegist.BackColor = SystemColors.Highlight;
            btnRegist.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var temp in splitContainer2.Panel1.Controls)
            {
                if (temp is Machin machins)
                {
                 machins.bntActive.PerformClick();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (curlist.Count > 0)
            {
                POPService service = new POPService();
                service.InsertWorkRegistList(curlist);
                dgvList2.DataSource = null;
                curlist.Clear();
                btnRegist.Enabled = false;
                btnRegist.BackColor = Color.Silver;

            }
            else if (curlist == null)
            {
                MessageBox.Show("기계를 먼저 돌려주세요");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void lblLogout_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("로그아웃을 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                this.Close();
                PopUpLogin login = new PopUpLogin();
                login.Show();
            }

        }
    }
}

