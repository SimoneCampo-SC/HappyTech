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
        string mode = "template"; //used to determine between code, section and template
        public NewEditDelete()
        {
            InitializeComponent();
            LoadTempMode();

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
            dropdownExistingSection.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                dropdownExistingSection.Items.Add($"{Sections.sectionList[i].name}");
            }
        }

        private void fillExistBoxWithTemplates()
        {
            checkboxAddExistTemps.Items.Clear();
            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                checkboxAddExistTemps.Items.Add($"{Template.templates[i].TempType}");
            }
        }

        private void fillExistingDropDownWithTemplates()
        {
            dropdownExistingTemplate.Items.Clear();
            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                dropdownExistingTemplate.Items.Add($"{Template.templates[i].TempType}");
            }
        }
        private void fillExistingDropDownWithCodes()
        {
            dropdownExistingCode.Items.Clear();
            Code.codeList.Clear();
            Code.fillCodeList();
            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                dropdownExistingCode.Items.Add($"{Code.codeList[i].CodeName}");
            }
        }

        private void submitNewBtn_Click(object sender, EventArgs e)
        {
           
            //sanitiseInput();
            if (mode == "code")
            {
                if (txtNewCodeName.Text.Length <= 0)
                {
                    lblAddError.Text = "Enter a code name";
                    lblAddError.Show();
                }
                else if (txtNewCodeName.Text.Length > 5)
                {
                    lblAddError.Text = "Code name must be 5 characters or less";
                    lblAddError.Show();
                }
                else if (newCodeParaBox.Text.Length <= 0)
                {
                    lblAddError.Text = "Enter a code paragraph";
                    lblAddError.Show();
                }
                else if (txtNewCodeName.Text.Contains(" "))
                {
                    lblAddError.Text = "Remove spaces from code name";
                    lblAddError.Show();
                }
                else if (newCodeSection.SelectedItem == null)
                {
                    lblAddError.Text = "Select a section to add to";
                    lblAddError.Show();
                }
                else if (Constants.checkCode(txtNewCodeName.Text))
                {
                    lblAddError.Text = "A code with this name already exists";
                    lblAddError.Show();
                }
                else
                {
                    lblAddError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(newCodeSection.Text));
                    DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                    var tagId = dRow.ItemArray.GetValue(0);
                    string toUse = txtNewCodeName.Text.ToUpper().Replace(" ", "");
                    string codeParaToUse = newCodeParaBox.Text;

                    Connection.GetDbConn().CreateCommand(Constants.insertNewCode(toUse, codeParaToUse, tagId));

                    txtNewCodeName.Clear();
                    newCodeParaBox.Text = "";
                    newCodeSection.Text = "";
                    fillExistingDropDownWithCodes();

                    lblAddSuccess.Text = "New code saved";
                    lblAddSuccess.Show();
                }
            }
            else if (mode == "section")
            {
                if (txtNewSectionName.Text.Length <= 0)
                {
                    lblAddError.Text = "Enter a section name";
                    lblAddError.Show();
                }
                else if (txtNewSectionName.Text.Contains(" "))
                {
                    lblAddError.Text = "Remove spaces from section name";
                    lblAddError.Show();
                }
                else if (Constants.checkSection(txtNewSectionName.Text))
                {
                    lblAddError.Text = "A section with this name already exists";
                    lblAddError.Show();
                }
                else
                {
                    lblAddError.Hide();
                    string sectionName = txtNewSectionName.Text.Replace(" ", "");
                    Sections.InsertSectionWithSelectedTemplates(sectionName, checkboxAddExistTemps);
                    ClearSectionModeFields();
                    lblAddSuccess.Text = "New section saved";
                    lblAddSuccess.Show();

                }
                
            }
            else if (mode == "template")
            {
                if (txtNewTemplateName.Text.Length <= 0)
                {
                    lblAddError.Text = "Enter a template name";
                    lblAddError.Show();
                }
                else if (txtNewTemplateName.Text.Contains(" "))
                {
                    lblAddError.Text = "Remove spaces from template name";
                    lblAddError.Show();
                }
                else if (Constants.checkTemplate(txtNewTemplateName.Text))
                {
                    lblAddError.Text = "A template with this name already exists";
                    lblAddError.Show();
                }
                else
                {
                    lblAddError.Hide();
                    string templateName = txtNewTemplateName.Text.Replace(" ", "");
                    Template.CreateTemplateWithSelectedSections(templateName, addToExistBox);
                    ClearTemplateModeFields();
                    lblAddSuccess.Text = "New template saved";
                    lblAddSuccess.Show();
                }

                
            }
        }

        private void dropdownExistingTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditTemplateName.Text = dropdownExistingTemplate.Text.Replace(" ", "");

            lblEditSuccess.Hide();
            lblEditError.Hide();
                
            //change check list to display templates
            checkBoxForEdit.Items.Clear(); // clear out old sections
            Sections.sectionList.Clear();
            // we will use the selected template name to get the selected template's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(txtEditTemplateName.Text.Replace(" ", "")));
            Console.WriteLine(Constants.getTemplateIdFromName(txtEditTemplateName.Text.Replace(" ", "")));
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

       

        private void saveChangeBtn_Click(object sender, EventArgs e)
        {
            if (mode == "code")
            {
                if (dropdownExistingCode.SelectedItem == null)
                {
                    lblEditError.Text = "Select a code to edit";
                    lblEditError.Show();
                }
                else if (txtEditCodeName.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a code name";
                    lblEditError.Show();
                }
                else if (txtEditCodeName.Text.Length > 5)
                {
                    lblEditError.Text = "Code name must be 5 characters or less";
                    lblEditError.Show();
                }
                else if (txtEditCodeName.Text.Contains(" "))
                {
                    lblEditError.Text = "Remove spaces from code name";
                    lblEditError.Show();
                }
                else if (codeParaEditBox.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a code paragraph";
                    lblEditError.Show();
                }
                else if (Constants.checkCode(txtEditCodeName.Text))
                {
                    if (txtEditCodeName.Text == dropdownExistingCode.SelectedItem.ToString())
                    {
                        SaveCodeChange();
                    }
                    else
                    {
                        lblEditError.Text = "A code with this name already exists";
                        lblEditError.Show();
                    }
                    
                }
                else
                {
                    SaveCodeChange();
                }
                
            }

            if (mode == "section")
            {
                if (dropdownExistingSection.SelectedItem == null)
                {
                    lblEditError.Text = "Select a section to edit";
                    lblEditError.Show();
                }
                else if (txtEditSectionName.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a section name";
                    lblEditError.Show();
                }
                else if (txtEditSectionName.Text.Contains(" "))
                {
                    lblEditError.Text = "Remove spaces from section name";
                    lblEditError.Show();
                }
                else if (Constants.checkSection(txtEditSectionName.Text))
                {
                    lblEditError.Text = "A section with this name already exists";
                    lblEditError.Show();
                }
                else
                {
                    lblEditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(dropdownExistingSection.Text));
                    DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                    var sectionId = dRow.ItemArray.GetValue(0);
                    Connection.GetDbConn().CreateCommand(Constants.editSection(sectionId, txtEditSectionName.Text.Replace(" ", "")));
                    //now we need to update the personalsection part
                    //for every template in case a template was deselected
                    UpdatePersonalSectionsForSection(sectionId);
                    ClearSectionModeFields();
                    lblEditSuccess.Text = "Section edit saved";
                    lblEditSuccess.Show();
                }
                
            }

            if (mode == "template")
            {
                if (dropdownExistingTemplate.SelectedItem == null)
                {
                    lblEditError.Text = "Select a template to edit";
                    lblEditError.Show();
                }
                else if (txtEditTemplateName.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a section name";
                    lblEditError.Show();
                }
                else if (txtEditTemplateName.Text.Contains(" "))
                {
                    lblEditError.Text = "Remove spaces from template name";
                    lblEditError.Show();
                }
                else if (Constants.checkTemplate(txtEditTemplateName.Text))
                {
                    lblEditError.Text = "A template with this name already exists";
                    lblEditError.Show();
                }
                else
                {
                    lblEditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(dropdownExistingTemplate.Text.Replace(" ", "")));
                    DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                    var templateId = dRow.ItemArray.GetValue(0);
                    Connection.GetDbConn().CreateCommand(Constants.editTemplate(templateId, txtEditTemplateName.Text));
                    UpdatePersonalSectionsForTemplate(templateId);
                    ClearTemplateModeFields();
                    lblEditSuccess.Text = "Template edit saved";
                    lblEditSuccess.Show();
                }
                
            }
            
            
        }

        private void SaveCodeChange()
        {
            lblEditError.Hide();
            //get the id of the old code and update the code short with the new one
            //update codepara with the new one
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeId(dropdownExistingCode.Text));
            DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
            var codeId = dRow.ItemArray.GetValue(0);
            Connection.GetDbConn().CreateCommand(Constants.editCode(codeId, txtEditCodeName.Text.ToUpper().Replace(" ", ""), codeParaEditBox.Text));
            codeParaEditBox.Clear();
            fillExistingDropDownWithCodes();
            dropDownForEdit.Items.Clear();
            txtEditCodeName.Text = "";

            lblEditSuccess.Text = "code edit saved";
            lblEditSuccess.Show();
        }

        private void ClearTempEditSectionCheckboxlist()
        {
            for (int i = 0; i < checkBoxForEdit.Items.Count; i++)
            {
                checkBoxForEdit.SetItemChecked(i, false);
            }
        }

        private void ClearSectionEditTempsCheckboxlist()
        {
            for (int i = 0; i < checkboxEditExistTemps.Items.Count; i++)
            {
                checkboxEditExistTemps.SetItemChecked(i, false);
            }
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


            for (int i = 0; i < checkboxEditExistTemps.Items.Count; i++) //for every item in check box, get its id. check if that checkbox is marked
            {
              
                string templateName = checkboxEditExistTemps.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(templateName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var templateId = dRow1.ItemArray.GetValue(0);
                if (checkboxEditExistTemps.GetItemCheckState(i) == CheckState.Checked)
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
                else if (checkboxEditExistTemps.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
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
            if (mode == "template")
            {
                ClearTemplateModeFields();
                dropdownExistingTemplate.Text = "";
                
            }
            else if (mode == "section")
            {
                ClearSectionModeFields();
                dropdownExistingSection.Text = "";
            }
            else if (mode == "code")
            {
                ClearCodeModeFields();
                dropDownForEdit.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (mode == "template")
            {
                // delete template

            }
            else if (mode == "section")
            {
                // delete section

            }
            else if (mode == "code")
            {
                // delete code

            }
        }

        private void btnModeTemplate_Click(object sender, EventArgs e)
        {
            mode = "template";
            LoadTempMode();
            SetModeButton(mode);
            SetModePanel(mode);
            ClearTemplateModeFields();
            
        }

        private void btnModeSection_Click(object sender, EventArgs e)
        {
            mode = "section";
            LoadSectionMode();
            SetModeButton(mode);
            SetModePanel(mode);
            ClearSectionModeFields();
        }

        private void btnModeCode_Click(object sender, EventArgs e)
        {
            mode = "code";
            LoadCodeMode();
            SetModeButton(mode);
            SetModePanel(mode);
            ClearCodeModeFields();
        }

        private void backBtnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cv = new codeViewForm();
            cv.Show();
        }

        private void dropdownExistingTemplate_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(dropdownExistingTemplate.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void txtNewTemplateName_TextChanged(object sender, EventArgs e)
        {
            lblAddSuccess.Hide();
            lblAddError.Hide();
        }

        private void SetModeButton(string type)
        {
            if (type == "template")
            {
                btnModeTemplate.BackColor = Color.FromArgb(83, 60, 182);
                btnModeTemplate.ForeColor = Color.White;

                btnModeSection.BackColor = Color.White;
                btnModeSection.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeCode.BackColor = Color.White;
                btnModeCode.ForeColor = Color.FromArgb(83, 60, 182);
            }
            else if (type == "section")
            {
                btnModeSection.BackColor = Color.FromArgb(83, 60, 182);
                btnModeSection.ForeColor = Color.White;

                btnModeTemplate.BackColor = Color.White;
                btnModeTemplate.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeCode.BackColor = Color.White;
                btnModeCode.ForeColor = Color.FromArgb(83, 60, 182);
            }
            else if (type == "code")
            {
                btnModeCode.BackColor = Color.FromArgb(83, 60, 182);
                btnModeCode.ForeColor = Color.White;

                btnModeSection.BackColor = Color.White;
                btnModeSection.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeTemplate.BackColor = Color.White;
                btnModeTemplate.ForeColor = Color.FromArgb(83, 60, 182);
            }


        }

        private void SetModePanel(string type)
        {
            if (type == "template")
            {
                panelAddTemplate.Show();
                panelEditTemplate.Show();
                panelAddSection.Hide();
                panelEditSection.Hide();
                panelAddCode.Hide();
                panelEditCode.Hide();
            }
            else if (type == "section")
            {
                panelAddTemplate.Hide();
                panelEditTemplate.Hide();
                panelAddSection.Show();
                panelEditSection.Show();
                panelAddCode.Hide();
                panelEditCode.Hide();

            }
            else if (type == "code")
            {
                panelAddTemplate.Hide();
                panelEditTemplate.Hide();
                panelAddSection.Hide();
                panelEditSection.Hide();
                panelAddCode.Show();
                panelEditCode.Show();
            }
        }

        private void ClearTemplateModeFields()
        {
            lblAddError.Hide();
            txtNewTemplateName.Clear();
            fillExistBoxWithSections();
            fillExistingDropDownWithTemplates();
            txtEditTemplateName.Clear();
            ClearTempEditSectionCheckboxlist();
        }

        private void ClearSectionModeFields()
        {
            lblAddError.Hide();
            txtNewSectionName.Clear();
            fillExistBoxWithTemplates();
            fillExistingDropDownWithSections();
            txtEditSectionName.Clear();
            ClearSectionEditTempsCheckboxlist();
        }

        private void ClearCodeModeFields()
        {
            lblAddError.Hide();
            txtNewCodeName.Clear();
            codeParaEditBox.Clear();
            fillExistingDropDownWithCodes();
            txtEditCodeName.Clear();
            dropDownForEdit.Items.Clear();
        }

        private void LoadSectionMode()
        {
            fillExistBoxWithTemplates();
            fillExistingDropDownWithSections();
        }

        private void LoadTempMode()
        {
            fillExistingDropDownWithTemplates();
            fillExistBoxWithSections();
        }

        private void LoadCodeMode()
        {
            fillNewCodeTagDrop();
            fillExistBoxWithSections();
            fillExistingDropDownWithCodes();
        }

        private void txtNewSectionName_TextChanged(object sender, EventArgs e)
        {
            lblAddSuccess.Hide();
            lblAddError.Hide();
        }

        private void dropdownExistingSection_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(dropdownExistingSection.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void dropdownExistingSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditSectionName.Text = dropdownExistingSection.Text.Replace(" ", "");
            //if we're editing sections, we need the checkbox to be populated with templates
            //change check list to display templates checkboxEditExistTemps needs to change if the existingDropDown changes

            lblEditSuccess.Hide();
            lblEditError.Hide();

            checkboxEditExistTemps.Items.Clear(); // clear out old info (if any)
            Template.templates.Clear();
            // we will use the selected section name to get the selected section's's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(dropdownExistingSection.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            var sectionId = dRow.ItemArray.GetValue(0);
            // we need to populate the sectionsListBox 
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                string tempNameToAdd = Template.templates[i].TempType.Replace(" ", "");
                int tempId = Template.templates[i].Id;
                checkboxEditExistTemps.Items.Add($"{tempNameToAdd}");
                //if there is a PersonalSection object with this template id and this section id, set checked to true
                DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");
                try
                {
                    DataRow dRow1 = ds1.Tables[0].Rows[0];

                    if (dRow1 != null)
                    {
                        checkboxEditExistTemps.SetItemChecked(i, true);
                    }
                }
                catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch

            }
        }

        private void dropdownExistingCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditCodeName.Text = dropdownExistingCode.Text.Replace(" ", "");

            lblEditSuccess.Hide();
            lblEditError.Hide();

            dropDownForEdit.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                dropDownForEdit.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
            }
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeParaFromShort(dropdownExistingCode.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            txtEditCodeName.Text = dropdownExistingCode.Text.Replace(" ", "");
            codeParaEditBox.Text = dRow.ItemArray.GetValue(0).ToString();
        }

        private void dropdownExistingCode_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(dropdownExistingCode.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void dropDownForEdit_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(dropDownForEdit.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void newCodeSection_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(newCodeSection.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void txtNewCodeName_TextChanged(object sender, EventArgs e)
        {
            lblAddSuccess.Hide();
            lblAddError.Hide();
        }

        private void txtEditSectionName_TextChanged(object sender, EventArgs e)
        {
            lblEditSuccess.Hide();
            lblEditError.Hide();
        }
    }
}
