using FProjectVO;
using log4net.Core;
using MESForm.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace POPForm.UserControls
{
    public partial class Machin : UserControl
    {
        #region property

        public string ID { get { return id; } set { id = value; } }
        public string Facility { get { return lblFacility.Text; } set { lblFacility.Text = value; } }
        public string Name { get { return lblName.Text; } set { lblName.Text = value; } }
        public string Program { get { return lblProgram.Text; } set { lblProgram.Text = value; } }
        public string IP { get { return lblIP.Text; } set { lblIP.Text = value; } }
        public string Port { get { return lblPort.Text; } set { lblPort.Text = value; } }
        public string BOM_Level { get { return lblLevel.Text; } set { lblLevel.Text = value; } }
        public int WorkOrder_ID { get ; set;}
        public string Plan_ID { get; set; }
        public int Qty { get; set; }
        public LoggingUtility Log { get { return _logging; } }

        #endregion
        public delegate void MachinRegistWorkRegist(object sender, WorkRegistEventArgs e);

        public event MachinRegistWorkRegist MachinRegist;
        LoggingUtility _logging;
        NetworkStream ns;
        Thread buttonClicka;
        TcpControl tcpcontrol;
        ThreadPLCTask m_thread;
        int Process_ID;
        string plan_ID;
        int qty;
        public bool bExit = false;
        string id;
        bool bflag = true;
        public Machin()
        {
            InitializeComponent();

        }

        private void ButtonClick()
        {
            try
            {
                while (tcpcontrol.client.Available > 0)
                {
                    byte[] data = new byte[tcpcontrol.client.Available];
                    ns.Read(data, 0, data.Length);
                    string response = Encoding.Default.GetString(data).Replace("", "").Replace("", "").Trim();
                    string[] arrData1 = response.Split('|');
                    if (arrData1.Length < 1) continue;




                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }





        private void bntActive_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\\MachinServer.exe";
            Process pro = Process.Start(filePath, $"{lblFacility.Text} {lblIP.Text} {int.Parse(lblPort.Text) + 1} {qty}");
            Process_ID = pro.Id;
            if (bflag)
            {
                _logging = new LoggingUtility(lblFacility.Text, Level.Debug, 30);
                bflag = false;
            }
            tcpcontrol = new TcpControl(lblIP.Text, int.Parse(lblPort.Text) + 1);


            if (tcpcontrol.CheckClientConnection())
            {
                ns = tcpcontrol.dataStream;
                Log.WriteInfo("서버 접속");
            }

            bntActive.BackColor = Color.Silver;
            bntActive.Enabled = false;
            button2.Enabled = true;
            button2.BackColor = Color.Red;


            m_thread = new ThreadPLCTask(_logging, lblFacility.Text, lblIP.Text, int.Parse(lblPort.Text) + 1, 500, 10000, 500, lblIP.Text);
            m_thread.ReadData += M_thread_ReadData;
            ;
            m_thread.ThreadStart();

        }

        private void M_thread_ReadData(object sender, ReadDataEventArgs argss)
        {
            string info = argss.Data;
            string[] arrData1 = info.Split('|');
            Log.WriteInfo($"성공 : {arrData1[0]}, 실패 : {arrData1[1]}, 진행률 {arrData1[2]}");
            LogService service = new LogService();
            LogVO log = new LogVO();
            log.LogFacility = lblFacility.Text;
            log.LogSuccess = Convert.ToInt32(arrData1[0]);
            log.LogFail = Convert.ToInt32(arrData1[1]);
            log.LogProgram = Convert.ToInt32(arrData1[2]);
            log.WorkOrderID = WorkOrder_ID;
            service.insertLog(log);
            this.Invoke(new Action(() =>
            {
                lblSuccess.Text = arrData1[0];
                lblFail.Text = arrData1[1];
                lblProgram.Text = arrData1[2];
            }));

            if (Convert.ToInt32(lblProgram.Text) >= 100)
            {
                WorkRegistVO vo = new WorkRegistVO
                {
                    Item_Code = lblName.Text,
                    FacilityDetail_Code = this.Tag.ToString(),
                    WorkRegist_FailQty = int.Parse(lblFail.Text),
                    WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                    WorkRegist_WorkTime = int.Parse(lblProgram.Text) * 5,
                    WorkRegistID = WorkOrder_ID,
                    WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                    WorkRegist_State = "제작완료",

                };
                this.Invoke(new Action(() =>
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

                }));

                foreach (Process process in Process.GetProcesses())
                {
                    if (process.Id.Equals(Process_ID))
                    {
                        process.Kill();
                    }
                }
            }
        }

        private void ButtonClickA()
        {
            lock (buttonClicka)
            {
                ButtonClick();
            }
        }
        private void Machin_Load(object sender, EventArgs e)
        {

            bntActive.BackColor = Color.Green;
            bntActive.Enabled = true;
            button2.BackColor = Color.Silver;
            button2.Enabled = false;
            lblqty.Text = $"/{Qty}개";
            plan_ID = Plan_ID;
            label2.Text = WorkOrder_ID.ToString();
            qty = Qty;
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

            WorkRegistVO vo = new WorkRegistVO
            {
                Item_Code = lblName.Text,
                FacilityDetail_Code = this.Tag.ToString(),
                WorkRegist_FailQty = int.Parse(lblFail.Text),
                WorkRegist_NomalQty = int.Parse(lblSuccess.Text),
                WorkRegist_WorkTime = int.Parse(lblProgram.Text) * 500,
                WorkRegist_Start = DateTime.Now.ToString("yyyy-MM-dd"),
                WorkRegistID = WorkOrder_ID,
                Plan_ID = plan_ID,
                WorkRegist_State = "제작완료",

            };

            WorkRegistEventArgs args = new WorkRegistEventArgs();
            args.Data = vo;
            MachinRegist(this, args);
            lblFail.Text = lblSuccess.Text = "0";
            lblProgram.Text = "00";
            bntActive.BackColor = Color.Green;
            bntActive.Enabled = true;
            button2.BackColor = Color.Silver;
            button2.Enabled = false;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id.Equals(Process_ID))
                {
                    process.Kill();
                }
            }

            lblSuccess.Text = lblFail.Text = lblProgram.Text = "0";


        }
    }

    public class WorkRegistEventArgs : EventArgs
    {
        public WorkRegistVO Data { get; set; }
    }





}
