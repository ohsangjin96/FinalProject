using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MESForm
{
    public partial class frmWorkRegist : MESForm.BaseForms.frmBaseLists
    {
        List<WorkRegistVO> list;
        List<WorkRegistVO> selectlist;
        bool bflag = true;
        public frmWorkRegist()
        {
            InitializeComponent();
            txtName.TextChanged += txtName_Textchange;
            txtFa.TextChanged += txtFa_Textchange;
         
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "실적번호", "WorkRegistID");
            CommonUtil.AddGridTextColumn(dgvList, "시작날짜", "WorkRegist_Start");
            CommonUtil.AddGridTextColumn(dgvList, "품명", "Item_Code");
            CommonUtil.AddGridTextColumn(dgvList, "설비", "FacilityDetail_Code");
            CommonUtil.AddGridTextColumn(dgvList, "양품", "WorkRegist_NomalQty");
            CommonUtil.AddGridTextColumn(dgvList, "불량", "WorkRegist_FailQty");
            CommonUtil.AddGridTextColumn(dgvList, "공정시간", "WorkRegist_WorkTime");
            CommonUtil.AddGridTextColumn(dgvList, "상태", "WorkRegist_State");
            CommonUtil.AddGridTextColumn(dgvList, "Plan_ID", "Plan_ID");
            POPService service = new POPService();
            list = service.GetWorkRegist();
            dgvList.DataSource = list;
        }

       

        private void txtFa_Textchange(object sender, EventArgs e)
        {
            if (txtFa.TextLength == 0)
            {
                
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                
                txtFa.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtName.Text = "";
            }
        }

        private void txtName_Textchange(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0)
            {
               
                txtFa.Enabled = true;
                txtFa.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
               
                txtFa.Enabled = false;
                txtFa.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                txtFa.Text = "";
            }

        }
     

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dtpfrom.Value < dtpto.Value)
                {
                    var selectdata = (from selected in list
                                      where int.Parse(selected.WorkRegist_Start) > int.Parse(dtpfrom.Value.ToString()) && int.Parse(selected.WorkRegist_Start) < int.Parse(dtpto.Value.ToString())
                                      select selected).ToList();
                    selectlist = selectdata;

                }
                else
                {
                    MessageBox.Show("날짜를 다시 결정해주세요");
                }
            }
            else
            {
                if (txtName.Enabled)
                {
                    string from = DateTime.Now.ToString("yyyyMMdd");
                    string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
                    var selectdata = (from selected in list
                                      where selected.Item_Code == txtName.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                else
                {
                    string from = DateTime.Now.ToString("yyyyMMdd");
                    string to = DateTime.Now.AddDays(12).ToString("yyyyMMdd");
                    var selectdata = (from selected in list
                                      where selected.FacilityDetail_Code == txtFa.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                }
                
                bflag = false;
            }
        }

        private void custButtonControl1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = list;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtFa.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtFa.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void custButtonControl2_Click(object sender, EventArgs e)
        {
            POPService service = new POPService();
            List<WorkRegistVO> shiplist = service.GetShipment();
            List<WorkRegistVO> selectlist = new List<WorkRegistVO>();
            for(int i = 1; i< shiplist.Count; i++)
            {
                shiplist[0].Plan_ID = selectlist[0].Plan_ID;
                
            }
        }
    }
}
