using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.CustomControls
{
    public partial class custTabControl : TabControl
    {
        public custTabControl()
        {
            InitializeComponent();

            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            try
            {
                //탭에 사각형 그리기
                Rectangle r = e.Bounds;
                r = this.GetTabRect(e.Index);
                r.Offset(2, 2);

                //선택된 탭의 백그라운드 색상은 흰색(나머지 탭은 기본값)
                if (this.SelectedIndex == e.Index)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }

                //탭에 텍스트 작성
                Brush titleBrush = new SolidBrush(Color.Black);
                string title = this.TabPages[e.Index].Text;
                Font f = this.Font;
                e.Graphics.DrawString(title, f, titleBrush, new Point(r.X, r.Y));

                //탭에 닫기(X) 이미지 추가
                //선택된 탭은 빨간색 나머지는 검정색 이미지
                Image img;
                if (this.SelectedIndex == e.Index)
                    img = Properties.Resources.close_red;
                else
                    img = Properties.Resources.close_black;

                Point _imgLocation = new Point(18, 5);

                e.Graphics.DrawImage(img, new Point(r.X + this.GetTabRect(e.Index).Width - _imgLocation.X, _imgLocation.Y));

                img.Dispose();
                img = null;
            }
            catch
            {

            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
