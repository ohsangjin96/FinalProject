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
        List<CompanyVO> Companylist;

        public frmD_Plan()
        {
            InitializeComponent();
        }

        private void ComboBinding()
        {
            //고객사
            CompanyService company = new CompanyService();
            Companylist = company.GetCompanyList();

            var Company = (from list in Companylist
                           select list.Com_Name).Distinct().ToList();
            Company.Insert(0, "전체");
            ComboBoxBinding.BindingComboBoxPart(cboCompany, Company, "Com_Name");

        }

        private void frmD_Plan_Load(object sender, EventArgs e)
        {
            ComboBinding();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupP_Plan frm = new popupP_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("생산계획 생성이 완료되었습니다");
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            //날짜 입력만큼의 데이터 조회
            string dtpfrom = dateTimePicker1.DtpFrom.ToString("yyyyMMdd");
            string dtpto = dateTimePicker1.DtpTo.ToString("yyyyMMdd");

            DemandService service = new DemandService();
            DataTable dt = service.GetList(dtpfrom, dtpto);
            service.Dispose();
            //custDataGridViewControl1.DataSource = dt;

            DataTable searchdt = new DataTable();

            searchdt = dt.Clone();

            string com_name, item_name, demandID;
            foreach (DataRow dr in dt.Rows)
            {
                com_name = dr["고객사명"].ToString();
                item_name = dr["품명"].ToString();
                demandID = dr["고객주문번호"].ToString();

                if (cboCompany.Text == "전체")
                {
                    if (txtPlanID.Text == "")
                    {
                        if (txtItem.Text == "")
                        {
                            searchdt = dt;
                            break;
                        }
                        else
                        {
                            if (item_name == txtItem.Text)
                                searchdt.ImportRow(dr);
                        }
                    }
                    else
                    {
                        if (txtItem.Text == "")
                        {
                            if (demandID == txtPlanID.Text)
                                searchdt.ImportRow(dr);
                        }
                        else
                        {
                            if (demandID == txtPlanID.Text && item_name == txtItem.Text)
                                searchdt.ImportRow(dr);
                        }
                    }
                }
                else
                {
                    if (com_name == cboCompany.Text)
                    {
                        if (txtPlanID.Text == "")
                        {
                            if (txtItem.Text == "")
                            {
                                searchdt = dt;
                                break;
                            }
                            else
                            {
                                if (item_name == txtItem.Text)
                                    searchdt.ImportRow(dr);
                            }
                        }
                        else
                        {
                            if (txtItem.Text == "")
                            {
                                if (demandID == txtPlanID.Text)
                                    searchdt.ImportRow(dr);
                            }
                            else
                            {
                                if (demandID == txtPlanID.Text && item_name == txtItem.Text)
                                    searchdt.ImportRow(dr);
                            }
                        }
                    }
                }
            }
            custDataGridViewControl1.DataSource = searchdt;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExcelExportToDataGridView(this, custDataGridViewControl1, string.Empty);
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
    }
}