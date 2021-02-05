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
        public popupOrder()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "발주업체", "a");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "업체코드", "b");

            CommonUtil.SetInitGridView(custDataGridViewControl2);
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "PlanID", "c");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주업체", "d");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품목", "e");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "품명", "f");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "납기일", "g");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "현재고", "h");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주제안수량", "i");
            CommonUtil.AddGridTextColumn(custDataGridViewControl2, "발주수량", "j");    //입력가능
        }

        private void LoadData()
        {
            //발주업체 -> 소요계획에 있던 업체 불러오기

            //발주 -> 발주업체 목록에 있는 창고 재고와 발주제안수량 보여주기 (발주수량 입력 후 발주 버튼 클릭하면 발주신청)
        }

        private void popupOrder_Load(object sender, EventArgs e)
        {
            DGVSetting();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}