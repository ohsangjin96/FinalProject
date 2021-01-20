using MESForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.PopUp
{
    public partial class CommonPopUp : Form
    {
        bool bRegCheck = true;
        public CommonPopUp()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCommonCode);
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드", "Common_Code");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드명", "Common_Name");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "상위코드", "Common_Parent");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "순서", "Common_Seq");
        }

        private void CommonPopUp_Load(object sender, EventArgs e)
        {
            gboInsert.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            pnlCommonCode.Location = gboInsert.Location;
            pnlCommonCode.Size = new Size(446, 515);
            DgvSetting();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (bRegCheck)
            {
                gboInsert.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                this.Size = new Size(470, 603);
                pnlCommonCode.Location = new Point(12, 285);
                pnlCommonCode.Size = new Size(446, 306);
                bRegCheck = false;
            }
            else
            {
                //446, 306
                gboInsert.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                pnlCommonCode.Location = gboInsert.Location;
                pnlCommonCode.Size = new Size(446, 515);
                bRegCheck = true;
            }
                
        }
    }
}
