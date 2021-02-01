using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POPForm;
namespace MachinServer
{
    public partial class Form1 : Form
    {
        string ip;
        int port;
        public Form1(string IP, int Port)
        {
            InitializeComponent();
            ip = IP;
            port = Port;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint local = new IPEndPoint(IPAddress.Parse(ip),port);
            server = new TcpListener(local);
            server.Start();
            Thread startThread = new Thread(StartServer);
            startThread.IsBackground = true;
            startThread.Start();
        }
        private void StartServer()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream ns = client.GetStream();

                    byte[] rcvBytes = new byte[128];
                    int i = ns.Read(rcvBytes, 0, rcvBytes.Length);
                    string rcvMsg = Encoding.Default.GetString(rcvBytes);
                    
                    string msg = $"서버 현재 시간은 {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                    byte[] sendBytes = Encoding.Default.GetBytes(msg); //string => byte[]
                    ns.Write(sendBytes, 0, sendBytes.Length);

                    ns.Close();
                    client.Close();
                }
                catch
                {

                }
            }
        }
    }
}
