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
        /// <summary>
        /// 상위코드를 바인딩할 때 사용
        /// </summary>
        /// <param name="cbo">콤보박스 name</param>
        /// <param name="list">공통코드 리스트</param>
        /// <param name="displayMember">보여줄 내용</param>
        /// <param name="blankItem">맨 위줄 빈칸 생성</param>
        /// <param name="blankText">빈 칸의 내용</param>
        public static void CommonCodeBind(ComboBox cbo, List<CommonCodeVO> list, string displayMember, bool blankItem = true, string blankText = "")
        {
            list = (from a in list
                    where a.Common_Parent == null
                    select a).ToList();

            if (blankItem)
            {
                CommonCodeVO blank = new CommonCodeVO
                { 
                    Common_Code = "",
                    Common_Name = blankText
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Common_Name";
            cbo.ValueMember = displayMember;
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
                    //Common_Code = "",
                    Common_Name = blankText // [선택,전체] 둘 중 하나 사용
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Common_Name";
            cbo.ValueMember =  "Common_code";
            cbo.DataSource = list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cbo">콤보박스</param>
        /// <param name="vo">뽑아온 리스트</param>
        /// <param name="displayMember"></param>
        public static void BindingComboBoxPart<T>(ComboBox cbo, List<T> vo, string displayMember)
        {
            
            cbo.DisplayMember = displayMember;
            cbo.DataSource = vo;
        }

        public static void CompanyBind(ComboBox cbo, List<CompanyVO> list, bool blankItem = true, string blankText = "")
        {
            if (blankItem)
            {
                CompanyVO blank = new CompanyVO
                {
                    Com_Code = "",
                    Com_Name = blankText // [선택,전체] 둘 중 하나 사용
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Com_Name";
            cbo.ValueMember = "Com_Code";
            cbo.DataSource = list;
        }

        public static void FactoryTypeBind(ComboBox cbo, List<FactoryVO> list, string warehouse, bool blankItem = true, string blankText = "")
        {
            if (warehouse == "창고")
            {
                list = (from temp in list
                        where temp.Factory_Type.EndsWith(warehouse) && temp.Factory_Type != "불량창고"
                        select temp).ToList();
            }
            else if (warehouse == "불량창고")
            {
                list = (from temp in list
                        where temp.Factory_Type == warehouse
                        select temp).ToList();
            }

            if (blankItem)
            {
                FactoryVO blank = new FactoryVO
                {
                    Factory_Code = "",
                    Factory_Name = blankText
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Factory_Name";
            cbo.ValueMember = "Factory_Code";
            cbo.DataSource = list;
        }

        public static void FactoryGradeBind(ComboBox cbo, List<FactoryVO> list, bool blankItem = true, string blankText = "")
        {
            if (blankItem)
            {
                FactoryVO blank = new FactoryVO
                {
                    Factory_Code = "",
                    Factory_Name = blankText
                };

                list.Insert(0, blank);
            }
            cbo.DisplayMember = "Factory_Name";
            cbo.ValueMember = "Factory_Code";
            cbo.DataSource = list;
        }

        public static void ComboBindingitem(ComboBox cbo, List<ItemVO> list, string gubun, bool blankItem = true, string blankText = "")
        {
            var codeList = (from item in list
                            where item.Gubun.Equals(gubun)
                            select item).ToList();

            if (blankItem)
            {
                ItemVO blank = new ItemVO
                { Code = "" };
                codeList.Insert(0, blank);
            }
            cbo.DisplayMember = "Code";
            cbo.ValueMember = "Code";
            cbo.DataSource = codeList;
        }

        public static void BOMComboBindingitem(ComboBox cbo, List<BOMVO> list, string gubun, bool blankItem = true, string blankText = "")
        {
            var codeList = (from item in list
                            where item.Gubun.Equals(gubun)
                            select item).ToList();

            if (blankItem)
            {
                BOMVO blank = new BOMVO
                { Code = "" };
                codeList.Insert(0, blank);
            }
            cbo.DisplayMember = "Code";
            cbo.ValueMember = "Code";
            cbo.DataSource = codeList;
        }
    }
}
