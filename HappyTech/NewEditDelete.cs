/**
 * 
 * File: NewEditDelete.cs
 * 
 * Author 1: Hopper, Kean. SID (EMAIL)
 * Author 2: Osborne, Oliver. 1602819 (OMO123@student.aru.ac.uk)
 * Course: BEng (Hons) Computer Science, Year 2 Timester 1
 * 
 * Summary:     This file allows the user to create, edit, and delete 
 *              templates, sections, and codes. These are then saved
 *              and updated in the database.
 * 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class NewEditDelete : Form
    {
        // Sets the available modes

        public enum Mode
        {
            Template,
            Section,
            Code
        }

        // Sets the default form start mode to template.

        private static readonly Mode DEFAULT_MODE = Mode.Template;
        private Mode currentMode = DEFAULT_MODE;

        /// <summary>
        /// 
        ///     Default constructor. Creates all form component
        ///     objects and sets it up for the default start mode. 
        /// 
        /// </summary>
        public NewEditDelete()
        {
            InitializeComponent();

            switch ( DEFAULT_MODE )
            {
                case Mode.Template:

                    LoadModeTemplate();

                    break;

                case Mode.Section:

                    LoadModeSection();

                    break;

                case Mode.Code:

                    LoadModeCode();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Alternate start mode constructor. Creates all form
        ///     component objects and sets it up for the supplied 
        ///     mode. Not used, intended for future options 
        ///     functionality.
        /// 
        /// </summary>
        /// <param name="alternateStartMode"> The alternative mode to start the form in. </param>
        public NewEditDelete( Mode alternateStartMode )
        {
            InitializeComponent();

            switch ( alternateStartMode )
            {
                case Mode.Template:

                    LoadModeTemplate();

                    break;

                case Mode.Section:

                    LoadModeSection();

                    break;

                case Mode.Code:

                    LoadModeCode();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Populates the contents of the existing templates
        ///     checkbox list for adding the new section to.
        /// 
        /// </summary>
        private void Populate_CheckedListBox_NewSectionExistingTemplates()
        {
            CheckedListBox_NewSectionExistingTemplates.Items.Clear();

            UpdateList("Template");

            for (int i = 0; i < Template.templates.Count(); i++)
            {
                CheckedListBox_NewSectionExistingTemplates.Items.
                    Add($"{Template.templates[i].TempType}");
            }
        }

        /// <summary>
        /// 
        ///     Populates the contents of the existing templates
        ///     dropdown list to edit.
        /// 
        /// </summary>
        private void Populate_ComboBox_EditExistingTemplate()
        {
            ComboBox_EditExistingTemplate.Items.Clear();

            UpdateList("Template");

            for (int i = 0; i < Template.templates.Count(); i++)
            {
                ComboBox_EditExistingTemplate.Items.
                    Add($"{Template.templates[i].TempType}");
            }
        }

        /// <summary>
        ///     
        ///     Populates the contents of the existing sections
        ///     dropdown list for adding the new code to.   
        /// 
        /// </summary>
        private void Populate_ComboBox_NewCodeSection()
        {
            ComboBox_NewCodeSection.Items.Clear();

            UpdateList( "Section" );

            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                ComboBox_NewCodeSection.Items.
                    Add( $"{Sections.sectionList[i].name.Replace( " ", "" )}" );
            }
        }

        /// <summary>
        /// 
        ///     Populates the contents of the existing sections
        ///     checkbox list for adding the new template to.
        /// 
        /// </summary>
        private void Populate_CheckedListBox_NewTemplateExistingSection()
        {
            CheckedListBox_NewTemplateExistingSection.Items.Clear();

            UpdateList( "Section" );

            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                CheckedListBox_NewTemplateExistingSection.Items.
                    Add( $"{Sections.sectionList[i].name.Replace( " ", "" )}" );
            }
        }

        /// <summary>
        /// 
        ///     Populates the contents of the existing sections
        ///     dropdown list to edit.
        /// 
        /// </summary>
        private void Populate_ComboBox_EditExistingSections()
        {
            ComboBox_EditExistingSections.Items.Clear();

            UpdateList( "Section" );

            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                ComboBox_EditExistingSections.Items.
                    Add( $"{Sections.sectionList[i].name.Replace( " ", "" )}" );
            }
        }

        /// <summary>
        /// 
        ///     Populates the contents of the existing codes
        ///     dropdown list to edit.
        /// 
        /// </summary>
        private void Populate_ComboBox_EditExistingCode()
        {
            ComboBox_EditExistingCode.Items.Clear();

            UpdateList( "Code" );

            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                ComboBox_EditExistingCode.Items.
                    Add( $"{Code.codeList[i].CodeName.Replace(" ", "")}" );
            }
        }

        private void Button_SaveNew_Click(object sender, EventArgs e)
        {
            switch ( currentMode )
            {
                case Mode.Template:

                    if ( txtNewTemplateName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a template name", "NewArea" );
                    }
                    else if ( txtNewTemplateName.Text.Length > 25 )
                    {
                        DisplayError( "Template name limit exceeded", "NewArea" );
                    }
                    else if ( Constants.checkTemplate( txtNewTemplateName.Text ) )
                    {
                        DisplayError( "A template with this name already exists", "NewArea" );
                    }
                    else
                    {
                        HideError( "NewArea" );

                        string templateName = txtNewTemplateName.Text.Replace( " ", "" );
                        Template.CreateTemplateWithSelectedSections( templateName,
                            CheckedListBox_NewTemplateExistingSection );
                        
                        ClearTemplateModeFields();

                        DisplaySuccess( "New template saved", "NewArea" );
                    }

                    break;

                case Mode.Section:

                    if (txtNewSectionName.Text.Length <= 0)
                    {
                        DisplayError( "Enter a section name", "NewArea" );
                    }
                    else if (txtNewSectionName.Text.Length > 25)
                    {
                        DisplayError( "Section name limit exceeded", "NewArea" );
                    }
                    else if (Constants.checkSection(txtNewSectionName.Text))
                    {
                        DisplayError( "A section with this name already exists", "NewArea" );
                    }
                    else
                    {
                        HideError( "NewArea" );

                        string sectionName = txtNewSectionName.Text.Replace(" ", "");
                        Sections.InsertSectionWithSelectedTemplates(sectionName,
                            CheckedListBox_NewSectionExistingTemplates);
                        ClearSectionModeFields();
                        
                        DisplaySuccess( "New section saved", "NewArea" );

                    }
                    break;

                case Mode.Code:

                    if (txtNewCodeName.Text.Length <= 0)
                    {
                        DisplayError( "Enter a code name", "NewArea" );
                    }
                    else if (txtNewCodeName.Text.Length > 5)
                    {
                        DisplayError( "Code name limit exceeded", "NewArea" );
                    }
                    else if (newCodeParaBox.Text.Length <= 0)
                    {
                        DisplayError( "Enter a code paragraph", "NewArea" );
                    }
                    else if (newCodeParaBox.Text.Length > 300)
                    {
                        DisplayError( "Code paragraph limit exceeded", "NewArea" );
                    }
                    else if (txtNewCodeName.Text.Contains(" "))
                    {
                        DisplayError( "Remove spaces from code name", "NewArea" );
                    }
                    else if (ComboBox_NewCodeSection.SelectedItem == null)
                    {
                        DisplayError( "Select a section to add to", "NewArea" );
                    }
                    else if (Constants.checkCode(txtNewCodeName.Text))
                    {
                        DisplayError( "A code with this name already exists", "NewArea" );
                    }
                    else
                    {
                        HideError( "NewArea" );

                        DataSet sectionDB = Connection.GetDbConn().getDataSet(Constants.
                            getTagIdFromName(ComboBox_NewCodeSection.Text));

                        DataRow sectionValue = sectionDB.Tables[0].Rows[0];
                        
                        var sectionId = sectionValue.ItemArray.GetValue(0);
                        string newCodeName = txtNewCodeName.Text.ToUpper().Replace(" ", "");
                        string newCodeParagraph = newCodeParaBox.Text;

                        Connection.GetDbConn().CreateCommand(Constants.
                            insertNewCode(newCodeName, newCodeParagraph, sectionId));

                        txtNewCodeName.Clear();
                        newCodeParaBox.Text = "";
                        ComboBox_NewCodeSection.Text = "";

                        Populate_ComboBox_EditExistingCode();

                        DisplaySuccess( "New code saved", "NewArea" );
                    }
                    break;
            }
        }

        private void ComboBox_EditExistingTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditTemplateName.Text = ComboBox_EditExistingTemplate.Text.Replace(" ", "");

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
            if (currentMode == Mode.Code)
            {
                if (ComboBox_EditExistingCode.SelectedItem == null)
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
                    lblEditError.Text = "Code name limit exceeded";
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
                else if (codeParaEditBox.Text.Length > 300)
                {
                    lblEditError.Text = "Code paragraph limit exceeded";
                    lblEditError.Show();
                }
                else if (Constants.checkCode(txtEditCodeName.Text))
                {
                    if (txtEditCodeName.Text == ComboBox_EditExistingCode.SelectedItem.ToString())
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

            if (currentMode == Mode.Section)
            {
                if (ComboBox_EditExistingSections.SelectedItem == null)
                {
                    lblEditError.Text = "Select a section to edit";
                    lblEditError.Show();
                }
                else if (txtEditSectionName.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a section name";
                    lblEditError.Show();
                }
                else if (txtEditSectionName.Text.Length > 25)
                {
                    lblAddError.Text = "Section name must be 25 characters or less";
                    lblAddError.Show();
                }
                else if (Constants.checkSection(txtEditSectionName.Text))
                {
                    lblEditError.Text = "A section with this name already exists";
                    lblEditError.Show();
                }
                else
                {
                    lblEditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(ComboBox_EditExistingSections.Text));
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

            if (currentMode == Mode.Template)
            {
                if (ComboBox_EditExistingTemplate.SelectedItem == null)
                {
                    lblEditError.Text = "Select a template to edit";
                    lblEditError.Show();
                }
                else if (txtEditTemplateName.Text.Length <= 0)
                {
                    lblEditError.Text = "Enter a section name";
                    lblEditError.Show();
                }
                else if (txtEditTemplateName.Text.Length > 25)
                {
                    lblAddError.Text = "Template name must be 25 characters or less";
                    lblAddError.Show();
                }
                else if (Constants.checkTemplate(txtEditTemplateName.Text))
                {
                    lblEditError.Text = "A template with this name already exists";
                    lblEditError.Show();
                }
                else
                {
                    lblEditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(ComboBox_EditExistingTemplate.Text.Replace(" ", "")));
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
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeId(ComboBox_EditExistingCode.Text));
            DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
            var codeId = dRow.ItemArray.GetValue(0);
            Connection.GetDbConn().CreateCommand(Constants.editCode(codeId, txtEditCodeName.Text.ToUpper().Replace(" ", ""), codeParaEditBox.Text));
            codeParaEditBox.Clear();
            Populate_ComboBox_EditExistingCode();
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
            if (currentMode == Mode.Template)
            {
                ClearTemplateModeFields();
                ComboBox_EditExistingTemplate.Text = "";
                
            }
            else if (currentMode == Mode.Section)
            {
                ClearSectionModeFields();
                ComboBox_EditExistingSections.Text = "";
            }
            else if (currentMode == Mode.Code)
            {
                ClearCodeModeFields();
                dropDownForEdit.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Template)
            {
                // delete template

            }
            else if (currentMode == Mode.Section)
            {
                // delete section

            }
            else if (currentMode == Mode.Code)
            {
                // delete code

            }
        }

        private void btnModeTemplate_Click(object sender, EventArgs e)
        {
            currentMode = Mode.Template;
            LoadModeTemplate();
            SetModeButton(currentMode);
            SetModePanel(currentMode);
            ClearTemplateModeFields();
            
        }

        private void btnModeSection_Click(object sender, EventArgs e)
        {
            currentMode = Mode.Section;
            LoadModeSection();
            SetModeButton(currentMode);
            SetModePanel(currentMode);
            ClearSectionModeFields();
        }

        private void btnModeCode_Click(object sender, EventArgs e)
        {
            currentMode = Mode.Code;
            LoadModeCode();
            SetModeButton(currentMode);
            SetModePanel(currentMode);
            ClearCodeModeFields();
        }

        private void backBtnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cv = new codeViewForm();
            cv.Show();
        }

        private void ComboBox_EditExistingTemplate_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_EditExistingTemplate.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't be drawn because it does not exist.", e.ToString());
            }
        }

        private void txtNewTemplateName_TextChanged(object sender, EventArgs e)
        {
            lblAddSuccess.Hide();
            lblAddError.Hide();
        }

        private void SetModeButton(Mode mode)
        {
            if (mode == Mode.Template)
            {
                btnModeTemplate.BackColor = Color.FromArgb(83, 60, 182);
                btnModeTemplate.ForeColor = Color.White;

                btnModeSection.BackColor = Color.White;
                btnModeSection.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeCode.BackColor = Color.White;
                btnModeCode.ForeColor = Color.FromArgb(83, 60, 182);
            }
            else if (mode == Mode.Section)
            {
                btnModeSection.BackColor = Color.FromArgb(83, 60, 182);
                btnModeSection.ForeColor = Color.White;

                btnModeTemplate.BackColor = Color.White;
                btnModeTemplate.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeCode.BackColor = Color.White;
                btnModeCode.ForeColor = Color.FromArgb(83, 60, 182);
            }
            else if (mode == Mode.Code)
            {
                btnModeCode.BackColor = Color.FromArgb(83, 60, 182);
                btnModeCode.ForeColor = Color.White;

                btnModeSection.BackColor = Color.White;
                btnModeSection.ForeColor = Color.FromArgb(83, 60, 182);

                btnModeTemplate.BackColor = Color.White;
                btnModeTemplate.ForeColor = Color.FromArgb(83, 60, 182);
            }


        }

        private void SetModePanel(Mode mode)
        {
            if (mode == Mode.Template)
            {
                panelAddTemplate.Show();
                panelEditTemplate.Show();
                panelAddSection.Hide();
                panelEditSection.Hide();
                panelAddCode.Hide();
                panelEditCode.Hide();
            }
            else if (mode == Mode.Section)
            {
                panelAddTemplate.Hide();
                panelEditTemplate.Hide();
                panelAddSection.Show();
                panelEditSection.Show();
                panelAddCode.Hide();
                panelEditCode.Hide();

            }
            else if (mode == Mode.Code)
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
            Populate_CheckedListBox_NewTemplateExistingSection();
            Populate_ComboBox_EditExistingTemplate();
            txtEditTemplateName.Clear();
            ClearTempEditSectionCheckboxlist();
        }

        private void ClearSectionModeFields()
        {
            lblAddError.Hide();
            txtNewSectionName.Clear();
            Populate_CheckedListBox_NewSectionExistingTemplates();
            Populate_ComboBox_EditExistingSections();
            txtEditSectionName.Clear();
            ClearSectionEditTempsCheckboxlist();
        }

        private void ClearCodeModeFields()
        {
            lblAddError.Hide();
            txtNewCodeName.Clear();
            codeParaEditBox.Clear();
            Populate_ComboBox_EditExistingCode();
            txtEditCodeName.Clear();
            dropDownForEdit.Items.Clear();
        }

        private void LoadModeSection()
        {
            Populate_CheckedListBox_NewSectionExistingTemplates();
            Populate_ComboBox_EditExistingSections();
        }

        private void LoadModeTemplate()
        {
            Populate_ComboBox_EditExistingTemplate();
            Populate_CheckedListBox_NewTemplateExistingSection();
        }

        private void LoadModeCode()
        {
            Populate_ComboBox_NewCodeSection();
            Populate_CheckedListBox_NewTemplateExistingSection();
            Populate_ComboBox_EditExistingCode();
        }

        private void txtNewSectionName_TextChanged(object sender, EventArgs e)
        {
            lblAddSuccess.Hide();
            lblAddError.Hide();
        }

        private void ComboBox_EditExistingSections_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_EditExistingSections.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't be drawn because it does not exist.", e.ToString());
            }
        }

        private void ComboBox_EditExistingSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditSectionName.Text = ComboBox_EditExistingSections.Text.Replace(" ", "");
            //if we're editing sections, we need the checkbox to be populated with templates
            //change check list to display templates checkboxEditExistTemps needs to change if the existingDropDown changes

            lblEditSuccess.Hide();
            lblEditError.Hide();

            checkboxEditExistTemps.Items.Clear(); // clear out old info (if any)
            Template.templates.Clear();
            // we will use the selected section name to get the selected section's's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(ComboBox_EditExistingSections.Text.Replace(" ", "")));
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

        private void ComboBox_EditExistingCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditCodeName.Text = ComboBox_EditExistingCode.Text.Replace(" ", "");

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
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeParaFromShort(ComboBox_EditExistingCode.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            txtEditCodeName.Text = ComboBox_EditExistingCode.Text.Replace(" ", "");
            codeParaEditBox.Text = dRow.ItemArray.GetValue(0).ToString();
        }

        private void ComboBox_EditExistingCode_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_EditExistingCode.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't be drawn because it does not exist.", e.ToString());
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

        private void ComboBox_NewCodeSection_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_NewCodeSection.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
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

            lblCodeNameLimit.Text = $"({txtNewCodeName.Text.Length} / 5)";
            if (txtNewCodeName.Text.Length > 5)
            {
                lblCodeNameLimit.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                lblCodeNameLimit.ForeColor = Color.FromArgb(119, 119, 136);
            }
        }

        private void txtEditSectionName_TextChanged(object sender, EventArgs e)
        {
            lblEditSuccess.Hide();
            lblEditError.Hide();
        }

        private void codeParaEditBox_TextChanged(object sender, EventArgs e)
        {
            lblEditCodeParaLimit.Text = $"({codeParaEditBox.Text.Length} / 300)";
            if (codeParaEditBox.Text.Length > 300)
            {
                lblEditCodeParaLimit.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                lblEditCodeParaLimit.ForeColor = Color.FromArgb(119, 119, 136);
            }
        }

        private void newCodeParaBox_TextChanged(object sender, EventArgs e)
        {
            lblCodeParaLimit.Text = $"({newCodeParaBox.Text.Length} / 300)";
            if (newCodeParaBox.Text.Length > 300)
            {
                lblCodeParaLimit.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                lblCodeParaLimit.ForeColor = Color.FromArgb(119, 119, 136);
            }
        }

        private void txtEditCodeName_TextChanged(object sender, EventArgs e)
        {
            lblEditCodeNameLimit.Text = $"({txtEditCodeName.Text.Length} / 5)";
            if (txtEditCodeName.Text.Length > 5)
            {
                lblEditCodeNameLimit.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                lblEditCodeNameLimit.ForeColor = Color.FromArgb(119, 119, 136);
            }
        }

        /// <summary>
        /// 
        ///     Clear the object list and fill it from the database again.
        /// 
        /// </summary>
        /// <param name="type"> Which object list to update: Template, Section, or Code </param>
        private void UpdateList( string type )
        {
            switch ( type )
            {
                case "Template":

                    Template.templates.Clear();
                    Template.listTemplates();

                    break;

                case "Section":

                    Sections.sectionList.Clear();
                    Sections.listSection();

                    break;

                case "Code":

                    Code.codeList.Clear();
                    Code.fillCodeList();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Display an error at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="message"> The error message </param>
        /// <param name="area"> The area to display the error to </param>
        private void DisplayError( string message, string area)
        {
            switch ( area )
            {
                case "NewArea":

                    lblAddError.Text = message;
                    lblAddError.Show();

                    break;

                case "EditArea":

                    lblEditError.Text = message;
                    lblEditError.Show();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Hide the error at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="area"> The area to hide the error from </param>
        private void HideError(string area)
        {
            switch (area)
            {
                case "NewArea":

                    lblAddError.Hide();

                    break;

                case "EditArea":

                    lblEditError.Hide();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Display a success message at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="message"> The success message </param>
        /// <param name="area"> The area to display the success message to </param>
        private void DisplaySuccess(string message, string area)
        {
            switch (area)
            {
                case "NewArea":

                    lblAddSuccess.Text = message;
                    lblAddSuccess.Show();

                    break;

                case "EditArea":

                    lblEditSuccess.Text = message;
                    lblEditSuccess.Show();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Hide the success message at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="area"> The area to hide the success message from </param>
        private void HideSuccess(string area)
        {
            switch (area)
            {
                case "NewArea":

                    lblAddSuccess.Hide();

                    break;

                case "EditArea":

                    lblEditSuccess.Hide();

                    break;
            }
        }
    }
}
