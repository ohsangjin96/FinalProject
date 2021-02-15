using MESForm.PopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using FProjectVO;
using MESForm.Services;

namespace POPForm
{
    public partial class PopUpLogin : Form
    {
        public LoginVO Info { get; set; }
        public PopUpLogin()
        {
            InitializeComponent();
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUpPopUp frm = new frmSignUpPopUp();
            frm.ShowDialog();
        }

        //x , 취소버튼 클릭 시 이벤트
        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하여 주십시오.");
                return;
            }
            //vo 객채 생성
            //LoginVO vo = new LoginVO();
            //vo.User_ID = txtID.Text;
            //vo.User_Pwd = txtPwd.Text;



            else //로그인 정보 일치
            {
                LoginService service = new LoginService();
                List<LoginVO> Login = service.LoginInfo(txtID.Text, txtPwd.Text);
                if (Login != null)
                {
                    foreach (var item in Login)
                    {
                        Info = new LoginVO();
                        Info.User_ID = item.User_ID;
                        Info.User_Pwd = item.User_Pwd;
                        Info.User_Name = item.User_Name;
                        Info.User_Email = item.User_Email;
                        Info.User_Dept = item.User_Dept;
                    }
                    MessageBox.Show($"{Info.User_Name}님 환영합니다.");

                    frmPOP frm = new frmPOP(Info);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    //로그인 정보 불일치
                    MessageBox.Show("일치하는 회원 정보가 없습니다.");
                }
            }

        }
    }
}

