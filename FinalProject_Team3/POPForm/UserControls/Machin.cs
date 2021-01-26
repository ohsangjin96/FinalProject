using FProjectVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm.UserControls
{
    public partial class Machin : UserControl
    {
        public string Facility { get { return lblFacility.Text; } set{lblFacility.Text=value;} }
        public string Name { get { return lblName.Text; } set { lblName.Text = value; } }
        public string Program { get { return lblProgram.Text; } set { lblProgram.Text = value; } }
        
        int fail, success = 0;
        
        int range = 1;
        List<WorkRegistVO> list = new List<WorkRegistVO>();
        
        public Machin()
        {
            InitializeComponent();
        }
        
        private void bntActive_Click(object sender, EventArgs e)
        {
            bntActive.BackColor = Color.Silver;
            bntActive.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
            button2.BackColor = Color.Red;
            timer1.Interval = int.Parse(ConfigurationManager.AppSettings["timer"]);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ConfigurationManager.AppSettings["timer"]);
                int TotTime = a * range / 1000;
                int per = int.Parse(lblProgram.Text);
                per = per + 1;
                Random rand = new Random();
                int Produce = rand.Next(0, 100);
                if (Produce < 95)
                {
                    success += 1;
                }
                else
                {
                    fail += 1;
                }
                lblFail.Text = fail.ToString();
                lblSuccess.Text = success.ToString();
                lblProgram.Text = per.ToString();
               
                if ( per > 100)
                {
                    
                    list.Add(new WorkRegistVO
                    {
                        Item_Code = lblName.Text,
                        FacilityDetail_Code = this.Tag.ToString(),
                        WorkRegist_FailQty = int.Parse(lblFail.Text),
                        WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                        WorkRegist_WorkTime = TotTime,
                        WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                        WorkRegist_State = "제작완료",
                        WorkOrder_ID = "20210126-P"
                    });

                    frmPOP.frm.dgvList2.DataSource = list;
                    lblFail.Text=lblSuccess.Text=lblProgram.Text= "0";
                    bntActive.BackColor = Color.Green;
                    bntActive.Enabled = true;
                    button2.BackColor = Color.Silver;
                    button2.Enabled = false;
                    timer1.Stop();
                }
                range += 1;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Machin_Load(object sender, EventArgs e)
        {
            bntActive.BackColor = Color.Green;
            bntActive.Enabled = true;
            button2.BackColor = Color.Silver;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.BackColor = Color.Silver;
            bntActive.Enabled = true;
            button2.Enabled = false;
            bntActive.BackColor = Color.Green;
        }
    }
}
