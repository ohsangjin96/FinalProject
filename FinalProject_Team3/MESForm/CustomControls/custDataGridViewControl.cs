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

            this.ColumnHeadersDefaultCellStyle.Font = new Font("나눔스퀘어OTF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.Font = new Font("나눔스퀘어OTF", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.BackgroundColor = Color.White;
            this.Dock = DockStyle.Fill;
            this.BorderStyle = BorderStyle.None;
            this.DefaultCellStyle.BackColor = Color.FromArgb(217, 248, 255);
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.AllowUserToAddRows = false;
            this.DataBindingComplete += CustDataGridViewControl_DataBindingComplete;
        }

        private void CustDataGridViewControl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (gridView.Columns.Count < 1)
                return;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].Cells[0].Value = (r.Index + 1).ToString();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
