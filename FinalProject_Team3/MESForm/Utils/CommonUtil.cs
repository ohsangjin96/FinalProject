using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Utils
{
    class CommonUtil
    {
        # region 콤보박스 바인딩
        //public static void ComboBinding(ComboBox cbo, List<CommonCodeVO> list, string gubun, bool blankItem = true, string blankText = "")
        //{
        //    var codeList = (from item in list
        //                    where item.Category.Equals(gubun)
        //                    select item).ToList();

        //    if (blankItem)
        //    {
        //        CommonCodeVO blank = new CommonCodeVO
        //        { Category = "", Prod_Name = blankText };
        //        codeList.Insert(0, blank);
        //    }
        //    cbo.DisplayMember = "Prod_Name";
        //    cbo.ValueMember = "CommonNum";
            
        //    cbo.DataSource = codeList;
        //}
        #endregion

        #region 데이터그리드뷰 셋팅
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void AddGridTextColumn(DataGridView dgv,
                                      string headerText, string dataPropertyName,
                                      int colWidth = 100, bool visiblity = true,
                                      DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visiblity;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }
        #endregion

        #region 이미지 <-> byte
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)(tc.ConvertFrom(data));
        }
        #endregion

        #region 데이터그리드뷰 버튼 생성
        public static void DgvButtonBinding(string headText, string name, string text, DataGridView dgv)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = headText;
            btn.Name = name;
            btn.Text = text;        //
            btn.Width = 100;
            btn.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            btn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btn);
        }
        #endregion

        #region 그리드뷰 번호 넣기
        public static void SetDGVDesign_Num(DataGridView dgv)
        {
            // TODO - 임시 주석 제거 // **// 
            // **// dgv.AutoGenerateColumns = false;
            // **// dgv.AllowUserToAddRows = false;

            dgv.AutoGenerateColumns = false;

            dgv.MultiSelect = false; //열하나만선택

            dgv.AllowUserToResizeColumns = true; // 칼럼 사용자 변경 o
            dgv.AllowUserToResizeRows = false; //사용자가임의로 로우의 크기를 변경시킬수 없게     

            dgv.RowHeadersVisible = false; // 맨왼쪽에 있는 컬럼 삭제
            // dgv.RowHeadersWidth = 20;     // 맨왼쪽에 있는 컬럼 사이즈 변경   

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 한줄전체선택
            //dgv.CellBorderStyle = DataGridViewCellBorderStyle.None; //테두리삭제

            dgv.BackgroundColor = Color.White; // Color.FromArgb(248, 241, 233); //그리드뷰 배경색
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);   // 로우 해더 색설정     
          //  dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230); //홀수 행 색
            //dgv.DefaultCellStyle.BackColor = Color.FromArgb(248, 241, 233);//Color.FromArgb(248, 241, 233); // 전체 행 색
          // dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(145, 224, 244); // 선택 로우 색

            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.AllowUserToAddRows = false;
            dgv.RowPostPaint += Dgv_RowPostPaint;
            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.Paint += CommonUtil_Paint;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private static void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ((DataGridView)sender).RowHeadersWidth = 50;
            ((DataGridView)sender).RowHeadersVisible = true;
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Black))
            {

                //TextRenderer.DrawText(e.Graphics,"No.", e.InheritedRowStyle.Font,new Point(e.RowBounds.Location.X + 25, 5),Color.Black);
                //TextRenderer.DrawText(e.Graphics,"No.", e.InheritedRowStyle.Font,new Point(19,5),Color.Black);

                //e.Graphics.DrawString("No.", e.InheritedRowStyle.Font,brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y -20, drawFormat);
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }
        private static void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
        private static void CommonUtil_Paint(object sender, PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, "No.", ((DataGridView)sender).Font, new Point(19, 5), Color.Black);
        }
        #endregion
    }
}
