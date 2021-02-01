using FProjectVO;
using MESForm.CustomControls;
using MESForm.Properties;
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

namespace MESForm
{
    public partial class FrmBOM : MESForm.BaseForms.frmBaseLists
    {
       public string DeptName { get; set; }
        List<BOMVO> Allist;
        public FrmBOM()
        {
            InitializeComponent();
        }

       
        private void FrmBOM_Load(object sender, EventArgs e)
        {
            
           // cboItemType.Items.Insert(0, "전체");
            Combinding();
            dgvsetting();
            LoadData();
        }

        private void Combinding()
        {
            BOMService service = new BOMService();
            List<BOMVO> comList = service.CboInfo();
            service.Dispose();
            ComboBoxBinding.BOMComboBindingitem(cboUseYN, comList, "use");
            ComboBoxBinding.BOMComboBindingitem(cboItemType, comList, "itemtype");
        }

        private void dgvsetting()
        {
            CommonUtil.SetInitGridView(dgvBom);
            CommonUtil.AddGridTextColumn(dgvBom, "BOM코드", "bom_code",100,false);//1
            CommonUtil.AddGridTextColumn(dgvBom, "품목유형", "item_type");//2
            CommonUtil.AddGridTextColumn(dgvBom, "상위품목", "BOM_Parent_Name");//3
            CommonUtil.AddGridTextColumn(dgvBom, "품목", "item_code");//4
            CommonUtil.AddGridTextColumn(dgvBom, "품명", "item_name");//5
            CommonUtil.AddGridTextColumn(dgvBom, "소요량", "BOM_Spend");//6
            CommonUtil.AddGridTextColumn(dgvBom, "Level", "BOM_Level");//7
            CommonUtil.AddGridTextColumn(dgvBom, "시작일자", "BOM_StartDate");//8
            CommonUtil.AddGridTextColumn(dgvBom, "종료일자", "BOM_EndDate");//9
            CommonUtil.AddGridTextColumn(dgvBom, "사용유무", "ITME_Use");//10
            CommonUtil.AddGridTextColumn(dgvBom, "소요계획", "BOM_Plan");//11
            CommonUtil.AddGridTextColumn(dgvBom, "자동차감", "BOM_Auto");//12
            CommonUtil.AddGridTextColumn(dgvBom, "비고", "BOM_Note",270);//13
           
        }

        private void LoadData()
        {
            BOMService service = new BOMService();
            Allist = service.GetBOMInfo(string.Empty, "", "");
            service.Dispose();
            dgvBom.DataSource = Allist;
        }
        private void btnInquiry_Click(object sender, EventArgs e)// 조회버튼
        {
            string CoodOrName = txtItemCodeOrName.Text;
            string UseYN = cboUseYN.Text;
            string Type = cboItemType.Text;

            BOMService service = new BOMService();
            List<BOMVO> selectList = service.GetBOMInfo(CoodOrName, UseYN, Type);
            dgvBom.DataSource = selectList;
        }
        private void btnReg_Click(object sender, EventArgs e)//등록버튼
        {
           
            PopUpBOM pop = new PopUpBOM(frmMain.OpenMode.Register);
            pop.Uname = DeptName;
            if (pop.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)//새로고침 버튼
        {
            
            LoadData();
        }

        private void btncopy_Click(object sender, EventArgs e)//복사버튼
        {
            int rowIdx = dgvBom.CurrentRow.Index;
            
           
                BOMVO vo = new BOMVO();

            vo.bom_code = Convert.ToInt32(dgvBom[1, rowIdx].Value.ToString());
            vo.item_type = dgvBom[2, rowIdx].Value.ToString();

            if (dgvBom[3, rowIdx].Value.ToString() == "")
                vo.BOM_Parent_Name = "없음";
            else
                vo.BOM_Parent_Name = dgvBom[3, rowIdx].Value.ToString();
           
            vo.item_code = dgvBom[4, rowIdx].Value.ToString();
            vo.item_name = dgvBom[5, rowIdx].Value.ToString();
            vo.BOM_Spend = Convert.ToInt32(dgvBom[6, rowIdx].Value.ToString());
            vo.BOM_Level = Convert.ToInt32(dgvBom[7, rowIdx].Value.ToString());
            vo.BOM_StartDate = Convert.ToDateTime(dgvBom[8, rowIdx].Value.ToString());
            vo.BOM_EndDate = Convert.ToDateTime(dgvBom[9, rowIdx].Value.ToString());
            vo.ITME_Use = dgvBom[10, rowIdx].Value.ToString();
            vo.BOM_Plan = dgvBom[11, rowIdx].Value.ToString();
            vo.BOM_Auto = dgvBom[12, rowIdx].Value.ToString();
            vo.BOM_Note = dgvBom[13, rowIdx].Value.ToString();


            PopUpBOM pop = new PopUpBOM(frmMain.OpenMode.Copy);
            pop.bomvo = vo;
            pop.Uname = DeptName;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)//수정버튼
        {
            int rowIdx = dgvBom.CurrentRow.Index;


            BOMVO vo = new BOMVO();

            vo.bom_code = Convert.ToInt32(dgvBom[1, rowIdx].Value.ToString());
            vo.item_type = dgvBom[2, rowIdx].Value.ToString();

            if (dgvBom[3, rowIdx].Value.ToString() == "")
                vo.BOM_Parent_Name = "없음";
            else
                vo.BOM_Parent_Name = dgvBom[3, rowIdx].Value.ToString();

            vo.item_code = dgvBom[4, rowIdx].Value.ToString();
            vo.item_name = dgvBom[5, rowIdx].Value.ToString();
            vo.BOM_Spend = Convert.ToInt32(dgvBom[6, rowIdx].Value.ToString());
            vo.BOM_Level = Convert.ToInt32(dgvBom[7, rowIdx].Value.ToString());
            vo.BOM_StartDate = Convert.ToDateTime(dgvBom[8, rowIdx].Value.ToString());
            vo.BOM_EndDate = Convert.ToDateTime(dgvBom[9, rowIdx].Value.ToString());
            vo.ITME_Use = dgvBom[10, rowIdx].Value.ToString();
            vo.BOM_Plan = dgvBom[11, rowIdx].Value.ToString();
            vo.BOM_Auto = dgvBom[12, rowIdx].Value.ToString();
            vo.BOM_Note = dgvBom[13, rowIdx].Value.ToString();


            PopUpBOM pop = new PopUpBOM(frmMain.OpenMode.Update);
            pop.bomvo = vo;
            pop.Uname = DeptName;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Properties.Resources.SaveSuccess);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제버튼
        {

            if (MessageBox.Show(Properties.Resources.DeleteCheck, "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                int pk = Convert.ToInt32(dgvBom[1, dgvBom.CurrentRow.Index].Value.ToString());//기본키
                string parent = dgvBom[4, dgvBom.CurrentRow.Index].Value.ToString();//상위품목을 위한 값
                BOMService service = new BOMService();
                if (service.ParentCheck(parent))
                {
                    service.Dispose();
                    MessageBox.Show("하위 품목들이 없어야 삭제할 수 있습니다.");
                    return;
                }
                bool result = service.DeleteBOM(pk);

                if (result)
                {
                    MessageBox.Show(Properties.Resources.DeleteSuccess);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("삭제 도중 오류가 발생하였습니다.");
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)//엑셀버튼
        {
            string sResult = ExcelExportImport.ExportToDataGridView<BOMVO>((List<BOMVO>)dgvBom.DataSource, "Gubun,Code,BOM_Amender");
            if (sResult.Length > 0)
            {
                MessageBox.Show(sResult);
            }
        }
    }
}
