using FProjectDAC;
using FProjectVO;
using log4net.Core;
using MachinServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace POPForm.UserControls
{
    public partial class Machin : UserControl
    {
        #region property

        public string ID { get { return id; } set { id = value; } }
        public string Facility { get { return lblFacility.Text; } set{lblFacility.Text=value;} }
        public string Name { get { return lblName.Text; } set { lblName.Text = value; } }
        public string Program { get { return lblProgram.Text; } set { lblProgram.Text = value; } }
        public string IP { get { return lblIP.Text; } set { lblIP.Text = value; } }
        public string Port { get { return lblPort.Text; } set { lblPort.Text = value; } }

        public LoggingUtility Log { get { return _logging; } }
        #endregion
        public delegate void MachinRegistWorkRegist(object sender, WorkRegistEventArgs e);
        public event MachinRegistWorkRegist MachinRegist;
   
        NetworkStream ns;
        LoggingUtility _logging;
        Form1 frm;
        Thread BntClick;
        Thread ServerPlay;
        TcpClient client;
        IPEndPoint serverPoint;
        System.Timers.Timer timer;
        bool MachinActive = true;
        int success = 0;
        int fail = 0;
        int process = 1;
        public bool bExit = false;
        string id;
       
        public Machin()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            BntClick = new Thread(bntClick);
            ServerPlay = new Thread(serverplay);
           
        }
        
        
        private void bntClick()

        {            
            try
          {
                #region 실수
                //        IPEndPoint clientPoint = new IPEndPoint(IPAddress.Parse(lblIP.Text), int.Parse(lblPort.Text));
                //        serverPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(lblPort.Text)+1);
                //        client = new TcpClient(clientPoint);
                //        client.Connect(serverPoint);
                //        while (true)
                //        {
                //            ns = client.GetStream();
                //            byte[] data = new byte[100];
                //            ns.Read(data, 0, data.Length);
                //            string response = Encoding.Default.GetString(data, 0, data.Length);
                //            string[] temp = response.Split(',');
                //            this.BeginInvoke(new Action(() =>
                //            {
                //                lblSuccess.Text = temp[0];
                //                lblFail.Text = temp[1];
                //                lblProgram.Text = temp[2];
                //            }));

                //            Log.WriteInfo($"성공:{temp[0]} 실패:{temp[1]} 진행률:{temp[2]}%");

                //            if (Convert.ToInt32(temp[2]) == 100)
                //            {
                //                WorkRegistVO vo = new WorkRegistVO
                //                {
                //                    Item_Code = lblName.Text,
                //                    FacilityDetail_Code = this.Tag.ToString(),
                //                    WorkRegist_FailQty = int.Parse(lblFail.Text),
                //                    WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                //                    // WorkRegist_WorkTime = TotTime,
                //                    WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                //                    WorkRegist_State = "제작완료",
                //                    Plan_ID = id
                //                };
                //                Log.WriteInfo($"설비 종료");

                //                this.BeginInvoke(new Action(() =>
                //                {
                //                    WorkRegistEventArgs args = new WorkRegistEventArgs();
                //                    args.Data = vo;
                //                    MachinRegist(this, args);
                //                    lblFail.Text = lblSuccess.Text = "0";
                //                    lblProgram.Text = "00";
                //                    bntActive.BackColor = Color.Green;
                //                    bntActive.Enabled = true;
                //                    button2.BackColor = Color.Silver;
                //                    button2.Enabled = false;
                //                    MachinActive = true;


                //                }));

                //                break;
                //            }

                //        }
                //        ns.Close();
                //        client.Close();
                #endregion
                timer.Start();
          }
            catch (Exception err)
            {
               Log.WriteError("DB접속 실패:" + err.Message);
            }
        }

        private void bntActive_Click(object sender, EventArgs e)
        {
            if (MachinActive)
            {
                
                bntActive.BackColor = Color.Silver;
                bntActive.Enabled = false;
                button2.Enabled = true;
                button2.BackColor = Color.Red;
                ServerPlay.Start();
                BntClick.Start();
                MachinActive = false;
            }
            else
            {
                bntActive.BackColor = Color.Silver;
                bntActive.Enabled = false;
                button2.Enabled = true;
                button2.BackColor = Color.Red;
                timer.Start();
            }
        }
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
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
            process++;
            lblSuccess.Text = success.ToString();
            lblFail.Text = fail.ToString();
            lblProgram.Text = process.ToString();

            string msg = $"{success},{fail},{process},";
            byte[] sendBytes = Encoding.Default.GetBytes(msg); //string => byte[]
            ns = client.GetStream();
            ns.Write(sendBytes, 0, sendBytes.Length);
            if (process >= 100) timer.Stop();
           


        }
        private void serverplay()
        {
            Form1 frm = new Form1(lblFacility.Text,lblPort.Text);
        }

        private void Machin_Load(object sender, EventArgs e)
        {
            Thread BntClick = new Thread(bntClick);
            bntActive.BackColor = Color.Green;
            bntActive.Enabled = true;
            button2.BackColor = Color.Silver;
            button2.Enabled = false;
           
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            PopUpLog frm = new PopUpLog(IP, Port, Facility);
            frm.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
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
