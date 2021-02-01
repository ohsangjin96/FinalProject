using FProjectDAC;
using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmPOUpload : BaseForms.frmBaseLists
    {
        public string PlanID { get; set; }
        public string OldPlanID { get; set; }
        public List<POVO> viewlist { get; set; }
        public List<POVO> insertlist { get; set; }
        public List<POVO> updatelist { get; set; }
        
        List<POVO> allList;

        public frmPOUpload()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanDate", "Order_Plandate");
            //CommonUtil.AddGridTextColumn(custDataGridViewControl1, "순번", "No");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "WorkOrderID", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체CODE", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품처", "Com_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "MKT", "Order_MKT");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주구분", "Order_OrderType");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "GROUP", "Order_Group");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "구분", "Order_Gubun");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "사이즈", "Order_Size");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고P/NO", "ITEM_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "계획수량합계", "TotalOrderAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "Plan_ID");

            //업체code, 납품처 => 업체관리의 업체 리스트 내용만 입력 가능
            //입고P/NO, 품명 => 품목관리의 품목 리스트 내용만 입력 가능
        }

        private void LoadData()
        {
            POService service = new POService();
            allList = service.GetPOList();
            service.Dispose();

            custDataGridViewControl1.DataSource = allList;
        }

        private void frmPOUpload_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();

            viewlist = (List<POVO>)custDataGridViewControl1.DataSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            popupPOUpload pop = new popupPOUpload(OpenMode.Register);
            pop.viewlist = viewlist;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                custDataGridViewControl1.DataSource = null;
                custDataGridViewControl1.DataSource = pop.viewlist;
                custDataGridViewControl1.Update();
                //저장버튼 클릭 시 추가 할 list
                insertlist = pop.uploadlist;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //영업마스터 DB에 데이터 insert
            if (MessageBox.Show("변경한 내용을 저장하시겠습니까?", "영업마스터 변경", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (insertlist != null)
                {
                    POService service = new POService();
                    foreach (POVO i in insertlist)
                    {
                        service.RegPOList(i);
                    }
                    service.Dispose();
                }
                if (updatelist != null)
                {
                    POService service = new POService();
                    if (service.DelPOList(OldPlanID))
                    {
                        foreach (POVO i in updatelist)
                        {
                            service.RegPOList(i);
                        }
                    }
                    else
                    {
                        MessageBox.Show("기존 정보 삭제 실패");
                    }
                    service.Dispose();
                }
                MessageBox.Show("저장");
            }
            LoadData();
        }

        private void btnFrmDownload_Click(object sender, EventArgs e)
        {
            //엑셀 양식 다운로드
            ExcelDownload();
        }

        private void custDataGridViewControl1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택한 데이터의 planID 넘기기
            PlanID = this.custDataGridViewControl1.CurrentRow.Cells["Plan_ID"].Value.ToString();

            popupPOUpload pop = new popupPOUpload(OpenMode.Update);
            pop.viewlist = viewlist;
            pop.planID = PlanID;
            if (pop.ShowDialog() == DialogResult.OK)
            {                
                MessageBox.Show("수정이 완료되었습니다.");
                custDataGridViewControl1.DataSource = null;
                custDataGridViewControl1.DataSource = pop.viewlist;
                custDataGridViewControl1.Update();
                //저장버튼 클릭 시 PlanID포함한 데이터 삭제 후 추가 할 list
                updatelist = pop.uploadlist;
                OldPlanID = pop.oldplanID;
            }
        }

        #region 엑셀양식
        private void ExcelDownload()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls";
            dlg.Title = "양식 다운로드";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //Range range = null;
                //range = xlWorkSheet.get_Range("A1", "M100");

                // 전체  
                //range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                // 아래,오른쪽,왼쪽,위  
                //range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                //range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                //range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                //range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                #region 컬럼명
                //xlWorkSheet.Cells[1, 1] = "순번";
                //xlWorkSheet.Cells[1, 2] = "WorkOrderID";
                //xlWorkSheet.Cells[1, 3] = "업체CODE";
                //xlWorkSheet.Cells[1, 4] = "납품처";
                //xlWorkSheet.Cells[1, 5] = "회사유형";
                //xlWorkSheet.Cells[1, 6] = "MKT";
                //xlWorkSheet.Cells[1, 7] = "발주구분";
                //xlWorkSheet.Cells[1, 8] = "GROUP";
                //xlWorkSheet.Cells[1, 9] = "구분";
                //xlWorkSheet.Cells[1, 10] = "사이즈";
                //xlWorkSheet.Cells[1, 11] = "입고P/NO";
                //xlWorkSheet.Cells[1, 12] = "품명";
                //xlWorkSheet.Cells[1, 13] = "계획수량합계";
                //xlWorkSheet.Cells[1, 14] = "납기일";
                #endregion
                xlWorkSheet.Cells[1, 1] = "순번";
                xlWorkSheet.Cells[1, 2] = "Order_WO";
                xlWorkSheet.Cells[1, 3] = "Com_Code";
                xlWorkSheet.Cells[1, 4] = "Com_Name";
                xlWorkSheet.Cells[1, 5] = "Com_Type";
                xlWorkSheet.Cells[1, 6] = "Order_MKT";
                xlWorkSheet.Cells[1, 7] = "Order_OrderType";
                xlWorkSheet.Cells[1, 8] = "Order_Group";
                xlWorkSheet.Cells[1, 9] = "Order_Gubun";
                xlWorkSheet.Cells[1, 10] ="Order_Size";
                xlWorkSheet.Cells[1, 11] = "ITEM_Type";
                xlWorkSheet.Cells[1, 12] = "Item_Name";
                xlWorkSheet.Cells[1, 13] = "TotalOrderAmount";
                xlWorkSheet.Cells[1, 14] = "Order_FixedDate";

                xlWorkSheet.Columns.AutoFit();

                xlWorkBook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("양식 다운로드가 완료되었습니다.");
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

    }
}