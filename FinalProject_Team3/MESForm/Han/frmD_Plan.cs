using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FProjectVO;
using MESForm.Services;
using MESForm.Utils;

namespace MESForm.Han
{
    public partial class frmD_Plan : BaseForms.frmBaseLists
    {
        public frmD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            custDataGridViewControl1.AutoGenerateColumns = true;    //컬럼 개수
            //custDataGridViewControl1.AllowUserToAddRows = false;
            //custDataGridViewControl1.MultiSelect = false;
            //custDataGridViewControl1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "No", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사설비", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객주문번호", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "f");
        }

        private void frmD_Plan_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();

            POService service = new POService();
            List<POVO> polist = service.GetPOList();
            var planidlist = (from list in polist
                              select list.Plan_ID).ToList();
            
            ComboBoxBinding.BindingComboBoxPart(cboPlanID, planidlist, "Plan_ID");
        }

        private void LoadData()
        {
            //데이터 로드
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupP_Plan frm = new popupP_Plan();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            //날짜 입력만큼의 데이터 조회
            //피벗 이용한 데이터 리스트로 가져오기
            //날짜 컬럼 안에 내용이 있다면 색 표시하기
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sResult = ExcelExportImport.ExportToDataGridView<DemandVO>((List<DemandVO>)custDataGridViewControl1.DataSource, string.Empty);
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
    }
}