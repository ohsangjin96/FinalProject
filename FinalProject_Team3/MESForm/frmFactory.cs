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
    public partial class frmFactory : MESForm.BaseForms.frmBaseList
    {
        public frmFactory()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvFactory);
            CommonUtil.AddGridTextColumn(dgvFactory, "시설군", "Factory_Grade"); // 1
            CommonUtil.AddGridTextColumn(dgvFactory, "시설타입", "Factory_Type"); // 2
            CommonUtil.AddGridTextColumn(dgvFactory, "시설코드", "Factory_Code"); // 3
            CommonUtil.AddGridTextColumn(dgvFactory, "시설명", "Factory_Name"); // 4
            CommonUtil.AddGridTextColumn(dgvFactory, "상위시설", "Factory_HighRa"); // 5
            CommonUtil.AddGridTextColumn(dgvFactory, "시설설명", "Factory_Explain"); // 6
            CommonUtil.AddGridTextColumn(dgvFactory, "유무상구분", "Factory_Credit"); // 7
            CommonUtil.AddGridTextColumn(dgvFactory, "순서", "Factory_Order"); // 8
            CommonUtil.AddGridTextColumn(dgvFactory, "수요차감", "Factory_Demand"); // 9
            CommonUtil.AddGridTextColumn(dgvFactory, "공정차감", "Factory_Process"); // 10
            CommonUtil.AddGridTextColumn(dgvFactory, "자재차감", "Factory_Material"); // 11
            CommonUtil.AddGridTextColumn(dgvFactory, "업체명", "Com_Name"); // 12
            CommonUtil.AddGridTextColumn(dgvFactory, "사용유무", "Factory_Use"); // 13
            CommonUtil.AddGridTextColumn(dgvFactory, "수정자", "Factory_Amender"); // 14
            CommonUtil.AddGridTextColumn(dgvFactory, "수정시간", "Factory_ModdifyDate"); // 15

        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            DgvSetting();
        }
    }
}
