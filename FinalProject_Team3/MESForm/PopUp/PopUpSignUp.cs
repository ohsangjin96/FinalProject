using FProjectVO;
using MESForm.Services;
using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class PopUpSignUp : MESForm.BaseForms.frmPopup
    {
        List<CommonCodeVO> list;
        SignUpService service = new SignUpService();
        public PopUpSignUp()
        {
            InitializeComponent();
        }
        private void PopUpSignUp_Load(object sender, EventArgs e)
        {
          
            CboBinding();
        }
        private void CboBinding()//콤보박스바인딩
        {
            CommonCodeService service = new CommonCodeService();
            list = service.GetCommonCodeList();
            ComboBoxBinding.DeptBind(cboDept, list, "Common_Name");
            cboDept.SelectedIndex = -1;
        }
        private void btnIdCheck_Click(object sender, EventArgs e)//중복확인
        {
            bool bFlag = service.IDCheck(txtID.Text);
            if (bFlag == true)
            {
                //ErrAlreadyReg
                MessageBox.Show(Properties.Resources.ErrAlreadyReg.Replace("@@", "아이디"));
                txtID.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(Properties.Resources.RegTrue.Replace("@@","아이디"));
                btnIdCheck.Visible = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)//가입버튼
        {
            //유효성 체크
            //패널의 입력,선택칸을 입력,선택하지 않았을 경우
            string errMsgText = ValidateText(pnl);
            if (!string.IsNullOrEmpty(errMsgText))
            {
                MessageBox.Show(errMsgText);
                return;
            }
            //비밀번호 일치 여부
            if (txtPwd.Text.Trim()!=txtPwdCheck.Text.Trim())
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
            //중복확인을 안 하였을 경우
            if (btnIdCheck.Visible == true)
            {
                MessageBox.Show("중복확인을 하십시오.");
                return;
            }
            //vo 객채 생성
            SignUpVO vo = new SignUpVO();
            vo.User_ID = txtID.Text;
            vo.User_Pwd = txtPwd.Text;
            vo.User_Name = txtName.Text;
            vo.User_Email = txtEmail.Text;
            vo.User_Dept = cboDept.Text;

            //서비스에 vo 전달해서 db에 저장
            
            bool bFlag = service.RegisterSignUp(vo);

            if (bFlag==true)
            {
                MessageBox.Show(Properties.Resources.SaveSignUp);
                this.Close();
            }
            else
                MessageBox.Show("실패");

        }
        private void btnCancel_Click(object sender, EventArgs e)//취소버튼
        {
            this.Close();
        }
        private string ValidateText(Panel pnl) //유효성 체크 메시지 출력
        {
            string errMsg = "";
            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    if (textBox.Text.Trim() == string.Empty)
                    {
                        errMsg += $"- {textBox.Tag}을(를) 입력해 주십시오.\n";
                    }
                }
            }
            foreach (Control ctrl1 in pnl.Controls)
            {
                if (ctrl1 is ComboBox comboBox)
                {
                    if (comboBox.Text.Trim() == string.Empty)
                    {
                        errMsg += $"- {comboBox.Tag}를 선택하여 주십시오.\n";
                    }
                }
            }
            return errMsg;
        }

        
    }
}
