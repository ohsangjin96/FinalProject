using log4net.Core;
using MachinServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MachinServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service = new Service1();
            service.taskID = args[0];
            service.hostIP = args[1];
            service.hostPort = int.Parse(args[2]);
            service.qty = int.Parse(args[3]);
            service.OnStart();

            Console.ReadLine();
        }
    }

    public class Service1
    {
        LoggingUtility loggingUtility;
        TcpListener listener;
        Timer timer1;
        int success = 0;
        int fail = 0;
        int process = 0;
        TcpClient tc;
        NetworkStream stream;

        LoggingUtility Log { get { return loggingUtility; } }

        public string taskID { get; set; }
        public string hostIP { get; set; }
        public int hostPort { get; set; }
        public int qty { get; set; }

        public void OnStart()
        {

            Console.WriteLine("서비스 시작");


            if (listener == null)
            {
                listener = new TcpListener(IPAddress.Parse(hostIP), hostPort);
            }

            AsyncEchoServer();
        }
        private async void AsyncEchoServer()
        {
            listener.Start();
            while (true)
            {
                tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                stream = tc.GetStream();

                timer1 = new Timer(1200);
                timer1.Elapsed += Timer1_Elapsed;
                timer1.Enabled = true;
                timer1.AutoReset = true;
                // await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
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
            string msg = $"{success}|{fail}|{process}|";

            byte[] buff = Encoding.Default.GetBytes(msg);
            stream.Write(buff, 0, buff.Length);
            //stream.Flush();
            Console.WriteLine(msg);
            if (success >= qty)
            {
                timer1.Stop();
                success = fail = process = 0;
            }
        }

        public void OnStop()
        {
            listener.Stop();
        }
    }
}
