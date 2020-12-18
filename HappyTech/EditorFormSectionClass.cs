using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace HappyTech
{
    class EditorFormSectionClass
    {
        public static void InsertNewSection( string sectionName, CheckedListBox templates)
        {
            string queryString = SqlQueries.CreateNewTag(sectionName);
            Connection.GetDbConn().CreateCommand(queryString); //section object has now been created
            //we will get the id of this new section first instead of getting it in each iteration of the loop
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionIdFromName(sectionName));
            DataRow dRow = ds.Tables[0].Rows[0];
            var sectionId = dRow.ItemArray.GetValue(0);
            foreach (string template in templates.CheckedItems)
            {
                //for each template selected, we have to add a template id and section id to PersonalSection
                //so we will get the template id from the template name
                DataSet ds1 = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateIdFromName(template));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var templateId = dRow1.ItemArray.GetValue(0);
                //now we have the template id and section id
                string createPersonalSection = $"insert into PersonalSection (template_ID, section_ID) VALUES ('{templateId}', '{sectionId}')";
                Connection.GetDbConn().CreateCommand(createPersonalSection);
                //now a PersonalSection object has been created
            }
        }

        public static void EditSection(ComboBox selectedSection, TextBox newSectionName, CheckedListBox editedTemplates)
        {
            DataSet sectionDB = Connection.GetDbConn().GetDataSet(SqlQueries.
                                                    GetSectionIdFromName(selectedSection.Text));

            DataRow sectionDBValue = sectionDB.Tables[0].Rows[0];
            var sectionId = sectionDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.
                EditSection(sectionId, newSectionName.Text.Replace(" ", "")));

            UpdatePersonalSection(sectionId, editedTemplates);
        }


        /// <summary>
        /// 
        ///     Update the PersonalSection foreign keys
        ///     for a template and section.
        ///         - Loop through template checkbox item
        ///             - Get the template ID from the
        ///               template name
        ///             - Check if the checkbox is checked
        ///               - If so, check if a PersonalSection already
        ///                 exists with forein keys from the template
        ///                 ID and section ID
        ///                 - If so, do nothing as it already exists
        ///                 - If not, create one (because it's checked)
        ///               - If not, check if a PersonalSection already
        ///                 exists with the forein keys from template
        ///                 ID and section ID
        ///                 - If so, delete it (because it's unchecked)
        ///                 - If not, do nothing as it doesn't exist
        ///                   and it wasn't checked
        /// 
        /// </summary>
        public static void UpdatePersonalSection(object section, CheckedListBox editedTemplates)
        {
            for (int i = 0; i < editedTemplates.Items.Count; i++)
            {
                string templateName = editedTemplates.Items[i].ToString();
                DataSet templateDB = Connection.GetDbConn().
                                            GetDataSet(SqlQueries.
                                                GetTemplateIdFromName(templateName));
                DataRow templateDBValue = templateDB.Tables[0].Rows[0];
                var templateId = templateDBValue.ItemArray.GetValue(0);

                if (editedTemplates.GetItemCheckState(i) == CheckState.Checked)
                {
                    DataSet personalSectionDB = Connection.GetDbConn().
                                                GetDataSet($"SELECT * from PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{section}'");

                    try
                    {
                        DataRow personalSectionDBValue = personalSectionDB.Tables[0].Rows[0];
                    }
                    catch
                    {
                        Connection.GetDbConn().
                            CreateCommand($"INSERT INTO PersonalSection (template_Id, section_Id) VALUES ('{templateId}', '{section}')");
                    }
                }
                else if (editedTemplates.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    DataSet personalSectionDB2 = Connection.GetDbConn().
                                                GetDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{section}'");

                    try
                    {
                        DataRow personalSectionDB2Value = personalSectionDB2.Tables[0].Rows[0];

                        Connection.GetDbConn().
                            CreateCommand($"DELETE FROM PersonalSection WHERE template_Id = '{templateId}' AND section_Id = '{section}'");
                    }
                    catch { }
                }
            }
        }

        public static void DeleteSection (ComboBox selectedSection)
        {
            DataSet sectionDB = Connection.GetDbConn().
                                               GetDataSet(SqlQueries.
                                                   GetSectionIdFromName(selectedSection.Text));

            DataRow sectionDBValue = sectionDB.Tables[0].Rows[0];
            var sectionId = sectionDBValue.ItemArray.GetValue(0);

            Connection.GetDbConn().CreateCommand(SqlQueries.
                DeleteSectionFromId(sectionId));
            Connection.GetDbConn().CreateCommand(SqlQueries.
                DeletePersonalSectionUsingSectionId(sectionId));
        }

        /// <summary>
        /// populates checked list box with all existing templates
        /// </summary>
        public static void PopulateTemplates(CheckedListBox templates)
        {
            //CheckedListBox_NewSectionExistingTemplate.Items.Clear();
            templates.Items.Clear();

            EditorFormCommon.UpdateList("Template");

            for (int i = 0; i < Template.templates.Count(); i++)
            {
                templates.Items.
                    Add($"{Template.templates[i].Type}");
            }
        }

        public static void PopulateSections(ComboBox existingSections)
        {
            //ComboBox_EditSectionChooseExisting.Items.Clear();
            existingSections.Items.Clear();

            EditorFormCommon.UpdateList("Section");

            for (int i = 0; i < Section.sectionList.Count(); i++)
            {
                existingSections.Items.
                    Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }
        }

        /// <summary>
        /// When a section is selected from the dropdown on the edit side of the screen, load that section's info into the textbox/ checkedlistbox
        /// </summary>
        /// <param name="sectionDropDown"></param>
        /// <param name="templates"></param>
        public static void LoadInfoForSectionEdit( ComboBox sectionDropDown, CheckedListBox templates)
        {
            //TextBox_EditSectionName
            //ComboBox_EditSectionChooseExisting
            //CheckedListBox_EditSectionTemplate
            EditorFormCommon.UpdateList("Template");

            DataSet sectionDB = Connection.GetDbConn().
                                        GetDataSet(SqlQueries.
                                            GetSectionIdFromName(sectionDropDown.Text.Replace(" ", "")));

            DataRow sectionDBValue = sectionDB.Tables[0].Rows[0];
            var sectionId = sectionDBValue.ItemArray.GetValue(0);

            for (int i = 0; i < Template.templates.Count(); i++)
            {
                string templateName = Template.templates[i].Type.Replace(" ", "");
                int templateID = Template.templates[i].Id;

                templates.Items.Add($"{templateName}");

                DataSet personalSectionDB = Connection.GetDbConn().
                                                GetDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateID}' and section_ID = '{sectionId}'");

                try
                {
                    DataRow personalSectionDBValue = personalSectionDB.Tables[0].Rows[0];

                    if (personalSectionDBValue != null)
                    {
                        templates.SetItemChecked(i, true);
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
