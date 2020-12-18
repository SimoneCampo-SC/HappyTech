using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This class will handle elements that are common between editorform's code,
/// section and template classes but which doesnt
/// have to do with styling. styling code will be left in editorform
/// </summary>

namespace HappyTech
{
    class EditorFormCommon
    {

        /// <summary>
        /// Some boxes are populated from items in a list of their respective class
        /// this method clears and populates these lists
        /// 
        /// </summary>
        /// <param name="type"></param>
        public static void UpdateList(string type)
        {
            switch (type)
            {
                case "Template":

                    Template.templates.Clear();
                    Template.GenerateTemplates();

                    break;

                case "Section":

                    Section.sectionList.Clear();
                    Section.FillSectionList();

                    break;

                case "Code":

                    Code.codeList.Clear();
                    Code.FillCodeList();

                    break;
            }
        }
    }
}
