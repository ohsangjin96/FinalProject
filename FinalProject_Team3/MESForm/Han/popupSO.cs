using FProjectVO;
using MESForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MESForm.frmMain;

namespace MESForm.Han
{
    public partial class popupSO : BaseForms.frmPopup
    {
        List<CompanyVO> Companylist;
        List<FactoryVO> Factorylist;

        public popupSO()
        {
            InitializeComponent();
            dtpFixedDate.MinDate = DateTime.Now;
        }

        public popupSO(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {

            }
            else if (mode == OpenMode.Update)
            {

            }
        }

        private void ComboBinding()
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성체크
            //
            POVO vo = new POVO()
            {
                Order_WO = txtWO.Text,
                Order_Arrive = cboArrive.Text,
                Com_Name = cboCom.Text,
                Order_FixedDate = dtpFixedDate.Value,
                Item_Name = txtItemName.Text,
                ITEM_Type = cboItmeType.Text,
                Order_OrderAmount = Convert.ToInt32(txtOrderAmount.Text),
                Order_RelaseAmount = Convert.ToInt32(txtReleaseAmount.Text),
                Order_CancelAmount = Convert.ToInt32(txtCancelAmount.Text),
                Order_OrderType = cboOrderType.Text
            };

            POService service = new POService();
            bool bFlag = service.RegPOList(vo);

            if (bFlag == true)
            {
                MessageBox.Show("저장완료");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("저장실패");
            }
        }
    }
}
