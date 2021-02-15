using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmMT_Plan : BaseForms.frmBaseLists
    {
        public frmMT_Plan()
        {
            InitializeComponent();
        }
        List<MtpVO> list;
        List<MtpVO> selectlist;
        bool aflag = true;
        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "Plan_ID", "Plan_ID",200);
            CommonUtil.AddGridTextColumn(dgvList, "물품코드", "ITEM_Code",200);
            CommonUtil.AddGridTextColumn(dgvList, "품명", "ITEM_Name",200);
            CommonUtil.AddGridTextColumn(dgvList, "갯수", "Amount",200);
            CommonUtil.AddGridTextColumn(dgvList, "계획날짜", "Plan_Date",200);
        }

        private void LoadData()
        {
            MtpService service = new MtpService();
            list =service.GetMtp();
            dgvList.DataSource = list;
        }

        private void frmMT_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
            txtName.TextChanged += txtName_Textchange;
            txtID.TextChanged += txtID_Textchange;
        }

        private void txtID_Textchange(object sender, EventArgs e)
        {
            if (txtID.TextLength == 0)
            {
                txtName.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;

            }
            else
            {
                txtName.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
                
            }
        }

        private void txtName_Textchange(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                txtID.Enabled = true;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
               
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtID.Enabled = false;
                txtName.Enabled = false;
                dtpfrom.Enabled = true;
                dtpto.Enabled = true;
            }
            else
            {
                txtID.Enabled = true;
                txtName.Enabled = true;
                dtpfrom.Enabled = false;
                dtpto.Enabled = false;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList);
        }

        private void custButtonControl1_Click(object sender, EventArgs e)
        {
            MtpService service = new MtpService();
           
            if (aflag)
            {
                bool bflag = service.InsertMtp(list);
                if (bflag)
                {
                    MessageBox.Show("저장되었습니다");
                }
                else
                {
                    MessageBox.Show("실패했습니다");
                }
            }
            else
            {
                bool bflag = service.InsertMtp(selectlist);
                if (bflag)
                {
                    MessageBox.Show("저장되었습니다");
                }
                else
                {
                    MessageBox.Show("실패했습니다");
                }
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dtpfrom.Value < dtpto.Value)
                {
                    var selectdata = (from selected in list
                                      where selected.Plan_Date > Convert.ToDateTime(dtpfrom) && selected.Plan_Date < Convert.ToDateTime(dtpto)
                                      select selected).ToList();
                    selectlist = selectdata;
                    dgvList.DataSource = selectlist;
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
                   
                    var selectdata = (from selected in list
                                      where selected.ITEM_Name == txtName.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                    dgvList.DataSource = selectlist;
                }
                
                else
                {
                 
                    var selectdata = (from selected in list
                                      where selected.Plan_ID == txtID.Text
                                      select selected).ToList();
                    selectlist = selectdata;
                    dgvList.DataSource = selectlist;
                }
            }
            aflag = false;
        }
    }
}