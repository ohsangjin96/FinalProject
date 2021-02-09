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
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 33;
            CommonUtil.AddGridTextColumn(dgv, "No", "RowNo", 50, true, DataGridViewContentAlignment.MiddleCenter);
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
        public static void AddGridImageColumn(DataGridView dgv, Image image, string columnName, int width = 50)
        {
            DataGridViewImageColumn col = new DataGridViewImageColumn();

            col.SortMode = DataGridViewColumnSortMode.Automatic;
            col.Image = image;
            col.HeaderText = columnName;
            col.Width = width;
            col.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgv.Columns.Add(col);
        }
        #endregion
    }
}
