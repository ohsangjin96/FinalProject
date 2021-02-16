using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESForm.Han
{
    public partial class frmMRelease : BaseForms.frmBaseLists
    {
        List<MRealeaseVO> AllList;
        List<CommonCodeVO> Commonlist;
        public frmMRelease()
        {
            InitializeComponent();
        }

        private void DGVSetting()
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "불출번호", "MR_Code");//1 d 
            CommonUtil.AddGridTextColumn(dgvList, "작업지시번호", "WorkOrder_ID");//2 d 
            CommonUtil.AddGridTextColumn(dgvList, "요청일자", "requestDate");//3
            CommonUtil.AddGridTextColumn(dgvList, "품목", "Item_Code",140);//4 d 
            CommonUtil.AddGridTextColumn(dgvList, "품명", "Item_name",140);//5
            CommonUtil.AddGridTextColumn(dgvList, "품목유형", "ITEM_Type");//6
            CommonUtil.AddGridTextColumn(dgvList, "규격", "Item_Standard");//7
            CommonUtil.AddGridTextColumn(dgvList, "단위", "Item_Unit");//8
            CommonUtil.AddGridTextColumn(dgvList, "요청업체", "item_Order_Company");//9
            CommonUtil.AddGridTextColumn(dgvList, "불출창고", "ITEM_WareHouse_IN");//10
            CommonUtil.AddGridTextColumn(dgvList, "수량", "Qty");//11 d 
            CommonUtil.AddGridTextColumn(dgvList, "작업일자", "RegDate");//12
            CommonUtil.AddGridTextColumn(dgvList, "상태", "MR_State",50);//13

            

        }
        private void ComBind()
        {
            CommonCodeService Common = new CommonCodeService();
            Commonlist = Common.GetCommonCodeList();
            Common.Dispose();
            ComboBoxBinding.ComBind(cboItemType, Commonlist, "ItemType000", true, "전체");//품목유형

        }
        private void frmMConfine_Load(object sender, EventArgs e)
        {
            dateTimePicker1.DtpTo = DateTime.Now.AddDays(5);
            DGVSetting();
            ComBind();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string dtpfrom = string.Empty;
            string dtpto = string.Empty;
            dtpfrom = dateTimePicker1.DtpFrom.ToShortDateString();
            dtpto = dateTimePicker1.DtpTo.ToShortDateString();

            MRealeaseService service = new MRealeaseService();
            AllList = service.GetList(dtpfrom, dtpto, cboItemType.Text);
            
            dgvList.DataSource = AllList;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExportImport.ExcelExportToDataGridView(this, dgvList);
        }

        private void btnRelease_Click(object sender, EventArgs e)//출고 버튼
        {
            int qty;
            MRealeaseService service = new MRealeaseService();
            int rowIdx1 = dgvList.CurrentRow.Index;
            //유효성 검사
            int MR_Code = Convert.ToInt32(dgvList[1, rowIdx1].Value.ToString());//불출번호
            int WoCode = Convert.ToInt32(dgvList[2, rowIdx1].Value.ToString());//작업지시번호
            string code = dgvList[4, rowIdx1].Value.ToString(); //품목
            int Qty = Convert.ToInt32(dgvList[11, rowIdx1].Value.ToString());//작업지시번호

            qty = service.QtyCheck(code);
            if (qty==0)
            {
                MessageBox.Show("재고가 없습니다. 발주를 하십시오.");
                return;
            }
            try
            {
                //출고 시작
                bool bFlag = service.Release(WoCode, Qty, code, MR_Code);
                if (bFlag)
                {
                    MessageBox.Show(Properties.Resources.SaveSuccess + "새로고침 하십시오.");
                }
                // 작지번호 수량 품목 불출번호
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            


        }
    }
}
