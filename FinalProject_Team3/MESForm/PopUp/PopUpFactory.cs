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

namespace MESForm.PopUp
{
    public partial class PopUpFactory : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }

        public PopUpFactory()
        {
            InitializeComponent();
        }

        public PopUpFactory(OpenMode mode)
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

        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            CompanyService companyService = new CompanyService();
            List<CompanyVO> companyList = companyService.GetCompanyList();
            commonService.Dispose();

            FactoryService service = new FactoryService();
            List<FactoryVO> factoryList = service.GetFactoryList();
            service.Dispose();

            factoryList = (from item in factoryList
                           where item.Factory_Grade != "창고"
                           select item).ToList();

            ComboBoxBinding.ComBind(cboFactoryGrade, commonList, "FacGrade000", false);
            ComboBoxBinding.ComBind(cboFactoryType, commonList, "FAC000", false);
            ComboBoxBinding.FactoryGradeBind(cboFactoryHighRank, factoryList, false);
            ComboBoxBinding.ComBind(cboFactoryCredit, commonList, "FreeOffer000");
            ComboBoxBinding.CompanyBind(cboComCode, companyList);
            ComboBox[] cbArray = { cboFactoryDemand, cboFactoryProcess, cboFactoryMaterial };
            for(int i=0; i< cbArray.Length; i++)
                ComboBoxBinding.ComBind(cbArray[i], commonList, "UseYN000");
            ComboBoxBinding.ComBind(cboFactoryUse, commonList, "UseYN000", false);
        }

        private void PopUpFactory_Load(object sender, EventArgs e)
        {
            ComboBoxBind();
            txtAmender.Text = DeptName;
            txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int factoryOrder;

            //유효성 체크
            if (txtFactoryName.Text == "")
            {
                MessageBox.Show("이름");
            }

            if (txtFactoryOrder.Text == "")
                factoryOrder = -1;
            else
                factoryOrder = Convert.ToInt32(txtFactoryOrder.Text);

            FactoryVO vo = new FactoryVO
            {
                Factory_Grade = cboFactoryGrade.Text,
                Factory_HighRank = cboFactoryHighRank.Text,
                Factory_Type = cboFactoryType.Text,
                Factory_Name = txtFactoryName.Text,
                Factory_Code = txtFactoryCode.Text,
                Factory_Credit = cboFactoryCredit.Text,
                Factory_Order = factoryOrder,
                Com_Code = cboComCode.SelectedValue.ToString(),
                Com_Name = cboComCode.Text,
                Factory_Demand = cboFactoryDemand.Text,
                Factory_Process = cboFactoryProcess.Text,
                Factory_Material = cboFactoryMaterial.Text,
                Factory_Use = cboFactoryUse.Text,
                Factory_Amender = txtAmender.Text,
                Factory_ModdifyDate = Convert.ToDateTime(txtModdifyDate.Text),
                Factory_Explain = txtExplain.Text
            };

            FactoryService service = new FactoryService();
            if (bRegOrUp)
            {
                service.InsertFactory(vo);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FactoryPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FactoryPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
