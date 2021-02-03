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
using System.Diagnostics;
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
        LoggingUtility _logging;
        NetworkStream ns; 
        TcpClient client;
        IPEndPoint serverPoint;
        IPEndPoint clientPoint;
        Thread buttonClick;
        int Process_ID;
        bool MachinActive = true;
        public bool bExit = false;
        string id;
        int i;
        public Machin()
        {
            InitializeComponent();
            buttonClick = new Thread(ButtonClick);
            i = 0;
        }

        private void ButtonClick()
        {
            if (i == 1)
            {
                ns = client.GetStream();
                byte[] data = new byte[100];
                ns.Read(data, 0, data.Length);
                string response = Encoding.Default.GetString(data, 0, data.Length);
                string[] temp = response.Split(',');
                _logging = new LoggingUtility(temp[0], Level.Debug, 30);
                Log.WriteInfo($"성공:{temp[1]} 실패:{temp[2]} 진행률:{temp[3]}");
                this.BeginInvoke(new Action(() =>
                {
                    lblSuccess.Text = temp[1];
                    lblFail.Text = temp[2];
                    lblProgram.Text = temp[3];
                }));
            }

            while (true)
            {

                ns = client.GetStream();
                byte[] data = new byte[100];
                ns.Read(data, 0, data.Length);
                string response = Encoding.Default.GetString(data, 0, data.Length);
                string[] temp = response.Split(',');
                Log.WriteInfo($"성공:{temp[1]} 실패:{temp[2]} 진행률:{temp[3]}%");
                this.BeginInvoke(new Action(() =>
                {
                    lblSuccess.Text = temp[1];
                    lblFail.Text = temp[2];
                    lblProgram.Text = temp[3];
                }));
                if (Convert.ToInt32(temp[3]) >= 100)
                {

                    WorkRegistVO vo = new WorkRegistVO
                    {
                        Item_Code = lblName.Text,
                        FacilityDetail_Code = this.Tag.ToString(),
                        WorkRegist_FailQty = int.Parse(lblFail.Text),
                        WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                        // WorkRegist_WorkTime = TotTime,
                        WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                        WorkRegist_State = "제작완료",
                        Plan_ID = id
                    };
                    this.BeginInvoke(new Action(() =>
                    {
                        WorkRegistEventArgs args = new WorkRegistEventArgs();
                        args.Data = vo;
                        MachinRegist(this, args);
                        lblFail.Text = lblSuccess.Text = "0";
                        lblProgram.Text = "00";
                        bntActive.BackColor = Color.Green;
                        bntActive.Enabled = true;
                        button2.BackColor = Color.Silver;
                        button2.Enabled = false;
                        MachinActive = true;
                    }));
                    foreach (Process process in Process.GetProcesses())
                    {
                        if (process.Id.Equals(Process_ID))
                        {
                            process.Kill();
                        }
                    }
                    break;
                }
            }

        }
        private void bntActive_Click(object sender, EventArgs e)
        {
            buttonClick = new Thread(ButtonClick);
            string server = @"C:\Users\azan0\source\repos\ohsangjin96\FinalProject\FinalProject_Team3\MachinServer\bin\Debug\MachinServer.exe";
            Process pro = Process.Start(server, $"{lblFacility.Text} {lblIP.Text} {int.Parse(lblPort.Text) + 1}");
            int Process_ID = pro.Id;

            if (client == null)
            {
                clientPoint = new IPEndPoint(IPAddress.Parse(lblIP.Text), int.Parse(lblPort.Text));
                serverPoint = new IPEndPoint(IPAddress.Parse(lblIP.Text), int.Parse(lblPort.Text) + 1);
                client = new TcpClient(clientPoint);
               
            }
            if (i == 0)
            {
                client.Connect(serverPoint);
                i++;
            }
            
           bntActive.BackColor = Color.Silver;
           bntActive.Enabled = false;
           button2.Enabled = true;
           button2.BackColor = Color.Red;
           MachinActive = false;
           buttonClick.Start();
           
          
            


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
            PopUpLog frm = new PopUpLog(IP, Port, Facility);
            frm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
            button2.BackColor = Color.Silver;
            bntActive.Enabled = true;
            button2.Enabled = false;
            bntActive.BackColor = Color.Green;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id.Equals(Process_ID))
                {
                    process.Kill();
                }
            }


        }
    }

    public class WorkRegistEventArgs : EventArgs
    {
        public WorkRegistVO Data { get; set; }
    }
   

   

   
}
