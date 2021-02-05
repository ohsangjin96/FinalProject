using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FProjectDAC;
using FProjectVO;
using MESForm.Services;
using MESForm.Utils;

namespace MESForm.Han
{
    public partial class frmD_Plan : BaseForms.frmBaseLists
    {
        List<POVO> polist;

        public frmD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사설비", "Com_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "Item_Name");
        }

        private void frmD_Plan_Load(object sender, EventArgs e)
        {
            //DGVSetting();

            POService service = new POService();
            polist = service.GetPOList();
            var planidlist = (from list in polist
                              select list.Plan_ID).ToList();
            
            ComboBoxBinding.BindingComboBoxPart(cboPlanID, planidlist, "Plan_ID");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string dtpfrom = string.Empty;
            string dtpto = string.Empty;
            //날짜 입력만큼의 데이터 조회
            DateTime dtpFrom = dateTimePicker1.DtpFrom;
            DateTime dtpTo = dateTimePicker1.DtpTo;

            dtpfrom = dtpFrom.ToShortDateString();
            dtpto = dtpTo.ToShortDateString();

            DemandService service = new DemandService();
            DataTable dt = service.GetList(dtpfrom, dtpto);
            custDataGridViewControl1.DataSource = dt;

            //POService service = new POService();
            //List<POVO> allList = service.GetPOList();


            //var result = allList
            //.GroupBy(c => c.Plan_ID)
            //.Select(g => new
            //{
            //    Plan_ID = g.Key,
            //    dtpfrom = g.Where(c => c.Order_FixedDate.ToShortDateString()==dtpfrom).Sum(c => c.Order_OrderAmount)
            //});


            //if (cboPlanID.Text.Length > 0)
            //{
            //    var PlanIDList = (from list in polist
            //                      where list.Plan_ID == cboPlanID.Text
            //                      select list.Order_WO).Distinct().ToList();

            //    custDataGridViewControl1.DataSource = null;
            //    custDataGridViewControl1.DataSource = PlanIDList;
            //}
            //else
            //{
            //    MessageBox.Show("PlanID값을 선택하세요");
            //}

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //string sResult = ExcelExportImport.ExportToDataGridView<===>((List<===>)custDataGridViewControl1.DataSource, string.Empty);
            //if (sResult.Length > 0)
            //{
            //    MessageBox.Show(sResult);
            //}
        }
    }
}