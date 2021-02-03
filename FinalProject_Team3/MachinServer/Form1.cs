using log4net.Core;
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
        public LoggingUtility Log { get { return _logging; } }
        LoggingUtility _logging;
        TcpListener server;
        NetworkStream ns;
        System.Timers.Timer timer;
        Thread startThread;
        IPEndPoint Serverlocal;
        string name;
        TcpClient client;
        int port;
        public Form1(string Name,string Port)
        {   
            InitializeComponent();
            name = Name;
            port = Convert.ToInt32(Port);
            startThread = new Thread(StartServer);
            startThread.Start();
            _logging = new LoggingUtility(name, Level.Debug, 30);
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
                    client = server.AcceptTcpClient();
                    

                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        

                    }
                    else
                    {
                       
                    }
                        

                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
         }
            
        

       

       
        

       
    }
}
