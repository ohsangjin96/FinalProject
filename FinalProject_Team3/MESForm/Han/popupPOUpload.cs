using FProjectDAC;
using FProjectVO;
using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MESForm.frmMain;
using Excel = Microsoft.Office.Interop.Excel;

namespace MESForm.Han
{
    public partial class popupPOUpload : Form
    {
        public string planID { get; set; }
        public string oldplanID { get; set; }
        public List<POVO> viewlist { get; set; }
        public DataTable uploaddt { get; set; }
        public List<POVO> uploadlist { get; set; }
        string item_code = string.Empty;

        public popupPOUpload()
        {
            InitializeComponent();

            txtPlanFile.Enabled = false;
            dtpPlan.Enabled = true;
            dtpPlan.MinDate = DateTime.Now;
            txtPlanVersion.Enabled = false;
        }

        public popupPOUpload(OpenMode mode)
        {
            InitializeComponent();

            txtPlanFile.Enabled = false;
            txtPlanVersion.Enabled = false;

            if (mode == OpenMode.Register)
            {
                dtpPlan.Enabled = true;
            }
            else if (mode == OpenMode.Update)
            {
                dtpPlan.Enabled = false;
            }
        }

        private void popupPOUpload_Load(object sender, EventArgs e)
        {
            txtPlanVersion.Text = planID;
         
            if (txtPlanVersion.Text.Length > 0)
            {
                oldplanID = txtPlanVersion.Text;
                string date_tmp = null;
                date_tmp = txtPlanVersion.Text.Substring(0, 4) + "-" + txtPlanVersion.Text.Substring(4, 2) + "-" + txtPlanVersion.Text.Substring(6, 2);
                dtpPlan.Value = Convert.ToDateTime(date_tmp);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            txtPlanFile.Text = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel (*.xlsx)|*.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

                string fileName = dlg.FileName;
                string fileExtension = System.IO.Path.GetExtension(fileName);
                string strConn = string.Empty;
                string sheetName = string.Empty;

                switch (fileExtension)
                {
                    case ".xls":
                        strConn = string.Format(Excel03ConString, fileName, "Yes");
                        break;
                    case ".xlsx":
                        strConn = string.Format(Excel07ConString, fileName, "Yes");
                        break;
                }
                //첫번째 Sheet 명을 가져옮
                OleDbConnection conn = new OleDbConnection(strConn);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                conn.Open();
                // 엑셀파일을 읽었을때 테이블명은 [Sheet$]
                string sql = "select * from [" + sheetName + "]";
                OleDbDataAdapter oda = new OleDbDataAdapter(sql, conn);
                uploaddt = new DataTable();
                oda.Fill(uploaddt);
                conn.Close();
                if (uploaddt.Columns.Count > 0)
                {
                    uploaddt.Columns[1].ColumnName = "Order_WO";
                    uploaddt.Columns[2].ColumnName = "Com_Code";
                    uploaddt.Columns[3].ColumnName = "Com_Name";
                    uploaddt.Columns[4].ColumnName = "Com_Type";
                    uploaddt.Columns[5].ColumnName = "Order_MKT";
                    uploaddt.Columns[6].ColumnName = "Order_OrderType";
                    uploaddt.Columns[7].ColumnName = "Order_Group";
                    uploaddt.Columns[8].ColumnName = "Order_Gubun";
                    uploaddt.Columns[9].ColumnName = "Order_Size";
                    uploaddt.Columns[10].ColumnName ="ITEM_Type";
                    uploaddt.Columns[11].ColumnName ="Item_Name";
                    uploaddt.Columns[12].ColumnName ="Order_OrderAmount";
                    uploaddt.Columns[13].ColumnName = "Order_FixedDate";
                }
                txtPlanFile.Text = dlg.FileName;
                

                //업로드한 엑셀 내용의 유효성체크
                POService service = new POService();

                string com_code, com_name, item_name, order_wo;

                foreach(DataRow dr in uploaddt.Rows)
                {
                    com_code = dr["Com_Code"].ToString();
                    com_name = dr["Com_Name"].ToString();
                    item_name = dr["Item_Name"].ToString();
                    order_wo = dr["Order_WO"].ToString();

                    if(!service.ExcelCompanyCheck(com_code, com_name))
                    {
                        MessageBox.Show("업로드할 주문서의 업체의 정보를 다시 확인해주세요.(실패)");
                        txtPlanFile.Text = null;
                        return;
                    }

                    item_code = service.ExcelItemCheck(item_name);

                    if (item_code == null)
                    {
                        MessageBox.Show("업로드할 주문서의 품목 정보를 다시 확인해주세요.(실패)");
                        txtPlanFile.Text = null;
                        return;
                    }

                    if (service.ExcelWOCheck(order_wo))
                    {
                        MessageBox.Show("업로드할 주문서의 고객주문번호를 다시 확인해주세요.(실패)");
                        txtPlanFile.Text = null;
                        return;
                    }

                    foreach(var i in viewlist)
                    {
                        if (i.Order_WO == order_wo)
                        {
                            MessageBox.Show("업로드할 주문서의 고객주문번호를 다시 확인해주세요.(실패)");
                            txtPlanFile.Text = null;
                            return;
                        }
                    }


                }
                service.Dispose();
            }
        }

