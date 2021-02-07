using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MESForm.Utils
{
    public class ExcelExportImport
    {
        public static string ExportToDataGridView<T>(List<T> dataList, string exceptColumns) //exceptColumns : 제외하고 싶은 컬럼
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                excel.Application.Workbooks.Add(true);

                int columnIndex = 0;

                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    if (!exceptColumns.Contains(prop.Name))
                    {
                        columnIndex++;
                        excel.Cells[1, columnIndex] = prop.Name;
                    }
                }

                int rowIndex = 0;

                foreach (T data in dataList)
                {
                    rowIndex++;
                    columnIndex = 0;
                    foreach (PropertyInfo prop in typeof(T).GetProperties())
                    {
                        if (!exceptColumns.Contains(prop.Name))
                        {
                            columnIndex++;
                            if (prop.GetValue(data, null) != null)
                            {
                                excel.Cells[rowIndex + 1, columnIndex] = prop.GetValue(data, null).ToString();
                            }
                        }
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
                Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;
                worksheet.Activate();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ExcelExportToDataGridView(Form frm, DataGridView dgv, string exceptColumns = "")
        {
            Cursor currentCursor = frm.Cursor;
            try
            {
                frm.Cursor = Cursors.WaitCursor;

                Excel._Application excel = new Excel.Application();
                Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;
                Excel.Range range;

                worksheet = workbook.ActiveSheet;

                int rowIndex = 1;
                int columnIndex = 1;

                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    if(!exceptColumns.Contains(dgv.Columns[col].HeaderText))
                    {
                        worksheet.Cells[rowIndex, columnIndex] = dgv.Columns[col].HeaderText;
                        columnIndex++;
                    }
                }
                range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, columnIndex-1]];
                range.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(142, 169, 219));
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int row = 0; row < dgv.Rows.Count - 1; row++)
                {
                    rowIndex++;
                    columnIndex = 1;
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        if (!exceptColumns.Contains(dgv.Columns[col].HeaderText))
                        {
                            worksheet.Cells[rowIndex, columnIndex] = Convert.ToString(dgv.Rows[row].Cells[col].Value);
                            columnIndex++;
                        }
                    }
                }

                excel.Columns.AutoFit();
                excel.Visible = true;
                worksheet = (Excel.Worksheet)excel.ActiveSheet;
                worksheet.Activate();

                ReleaseObject(excel);
                ReleaseObject(workbook);
                ReleaseObject(worksheet);
                return "";
            }
            catch (Exception err)
            {
                return err.Message;
            }
            finally
            {
                frm.Cursor = currentCursor;
            }
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception err)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
