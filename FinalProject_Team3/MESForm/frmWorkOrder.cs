using FProjectVO;
using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class frmWorkOrder : MESForm.BaseForms.frmBaseLists
    {
        List<SeeWorkOrderVO> list;
        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {

        }
        private void custButtonControl3_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            list = service.GetWorkOrderList();
            bool bflag = service.InsertWorkOrderList(list);
            if (!bflag)
            {
                MessageBox.Show("작업지시확정에 실패했습니다.");
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            OrderService service = new OrderService();
            string datefrom = dtpfrom.Value.ToString("yyyyMMdd");
            string dateto = dtpto.Value.ToString("yyyyMMdd");
            dgvList.DataSource = service.GetWorkOrder(datefrom, dateto);
        }
    }
}