        private void dtpPlan_ValueChanged(object sender, EventArgs e)   //계획일자선택
        {
            if (dtpPlan.Value < DateTime.Now)
            {
                MessageBox.Show("현재날짜 이전의 날짜는 계획일자로 선택할 수 없습니다.");
                dtpPlan.Value = DateTime.Now;
            }

            if (oldplanID == null)
            {
                txtPlanVersion.Text = dtpPlan.Value.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("mmss");
            }
        }

        private void txtPlanFile_TextChanged(object sender, EventArgs e)
        {
            if (oldplanID == null)
            {
                txtPlanVersion.Text = null;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //if 선택파일명, 계획기준버전 선택한 경우
            if (txtPlanFile.Text.Length > 0 && txtPlanVersion.Text.Length > 0)
            {
                uploaddt.Columns.Add("Plan_ID");
                uploaddt.Columns.Add("Order_Plandate");
                uploaddt.Columns.Add("Item_Code");
                uploaddt.Columns.Add("Order_Arrive");
                uploaddt.Columns.Add("Order_Remark");

                foreach (DataRow dr in uploaddt.Rows)
                {
                    dr["Plan_ID"] = txtPlanVersion.Text;
                    dr["Order_Plandate"] = dtpPlan.Value.ToShortDateString();
                    dr["ITEM_Code"] = item_code;
                    dr["Order_Arrive"] = dr["Com_Code"];
                    dr["Order_Remark"] = "";
                }

                List<POVO> planidfind = (from id in viewlist
                                         where id.Plan_ID.Substring(0, 8) == txtPlanVersion.Text.Substring(0, 8)
                                         select id).ToList();

                if (planidfind.Count != 0)
                    oldplanID = planidfind[0].Plan_ID;
                
                //if 계획기준버전이 존재하는 경우 파일 덮어쓰기 여부 showdialog
                if (oldplanID!=null/*planID !=null || planidfind.Count!=0*/)
                {
                    if (MessageBox.Show("계획일자로 존재하는 영업마스터가 있습니다.\n파일을 덮어쓰시겠습니까?", "파일 덮어쓰기", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        //planid가 같은 값 제거
                        viewlist.RemoveAll(i => i.Plan_ID.Equals(planID));

                        //planid 업데이트
                        string[] str_tmp = planID.Split('_');
                        planID = str_tmp[0] + "_" + DateTime.Now.ToString("mmss");
                        txtPlanVersion.Text = planID;
                    }
                    else
                    {
                        return;
                    }
                }

                //업로드 성공
                uploadlist = Helper.ConvertDataTableToList<POVO>(uploaddt);
                viewlist.AddRange(uploadlist);

                this.DialogResult = DialogResult.OK;
            }
            //else 선택파일명, 계획기준버전 없는경우 업로드 실패
            else
            {
                MessageBox.Show("업로드할 파일이 없습니다.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
