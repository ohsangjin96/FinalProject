﻿using FProjectVO;
using MESForm.Services;
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

namespace MESForm.Han
{
    public partial class popupOrder : BaseForms.frmPopup
    {
        List<ReOrderVO> list = new List<ReOrderVO>();
        List<ReOrderVO> newList = new List<ReOrderVO>();

        public List<ReOrderVO> Curlist {get{return list;} set {list=value;}}

        public popupOrder()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvOrder);
            CommonUtil.AddGridTextColumn(dgvOrder, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(dgvOrder, "품명", "Item_Name",80);
            CommonUtil.AddGridTextColumn(dgvOrder, "코드", "Item_Code",80);
            CommonUtil.AddGridTextColumn(dgvOrder, "수량", "Amount",80);
            CommonUtil.AddGridTextColumn(dgvOrder, "입고창고", "ITEM_WareHouse_IN", 80);
            CommonUtil.AddGridTextColumn(dgvOrder, "발주업체", "ITEM_Order_Company", 80);
            CommonUtil.AddGridTextColumn(dgvOrder, "업체코드", "Com_Code", 80);
            CommonUtil.SetInitGridView(dgvReOrder);

            CommonUtil.AddGridTextColumn(dgvReOrder, "품명", "ITEM_Code");
            CommonUtil.AddGridTextColumn(dgvReOrder, "수량", "Amount");
            CommonUtil.AddGridTextColumn(dgvReOrder, "업체코드", "Com_Code");
            CommonUtil.AddGridTextColumn(dgvReOrder, "잔량", "Amount");
            CommonUtil.AddGridTextColumn(dgvReOrder, "취소가능량", "Amount");
            CommonUtil.AddGridTextColumn(dgvReOrder, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(dgvReOrder, "입고창고", "ITEM_WareHouse_IN");
            CommonUtil.AddGridTextColumn(dgvReOrder, "비고", "Note");

            dgvReOrder.Columns["Note"].ReadOnly = false;
        }

        private void LoadData()
        {
            ReOrderService service = new ReOrderService();
            list = service.SelectOrder(DateTime.Now);
            service.Dispose();
            dgvOrder.DataSource = list;
        }
        
        private void popupOrder_Load(object sender, EventArgs e)
        {
            DGVSetting();
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDate.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItem.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAmount.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtComName.Text = dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtWareHouse.Text = dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString();
            label2.Text = dgvOrder.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //dgvReOrder.DataSource = null;
            //string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //ReOrderVO vo = new ReOrderVO
            //{
            //    Com_Code = label2.Text,
            //    Reorder_Amount = Convert.ToInt32(txtAmount.Text),
            //    ReOrder_FixDate = date,
            //    ITEM_Code = txtItem.Text,
            //    Reorder_Balance = Convert.ToInt32(txtAmount.Text),
            //    Plan_ID = txtDate.Text,
            //    WareHouse_In = txtWareHouse.Text,
            //    Reorder_CanCancel = Convert.ToInt32(txtAmount.Text),
            //    Note = Convert.ToString(dgvReOrder["Note", 1].Value)
            //};
            //list.Add(vo);
            //dgvReOrder.DataSource = list;

            ReOrderService service = new ReOrderService();
            bool result = service.InsertReOrder(newList);
            service.Dispose();

            if (result)
            {
                MessageBox.Show("발주가 완료되었습니다.");
                dgvReOrder.DataSource = null;
            }
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            newList.Add(list[e.RowIndex]);
            dgvReOrder.DataSource = null;
            dgvReOrder.DataSource = newList;
        }
    }
    
}