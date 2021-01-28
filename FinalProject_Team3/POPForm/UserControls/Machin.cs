using FProjectVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm.UserControls
{
    public partial class Machin : UserControl
    {
        public string ID { get { return id; } set { id = value; } }
        public string Facility { get { return lblFacility.Text; } set{lblFacility.Text=value;} }
        public string Name { get { return lblName.Text; } set { lblName.Text = value; } }
        public string Program { get { return lblProgram.Text; } set { lblProgram.Text = value; } }

        
        public delegate void MachinRegistWorkRegist(object sender, WorkRegistEventArgs e);
        
        
        public event MachinRegistWorkRegist MachinRegist;

        int fail, success = 0;
        
        int range = 1;

        string id;
        
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

         public void RandomNumber()
        {
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
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ConfigurationManager.AppSettings["timer"]);
                int TotTime = a * range / 1000;
                int per = int.Parse(lblProgram.Text);
                per = per + 1;
                RandomNumber();
                lblProgram.Text = per.ToString();

                if ( per >= 100)
                {
                    timer1.Stop();

                    if (MachinRegist != null)
                    {
                        WorkRegistVO vo = new WorkRegistVO
                        {
                            Item_Code = lblName.Text,
                            FacilityDetail_Code = this.Tag.ToString(),
                            WorkRegist_FailQty = int.Parse(lblFail.Text),
                            WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                            WorkRegist_WorkTime = TotTime,
                            WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                            WorkRegist_State = "제작완료",
                            Plan_ID = id
                        };

                        WorkRegistEventArgs args = new WorkRegistEventArgs();
                        args.Data = vo;
                        MachinRegist(this, args);
                    }
                    lblFail.Text=lblSuccess.Text= "0";
                    lblProgram.Text = "00";
                    bntActive.BackColor = Color.Green;
                    bntActive.Enabled = true;
                    button2.BackColor = Color.Silver;
                    button2.Enabled = false;
                    success = fail = range = 0;
                    
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

        private void button11_Click(object sender, EventArgs e)
        {

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

    public class WorkRegistEventArgs : EventArgs
    {
        public WorkRegistVO Data { get; set; }
    }
}
