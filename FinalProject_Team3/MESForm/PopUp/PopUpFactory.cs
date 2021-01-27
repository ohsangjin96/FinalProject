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
        public FactoryVO factoryVO { get; set; }

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
                txtFactoryCode.Enabled = false;
            }
        }

        /// <summary>
        /// 수정하기 위해 기존의 데이터를 불러오는 메서드
        /// </summary>
        private void GetFactoryInfo()
        {
            cboFactoryGrade.Text = factoryVO.Factory_Grade;
            cboFactoryHighRank.Text = factoryVO.Factory_HighRank;
            cboFactoryType.Text = factoryVO.Factory_Type;
            txtFactoryName.Text = factoryVO.Factory_Name;
            txtFactoryCode.Text = factoryVO.Factory_Code;
            cboFactoryCredit.Text = factoryVO.Factory_Credit;

            if(factoryVO.Factory_Order != 0)
                txtFactoryOrder.Text = factoryVO.Factory_Order.ToString();

            cboComCode.Text = factoryVO.Com_Name;
            cboFactoryDemand.Text = factoryVO.Factory_Demand;
            cboFactoryProcess.Text = factoryVO.Factory_Process;
            cboFactoryMaterial.Text = factoryVO.Factory_Material;
            cboFactoryUse.Text = factoryVO.Factory_Use;
            txtAmender.Text = factoryVO.Factory_Amender;
            txtModdifyDate.Text = factoryVO.Factory_ModdifyDate.ToString();
            txtExplain.Text = factoryVO.Factory_Explain;
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
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
            ComboBoxBinding.FactoryGradeBind(cboFactoryHighRank, factoryList, true, "없음");
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

            if (bRegOrUp)
            {
                txtAmender.Text = DeptName;
                txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                GetFactoryInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (txtFactoryName.Text == "") // 시설명 미입력
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "시설명을"));
                return;
            }

            else if (txtFactoryCode.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "시설코드를"));
                return;
            }

            try
            {
                int factoryOrder; // 순서

                if (txtFactoryOrder.Text == "") //순서를 입력하지 않았을 때는 DB에 null 저장
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
                    //등록
                    service.InsertFactory(vo);
                }
                else
                {
                    //수정
                    service.UpdateFactory(vo);
                }
                service.Dispose();

                DialogResult = DialogResult.OK;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                if (err.Message == "이미 등록된 시설명입니다.")
                {
                    txtFactoryName.Focus();
                    txtFactoryName.SelectAll();
                }
                else if(err.Message == "이미 등록된 시설코드입니다.")
                {
                    txtFactoryCode.Focus();
                    txtFactoryCode.SelectAll();
                }
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

        private void txtFactoryOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
