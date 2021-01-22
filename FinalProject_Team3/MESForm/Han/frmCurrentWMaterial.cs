﻿using MESForm.Utils;
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
    public partial class frmCurrentWMaterial : Form
    {
        public frmCurrentWMaterial()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고번호", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고일", "b");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고유형", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고창고", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "규격", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "단위", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "입고량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소량", "j");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "잔량", "k");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체", "l");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "납품업체", "m");
        }

        private void frmCurrentWMaterial_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }
    }
}