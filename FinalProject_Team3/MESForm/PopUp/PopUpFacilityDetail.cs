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

namespace MESForm.PopUp
{
    public partial class PopUpFacilityDetail : MESForm.BaseForms.frmPopup
    {
        private Point mousePoint;
        bool bRegOrUp; //등록 : true, 수정 : false

        public string DeptName { get; set; }
        public string FacilitiesCode { get; set; }

        public FacilityVO facilityVO { get; set; }

        public PopUpFacilityDetail()
        {
            InitializeComponent();
        }

        public PopUpFacilityDetail(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Register)
            {
                bRegOrUp = true;
            }
            else if (mode == OpenMode.Update)
            {
                bRegOrUp = false;
                txtFacilityCode.Enabled = false;
            }
        }
        private void ComboBoxBind()
        {
            //공통코드 (사용유무)
            CommonCodeService commonService = new CommonCodeService();
            List<CommonCodeVO> commonList = commonService.GetCommonCodeList();
            commonService.Dispose();
            ComboBoxBinding.ComBind(cboFacilityUse, commonList, "UseYN000", false);
            ComboBoxBinding.ComBind(cboOutSourcing, commonList, "UseYN000", false);

            //공장관리
            FactoryService factoryService = new FactoryService();
            List<FactoryVO> factoryList = factoryService.GetFactoryList();
            factoryService.Dispose();

            ComboBoxBinding.FactoryTypeBind(cboExhaustion, factoryList, "창고");
            ComboBoxBinding.FactoryTypeBind(cboImported, factoryList, "창고");
            ComboBoxBinding.FactoryTypeBind(cboPoor, factoryList, "불량창고");

            ItemService itemService = new ItemService();
            List<ItemVO> itemList = itemService.GetItemAllList();
            itemService.Dispose();

            itemList = (from temp in itemList
                        where temp.ITEM_Type != "원자재"
                        select temp).ToList();

            cboItemCode.DisplayMember = "ITEM_Code";
            cboItemCode.ValueMember = "ITEM_Name";
            cboItemCode.DataSource = itemList;
        }

        // 설비정보 가져오는 메서드
        private void GetFacilityInfo()
        {
            txtFacilitiesCode.Text = facilityVO.Facilities_Code;
            txtFacilityCode.Text = facilityVO.Facility_Code;
            txtFacilityName.Text = facilityVO.Facility_Name;
            cboExhaustion.Text = facilityVO.Facility_Exhaustion;
            cboImported.Text = facilityVO.Facility_Imported;
            cboPoor.Text = facilityVO.Facility_Poor;
            cboFacilityUse.Text = facilityVO.Facility_Use;
            txtFacilityMES.Text = facilityVO.Facility_MES;
            cboOutSourcing.Text = facilityVO.Facility_OutSourcing;
            cboItemCode.Text = facilityVO.Item_Code;
            txtIP.Text = facilityVO.Facility_IP;
            txtPort.Text = facilityVO.Facility_Port;
            txtFacilityNote.Text = facilityVO.Facility_Note;
            txtFacilityComment.Text = facilityVO.Facility_Comment;
            txtAmender.Text = facilityVO.Facility_Amender;
            txtModdifyDate.Text = Convert.ToString(facilityVO.Facility_ModdifyDate);
        }

        private void PopUpFacilityDetail_Load(object sender, EventArgs e)
        {
            ComboBoxBind();

            if (bRegOrUp)
            {
                txtFacilitiesCode.Text = FacilitiesCode;
                txtAmender.Text = DeptName;
                txtModdifyDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                GetFacilityInfo();
            }
        }

        /// <summary>
        /// 데이터 등록(bRegOrUp = true) 및 수정(bRegOrUp = false) 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFacilityCode.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비코드를"));
                return;
            }
            else if (txtFacilityName.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "설비명을"));
                return;
            }
            else if (cboExhaustion.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyComboBox.Replace("@@", "소진창고를"));
                return;
            }
            else if (cboImported.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyComboBox.Replace("@@", "양품창고를"));
                return;
            }
            else if (txtIP.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "아이피를"));
                return;
            }
            else if (txtPort.Text == "")
            {
                MessageBox.Show(Properties.Resources.ErrEmptyText.Replace("@@", "포트를"));
                return;
            }

            try
            {
                FacilityVO vo = new FacilityVO
                {
                    Facilities_Code = txtFacilitiesCode.Text,
                    Facility_Code = txtFacilityCode.Text,
                    Facility_Name = txtFacilityName.Text,
                    Facility_Exhaustion = cboExhaustion.Text,
                    Facility_Imported = cboImported.Text,
                    Facility_Poor = cboPoor.Text,
                    Facility_Use = cboFacilityUse.Text,
                    Facility_MES = txtFacilityMES.Text,
                    Facility_OutSourcing = cboOutSourcing.Text,
                    Item_Code = cboItemCode.Text,
                    Facility_IP = txtIP.Text,
                    Facility_Port = txtPort.Text,
                    Facility_Note = txtFacilityNote.Text,
                    Facility_Comment = txtFacilityComment.Text,
                    Facility_Amender = txtAmender.Text,
                    Facility_ModdifyDate = Convert.ToDateTime(txtModdifyDate.Text)
                };

                FacilityService service = new FacilityService();
                if (bRegOrUp) //등록
                {
                    service.InsertFacility(vo);
                }
                else //수정
                {
                    service.UpdateFacility(vo);
                }
                service.Dispose();

                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                if (err.Message == "이미 등록된 설비코드입니다.")
                {
                    txtFacilityCode.Focus();
                    txtFacilityCode.SelectAll();
                }
                else if (err.Message == "이미 등록된 설비명입니다.")
                {
                    txtFacilityName.Focus();
                    txtFacilityName.SelectAll();
                }

                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilityDetailPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void FacilityDetailPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
