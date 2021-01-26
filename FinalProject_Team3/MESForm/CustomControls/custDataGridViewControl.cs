using MESForm.Utils;
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
    public partial class custDataGridViewControl : DataGridView
    {
        public custDataGridViewControl()
        {
            InitializeComponent();

            this.Font = new Font("나눔스퀘어OTF", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.BackgroundColor = Color.White;
            this.Dock = DockStyle.Fill;
            this.BorderStyle = BorderStyle.None;
            CommonUtil.AddGridTextColumn(this, "No", "no", 50, true, DataGridViewContentAlignment.MiddleCenter);
            this.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView_RowPostPaint);
        }

        private void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
