using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace HappyTech
{
    class EditorFormCodeClass : EditorForm
    {
        /// <summary>
        /// populates the dropdown box of sections on the 'new' side of the screen
        /// </summary>
        /// <param name="combobox"></param>
        public static void Populate_ComboBox_NewCodeSection(ComboBox combobox)
        {
            combobox.Items.Clear();

            EditorFormCommon.UpdateList("Section");

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                combobox.Items.
                    Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }
        }


        /// <summary>
        /// When a code is seletced from the dropdown on the edit side of the screen
        /// this loads the selected code's info into the textbox/ richtextbox
        /// to allow this information to be edited
        /// </summary>
        /// <param name="newCodeName"></param>
        /// <param name="editedParagraph"></param>
        /// <param name="selectedCode"></param>
        /// <param name="cboxOldSec"></param>
        public static void LoadInfoForCodeEdit(
                                                       TextBox newCodeName, 
                                                       RichTextBox editedParagraph, 
                                                        ComboBox selectedCode, 
                                                        ComboBox cboxOldSec)
        {
            newCodeName.Text = selectedCode.Text.Replace(" ", "");
            
            cboxOldSec.Items.Clear();
            EditorFormCommon.UpdateList("Section");

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                cboxOldSec.Items.Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }

            DataSet codeDB = Connection.GetDbConn().
                                    GetDataSet(SqlQueries.
                                        GetCodeParaFromShort(selectedCode.Text.Replace(" ", "")));

            DataRow codeDBValue = codeDB.Tables[0].Rows[0];

            newCodeName.Text = selectedCode.Text.Replace(" ", "");
            editedParagraph.Text = codeDBValue.ItemArray.GetValue(0).ToString();
        }

        /// <summary>
        /// populates the dropdown box of selectable codes
        /// </summary>
        /// <param name="existingCodeDropdown"></param>
        public static void Populate_ComboBox_EditExistingCode(ComboBox existingCodeDropdown)
        {
            existingCodeDropdown.Items.Clear();

            EditorFormCommon.UpdateList("Code");

            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                existingCodeDropdown.Items.
                    Add($"{Code.codeList[i].CodeName.Replace(" ", "")}");
            }
        }

        //combobox_editcodesection
        /// <summary>
        /// 
        /// this function populates the dropdown list of sections on the 'edit' side of the page
        /// </summary>
        /// <param name="existingSections"></param>
        public static void Populate_ComboBox_EditCodeSection(ComboBox existingSections)
        {
            existingSections.Items.Clear();

            EditorFormCommon.UpdateList("Section");

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                existingSections.Items.
                    Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }
        }

        public static void InsertNewCode(TextBox codeName, RichTextBox codeParagraph, ComboBox section)
        {

            /* 
             * Add code to database, reset fields, display success.             TextBox_NewCodeName     RichTextBox_NewCodeParagraph       ComboBox_NewCodeSection
             */


            DataSet sectionDB = Connection.GetDbConn().GetDataSet(SqlQueries.
                                        GetTagIdFromName(section.Text));

            DataRow sectionDBValue = sectionDB.Tables[0].Rows[0];

            object sectionId = sectionDBValue.ItemArray.GetValue(0);
            string newCodeName = codeName.Text.ToUpper().Replace(" ", "");
            string newCodeParagraph = codeParagraph.Text;

            Connection.GetDbConn().CreateCommand(SqlQueries.
                InsertNewCode(newCodeName, newCodeParagraph, sectionId));
        }

        public static void SaveCodeChange(ComboBox selectedCode, TextBox editedCodeName, RichTextBox editedCodeParagraph)
        {
            DataSet codeDB = Connection.GetDbConn().GetDataSet(SqlQueries.
                                           GetCodeId(selectedCode.Text));

            DataRow codeDBValue = codeDB.Tables[0].Rows[0];
            var codeId = codeDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.
                EditCode(codeId, editedCodeName.Text.ToUpper().Replace(" ", ""),
                editedCodeParagraph.Text));
        }

        public static void DeleteCode (ComboBox selectedCode)
        {
            string codeName = selectedCode.Text;

            DataSet codeDB = Connection.GetDbConn().
                                        GetDataSet(SqlQueries.
                                            GetCodeIdFromName(codeName));

            DataRow codeDBValue = codeDB.Tables[0].Rows[0];
            var codeId = codeDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.
                DeleteCodeFromId(codeId));
        }
    }
    
}
