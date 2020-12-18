using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace HappyTech
{
    class EditorFormTemplateClass : EditorForm
    {
        /// <summary>
        /// When template is selected at the top of the page, load all existing templates
        /// into the dropdown box on the edit side of the page
        /// </summary>
        /// <param name="chooseTemplateCombo">ComboBox_EditTemplateChooseExisting</param>
        public static void LoadExistingTemplates(ComboBox chooseTemplateCombo)
        {
            chooseTemplateCombo.Items.Clear();

            EditorFormCommon.UpdateList("Template");

            for (int i = 0; i < Template.templates.Count(); i++)
            {
                chooseTemplateCombo.Items.
                    Add($"{Template.templates[i].Type}");
            }
        }

        /// <summary>
        /// loads existing sections into a checklistBox - allows user to easily select
        /// multiple sections to attach a new template to
        /// </summary>
        /// <param name="chooseSectionCheck">CheckedListBox_NewTemplateExistingSection</param>
        public static void LoadExistingSections(CheckedListBox chooseSectionCheck)
        {
            chooseSectionCheck.Items.Clear();

            EditorFormCommon.UpdateList("Section");

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                chooseSectionCheck.Items.
                    Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }
        }


        /// <summary>
        /// 
        /// takes a string (from a textbox) and makes a template object with it, then makes personalsection objects for eah checked section
        /// from a checkedlistbox of sections.
        /// 
        /// </summary>
        /// <param name="templName"></param>
        /// <param name="selectedSections">CheckedListBox_EditTemplateSection</param>
        ///  
        public static void InsertNewTemplate(string templName, CheckedListBox selectedSections)
        {
      
                //when template is submitted, needs to make a new section ID, then needs to make new PersonalSection
                //objects for each checked section in the sectionsListBox
                bool stringOk = false; //stringOk will check the string isn't just spaces or blank
                                       //ideally there would be a check to make sure this name asn't already been entered into the database
                                       //if SELECT * FROM Section WHERE name = tagBox.Text != null then throw error (because a row exists with this name)
                if (templName.Replace(" ", "") != "")
                {
                    stringOk = true;
                }

                if (stringOk == true)
                {
                    //has to create the template object first so we have a template ID to work with
                    string queryString = SqlQueries.InsertNewTemplate(templName);
                    Connection.GetDbConn().CreateCommand(queryString);
                    //template object has now been created
                    //we will get the id of this new template first instead of getting it in each iteration of the loop
                    DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateIdFromName(templName));
                    DataRow dRow = ds.Tables[0].Rows[0];
                    var templateId = dRow.ItemArray.GetValue(0);
                    foreach (string section in selectedSections.CheckedItems)
                    {
                        //for each template selected, we have to add a template id and section id to PersonalSection
                        //so we will get the template id from the template name
                        DataSet ds1 = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionIdFromName(section));
                        DataRow dRow1 = ds1.Tables[0].Rows[0];
                        var sectionId = dRow1.ItemArray.GetValue(0);
                        //now we have the template id and section id
                        Connection.GetDbConn().CreateCommand(SqlQueries.InsertNewPersonalSection(templateId, sectionId));
                        //now a PersonalSection object has been created
                    }
                }
                else if (stringOk == false)
                {
                    //need an error box here to advise user of issue
                }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionsCheckBox"></param>
        /// <param name="editTemplatename">TextBox_EditTemplateName</param>
        public static void EditTemplate(CheckedListBox sectionsCheckBox, TextBox editTemplatename)
        {
            DataSet templateDB = Connection.GetDbConn().GetDataSet(SqlQueries.
                                                   GetTemplateIdFromName(sectionsCheckBox.Text.Replace(" ", "")));

            DataRow templateDBValue = templateDB.Tables[0].Rows[0];
            var templateId = templateDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.EditTemplate(templateId,
                editTemplatename.Text));

            UpdatePersonalSections(templateId, sectionsCheckBox);

        }

        /// <summary>
        /// updates personal section DB
        /// if there is a check on the checklistbox item
        /// -that section should be linked with this template
        /// -needs to have a personal section objct with this template ID and the section ID
        /// -if there isn't one, make one
        /// if there is not a check on that section
        /// -if there is a personalsection object, it needs to be deleted
        /// -if not checked and no PS object, dont do anything
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="sectionsCheckBox">CheckedListBox_EditTemplateSection</param>
        public static void UpdatePersonalSections(object tempId, CheckedListBox sectionsCheckBox)
        {
            for (int i = 0; i < sectionsCheckBox.Items.Count; i++)
            {
                string sectionName = sectionsCheckBox.Items[i].ToString();
                DataSet sectionDB = Connection.GetDbConn().
                                            GetDataSet(SqlQueries.
                                                GetSectionIdFromName(sectionName));
                DataRow sectionDBValue = sectionDB.Tables[0].Rows[0];
                var sectionId = sectionDBValue.ItemArray.GetValue(0);

                if (sectionsCheckBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    DataSet personalSectionDB = Connection.GetDbConn().
                                                    GetDataSet($"SELECT * from PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");

                    try
                    {
                        DataRow personalSectionDBValue = personalSectionDB.Tables[0].Rows[0];
                    }
                    catch
                    {
                        Connection.GetDbConn().
                            CreateCommand($"INSERT INTO PersonalSection (template_Id, section_Id) VALUES ('{tempId}', '{sectionId}')");
                    }
                }
                else if (sectionsCheckBox.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    DataSet personalSectionDB2 = Connection.GetDbConn().
                                                    GetDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");

                    try
                    {
                        DataRow personalSectionDB2Value = personalSectionDB2.Tables[0].Rows[0];

                        Connection.GetDbConn().
                            CreateCommand($"DELETE FROM PersonalSection WHERE template_Id = '{tempId}' AND section_Id = '{sectionId}'");
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// when delete button is clicked, takes the name of the template from a combobox and deletes it, also deletes personal sections
        /// </summary>
        /// <param name="existingTemp">ComboBox_EditTemplateChooseExisting</param>
        public static void DeleteTemplate(ComboBox existingTemp)
        {
            string templateName = existingTemp.Text;
            DataSet templateDB = Connection.GetDbConn().
                                        GetDataSet(SqlQueries.
                                            GetTemplateIdFromName(templateName));

            DataRow templateDBValue = templateDB.Tables[0].Rows[0];
            object templateId = templateDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.
                DeleteTemplateFromId(templateId));

            Connection.GetDbConn().CreateCommand(SqlQueries.
                DeletePersonalSectionUsingTemplateId(templateId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="templateName">TextBox_EditTemplateName.Text</param>
        /// <param name="sections">CheckedListBox_EditTemplateSection</param>
        public static void LoadInfoForTemplateEdit(TextBox templateName, CheckedListBox sections)
        {
            sections.Items.Clear();

            EditorFormCommon.UpdateList("Section");

            DataSet templateDB = Connection.GetDbConn().
                                        GetDataSet(SqlQueries.
                                            GetTemplateIdFromName(templateName.Text.Replace(" ", "")));

            DataRow templateDBValue = templateDB.Tables[0].Rows[0];
            var templateId = templateDBValue.ItemArray.GetValue(0);

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                string sectionName = Section.sectionList[i].Name.Replace(" ", "");
                int sectionId = Section.sectionList[i].Id;

                sections.Items.Add($"{sectionName}");

                DataSet personalSectionDB = Connection.GetDbConn().
                                                GetDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");

                try
                {
                    DataRow personalSectionDBValue = personalSectionDB.Tables[0].Rows[0];

                    if (personalSectionDBValue != null)
                    {
                        sections.SetItemChecked(i, true);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Returned NULL.");
                }
            }
        }
    }
}
