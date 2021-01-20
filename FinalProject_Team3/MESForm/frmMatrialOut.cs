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

namespace MESForm
{
    public partial class frmMatrialOut : Form
    {
        public frmMatrialOut()
        {
            InitializeComponent();
        }

        private void frmMatrialOut_Load(object sender, EventArgs e)
        {
            
            #region 작업지시조회
            CommonUtil.SetInitGridView(dgvList1);
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "chk";
            chkCol.HeaderText = "선택";
            chkCol.Width = 50;
            dgvList1.Columns.Add(chkCol);
            CommonUtil.AddGridTextColumn(dgvList1, "계획시작일자", "Order_Date", 160);
            CommonUtil.AddGridTextColumn(dgvList1, "설비코드", "Facility_Code", 200);
            CommonUtil.AddGridTextColumn(dgvList1, "설비명", "Facility_Name", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "품목코드", "ItemCode", 200);
            CommonUtil.AddGridTextColumn(dgvList1, "품목명", "ItemName", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "소진창고", "Facility_Exhaustion", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "불량창고", "Facility_Poor", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "양품창고", "Facility_Imported", 150);
            CommonUtil.AddGridTextColumn(dgvList1, "주문갯수", "Order_Qty", 130);
            CommonUtil.AddGridTextColumn(dgvList1, "작업상태", "Order_State", 120); 
            #endregion
            #region 자재불출
            CommonUtil.SetInitGridView(dgvList2);
            CommonUtil.AddGridTextColumn(dgvList2, "품목코드", "ItemCode", 200);
            CommonUtil.AddGridTextColumn(dgvList2, "품목명", "ItemName", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "소진창고", "Facility_Exhaustion", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "양품창고", "Facility_Imported", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "주문갯수", "Order_Qty", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "소모량", "Qty", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "재고량", " Stock_Amount", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "주문일자", "Order_Date", 160);
            CommonUtil.AddGridTextColumn(dgvList2, "작업상태", "Order_State", 150);
            CommonUtil.AddGridTextColumn(dgvList2, "비고", "Remark", 200);
            #endregion
        }

       
        }
    }

