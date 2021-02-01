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
        public string Uname { get; set; }
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
        }

        private void ComBind()
        {
            string gu1 = "company";
            //
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
            txtModifier.Text = cboCompany.SelectedValue.ToString();
        }

        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCompany.SelectedIndex == 0)
                return;
            string order = cboCompany.SelectedValue.ToString();

            MaterialCostService service = new MaterialCostService();
            List<MaterialCostVO> list = service.GetItemCode(order);
            service.Dispose();
            for (int i = 0; i < list.Count; i++)
            {
                cboItem.Items.Add(list[i].ITEM_Code.ToString());
            }
        }
    }
}
