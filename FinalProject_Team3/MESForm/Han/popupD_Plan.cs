using FProjectDAC;
using FProjectVO;
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
    public partial class popupD_Plan : BaseForms.frmPopup
    {
        List<POVO> allList;
        List<POVO> deList;
        public popupD_Plan()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(custDataGridViewControl1);
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "PlanID", "Plan_ID");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객WO", "Order_WO");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사코드", "Com_Code");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "고객사명", "Com_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "도착지", "Order_Arrive");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품목", "ITEM_Type");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "품명", "Item_Name");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "생산납기일", "Order_FixedDate");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "주문수량", "Order_OrderAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "출고수량", "Order_RelaseAmount");
            CommonUtil.AddGridTextColumn(custDataGridViewControl1, "취소수량", "Order_CancelAmount");
        }

        private void LoadData()
        {
            POService service = new POService();
            allList = service.GetPOList();
            service.Dispose();
            custDataGridViewControl1.DataSource = allList;

            var Planid = (from list in allList
                             where list.Plan_ID != null
                             select list.Plan_ID).Distinct().ToList();
            Planid.Insert(0, "전체"); //전체선택시 전체 데이터
            ComboBoxBinding.BindingComboBoxPart(cboPlanID, Planid, "Plan_ID");

        }

        private void popupD_Plan_Load(object sender, EventArgs e)
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

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (cboPlanID.Text.Length > 0)
            {
                var PlanIDList = (from list in allList
                                    where list.Plan_ID == cboPlanID.Text
                                    select list).Distinct().ToList();
                custDataGridViewControl1.DataSource = null;
                custDataGridViewControl1.DataSource = PlanIDList;
                deList = PlanIDList;
            }
            else
            {
                MessageBox.Show("PlanID값을 선택하세요");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //수요계획생성
            if(MessageBox.Show("수요계획을 생성하시겠습니까?", "수요계획저장", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<DemandVO> updatelist = new List<DemandVO>();

                foreach (POVO i in deList)
                {
                    DemandVO newvo = new DemandVO
                    {
                        Plan_ID = i.Plan_ID,
                        Com_Code = i.Com_Code,
                        Com_Name = i.Com_Name,
                        Item_Code = i.Item_Code,
                        Item_Name = i.Item_Name,
                        Demand_WO = i.Order_WO,
                        Demand_FixedDate = i.Order_FixedDate,
                        Demand_OrderAmount = i.Order_OrderAmount
                    };
                    updatelist.Add(newvo);
                }

                DemandService service = new DemandService();
                foreach (DemandVO i in updatelist)
                {
                    service.Update(i);
                }
                service.Dispose();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}