using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm
{
    public partial class PopUpLog : Form
    {
        string ip, port, facility;
        public PopUpLog(string IP, string Port,string Facility)
        {
            InitializeComponent();
            ip = IP;
            port = Port;
            facility = Facility;
        }

        private void PopUpLog_Load(object sender, EventArgs e)
        {
        
            lblIP.Text = ip;
            lblPort.Text = port;
            string path = Application.StartupPath + $@"\\Logs\{facility}.log";
            StreamReader SR = new StreamReader(path, Encoding.Default);    
            string result = "";                                     
            result = SR.ReadToEnd();                               
            textBox1.Text = result;                                  
            SR.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
