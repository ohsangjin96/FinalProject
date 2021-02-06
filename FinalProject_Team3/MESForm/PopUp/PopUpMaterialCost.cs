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
    public partial class popUpMaterialCost : MESForm.BaseForms.frmPopup
    {
        bool bRegOrUp;
        List<string> list;
        public string Uname { get; set; }
        public MaterialCostVO MCvo { get; set; }
        public popUpMaterialCost()
        {
            InitializeComponent();
        }
        public popUpMaterialCost(OpenMode mode)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popUpMaterialCost_Load(object sender, EventArgs e)
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
            txtBeginCost.Text = Convert.ToString(MCvo.MC_IngCost);
            cboCompany.Text = MCvo.COM_Code;
            cboItem.Text = MCvo.ITEM_Code;
            cboUse.Text = MCvo.MC_USE;
            txtRemark.Text = MCvo.MC_Remark;
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
                           where item.Com_Type == "협력업체"
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
                MaterialCostVO vo = new MaterialCostVO();
                vo.COM_Code = cboCompany.Text;
                vo.ITEM_Code = cboItem.Text;
                vo.MC_IngCost = Convert.ToInt32(txtIngCost.Text);
                vo.MC_BeforeCost = Convert.ToInt32(txtBeginCost.Text);
                vo.MC_StartDate = Convert.ToDateTime(dtpStart.Value);
                vo.MC_EndDate = Convert.ToDateTime(dtpEnd.Value);
                vo.MC_Last_Modifier = txtModifier.Text;
                vo.MC_Last_Modifier_Time = Convert.ToDateTime(txtModifyDate.Text);
                vo.MC_USE = cboUse.Text;
                vo.MC_Remark = txtRemark.Text;
                if (!bRegOrUp)
                {
                    vo.MC_Code = MCvo.MC_Code;
                }
               

                MaterialCostService service = new MaterialCostService();
                if (bRegOrUp)//등록
                {
                    service.RegisterMC(vo);
                }
                else //수정
                {
                    service.UpdateMC(vo);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                
            }
            //VO 전달
            

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

            MaterialCostService service = new MaterialCostService();
            list = service.GetItemCode(order);
            service.Dispose();
            for (int i = 0; i < list.Count; i++)
            {
                cboItem.Items.Add(list[i].ToString());
            }


        }

        private void txtIngCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
