using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPForm
{
    public partial class PopUpLog : Form
    {
        string ip, port;
        public PopUpLog(string IP, string Port)
        {
            InitializeComponent();
            ip = IP;
            port = Port;
        }

        private void PopUpLog_Load(object sender, EventArgs e)
        {
            lblIP.Text = ip;
            lblPort.Text = port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
