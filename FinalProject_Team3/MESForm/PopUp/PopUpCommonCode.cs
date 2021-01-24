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

namespace MESForm.PopUp
{
    public partial class PopUpCommonCode : MESForm.BaseForms.frmPopup
    {
        List<CommonCodeVO> list;

        Point mousePoint;

        bool updateMode = false; // 데이터를 수정하는 것인지 체크
        bool bRegCheck = true; // 등록하는 화면 visible

        public PopUpCommonCode()
        {
            InitializeComponent();
        }

        private void DgvSetting()
        {
            CommonUtil.SetInitGridView(dgvCommonCode);
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드", "Common_Code");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "코드명", "Common_Name", 120);
            CommonUtil.AddGridTextColumn(dgvCommonCode, "상위코드", "Common_Parent");
            CommonUtil.AddGridTextColumn(dgvCommonCode, "순서", "Common_Seq",60);
        }

        private void LoadData()
        {
            CommonCodeService service = new CommonCodeService();
            list = service.GetCommonCodeList();
            dgvCommonCode.DataSource = list;

            ComboBoxBinding.CommonCodeBind(cboParentCode, list, "Common_Code", true, "미선택");
        }

        private void CommonCodePopUp_Load(object sender, EventArgs e)
        {
            gboInsert.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            pnl.Location = gboInsert.Location;
            pnl.Size = new Size(446, 555);
            DgvSetting();
            LoadData();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            btnCodeVal.Visible = true;
            updateMode = false;

            gboInsert.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            pnl.Location = new Point(12, 308);
            pnl.Size = new Size(446, 329);
            bRegCheck = false;
        }

        private void CommonCodePopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void CommonCodePopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!updateMode && btnCodeVal.Enabled)
            {
                MessageBox.Show(Properties.Resources.ErrValCheck);
                return;
            }

            try
            {
                CommonCodeVO vo = new CommonCodeVO
                {
                    Common_Code = txtCode.Text,
                    Common_Name = txtCodeName.Text,
                    Common_Parent = cboParentCode.Text,
                    Common_Seq = (int)nudSeq.Value
                };

                CommonCodeService service = new CommonCodeService();
                bool result;

                if (updateMode)
                {
                    if (txtCode.Text == "")
                    {
                        MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "코드를"));
                        return;
                    }
                    string orgPname = Convert.ToString(dgvCommonCode[2, dgvCommonCode.CurrentRow.Index].Value);
                    result = service.UpdateCommonCode(vo);
                }
                else
                    result = service.InsertCommonCode(vo);

                service.Dispose();

                if (result)
                {
                    MessageBox.Show(Properties.Resources.SaveSuccess);
                    LoadData();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtCode.Enabled = updateMode;
            btnCodeVal.Visible = updateMode;

            if(!updateMode)
                updateMode = true;
            else
                updateMode = false;

            if (bRegCheck)
            {
                gboInsert.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                pnl.Location = new Point(12, 308);
                pnl.Size = new Size(446, 329);

                if(bRegCheck)
                    bRegCheck = false;
                else
                    bRegCheck = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtCode.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "코드를"));
                return;
            }

            try
            {
                CommonCodeService service = new CommonCodeService();
                bool result = service.DeleteCommonCode(txtCode.Text);
                service.Dispose();

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                    MessageBox.Show(Properties.Resources.ErrDeleteSuccess);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gboInsert.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            pnl.Location = gboInsert.Location;
            pnl.Size = new Size(446, 555);
            bRegCheck = true;
            updateMode = false;
        }

        private void btnCodeVal_Click(object sender, EventArgs e)
        {
            CommonCodeService service = new CommonCodeService();

            if (txtCode.Text == "")
            {
                service.Dispose();
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "코드를"));
                return;
            }

            bool result = service.IsCodeValied(txtCode.Text);
            service.Dispose();

            if (result)
            {
                MessageBox.Show(Properties.Resources.RegTrue.Replace("@@", "코드"));
                btnCodeVal.Enabled = false;
                txtCodeName.Focus();
            }
            else
            {
                MessageBox.Show(Properties.Resources.ErrAlreadyReg.Replace("@@", "코드"));
                txtCode.Focus();
                txtCode.SelectAll();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!btnCodeVal.Enabled)
                btnCodeVal.Enabled = true;
        }

        private void cboParentCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboParentCode.Items.Count > 0)
            {
                CommonCodeService service = new CommonCodeService();
                int idx = service.GetSeqValue(cboParentCode.Text);
                service.Dispose();
                nudSeq.Value = idx + 1;
            }
        }

        private void dgvCommonCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvCommonCode[0, e.RowIndex].Value.ToString();
            txtCodeName.Text = dgvCommonCode[1, e.RowIndex].Value.ToString();

            if (Convert.ToString(dgvCommonCode[2, e.RowIndex].Value) == "")
                cboParentCode.SelectedIndex = 0;
            else
                cboParentCode.Text = Convert.ToString(dgvCommonCode[2, e.RowIndex].Value);
        }
    }
}
