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
        public popupOrder()
        {
            InitializeComponent();
        }
        
        
           
        
           
        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvFactory);
            CommonUtil.AddGridTextColumn(dgvFactory, "업체코드", "Com_Code",80);
            CommonUtil.AddGridTextColumn(dgvFactory, "업체명", "Com_Name",80);

            CommonUtil.SetInitGridView(dgvOrder);
            CommonUtil.AddGridTextColumn(dgvOrder, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(dgvOrder, "품명", "Item_Name",80);
            CommonUtil.AddGridTextColumn(dgvOrder, "코드", "Item_Code",80);
            CommonUtil.AddGridTextColumn(dgvOrder, "수량", "Amount",80);
            
        }

        private void LoadData()
        {
            ReOrderService service = new ReOrderService();
            dgvFactory.DataSource=service.SelectFactory();
            dgvOrder.DataSource = service.SelectOrder();
            List<string> list = service.SelectHouse();
            for(int i = 0; i<list.Count; i++)
            {
                cbohouse.Items.Add(list[i]);
            }
            
            //발주업체 -> 소요계획에 있던 업체 불러오기

            //발주 -> 발주업체 목록에 있는 창고 재고와 발주제안수량 보여주기 (발주수량 입력 후 발주 버튼 클릭하면 발주신청)
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

        private void dgvFactory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtComcode.Text = dgvFactory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtComName.Text = dgvFactory.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDate.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItem.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAmount.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}