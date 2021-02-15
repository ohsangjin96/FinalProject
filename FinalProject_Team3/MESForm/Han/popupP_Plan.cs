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
    public partial class popupP_Plan : BaseForms.frmPopup
    {
        List<PPlanSelect> selectData;
        List<DemandVO> allList;
        DateTime fixedDate = DateTime.Now;

        public popupP_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "날짜", "selectDate",200);

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "writeAmount";
            col.HeaderText = "수량";
            col.DataPropertyName = "writeAmount";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            col.Visible = true;
            col.ReadOnly = false;

            custDataGridViewControl1.Columns.Add(col);
        }

        private void LoadData()
        {
            selectData = new List<PPlanSelect>();
            DateTime addDate = DateTime.Now;

            while (true)
            {
                if (addDate.Date == fixedDate.Date)
                {
                    break;
                }

                PPlanSelect select = new PPlanSelect
                {
                    selectDate = addDate.ToShortDateString()
                };
                selectData.Add(select);
                addDate = addDate.AddDays(1);
            }

            custDataGridViewControl1.DataSource = selectData;
        }

        private void popupP_Plan_Load(object sender, EventArgs e)
        {
            DemandService service = new DemandService();
            allList = service.GetDemandAllList();
            service.Dispose();

            lblPlanAmount.Text = lblWriteAmount.Text = "0";

            DGVSetting();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (txtPlanID.Text.Length > 0)
            {
                var PlanIDList = (from list in allList
                                  where list.Plan_ID == txtPlanID.Text
                                  select list).Distinct().ToList();

                int amount = 0;

                foreach(var i in PlanIDList)
                {
                    if(fixedDate.Date < i.Demand_FixedDate.Date)
                    {
                        fixedDate = i.Demand_FixedDate;
                    }
                    amount += i.Demand_OrderAmount;
                }
                LoadData();
                lblPlanAmount.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("PlanID값을 입력하세요");
            }
        }

        public class PPlanSelect
        {
            public string selectDate { get; set; }
            public string writeAmount { get; set; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblPlanAmount == lblWriteAmount)
            {
                //생산계획 생성
            }
            else
            {
                MessageBox.Show("계획수량과 입력한 수량이 일치하지 않습니다.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
