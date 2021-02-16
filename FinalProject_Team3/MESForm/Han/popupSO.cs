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
using static MESForm.frmMain;

namespace MESForm.Han
{
    public partial class popupSO : BaseForms.frmPopup
    {
        public string WOID { get; set; }          //수정을 위해 선택된 셀의 workorderID
        List<POVO> getList;

        string comtype = string.Empty;
        List<ItemVO> ItemList;
        //public bool Bflag { get; set; }

        public popupSO()
        {
            InitializeComponent();
        }

        public popupSO(OpenMode mode)
        {
            InitializeComponent();
            txtItemName.Enabled = false;

            if (mode == OpenMode.Register)
            {
                txtWO.Enabled = true;
                txtCancelAmount.Enabled = true;
                cboMkt.Enabled = true;
                cboItemCode.Enabled = true;
                txtOrderAmount.Text = txtCancelAmount.Text = txtReleaseAmount.Text = "0";
            }
            else if (mode == OpenMode.Update)
            {
                txtWO.Enabled = false;
                txtCancelAmount.Enabled = false;
                cboMkt.Enabled = false;
                cboItemCode.Enabled = false;
            }
        }

        private void ComboBinding()
        {
            //고객사
            CompanyService company = new CompanyService();
            List<CompanyVO> CompanyList = company.GetCompanyList();

            var Company = (from list in CompanyList
                           select list.Com_Code).Distinct().ToList();
            Company.Insert(0, "");
            company.Dispose();
            ComboBoxBinding.BindingComboBoxPart(cboCom, Company, "Com_Code");
            ComboBoxBinding.BindingComboBoxPart(cboArrive, Company, "Com_Code");    //도착지

            //품목
            ItemService item = new ItemService();
            ItemList= item.GetItemAllList();

            var Item = (from list in ItemList
                        select list.ITEM_Code).Distinct().ToList();
            Item.Insert(0, "");
            item.Dispose();
            ComboBoxBinding.BindingComboBoxPart(cboItemCode, Item, "ITEM_Code");

            //Mkt
            CommonCodeService commoncode = new CommonCodeService();
            List<CommonCodeVO> CommonList = commoncode.GetCommonCodeList();

            var Market = (from list in CommonList
                          where list.Common_Parent == "MktType000"
                          select list.Common_Name).Distinct().ToList();
            Market.Insert(0, "");
            ComboBoxBinding.BindingComboBoxPart(cboMkt, Market, "Common_Name");

            //발주구분 -- commoncode에 추가(?)
            List<string> Gubun = new List<string>();
            Gubun.Add("");
            Gubun.Add("P/O");
            ComboBoxBinding.BindingComboBoxPart(cboGubun, Gubun,"");

        }

        private void DataLoad() //선택한 셀의 수정내용 로드
        {
            txtWO.Text = WOID;

            POService service = new POService();
            getList = service.GetPOList(WOID);

            dtpFixedDate.Value = getList[0].Order_FixedDate;
            cboCom.Text = getList[0].Com_Code;
            cboItemCode.Text = getList[0].Item_Code;
            txtOrderAmount.Text = getList[0].Order_OrderAmount.ToString();
            txtCancelAmount.Text = getList[0].Order_CancelAmount.ToString();
            txtReleaseAmount.Text = getList[0].Order_RelaseAmount.ToString();
            cboMkt.Text = getList[0].Order_MKT;
            cboGubun.Text = getList[0].Order_OrderType;
            txtRemark.Text = getList[0].Order_Remark;
        }

        private void popupSO_Load(object sender, EventArgs e)
        {
            ComboBinding();
            if (WOID != null)
            {
                DataLoad();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (cboCom.Text == "" || cboItemCode.Text == "" || txtOrderAmount.Text == "0" || txtOrderAmount.Text == "" || cboMkt.Text == "")
            {
                MessageBox.Show("필수 입력사항을 체크하세요");
                return;
            }

            CompanyService company = new CompanyService();
            List<CompanyVO> companyList = company.GetCompanyList();

            var comtypelist = (from list in companyList
                               where list.Com_Code == cboCom.Text
                               select list).ToList();

            foreach (var i in comtypelist)
            {
                comtype = i.Com_Type;
            }

            POService poservice = new POService();
            List<POVO> poList = poservice.GetPOList();
            foreach(var i in poList)
            {
                if(i.Order_WO==txtWO.Text)
                {
                    MessageBox.Show("입력한 고객주문번호와 일치하는 번호가 존재합니다.");
                    return;
                }
            }
            poservice.Dispose();

            //planid..?
            POVO vo = new POVO()
            {
                Order_WO = txtWO.Text,
                Com_Code = cboCom.Text,
                Com_Type = comtype,
                Order_MKT = cboMkt.Text,
                Order_OrderType = cboGubun.Text,
                Item_Code = cboItemCode.Text,
                Item_Name = txtItemName.Text,
                Order_FixedDate = dtpFixedDate.Value,
                Order_OrderAmount = Convert.ToInt32(txtOrderAmount.Text),
                Order_RelaseAmount = Convert.ToInt32(txtReleaseAmount.Text),
                Order_CancelAmount = Convert.ToInt32(txtCancelAmount.Text),
                Order_Arrive = cboArrive.Text,
                Order_Remark = txtRemark.Text
            };

            POService service = new POService();

            if (WOID == null)
            {
                vo.Order_Group = "";
                vo.Order_Gubun = "양산";
                vo.Order_Size = 321;
                vo.Plan_ID = DateTime.Now.ToString("yyyyMMdd_mmss");
                vo.Order_Plandate = DateTime.Now;

                bool bFlag = service.RegPOList(vo);
                service.Dispose();

                if (bFlag == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("저장 실패");
                    return;
                }
            }
            else
            {
                bool bFlag = service.UpdatePOList(vo);
                service.Dispose();

                if (bFlag == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정 실패");
                    return;
                }
            }
        }

        private void dtpFixedDate_ValueChanged(object sender, EventArgs e)
        {
            if (WOID == null)
            {
                if (dtpFixedDate.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("현재날짜 이전의 날짜는 납기일로 선택할 수 없습니다.");
                    dtpFixedDate.Value = DateTime.Now;
                }
            }
        }

        private void cboItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemCode.Text != "")
            {
                var ItemName = (from list in ItemList
                                where list.ITEM_Code == cboItemCode.Text
                                select list).ToList();
                foreach(var i in ItemName)
                {
                    txtItemName.Text = i.ITEM_Name;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
