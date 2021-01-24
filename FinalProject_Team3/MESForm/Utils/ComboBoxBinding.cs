using FProjectVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESForm.Utils
{
    public class ComboBoxBinding
    {
        public static void CommonCodeBind(ComboBox cbo, List<CommonCodeVO> list, string displayMember, bool blankItem = true, string blankText = "")
        {
            list = (from a in list
                    where a.Common_Parent == null
                    select a).ToList();

            if (blankItem)
            {
                CommonCodeVO blank = new CommonCodeVO
                { 
                    Common_Code = blankText,
                    Common_Name = ""
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = "Common_Name";
            cbo.DataSource = list;
        }

        public static void DeptBind(ComboBox cbo, List<CommonCodeVO> list, string displayMember)
        {
            list = (from a in list
                    where a.Common_Parent == "dept000"
                    select a).ToList();

            //if (blankItem)
            //{
            //    CommonCodeVO blank = new CommonCodeVO
            //    {
            //        Common_Code = blankText,
            //        Common_Name = ""
            //    };

            //    list.Insert(0, blank);
            //}
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = "Common_Name";
            cbo.DataSource = list;
        }
    }
}
