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
using System.Windows.Forms;
using static MESForm.frmMain;

namespace MESForm
{

    public partial class PopUpSalesCost : MESForm.BaseForms.frmPopup
    {
        bool bRegOrUp;// 등록인지 수정인지
        List<string> list; // 고객사의 대한 품목들 리스트
        public SalesCostVO SCvo { get; set; }
        public string Uname { get; set; }
        public PopUpSalesCost()
        {
            InitializeComponent();
        }
        public PopUpSalesCost(OpenMode mode)
        {
            InitializeComponent();
            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
            }
        }
        private void PopUpSalesCost_Load(object sender, EventArgs e)
        {
            ComBind();
            txtModifier.Text = Uname;
            txtModifyDate.Text = DateTime.Now.ToString("d");
            if (!bRegOrUp)
            {
                ControlInfo();
            }
        }

        private void ControlInfo()
        {
            txtBeginCost.Text = Convert.ToString(SCvo.SC_IngCost);
            cboCompany.Text = SCvo.COM_Code;
            cboItem.Text = SCvo.ITEM_Code;
            cboUse.Text = SCvo.SC_Use;
            txtRemark.Text = SCvo.SC_Remark;
            cboItem.Enabled = false;
            cboCompany.Enabled = false;
        }

        private void ComBind()
        {
            CompanyService service = new CompanyService();
            List<CompanyVO> CompanyList = service.GetCompanyList();
            service.Dispose();

            CommonCodeService service1 = new CommonCodeService();
            List<CommonCodeVO> CommonList = service1.GetCommonCodeList();
            service1.Dispose();

            var company = (from item in CompanyList
                           where item.Com_Type == "고객사"
                           select item).ToList();
            company.Insert(0, new CompanyVO { Com_Code = "선택" });

            var use = (from a in CommonList
                       where a.Common_Parent == "UseYN000"  //Common_Parent의 코드명
                       select a).ToList();
            use.Insert(0, new CommonCodeVO { Common_Name = "선택" });

            ComboBoxBinding.BindingComboBox(cboCompany, company, "Com_Name", "Com_Code");
            ComboBoxBinding.BindingComboBox(cboUse, use, "Common_Name", "Common_Name");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 검사
            if (cboCompany.Text.Trim() == "선택" || cboItem.Text.Trim() == string.Empty || txtIngCost.Text == string.Empty ||
               cboUse.Text == "선택")
            {
                MessageBox.Show(Properties.Resources.ErrNotEntered);
                return;
            }
            if (dtpStart.Value.Day < DateTime.Now.Day)
            {
                MessageBox.Show("시작일은 오늘보다 전 날일 수 없습니다. 다시 설정하여 주십시오.");
                return;
            }
            try
            {
                SalesCostVO vo = new SalesCostVO();
                vo.COM_Code = cboCompany.Text;
                vo.ITEM_Code = cboItem.Text;
                vo.SC_IngCost = Convert.ToInt32(txtIngCost.Text);
                vo.SC_BeforeCost = Convert.ToInt32(txtBeginCost.Text);
                vo.SC_StartDate = Convert.ToDateTime(dtpStart.Value);
                vo.SC_EndDate = Convert.ToDateTime(dtpEnd.Value);
                vo.SC_Last_Modifier = txtModifier.Text;
                vo.SC_Last_Modifier_Time = Convert.ToDateTime(txtModifyDate.Text);
                vo.SC_Use = cboUse.Text;
                vo.SC_Remark = txtRemark.Text;
                if (!bRegOrUp)
                {
                    vo.SC_Code = SCvo.SC_Code;
                }

                SalesCostService service = new SalesCostService();
                if (bRegOrUp)//등록
                {
                    service.RegisterSC(vo);
                }
                else //수정
                {
                   service.UpdateSC(vo);
                }
                DialogResult = DialogResult.OK;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCompany.SelectedIndex == 0)
            {
                cboItem.Text = "선택";
                cboItem.Items.Clear();
                return;
            }

            if (list != null)
            {
                list.Clear();
                cboItem.Items.Clear();
            }

            string order = cboCompany.SelectedValue.ToString();

            SalesCostService service = new SalesCostService();
            list = service.GetItemCode(order);
            service.Dispose();
            for (int i = 0; i < list.Count; i++)
            {
                cboItem.Items.Add(list[i].ToString());
            }
        }
    }
}
