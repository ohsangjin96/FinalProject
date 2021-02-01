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
    public partial class PopUpBOM : MESForm.BaseForms.frmPopup
    {
        int bRegOrUp; //등록/복사 : true, 수정 : false
        int pk;
        public string Uname { get; set; }
        public BOMVO bomvo { get; set; }

        List<BOMVO> BomList;
        BOMVO vo = new BOMVO();

        public PopUpBOM()
        {
            InitializeComponent();
        }
        public PopUpBOM(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = 1;
            }
            else if (mode == OpenMode.Copy)
            {
                bRegOrUp = 2;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = 3;
            }
        }

        private void PopUpBOM_Load(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = false;
            txtModifier.Text = Uname;
            txtModifiDay.Text = DateTime.Now.ToString("d");

            ComBinding();
            if (bRegOrUp == 2)
            {

                BOMCopy();
            }
            if (bRegOrUp == 3)
            {
                pk = bomvo.bom_code;
                BOMUpdate();
            }
        }
        private void BOMCopy()
        {
            // 도구들한테 vo받은 것들 바인딩
            controlInfo();

        }
        private void BOMUpdate()
        {
            cboParent.Enabled = false;
            cboItemCode.Enabled = false;
            // 도구들한테 vo받은 것들 바인딩
            controlInfo();
        }

        private void controlInfo()
        {
            if (bomvo.BOM_Parent_Name == null)
            {
                cboParent.Text = bomvo.BOM_Parent_Name;
            }
            cboParent.Text = bomvo.BOM_Parent_Name;
            cboItemCode.Text = bomvo.item_code;
            txtItemName.Text = bomvo.item_name.Trim().Replace("L", string.Empty);
            numSpend.Value = bomvo.BOM_Spend;
            dtpStartDate.Value = bomvo.BOM_StartDate;
            dtpEndDate.Value = bomvo.BOM_EndDate;
            txtModifier.Text = bomvo.BOM_Amender;
            cboAuto.Text = bomvo.BOM_Auto;
            cboPlan.Text = bomvo.BOM_Plan;
            numLevel.Value = bomvo.BOM_Level;
            txtNote.Text = bomvo.BOM_Note;
            txtModifier.Text = Uname;
        }

        private void ComBinding()//콤보박스 바인딩
        {
            BOMService bService = new BOMService();
            BomList = bService.GetParent();

            ItemService Itemservice = new ItemService();
            List<ItemVO> ItemList = Itemservice.GetItemAllList();

            CommonCodeService service = new CommonCodeService();
            List<CommonCodeVO> comList = service.GetCommonCodeList();

            var BomLinq = (from item in BomList
                           where item.item_type == "제품" || item.item_type == "반제품"
                           select item.item_code).ToList();
            BomLinq.Insert(0, "없음");

            ComboBoxBinding.BindingComboBoxPart(cboParent, BomLinq, "item_code");
            ComboBoxBinding.BindingComboBox(cboItemCode, ItemList, "item_name", "item_code");
            ComboBoxBinding.ComBind(cboAuto, comList, "YN000", true);
            ComboBoxBinding.ComBind(cboPlan, comList, "YN000", true);
        }

        private void cboItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemCode.SelectedIndex < 0)
            {
                return;
            }

            txtItemName.Text = cboItemCode.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bRegOrUp == 1 || bRegOrUp == 2)
            {
                if (dtpStartDate.Value.Day < DateTime.Now.Day)
                {
                    MessageBox.Show("시작일자는 오늘보다 전 날일 수 없습니다. 다시 설정하여 주십시오.");
                    return;
                }
            }

            if (cboAuto.Text == "" || cboPlan.Text == "")
            {
                MessageBox.Show("필수 입력사항을 기입하여 주십시오.");
                return;
            }
            try
            {
                CreateVO();
                BOMService service = new BOMService();
                if (bRegOrUp == 1 || bRegOrUp == 2)//등록
                {
                    service.RegisterBOM(vo);
                }
                else //수정
                {
                    service.UpdateBOM(vo);
                }
                DialogResult = DialogResult.OK;
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
        private void CreateVO()
        {
            vo.bom_code = pk;
            vo.BOM_Parent_Name = cboParent.Text;
            vo.item_code = cboItemCode.Text;
            vo.item_name = txtItemName.Text;
            vo.BOM_Spend = Convert.ToInt32(numSpend.Value);
            vo.BOM_StartDate = Convert.ToDateTime(dtpStartDate.Value);
            vo.BOM_EndDate = Convert.ToDateTime(dtpEndDate.Value);

            vo.BOM_Amender = txtModifier.Text;
            vo.BOM_ModdifyDate = Convert.ToDateTime(txtModifiDay.Text);
            vo.BOM_Auto = cboAuto.Text;
            vo.BOM_Plan = cboPlan.Text;
            vo.BOM_Note = txtNote.Text;
            vo.BOM_Level = Convert.ToInt32(numLevel.Value);
        }
        private void cboParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Type1 = "제품";
            string Type2 = "반제품";
            BOMService service = new BOMService();
            if (cboParent.SelectedIndex == 0)
            {
                numLevel.Value = 1;
            }
            else if (Type1 == service.LevelCheck(cboParent.Text))
            {
                numLevel.Value = 2;
            }
            else if (Type2 == service.LevelCheck(cboParent.Text))
            {
                numLevel.Value = 3;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
