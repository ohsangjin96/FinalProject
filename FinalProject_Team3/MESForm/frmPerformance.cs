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

namespace MESForm
{
    public partial class frmPerformance : Form
    {
        List<WorkRegistVO> list ;
        public frmPerformance()
        {
            InitializeComponent();
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {
            //CommonUtil.SetInitGridView(custDataGridViewControl1);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "작업코드", "WorkOrder_ID", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사", "Com_Code", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "Item_Code", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "가동설비", "FacilityDetail_Code", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "양품수량", "WorkRegist_NomalQty", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "불량수량", "WorkRegist_FailQty", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "작업시간", "WorkRegist_WorkTime", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "작업상태", "WorkRegist_State", 150);
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "시작일", "WorkRegist_Start", 200);
            //POPService service = new POPService();
            //list=service.GetWorkRegist();
            //custDataGridViewControl1.DataSource = list;
        }
    }
}

   
