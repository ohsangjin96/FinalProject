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
    public partial class custButtonControl : Button
    {
        public custButtonControl()
        {
            InitializeComponent();
            this.BackColor = Color.LightSlateGray;
            this.FlatAppearance.BorderColor = Color.LightSteelBlue;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("나눔스퀘어OTF", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = Color.Black;
            this.Size = new Size(83, 32);
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
