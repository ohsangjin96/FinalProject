using FProjectDAC;
using FProjectVO;
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
        public bool Bflag { get; set; }

        public popupPOUpload()
        {
            InitializeComponent();

            txtPlanFile.Enabled = false;
            dtpPlan.Enabled = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                txtPlanFile.Text = dlg.FileName;
            }
        }

        private void dtpPlan_ValueChanged(object sender, EventArgs e)   //계획일자선택
        {
            if (oldplanID == null)
            {
                txtPlanVersion.Text = dtpPlan.Value.ToString("yyyyMMdd") + "_P1";
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
                List<POVO> planidfind = (from id in viewlist
                                 where id.Plan_ID.Substring(0,8) == txtPlanVersion.Text.Substring(0,8)
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
                        string[] str_tmp = planID.Split('P');
                        int int_tmp = Convert.ToInt32(str_tmp[1]);
                        planID = str_tmp[0] + "P" + (int_tmp + 1).ToString();
                        txtPlanVersion.Text = planID;
                    }
                    else
                    {
                        return;
                    }
                }
                //업로드 성공
                uploaddt.Columns.Add("Plan_ID");
                uploaddt.Columns.Add("Order_Plandate");
                uploaddt.Columns.Add("Item_Code");
                uploaddt.Columns.Add("Order_Arrive");
                uploaddt.Columns.Add("Order_Remark");
                foreach(DataRow dr in uploaddt.Rows)
                {
                    dr["Plan_ID"] = txtPlanVersion.Text;
                    dr["Order_Plandate"] = dtpPlan.Value;
                    dr["Item_Code"] = "abc";
                    dr["Order_Arrive"] = "ABC";
                    dr["Order_Remark"] = "비고";
                }

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
    }
}
