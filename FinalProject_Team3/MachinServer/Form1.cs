﻿using log4net.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MachinServer
{
    public partial class Form1 : Form
    {
        
        TcpListener server;
        NetworkStream ns;
        int success = 0, fail = 0, process = 1;
        System.Timers.Timer timer;
        Thread startThread;
        IPEndPoint Serverlocal;
        string name;
        int port;
        public Form1(string Port)
        {   
            InitializeComponent();
            port = Convert.ToInt32(Port);
            startThread = new Thread(StartServer);
            startThread.IsBackground = true;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            startThread.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StartServer()
        {
           
            Serverlocal = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port+1);
            server = new TcpListener(Serverlocal);
            server.Start();
            
            bool bflag = true;
            bool bbflag = true;
            while (bflag)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    ns = client.GetStream();

                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        if (bbflag)
                        {
                            timer.Start();
                            bbflag = false;
                        }

                    }
                    else
                    {
                        timer.Stop();
                        bbflag = true;
                      
                    }
          
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
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
            string msg = $"{success},{fail},{process},";
            byte[] sendBytes = Encoding.Default.GetBytes(msg); //string => byte[]
            ns.Write(sendBytes, 0, sendBytes.Length);
            if (process >= 100) timer.Stop();
            process++;

        }

       
        

       
    }
}
