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
            CheckedListBox_NewSectionExistingTemplate.Items.Clear();

            UpdateList( "Template" );

            for ( int i = 0; i < Template.templates.Count(); i++ )
            {
                CheckedListBox_NewSectionExistingTemplate.Items.
                    Add( $"{Template.templates[i].TempType}" );
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
            ComboBox_EditTemplateChooseExisting.Items.Clear();

            UpdateList( "Template" );

            for ( int i = 0; i < Template.templates.Count(); i++ )
            {
                ComboBox_EditTemplateChooseExisting.Items.
                    Add( $"{Template.templates[i].TempType}" );
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

            for ( int i = 0; i < Sections.sectionList.Count(); i++ )
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
            ComboBox_EditSectionChooseExisting.Items.Clear();

            UpdateList( "Section" );

            for ( int i = 0; i < Sections.sectionList.Count(); i++ )
            {
                ComboBox_EditSectionChooseExisting.Items.
                    Add( $"{Sections.sectionList[i].name.Replace( " ", "" )}" );
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

            for ( int i = 0; i < Sections.sectionList.Count(); i++ )
            {
                ComboBox_NewCodeSection.Items.
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
            ComboBox_EditCodeChooseExisting.Items.Clear();

            UpdateList( "Code" );

            for ( int i = 0; i < Code.codeList.Count(); i++ )
            {
                ComboBox_EditCodeChooseExisting.Items.
                    Add( $"{Code.codeList[i].CodeName.Replace( " ", "" )}" );
            }
        }

        /// <summary>
        ///     
        ///     Populates the contents of the existing sections
        ///     dropdown list for adding the edited code to.   
        /// 
        /// </summary>
        private void Populate_ComboBox_EditCodeSection()
        {
            ComboBox_EditCodeSection.Items.Clear();

            UpdateList( "Section" );

            for ( int i = 0; i < Sections.sectionList.Count(); i++ )
            {
                ComboBox_EditCodeSection.Items.
                    Add( $"{Sections.sectionList[i].name.Replace( " ", "" )}" );
            }
        }

        /// <summary>
        /// 
        ///     Trigger function for clicking the new area save
        ///     button. This will check the field requirements for
        ///     the current mode. If all errors are avoided, the
        ///     template, section, or code will be added to the database.
        /// 
        /// </summary>
        private void Button_NewSave_Click( object sender, EventArgs e )
        {
            switch ( currentMode )
            {
                case Mode.Template:

                    /* 
                     * Check template field requirements:
                     *      - Template name
                     *      - Template name less than or at max length: 25
                     *      - Template name not already in database    
                     */

                    if ( TextBox_NewTemplateName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a template name", "NewArea" );
                    }
                    else if ( TextBox_NewTemplateName.Text.Length > 25 )
                    {
                        DisplayError( "Template name limit exceeded", "NewArea" );
                    }
                    else if ( Constants.checkTemplate( TextBox_NewTemplateName.Text ) )
                    {
                        DisplayError( "A template with this name already exists", "NewArea" );
                    }

                    /* 
                     * Add template to database, reset fields, display success.
                     */

                    else
                    {
                        string templateName = TextBox_NewTemplateName.Text.Replace( " ", "" );
                        Template.CreateTemplateWithSelectedSections( templateName,
                            CheckedListBox_NewTemplateExistingSection );
                        
                        ClearTemplateModeFields();

                        DisplaySuccess( "New template saved", "NewArea" );
                    }

                    break;

                case Mode.Section:

                    /* 
                     * Check section field requirements:
                     *      - Section name
                     *      - Section name less than or at max length: 25
                     *      - Section name not already in database    
                     */

                    if ( TextBox_NewSectionName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a section name", "NewArea" );
                    }
                    else if ( TextBox_NewSectionName.Text.Length > 25 )
                    {
                        DisplayError( "Section name limit exceeded", "NewArea" );
                    }
                    else if ( Constants.checkSection( TextBox_NewSectionName.Text ) )
                    {
                        DisplayError( "A section with this name already exists", "NewArea" );
                    }

                    /* 
                     * Add section to database, reset fields, display success.
                     */

                    else
                    {
                        string sectionName = TextBox_NewSectionName.Text.Replace( " ", "" );
                        Sections.InsertSectionWithSelectedTemplates( sectionName,
                            CheckedListBox_NewSectionExistingTemplate );

                        ClearSectionModeFields();
                        
                        DisplaySuccess( "New section saved", "NewArea" );
                    }
                    break;

                case Mode.Code:

                    /* 
                     * Check code field requirements:
                     *      - Code name
                     *      - Code name less than or at max length: 5
                     *      - Code paragraph
                     *      - Code paragraph less than or at max length: 300
                     *      - Code name contains no spaces
                     *      - Code attached to a section
                     *      - Code name not already in database
                     */

                    if ( TextBox_NewCodeName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a code name", "NewArea" );
                    }
                    else if ( TextBox_NewCodeName.Text.Length > 5 )
                    {
                        DisplayError( "Code name limit exceeded", "NewArea" );
                    }
                    else if ( RichTextBox_NewCodeParagraph.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a code paragraph", "NewArea" );
                    }
                    else if ( RichTextBox_NewCodeParagraph.Text.Length > 300 )
                    {
                        DisplayError( "Code paragraph limit exceeded", "NewArea" );
                    }
                    else if ( TextBox_NewCodeName.Text.Contains( " " ) )
                    {
                        DisplayError( "Remove spaces from code name", "NewArea" );
                    }
                    else if ( ComboBox_NewCodeSection.SelectedItem == null )
                    {
                        DisplayError( "Select a section to add to", "NewArea" );
                    }
                    else if ( Constants.checkCode( TextBox_NewCodeName.Text ) )
                    {
                        DisplayError( "A code with this name already exists", "NewArea" );
                    }

                    /* 
                     * Add code to database, reset fields, display success.
                     */

                    else
                    {
                        DataSet sectionDB       = Connection.GetDbConn().getDataSet( Constants.
                                                    getTagIdFromName( ComboBox_NewCodeSection.Text ) );

                        DataRow sectionDBValue  = sectionDB.Tables[0].Rows[0];
                        
                        object sectionId        = sectionDBValue.ItemArray.GetValue( 0 );
                        string newCodeName      = TextBox_NewCodeName.Text.ToUpper().Replace( " ", "" );
                        string newCodeParagraph = RichTextBox_NewCodeParagraph.Text;

                        Connection.GetDbConn().CreateCommand( Constants.
                            insertNewCode( newCodeName, newCodeParagraph, sectionId ) );

                        ClearCodeModeFields();

                        DisplaySuccess( "New code saved", "NewArea" );
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void Button_EditSave_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Code)
            {
                if (ComboBox_EditCodeChooseExisting.SelectedItem == null)
                {
                    Label_EditError.Text = "Select a code to edit";
                    Label_EditError.Show();
                }
                else if (TextBox_EditCodeName.Text.Length <= 0)
                {
                    Label_EditError.Text = "Enter a code name";
                    Label_EditError.Show();
                }
                else if (TextBox_EditCodeName.Text.Length > 5)
                {
                    Label_EditError.Text = "Code name limit exceeded";
                    Label_EditError.Show();
                }
                else if (TextBox_EditCodeName.Text.Contains(" "))
                {
                    Label_EditError.Text = "Remove spaces from code name";
                    Label_EditError.Show();
                }
                else if (RichTextBox_EditCodeParagraph.Text.Length <= 0)
                {
                    Label_EditError.Text = "Enter a code paragraph";
                    Label_EditError.Show();
                }
                else if (RichTextBox_EditCodeParagraph.Text.Length > 300)
                {
                    Label_EditError.Text = "Code paragraph limit exceeded";
                    Label_EditError.Show();
                }
                else if (Constants.checkCode(TextBox_EditCodeName.Text))
                {
                    if (TextBox_EditCodeName.Text == ComboBox_EditCodeChooseExisting.SelectedItem.ToString())
                    {
                        SaveCodeChange();
                    }
                    else
                    {
                        Label_EditError.Text = "A code with this name already exists";
                        Label_EditError.Show();
                    }

                }
                else
                {
                    SaveCodeChange();
                }

            }

            if (currentMode == Mode.Section)
            {
                if (ComboBox_EditSectionChooseExisting.SelectedItem == null)
                {
                    Label_EditError.Text = "Select a section to edit";
                    Label_EditError.Show();
                }
                else if (TextBox_EditSectionName.Text.Length <= 0)
                {
                    Label_EditError.Text = "Enter a section name";
                    Label_EditError.Show();
                }
                else if (TextBox_EditSectionName.Text.Length > 25)
                {
                    Label_NewError.Text = "Section name must be 25 characters or less";
                    Label_NewError.Show();
                }
                else if (Constants.checkSection(TextBox_EditSectionName.Text))
                {
                    Label_EditError.Text = "A section with this name already exists";
                    Label_EditError.Show();
                }
                else
                {
                    Label_EditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(ComboBox_EditSectionChooseExisting.Text));
                    DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                    var sectionId = dRow.ItemArray.GetValue(0);
                    Connection.GetDbConn().CreateCommand(Constants.editSection(sectionId, TextBox_EditSectionName.Text.Replace(" ", "")));
                    //now we need to update the personalsection part
                    //for every template in case a template was deselected
                    UpdatePersonalSectionsForSection(sectionId);
                    ClearSectionModeFields();
                    Label_EditSuccess.Text = "Section edit saved";
                    Label_EditSuccess.Show();
                }

            }

            if (currentMode == Mode.Template)
            {
                if (ComboBox_EditTemplateChooseExisting.SelectedItem == null)
                {
                    Label_EditError.Text = "Select a template to edit";
                    Label_EditError.Show();
                }
                else if (TextBox_EditTemplateName.Text.Length <= 0)
                {
                    Label_EditError.Text = "Enter a section name";
                    Label_EditError.Show();
                }
                else if (TextBox_EditTemplateName.Text.Length > 25)
                {
                    Label_NewError.Text = "Template name must be 25 characters or less";
                    Label_NewError.Show();
                }
                else if (Constants.checkTemplate(TextBox_EditTemplateName.Text))
                {
                    Label_EditError.Text = "A template with this name already exists";
                    Label_EditError.Show();
                }
                else
                {
                    Label_EditError.Hide();
                    DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(ComboBox_EditTemplateChooseExisting.Text.Replace(" ", "")));
                    DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                    var templateId = dRow.ItemArray.GetValue(0);
                    Connection.GetDbConn().CreateCommand(Constants.editTemplate(templateId, TextBox_EditTemplateName.Text));
                    UpdatePersonalSectionsForTemplate(templateId);
                    ClearTemplateModeFields();
                    Label_EditSuccess.Text = "Template edit saved";
                    Label_EditSuccess.Show();
                }

            }


        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void ComboBox_EditTemplateChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            TextBox_EditTemplateName.Text = ComboBox_EditTemplateChooseExisting.Text.Replace( " ", "" );

            HideSuccess( "EditArea" );
            HideError( "EditArea" );
                
            //change check list to display templates
            CheckedListBox_EditTemplateSection.Items.Clear(); // clear out old sections
            Sections.sectionList.Clear();
            // we will use the selected template name to get the selected template's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(TextBox_EditTemplateName.Text.Replace(" ", "")));
            Console.WriteLine(Constants.getTemplateIdFromName(TextBox_EditTemplateName.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            var templateId = dRow.ItemArray.GetValue(0);
            // we need to populate the sectionsListBox 
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                string sectionNameToAdd = Sections.sectionList[i].name.Replace(" ", "");
                int sectionId = Sections.sectionList[i].id;
                CheckedListBox_EditTemplateSection.Items.Add($"{sectionNameToAdd}");
                //if there is a PersonalSection object with this template id and this section id, set checked to true
                DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");
                try
                {
                    DataRow dRow1 = ds1.Tables[0].Rows[0];

                    if (dRow1 != null)
                    {
                        CheckedListBox_EditTemplateSection.SetItemChecked(i, true);
                    }
                }
                catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch
            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void SaveCodeChange()
        {
            Label_EditError.Hide();
            //get the id of the old code and update the code short with the new one
            //update codepara with the new one
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeId(ComboBox_EditCodeChooseExisting.Text));
            DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
            var codeId = dRow.ItemArray.GetValue(0);
            Connection.GetDbConn().CreateCommand(Constants.editCode(codeId, TextBox_EditCodeName.Text.ToUpper().Replace(" ", ""), RichTextBox_EditCodeParagraph.Text));
            RichTextBox_EditCodeParagraph.Clear();
            Populate_ComboBox_EditExistingCode();
            ComboBox_EditCodeSection.Items.Clear();
            TextBox_EditCodeName.Text = "";

            Label_EditSuccess.Text = "code edit saved";
            Label_EditSuccess.Show();
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void ClearTempEditSectionCheckboxlist()
        {
            for (int i = 0; i < CheckedListBox_EditTemplateSection.Items.Count; i++)
            {
                CheckedListBox_EditTemplateSection.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void ClearSectionEditTempsCheckboxlist()
        {
            for (int i = 0; i < CheckedListBox_EditSectionTemplate.Items.Count; i++)
            {
                CheckedListBox_EditSectionTemplate.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        /// <param name="tempId">  </param>
        private void UpdatePersonalSectionsForTemplate(object tempId)
        {
            for (int i = 0; i < CheckedListBox_EditTemplateSection.Items.Count; i++) //for every item in check box, get its id. check if that checkbox is marked
            {
                string sectionName = CheckedListBox_EditTemplateSection.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(sectionName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);

                if (CheckedListBox_EditTemplateSection.GetItemCheckState(i) == CheckState.Checked)
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
                else if (CheckedListBox_EditTemplateSection.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
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

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        /// <param name="sectId">  </param>
        private void UpdatePersonalSectionsForSection(object sectId)
        {
            for (int i = 0; i < CheckedListBox_EditSectionTemplate.Items.Count; i++) //for every item in check box, get its id. check if that checkbox is marked
            {
                string templateName = CheckedListBox_EditSectionTemplate.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(templateName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var templateId = dRow1.ItemArray.GetValue(0);

                if (CheckedListBox_EditSectionTemplate.GetItemCheckState(i) == CheckState.Checked)
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
                else if (CheckedListBox_EditSectionTemplate.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
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

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_NewBack_Click( object sender, EventArgs e )
        {
            Hide();
            codeViewForm instance_CodeViewForm = new codeViewForm();
            instance_CodeViewForm.Show();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_EditCancel_Click( object sender, EventArgs e )
        {
            switch (currentMode)
            {
                case Mode.Template:

                    ClearTemplateModeFields();

                    break;

                case Mode.Section:

                    ClearSectionModeFields();

                    break;

                case Mode.Code:

                    ClearCodeModeFields();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_EditDelete_Click( object sender, EventArgs e )
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

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_ModeTemplate_Click( object sender, EventArgs e )
        {
            currentMode = Mode.Template;
            LoadModeTemplate();
            SetModeButton( currentMode );
            SetModePanel( currentMode );
            ClearTemplateModeFields();
            
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_ModeSection_Click( object sender, EventArgs e )
        {
            currentMode = Mode.Section;
            LoadModeSection();
            SetModeButton( currentMode );
            SetModePanel( currentMode );
            ClearSectionModeFields();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_ModeCode_Click( object sender, EventArgs e )
        {
            currentMode = Mode.Code;
            LoadModeCode();
            SetModeButton( currentMode );
            SetModePanel( currentMode );
            ClearCodeModeFields();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_EditBack_Click( object sender, EventArgs e )
        {
            Hide();
            codeViewForm instance_CodeViewForm = new codeViewForm();
            instance_CodeViewForm.Show();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ComboBox_EditTemplateChooseExisting_DrawItem( object sender, DrawItemEventArgs e )
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage( Properties.Resources.happytech_circle, 
                                        e.Bounds.X + 6,
                                        e.Bounds.Y + 6,
                                        8,
                                        8 );
                e.Graphics.DrawString( ComboBox_EditTemplateChooseExisting.Items[e.Index].ToString(),
                                        e.Font,
                                        new SolidBrush( e.ForeColor ),
                                        e.Bounds.X + 20,
                                        e.Bounds.Y + 3 );
                e.DrawFocusRectangle();
            }
            catch ( Exception )
            {
                Console.WriteLine( "{0} can't be drawn because it does not exist.", e.ToString() );
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void TextBox_NewTemplateName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "NewArea" );
            HideError( "NewArea" );
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        /// <param name="mode">  </param>
        private void SetModeButton( Mode mode )
        {
            switch ( mode )
            {
                case Mode.Template:

                    Button_ModeTemplate.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeTemplate.ForeColor = Color.White;

                    Button_ModeSection.BackColor = Color.White;
                    Button_ModeSection.ForeColor = Color.FromArgb( 83, 60, 182 );

                    Button_ModeCode.BackColor = Color.White;
                    Button_ModeCode.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;

                case Mode.Section:

                    Button_ModeSection.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeSection.ForeColor = Color.White;

                    Button_ModeTemplate.BackColor = Color.White;
                    Button_ModeTemplate.ForeColor = Color.FromArgb( 83, 60, 182 );

                    Button_ModeCode.BackColor = Color.White;
                    Button_ModeCode.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;

                case Mode.Code:

                    Button_ModeCode.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeCode.ForeColor = Color.White;

                    Button_ModeSection.BackColor = Color.White;
                    Button_ModeSection.ForeColor = Color.FromArgb( 83, 60, 182 );

                    Button_ModeTemplate.BackColor = Color.White;
                    Button_ModeTemplate.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        /// <param name="mode">  </param>
        private void SetModePanel( Mode mode )
        {
            switch ( mode )
            {
                case Mode.Template:

                    Panel_NewTemplate.Show();
                    Panel_EditTemplate.Show();
                    Panel_NewSection.Hide();
                    Panel_EditSection.Hide();
                    Panel_NewCode.Hide();
                    Panel_EditCode.Hide();

                    break;

                case Mode.Section:

                    Panel_NewTemplate.Hide();
                    Panel_EditTemplate.Hide();
                    Panel_NewSection.Show();
                    Panel_EditSection.Show();
                    Panel_NewCode.Hide();
                    Panel_EditCode.Hide();

                    break;

                case Mode.Code:

                    Panel_NewTemplate.Hide();
                    Panel_EditTemplate.Hide();
                    Panel_NewSection.Hide();
                    Panel_EditSection.Hide();
                    Panel_NewCode.Show();
                    Panel_EditCode.Show();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ClearTemplateModeFields()
        {
            HideError( "NewArea" );
            HideError( "EditArea" );
            
            Populate_CheckedListBox_NewTemplateExistingSection();
            Populate_ComboBox_EditExistingTemplate();

            TextBox_NewTemplateName.Clear();
            TextBox_EditTemplateName.Clear();

            ClearTempEditSectionCheckboxlist();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ClearSectionModeFields()
        {
            HideError ("NewArea" );
            HideError( "EditArea" );
            
            Populate_CheckedListBox_NewSectionExistingTemplates();
            Populate_ComboBox_EditExistingSections();

            TextBox_NewSectionName.Clear();
            TextBox_EditSectionName.Clear();

            ClearSectionEditTempsCheckboxlist();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ClearCodeModeFields()
        {
            HideError( "NewArea" );
            HideError( "EditArea" );

            Populate_ComboBox_NewCodeSection();
            Populate_ComboBox_EditExistingCode();
            Populate_ComboBox_EditCodeSection();

            TextBox_NewCodeName.Clear();
            TextBox_EditCodeName.Clear();
            RichTextBox_NewCodeParagraph.Clear();
            RichTextBox_EditCodeParagraph.Clear();

        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void LoadModeSection()
        {
            Populate_CheckedListBox_NewSectionExistingTemplates();
            Populate_ComboBox_EditExistingSections();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void LoadModeTemplate()
        {
            Populate_CheckedListBox_NewTemplateExistingSection();
            Populate_ComboBox_EditExistingTemplate();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void LoadModeCode()
        {
            Populate_ComboBox_NewCodeSection();
            Populate_ComboBox_EditExistingCode();
            Populate_ComboBox_EditCodeSection();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void TextBox_NewSectionName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "NewArea" );
            HideError( "NewArea" );
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ComboBox_EditSectionChooseExisting_DrawItem( object sender, DrawItemEventArgs e )
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage( Properties.Resources.happytech_circle,
                                        e.Bounds.X + 6,
                                        e.Bounds.Y + 6,
                                        8,
                                        8 );
                e.Graphics.DrawString( ComboBox_EditSectionChooseExisting.Items[e.Index].ToString(),
                                        e.Font,
                                        new SolidBrush( e.ForeColor ),
                                        e.Bounds.X + 20,
                                        e.Bounds.Y + 3 );
                e.DrawFocusRectangle();
            }
            catch ( Exception )
            {
                Console.WriteLine( "{0} can't be drawn because it does not exist.", e.ToString() );
            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void ComboBox_EditSectionChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            TextBox_EditSectionName.Text = ComboBox_EditSectionChooseExisting.Text.Replace( " ", "" );
            //if we're editing sections, we need the checkbox to be populated with templates
            //change check list to display templates checkboxEditExistTemps needs to change if the existingDropDown changes

            HideSuccess( "EditArea" );
            HideError( "EditArea" );

            CheckedListBox_EditSectionTemplate.Items.Clear(); // clear out old info (if any)
            Template.templates.Clear();
            // we will use the selected section name to get the selected section's's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(ComboBox_EditSectionChooseExisting.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            var sectionId = dRow.ItemArray.GetValue(0);
            // we need to populate the sectionsListBox 
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                string tempNameToAdd = Template.templates[i].TempType.Replace(" ", "");
                int tempId = Template.templates[i].Id;
                CheckedListBox_EditSectionTemplate.Items.Add($"{tempNameToAdd}");
                //if there is a PersonalSection object with this template id and this section id, set checked to true
                DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{tempId}' and section_ID = '{sectionId}'");
                try
                {
                    DataRow dRow1 = ds1.Tables[0].Rows[0];

                    if (dRow1 != null)
                    {
                        CheckedListBox_EditSectionTemplate.SetItemChecked(i, true);
                    }
                }
                catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch

            }
        }

        /// <summary>
        /// 
        ///     NEEDS CLEANING AND COMMENTING
        /// 
        /// </summary>
        private void ComboBox_EditCodeChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            TextBox_EditCodeName.Text = ComboBox_EditCodeChooseExisting.Text.Replace( " ", "" );

            HideSuccess("EditArea");
            HideError("EditArea");

            ComboBox_EditCodeSection.Items.Clear();
            Sections.sectionList.Clear();
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:

                ComboBox_EditCodeSection.Items.Add($"{Sections.sectionList[i].name.Replace(" ", "")}");
            }
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeParaFromShort(ComboBox_EditCodeChooseExisting.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            TextBox_EditCodeName.Text = ComboBox_EditCodeChooseExisting.Text.Replace(" ", "");
            RichTextBox_EditCodeParagraph.Text = dRow.ItemArray.GetValue(0).ToString();
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ComboBox_EditCodeChooseExisting_DrawItem( object sender, DrawItemEventArgs e )
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(  Properties.Resources.happytech_circle,
                                        e.Bounds.X + 6,
                                        e.Bounds.Y + 6,
                                        8,
                                        8 );
                e.Graphics.DrawString( ComboBox_EditCodeChooseExisting.Items[e.Index].ToString(),
                                        e.Font,
                                        new SolidBrush( e.ForeColor ),
                                        e.Bounds.X + 20,
                                        e.Bounds.Y + 3 );
                e.DrawFocusRectangle();
            }
            catch ( Exception )
            {
                Console.WriteLine( "{0} can't be drawn because it does not exist.", e.ToString() );
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ComboBox_EditCodeSection_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage( Properties.Resources.happytech_circle,
                                        e.Bounds.X + 6,
                                        e.Bounds.Y + 6,
                                        8,
                                        8 );
                e.Graphics.DrawString( ComboBox_EditCodeSection.Items[e.Index].ToString(),
                                        e.Font,
                                        new SolidBrush( e.ForeColor ),
                                        e.Bounds.X + 20,
                                        e.Bounds.Y + 3 );
                e.DrawFocusRectangle();
            }
            catch ( Exception )
            {
                Console.WriteLine( "{0} can't be drawn because it does not exist.", e.ToString() );
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void ComboBox_NewCodeSection_DrawItem( object sender, DrawItemEventArgs e )
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage( Properties.Resources.happytech_circle,
                                        e.Bounds.X + 6,
                                        e.Bounds.Y + 6,
                                        8,
                                        8 );
                e.Graphics.DrawString( ComboBox_NewCodeSection.Items[e.Index].ToString(),
                                        e.Font,
                                        new SolidBrush( e.ForeColor ),
                                        e.Bounds.X + 20,
                                        e.Bounds.Y + 3 );
                e.DrawFocusRectangle();
            }
            catch ( Exception )
            {
                Console.WriteLine( "{0} can't be drawn because it does not exist.", e.ToString() );
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void TextBox_NewCodeName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "NewArea" );
            HideError( "NewArea" );

            Label_NewCodeNameLimit.Text = $"({TextBox_NewCodeName.Text.Length} / 5)";
            
            if ( TextBox_NewCodeName.Text.Length > 5 )
            {
                Label_NewCodeNameLimit.ForeColor = 
                    Color.FromArgb(255, 85, 85); // Red
            }
            else
            {
                Label_NewCodeNameLimit.ForeColor = 
                    Color.FromArgb(119, 119, 136); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void TextBox_EditSectionName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "EditArea" );
            HideError( "EditArea" );
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void RichTextBox_EditCodeParagraph_TextChanged( object sender, EventArgs e )
        {
            Label_EditCodeParagraphLimit.Text = $"({RichTextBox_EditCodeParagraph.Text.Length} / 300)";

            if ( RichTextBox_EditCodeParagraph.Text.Length > 300 )
            {
                Label_EditCodeParagraphLimit.ForeColor =
                    Color.FromArgb(255, 85, 85); // Red
            }
            else
            {
                Label_EditCodeParagraphLimit.ForeColor =
                    Color.FromArgb(119, 119, 136); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void RichTextBox_NewCodeParagraph_TextChanged( object sender, EventArgs e )
        {
            Label_NewCodeParagraphLimit.Text = $"({RichTextBox_NewCodeParagraph.Text.Length} / 300)";

            if ( RichTextBox_NewCodeParagraph.Text.Length > 300 )
            {
                Label_NewCodeParagraphLimit.ForeColor = 
                    Color.FromArgb(255, 85, 85);  // Red
            }
            else
            {
                Label_NewCodeParagraphLimit.ForeColor = 
                    Color.FromArgb(119, 119, 136); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        private void TextBox_EditCodeName_TextChanged( object sender, EventArgs e )
        {
            Label_EditCodeNameLimit.Text = $"({TextBox_EditCodeName.Text.Length} / 5)";

            if ( TextBox_EditCodeName.Text.Length > 5 )
            {
                Label_EditCodeNameLimit.ForeColor =
                    Color.FromArgb(255, 85, 85); // Red
            }
            else
            {
                Label_EditCodeNameLimit.ForeColor =
                    Color.FromArgb(119, 119, 136); // Default (Grey)
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

                    Label_NewError.Text = message;
                    Label_NewError.Show();

                    break;

                case "EditArea":

                    Label_EditError.Text = message;
                    Label_EditError.Show();

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

                    Label_NewError.Hide();

                    break;

                case "EditArea":

                    Label_EditError.Hide();

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

                    Label_NewSuccess.Text = message;
                    Label_NewSuccess.Show();

                    break;

                case "EditArea":

                    Label_EditSuccess.Text = message;
                    Label_EditSuccess.Show();

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

                    Label_NewSuccess.Hide();

                    break;

                case "EditArea":

                    Label_EditSuccess.Hide();

                    break;
            }
        }
    }
}
