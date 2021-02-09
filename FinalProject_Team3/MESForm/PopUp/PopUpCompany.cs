using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static MESForm.frmMain;

namespace MESForm.PopUp
{
    public partial class PopUpCompany : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }
        public CompanyVO companyVO { get; set; }

        public PopUpCompany()
        {
            InitializeComponent();
        }

        public PopUpCompany(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
                txtCompanyCode.Enabled = false;
                txtCompanyName.Enabled = false;
            }
        }

        /// <summary>
        ///  기존의 데이터를 팝업창에 불러오는 메서드
        /// </summary>
        private void GetCompanyInfo()
        {
            txtCompanyCode.Text = companyVO.Com_Code;
            txtCompanyName.Text = companyVO.Com_Name;
            cboCompanyType.Text = companyVO.Com_Type;
            txtCEOName.Text = companyVO.Com_CEO;
            txtCompanyRegNum.Text = companyVO.Com_CNum;
            txtCompanyCategory.Text = companyVO.Com_Category;
            txtCompanyConditions.Text = companyVO.Com_Conditions;
            txtChargeName.Text = companyVO.Com_Charge;
            txtEmail.Text = companyVO.Com_Email;
            dtpStartDate.Value = Convert.ToDateTime(companyVO.Com_StartDate);
            dtpEndDate.Value = Convert.ToDateTime(companyVO.Com_EndDate);
            txtTelNumber.Text = companyVO.Com_Phone;
            txtFaxNumber.Text = companyVO.Com_Fax;
            cboWarehouse.Text = companyVO.Com_Warehouse;
            cboCompanyUse.Text = companyVO.Com_Use;
            txtAmender.Text = companyVO.Com_Amender;
            txtModdifyDate.Text = companyVO.Com_ModdifyDate;
            txtCompanyInfo.Text = companyVO.Com_Info;
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
        private void ComboBoxBind()
        {
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();

            ComboBoxBinding.ComBind(cboCompanyType, commonList, "ComType000", false);
            ComboBoxBinding.ComBind(cboCompanyUse, commonList, "UseYN000", false);
            ComboBoxBinding.ComBind(cboWarehouse, commonList, "UseYN000", false);

            cboCompanyUse.SelectedIndex = 1;
            cboWarehouse.SelectedIndex = 1;
        }

        private void PopUpCompany_Load(object sender, EventArgs e)
        {
            ComboBoxBind();

            if (bRegOrUp)
            {
                txtAmender.Text = DeptName;
                txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                GetCompanyInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 유효성체크
            //전화번호 및 이메일 정규식
            string telnumPattern = @"^\d{2,3}-\d{3,4}-\d{4}$";
            string emailPattern = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";

            if (txtCompanyCode.Text == "") //업체코드 미입력
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "업체코드를"));
                txtCompanyCode.Focus();
                return;
            }
            else if (txtCompanyName.Text == "") //업체명 미입력
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "업체명을"));
                txtCompanyName.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtEmail.Text, emailPattern)) //이메일 형식 확인
            {
                // 입력 칸이 비어있으면 건너뛴다.
                if (txtEmail.Text != "")
                {
                    MessageBox.Show(Properties.Resources.ErrPattern.Replace("@@", "이메일"));
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }
            }
            else if (!Regex.IsMatch(txtTelNumber.Text, telnumPattern)) //전화번호 형식 확인
            {
                // 입력 칸이 비어있으면 건너뛴다.
                if (txtTelNumber.Text != "")
                {
                    MessageBox.Show(Properties.Resources.ErrPattern.Replace("@@", "전화번호"));
                    txtTelNumber.Focus();
                    txtTelNumber.SelectAll();
                    return;
                }
            }
            else if (!Regex.IsMatch(txtFaxNumber.Text, telnumPattern)) //팩스번호 형식 확인
            {
                // 입력 칸이 비어있으면 건너뛴다.
                if (txtFaxNumber.Text != "")
                {
                    MessageBox.Show(Properties.Resources.ErrPattern.Replace("@@", "팩스번호"));
                    txtTelNumber.Focus();
                    txtTelNumber.SelectAll();
                    return;
                }
            }
            #endregion

            try
            {
                CompanyVO vo = new CompanyVO
                {
                    Com_Code = txtCompanyCode.Text,
                    Com_Name = txtCompanyName.Text,
                    Com_Type = cboCompanyType.Text,
                    Com_CEO = txtCEOName.Text,
                    Com_CNum = txtCompanyRegNum.Text,
                    Com_Category = txtCompanyCategory.Text,
                    Com_Conditions = txtCompanyConditions.Text,
                    Com_Charge = txtChargeName.Text,
                    Com_Email = txtEmail.Text,
                    Com_StartDate = dtpStartDate.Value.ToShortDateString(),
                    Com_EndDate = dtpEndDate.Value.ToShortDateString(),
                    Com_Phone = txtTelNumber.Text,
                    Com_Fax = txtFaxNumber.Text,
                    Com_Warehouse = cboWarehouse.Text,
                    Com_Use = cboCompanyUse.Text,
                    Com_Amender = txtAmender.Text,
                    Com_ModdifyDate = txtModdifyDate.Text,
                    Com_Info = txtCompanyInfo.Text
                };

                CompanyService service = new CompanyService();
                if (bRegOrUp)
                {
                    //등록
                    service.InsertCompany(vo);
                }
                else
                {
                    //수정
                    service.UpdateCompany(vo);
                }
                service.Dispose();

                DialogResult = DialogResult.OK;
            }
            catch(Exception err)
            {
                if (err.Message == "이미 등록된 업체코드입니다.")
                {
                    txtCompanyCode.Focus();
                    txtCompanyCode.SelectAll();
                }
                else if (err.Message == "이미 등록된 업체명입니다.")
                {
                    txtCompanyName.Focus();
                    txtCompanyName.SelectAll();
                }
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void CompanyPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
