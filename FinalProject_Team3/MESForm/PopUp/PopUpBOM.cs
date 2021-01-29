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
        bool bRegOrUp; //등록/복사 : true, 수정 : false
        string Parent = "없음";
        public string  Uname { get; set; }
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
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
            }
        }

        private void PopUpBOM_Load(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = false;
            txtModifier.Text = Uname;
            txtModifiDay.Text = DateTime.Now.ToString("d");
            ComBinding();

            
           
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

            //var ItemLinq = (from item in ItemList
            //                select item.ITEM_Code).ToList();
            //ItemLinq.Insert(0, "선택");

           
       
            ComboBoxBinding.BindingComboBoxPart(cboParent, BomLinq, "item_code");
            ComboBoxBinding.BindingComboBox(cboItemCode, ItemList, "item_name", "item_code");
            ComboBoxBinding.ComBind(cboUseYN, comList, "UseYN000", true);//사용유무
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
            StringBuilder sb = new StringBuilder();
            //유효성 체크
            if (bRegOrUp == true)
            {
                //string Parent1 = "";
                NewMethod(sb);
                CreateVO();
                BOMService service = new BOMService();
                bool bFlag = service.RegisterBOM(vo,vo.BOM_Parent_Name);
                if (bFlag == true)
                {
                    MessageBox.Show(Properties.Resources.SaveSuccess + "새로고침 하십시오.");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다.");
                }
            }
            if (bRegOrUp == false)
            {
                NewMethod(sb);

            }
            //vo 객채 생성

          
            //서비스에 vo 전달해서 db에 저장
            

        }

        private void CreateVO()
        {
            vo.BOM_Parent_Name = cboParent.Text;
            vo.item_code = cboItemCode.Text;
            vo.item_name = txtItemName.Text;
            vo.BOM_Spend = Convert.ToInt32(numSpend.Value);
            vo.BOM_StartDate = Convert.ToDateTime(dtpStartDate.Value);
            vo.BOM_EndDate = Convert.ToDateTime(dtpEndDate.Value);
            vo.ITME_Use = cboUseYN.Text;
            vo.BOM_Amender = txtModifier.Text;
            vo.BOM_ModdifyDate = Convert.ToDateTime(txtModifiDay.Text);
            vo.BOM_Auto = cboAuto.Text;
            vo.BOM_Plan = cboPlan.Text;
            vo.BOM_Note = txtNote.Text;
            vo.BOM_Level = Convert.ToInt32(numLevel.Value);
        }

        private void NewMethod(StringBuilder sb)
        {
            if (dtpStartDate.Value.Day < DateTime.Now.Day)
            {
                sb.AppendLine("시작일자는 오늘보다 전 날일 수 없습니다. 다시 설정하여 주십시오.");

            }
            if (cboUseYN.Text == "" || cboAuto.Text == "" || cboPlan.Text == "")
            {
                sb.AppendLine("필수 입력사항을 기입하여 주십시오.");
            }

            MessageBox.Show(sb.ToString());
        }

        private void cboParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Type1 = "제품";
            string Type2 = "반제품";
            BOMService service = new BOMService();
            if (cboParent.SelectedIndex==0)
            {
                numLevel.Value = 1;
            }
            else if (Type1 == service.LevelCheck(cboParent.Text))
            {
                numLevel.Value = 2;
            }
            else if (Type2 ==service.LevelCheck(cboParent.Text))
            {
                numLevel.Value = 3;
            }
        }
    }
}
