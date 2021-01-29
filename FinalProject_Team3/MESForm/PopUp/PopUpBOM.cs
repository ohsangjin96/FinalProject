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
        public string  Uname { get; set; }
        List<BOMVO> BomList;
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


            BOMService bService = new BOMService();
             BomList = bService.GetParent();

            ItemService Itemservice = new ItemService();
            List<ItemVO> ItemList = Itemservice.GetItemAllList();

            var BomLinq = (from item in BomList
                           where item.item_type=="제품" || item.item_type=="반제품"
                           select item.item_name).ToList();
            BomLinq.Insert(0, "없음");

            var ItemLinq = (from item in ItemList
                         select item.ITEM_Code).ToList();
            ItemLinq.Insert(0, "선택");


            ComboBoxBinding.BindingComboBoxPart(cboParent, BomLinq, "item_name");
            ComboBoxBinding.BindingComboBoxPart(cboItemCode, ItemLinq, "ITEM_Code");
            
        }

        private void cboItemCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboItemCode.SelectedIndex < 1)
                return;
            var Find = (from item in BomList
                        where item.item_code == cboItemCode.Text
                        select item.item_name).ToList();
            txtItemName.Text = Find.ToString();
        }
    }
}
