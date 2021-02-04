using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESForm
{
    public partial class FrmShift : MESForm.BaseForms.frmBaseLists
    {
        public string DeptName { get; set; }
        public FrmShift()
        {
            InitializeComponent();
        }
        private void FrmShift_Load(object sender, EventArgs e)
        {
            //설비코드 설비명 시프트 시작시간 완료시간 적용시작일자 적용완료일자 투입인원 사용유무 수정자 수정시간 ㅅ비고
        }
        private void btnReg_Click(object sender, EventArgs e)//등록
        {

        }
        private void btnInquiry_Click(object sender, EventArgs e)//조회
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)//수정
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)//엑셀
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침
        {

        }

       
    }
}
