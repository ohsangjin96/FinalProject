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

        /// <summary>
        /// 상속받은 공통코드를 콤보박스에 바인딩
        /// </summary>
        /// <param name="cbo">콤보박스</param>
        /// <param name="list">공통코드 리스트</param>
        /// <param name="Code">상속받은 코드명</param>
        /// <param name="blankItem">true , false</param>
        /// <param name="blankText">[선택,전체] 둘 중 하나 사용</param>
        public static void ComBind(ComboBox cbo, List<CommonCodeVO> list,string Code, bool blankItem = true, string blankText = "")
        {
            list = (from a in list
                    where a.Common_Parent == Code  //Common_Parent의 코드명
                    select a).ToList();

            if (blankItem)
            {
                CommonCodeVO blank = new CommonCodeVO
                {
                    Common_Code = "",
                    Common_Name = blankText // [선택,전체] 둘 중 하나 사용
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Common_Name";
            cbo.ValueMember =  "Common_code";
            cbo.DataSource = list;
        }

        
    }
}
