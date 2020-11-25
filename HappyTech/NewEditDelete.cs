using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class NewEditDelete : Form
    {
        string type; //used to determine between code, section and template
        public NewEditDelete(string type)
        {
            InitializeComponent();
            codeParaLbl.Hide();
            newCodeParaBox.Hide();
            codeParaEditBox.Hide();
            newCodeSection.Hide();
            dropDownForEdit.Hide();
            addToExistBox.CheckOnClick = true;
            this.type = type;
            

            if (type == "code")
            {
                codeParaLbl.Show();
                addToExistBox.Hide();
                fillNewCodeTagDrop();
                newCodeSection.Show();
                newCodeParaBox.Show();
                codeParaEditBox.Show();
                fillExistBoxWithSections();
                fillExistingDropDownWithCodes();
                dropDownForEdit.Show();
                checkBoxForEdit.Hide();


            }

            else if (type == "section")
            {
                fillExistBoxWithTemplates();
                fillExistingDropDownWithSections();
            }

            else if (type == "template")
            {
                fillExistingDropDownWithTemplates();
                fillExistBoxWithSections();
            }
        }
        private void fillNewCodeTagDrop()
        {
            newCodeSection.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                newCodeSection.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
            }
        }

        private void fillExistBoxWithSections()
        {
            addToExistBox.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                addToExistBox.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
            }
        }

        private void fillExistingDropDownWithSections()
        {
            existingDropDown.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                existingDropDown.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
            }
        }

        private void fillExistBoxWithTemplates()
        {
            addToExistBox.Items.Clear();
            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                addToExistBox.Items.Add($"{Template.templates[i].TempType}");
            }
        }

        private void fillExistingDropDownWithTemplates()
        {
            existingDropDown.Items.Clear();
            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                existingDropDown.Items.Add($"{Template.templates[i].TempType}");
            }
        }
        private void fillExistingDropDownWithCodes()
        {
            existingDropDown.Items.Clear();
            Code.codeList.Clear();
            Code.fillCodeList();
            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                existingDropDown.Items.Add($"{Code.codeList[i].CodeName}");
            }
        }

        private void submitNewBtn_Click(object sender, EventArgs e)
        {
            //sanitiseInput();
            if (type == "code")
            {
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(newCodeSection.Text));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var tagId = dRow.ItemArray.GetValue(0);
                string toUse = inputBox.Text.Replace(" ", "");
                string codeParaToUse = newCodeParaBox.Text;

                Connection.GetDbConn().CreateCommand(Constants.insertNewCode(toUse, codeParaToUse, tagId));
                
                inputBox.Clear();
                newCodeParaBox.Text = "";
                newCodeSection.Text = "";

            }
            else if (type == "section")
            {
                string sectionName = inputBox.Text.Replace(" ", "");
                Sections.InsertSectionWithSelectedTemplates(sectionName, addToExistBox);
                inputBox.Clear();
                fillExistBoxWithTemplates();
            }
            else if (type == "template")
            {
                string templateName = inputBox.Text.Replace(" ", "");
                Template.CreateTemplateWithSelectedSections(templateName, addToExistBox);
                inputBox.Clear();
                fillExistBoxWithTemplates();
            }
        }

        private void existingDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            editBox.Text = existingDropDown.Text.Replace(" ", "");

            if (type == "code")
            {
               dropDownForEdit.Items.Clear();
                Sections.sectionList.Clear();
                //by default, loads all the sections into the sectionsListBox
                Sections.listSection();
                for (int i = 0; i < Sections.sectionList.Count(); i++)
                {
                    //Code.codeList[i].GetSectionName().Trim()}:

                    dropDownForEdit.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
                }
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeParaFromShort(existingDropDown.Text.Replace(" ", "")));
                DataRow dRow = ds.Tables[0].Rows[0];
                codeParaEditBox.Text = dRow.ItemArray.GetValue(0).ToString();

            }
            if (type == "section") //if we're editing sections, we need the checkbox to be populated with templates
            {
                //change check list to display templates checkBoxForEdit needs to change if the existingDropDown changes

                checkBoxForEdit.Items.Clear(); // clear out old info (if any)
                Template.templates.Clear();
                // we will use the selected section name to get the selected section's's ID
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(existingDropDown.Text.Replace(" ", "")));
                DataRow dRow = ds.Tables[0].Rows[0];
                var sectionId = dRow.ItemArray.GetValue(0);
                // we need to populate the sectionsListBox 
                Template.listTemplates();
                for (int i = 0; i < Template.templates.Count(); i++)
                {
                    string tempNameToAdd = Template.templates[i].TempType.Replace(" ", "");
                    int tempId = Template.templates[i].Id;
                    checkBoxForEdit.Items.Add($"{tempNameToAdd}");
                    //if there is a PersonalSection object with this template id and this section id, set checked to true
                    DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow1 = ds1.Tables[0].Rows[0];

                        if (dRow1 != null)
                        {
                            checkBoxForEdit.SetItemChecked(i, true);
                        }
                    }
                    catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch

                }
            }
            if (type == "template") //if we're editing a template, we want to see the sections we can add it to
            {
                //change check list to display templates
                checkBoxForEdit.Items.Clear(); // clear out old sections
                Sections.sectionList.Clear();
                // we will use the selected template name to get the selected template's ID
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(editBox.Text.Replace(" ", "")));
                Console.WriteLine(Constants.getTemplateIdFromName(editBox.Text.Replace(" ", "")));
                DataRow dRow = ds.Tables[0].Rows[0];
                var templateId = dRow.ItemArray.GetValue(0);
                // we need to populate the sectionsListBox 
                Sections.listSection();
                for (int i = 0; i < Sections.sectionList.Count(); i++)
                {
                    string sectionNameToAdd = Sections.sectionList[i].name.Replace(" ", "");
                    int sectionId = Sections.sectionList[i].id;
                    checkBoxForEdit.Items.Add($"{sectionNameToAdd}");
                    //if there is a PersonalSection object with this template id and this section id, set checked to true
                    DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow1 = ds1.Tables[0].Rows[0];

                        if (dRow1 != null)
                        {
                            checkBoxForEdit.SetItemChecked(i, true);
                        }
                    }
                    catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch

                }
            }
        }

       

        private void saveChangeBtn_Click(object sender, EventArgs e)
        {
            if (type == "code")
            {
                //get the id of the old code and update the code short with the new one
                //update codepara with the new one
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeId(existingDropDown.Text));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var codeId = dRow.ItemArray.GetValue(0);
                Connection.GetDbConn().CreateCommand(Constants.editCode(codeId, editBox.Text.Replace(" ",""), codeParaEditBox.Text));
                codeParaEditBox.Clear();
                fillExistingDropDownWithCodes();
                dropDownForEdit.Items.Clear();
            }

            if (type == "section")
            {
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(existingDropDown.Text));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var sectionId = dRow.ItemArray.GetValue(0);
                Connection.GetDbConn().CreateCommand(Constants.editSection(sectionId, editBox.Text.Replace(" ","")));
                //now we need to update the personalsection part
                //for every template in case a template was deselected
                UpdatePersonalSectionsForSection(sectionId);
                editBox.Clear();
            }

            if (type == "template")
            {
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(existingDropDown.Text.Replace(" ","")));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var templateId = dRow.ItemArray.GetValue(0);
                Connection.GetDbConn().CreateCommand(Constants.editTemplate(templateId, editBox.Text));
                UpdatePersonalSectionsForTemplate(templateId);
                editBox.Clear();
               
            }
            editBox.Clear();
            
        }

        private void UpdatePersonalSectionsForTemplate(object tempId)
        {


            for (int i = 0; i < checkBoxForEdit.Items.Count; i++) //for every item in check box, get its id. check if that checkbox is marked
            {
                string sectionName = checkBoxForEdit.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(sectionName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);
                if (checkBoxForEdit.GetItemCheckState(i) == CheckState.Checked)
                {
                   

                    DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT * from PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow2 = ds2.Tables[0].Rows[0];
                        //this has checked the related box was ticked and there IS a PersonalSection object already created for
                        //this template and section combination
                    }
                    catch
                    {
                        //no PersonalSection object was found so one needs to be created
                        Connection.GetDbConn().CreateCommand($"INSERT INTO PersonalSection (template_Id, section_Id) VALUES ('{tempId}', '{sectionId}')");
                        //now a PersonalSection object has been made
                    }
                }
                else if (checkBoxForEdit.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
                {
                    //need to check if there is a Personalsection object
                    DataSet ds3 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow3 = ds3.Tables[0].Rows[0];
                        //if this passes then the check box was NOT ticked and there IS a PersonalSection object
                        //so we need to find the row and drop it
                        Connection.GetDbConn().CreateCommand($"DELETE FROM PersonalSection WHERE template_Id = '{tempId}' AND section_Id = '{sectionId}'");
                    }
                    catch { } //if catch is reached then checkbox was NOT ticked and the was NO PersonalSection object
                }

            
            }
           
        }

        private void UpdatePersonalSectionsForSection(object sectId)
        {


            for (int i = 0; i < checkBoxForEdit.Items.Count; i++) //for every item in check box, get its id. check if that checkbox is marked
            {
              
                string templateName = checkBoxForEdit.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(templateName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var templateId = dRow1.ItemArray.GetValue(0);
                if (checkBoxForEdit.GetItemCheckState(i) == CheckState.Checked)
                {
                    

                    DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT * from PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectId}'");
                    try
                    {
                        DataRow dRow2 = ds2.Tables[0].Rows[0];
                        //this has checked the related box was ticked and there IS a PersonalSection object already created for
                        //this template and section combination
                    }
                    catch
                    {
                        //no PersonalSection object was found so one needs to be created
                        Connection.GetDbConn().CreateCommand($"INSERT INTO PersonalSection (template_Id, section_Id) VALUES ('{templateId}', '{sectId}')");
                        //now a PersonalSection object has been made
                    }
                }
                else if (checkBoxForEdit.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
                {
                    //need to check if there is a Personalsection object
                    DataSet ds3 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectId}'");
                    try
                    {
                        DataRow dRow3 = ds3.Tables[0].Rows[0];
                        //if this passes then the check box was NOT ticked and there IS a PersonalSection object
                        //so we need to find the row and drop it
                        Connection.GetDbConn().CreateCommand($"DELETE FROM PersonalSection WHERE template_Id = '{templateId}' AND section_Id = '{sectId}'");
                    }
                    catch { } //if catch is reached then checkbox was NOT ticked and the was NO PersonalSection object
                }


            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cv = new codeViewForm();
            cv.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            editBox.Clear();
            existingDropDown.Text = "";
            dropDownForEdit.Text = "";
            try {
                codeParaEditBox.Clear(); //only shows if type is code
            }
            catch { }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
