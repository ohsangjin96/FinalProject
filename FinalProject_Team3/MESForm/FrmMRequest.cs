using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MESForm
{
    public partial class FrmMRequest : MESForm.BaseForms.frmBaseLists
    {
        List<MRequestVO> AllList;
        List<ShiftVO> fList;
        public FrmMRequest()
        {
            InitializeComponent();
        }

        private void FrmMRequest_Load(object sender, EventArgs e)
        {
            dateTimePicker1.DtpTo = DateTime.Now.AddDays(5);

            label4.Visible = false;
            ShiftService service = new ShiftService();
            fList = service.GetShiftInfo();
            service.Dispose();

            var name = (from a in fList
                        select a.Facility_Name).Distinct().ToList();
            name.Insert(0, "전체");
            ComboBoxBinding.BindingComboBox(cboFacility, name, "Facility_Name", "Facility_Name");


            DgvSetting();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvList1);
            CommonUtil.AddGridTextColumn(dgvList1, "작업지시번호", "WorkOrder_ID",130);//2
            CommonUtil.AddGridTextColumn(dgvList1, "업체코드", "Com_Code");//2
            CommonUtil.AddGridTextColumn(dgvList1, "업체명", "Com_Name");//2
            CommonUtil.AddGridTextColumn(dgvList1, "품목", "Item_Code",140);//4
            CommonUtil.AddGridTextColumn(dgvList1, "품명", "Item_Name");//2
            CommonUtil.AddGridTextColumn(dgvList1, "상태", "WorkOrder_State");//2
            CommonUtil.AddGridTextColumn(dgvList1, "설비코드", "Facility_Code");//2
            CommonUtil.AddGridTextColumn(dgvList1, "설비명", "Facility_Name");//2
            CommonUtil.AddGridTextColumn(dgvList1, "수량", "OrderAmount");//9
            CommonUtil.AddGridTextColumn(dgvList1, "일자", "FixDate");//10
            CommonUtil.AddGridTextColumn(dgvList1, "소요시간", "TackTime");//2
            CommonUtil.AddGridTextColumn(dgvList1, "Plan_ID", "Plan_ID");//2
            CommonUtil.AddGridTextColumn(dgvList1, "요청상태", "MR_State");//2

            CommonUtil.SetInitGridView(dgvList2);
            CommonUtil.AddGridTextColumn(dgvList2, "품목", "Item_Code",140);//2
            CommonUtil.AddGridTextColumn(dgvList2, "품명", "Item_Name");//2
            CommonUtil.AddGridTextColumn(dgvList2, "규격", "ITEM_Standard");//2
            CommonUtil.AddGridTextColumn(dgvList2, "단위", "ITEM_Unit");//2
            CommonUtil.AddGridTextColumn(dgvList2, "요청업체", "ITEM_Order_Company");//2
            CommonUtil.AddGridTextColumn(dgvList2, "요청수량", "Qty");//2
            CommonUtil.AddGridTextColumn(dgvList2, "일자", "ReqDate");//2
            CommonUtil.AddGridTextColumn(dgvList2, "요청업체", "ITEM_WareHouse_IN");//2
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
          
            string dtpfrom = string.Empty;
            string dtpto = string.Empty;
            dtpfrom = dateTimePicker1.DtpFrom.ToShortDateString();
            dtpto = dateTimePicker1.DtpTo.ToShortDateString();

            MRequestService service = new MRequestService();
            AllList = service.GetMRequestList(dtpfrom, dtpto,txtItem.Text, txtWOID.Text, cboFacility.Text);
            service.Dispose();
            dgvList1.DataSource = AllList;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvList1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIdx = dgvList1.CurrentRow.Index;
            
            string code = dgvList1[4, rowIdx].Value.ToString();//품목
            int qty =    Convert.ToInt32( dgvList1[9, rowIdx].Value.ToString());//수량
            string date =  dgvList1[10, rowIdx].Value.ToString();//일자
            label4.Text= dgvList1[13, rowIdx].Value.ToString();//일자
            List<MRequestVO> List2;
            MRequestService service = new MRequestService();
            List2 = service.GetList(code,qty, date);
            service.Dispose();
            dgvList2.DataSource = List2;
        }

        private void custButtonControl4_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList1);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList2);
        }

        private void btnSave_Click(object sender, EventArgs e)//저장 버튼
        {
            int rowIdx1 = dgvList1.CurrentRow.Index;
            int rowIdx2 = dgvList2.CurrentRow.Index;

            int WCode = Convert.ToInt32(dgvList1[1, rowIdx1].Value.ToString());

            string code = dgvList2[1, rowIdx2].Value.ToString();
            string name = dgvList2[2, rowIdx2].Value.ToString();
            string standard = dgvList2[3, rowIdx2].Value.ToString();
            string unit = dgvList2[4, rowIdx2].Value.ToString();
            string company = dgvList2[5, rowIdx2].Value.ToString();
            int qty = Convert.ToInt32( dgvList2[6, rowIdx2].Value.ToString());
            DateTime date =Convert.ToDateTime( dgvList2[7, rowIdx2].Value.ToString());
           

            MRequestService service = new MRequestService();
            try
            {
                bool bFlag = service.SaveMR(code, name, standard, unit, company, qty, date, WCode);

                if (label4.Text=="I")
                {
                    MessageBox.Show("이미 요청된 자재 입니다.");
                    return;
                }

                if (bFlag)
                {
                    MessageBox.Show(Properties.Resources.SaveSuccess + "새로고침 하십시오.");
                }
               
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }
    }
}
