﻿using FProjectDAC;
using FProjectVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

     
        NetworkStream recvData;
        SqlConnection conn;
        LoggingUtility _logging;
 
        string taskID;
        string strConn;
        bool logVisible = false;
        string clientName;
        string clientIP;

        public bool bExit = false;

        int timer_CONNECT = 1000;
        int timer_KEEP_ALIVE = 10000;
        int timer_READ_PLC = 1000;
        int fail, success = 0;
        int range = 1;
        string id;
        
        public Machin()
        {
            InitializeComponent();
            taskID = lblFacility.Text;

            this.Text =taskID;
            TcpClient client = new TcpClient();
            client.Connect(lblIP.Text, lblPort.Text);
            clientName = Dns.GetHostName();

            IPAddress[] locals = Dns.GetHostAddresses(clientName);
            if (locals.Length > 0)
            {
                clientIP = locals[1].ToString();
            }

                ConnectionAccess con = new ConnectionAccess();
                strConn = con.ConnectionString;
    
        }
        
        private void bntActive_Click(object sender, EventArgs e)
        {
            bntActive.BackColor = Color.Silver;
            bntActive.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
            button2.BackColor = Color.Red;
            timer1.Interval = int.Parse(ConfigurationManager.AppSettings["timer"]);
            _logging = new LoggingUtility(lblFacility.Text, Level.Debug, 30);
            MachinServer.Form1 server = new MachinServer.Form1(lblIP.Text,lblPort.Text);
            try
            {
                Log.WriteInfo("DB서버 연결");
      
                NetworkStream ns = client.GetStream();

                while (true)
                {
                    IPEndPoint clientPoint = new IPEndPoint(127.0.0.1,9000);
                    IPEndPoint serverPoint = new IPEndPoint(IPAddress.Parse(lblIP.Text), int.Parse(lblPort.Text));

                    myClient = new TcpClient(clientPoint);
                    myClient.Connect(serverPoint);

                    string msg = $"{lblIP.Text},{lblPort.Text}";
                    byte[] data = Encoding.Default.GetBytes(msg);
                    ns.Write(data, 0, data.Length);
                    Console.WriteLine("송신:" + msg);

                    data = new byte[256];
                    ns.Read(data, 0, data.Length);
                    string response = Encoding.Default.GetString(data, 0, data.Length);
                    Console.WriteLine("수신:" + response);
                }
                ns.Close();
                client.Close();

                Console.WriteLine("클라이언트를 종료합니다...");

                EncrytLibrary.AES aes = new EncrytLibrary.AES();
                strConn = aes.AESDecrypt256(strConn);
                conn = new SqlConnection(strConn);
                conn.Open();

                timer_Conn.Start();
            }
            catch (Exception err)
            {
                Log.WriteError("DB접속 실패:" + err.Message);
            }

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
                    Log.WriteInfo($"{lblName.Text} | {lblFacility.Text} | 성공: {lblSuccess.Text} / 실패: {lblFail.Text}");
                    Log.WriteInfo("설비 가동이 완료되었습니다.");
                    lblFail.Text=lblSuccess.Text= "0";
                    lblProgram.Text = "00";
                    bntActive.BackColor = Color.Green;
                    bntActive.Enabled = true;
                    button2.BackColor = Color.Silver;
                    button2.Enabled = false;
                    success = fail = range = 0;

                
                }
                Log.WriteInfo($"{lblName.Text} | {lblFacility.Text} | 성공: {lblSuccess.Text} / 실패: {lblFail.Text}");
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
            PopUpLog frm = new PopUpLog(IP, Port);
            frm.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.BackColor = Color.Silver;
            bntActive.Enabled = true;
            button2.Enabled = false;
            bntActive.BackColor = Color.Green;
            m_thread.ThreadStop();
        }
    }

    public class WorkRegistEventArgs : EventArgs
    {
        public WorkRegistVO Data { get; set; }
    }
   

   

   
}
