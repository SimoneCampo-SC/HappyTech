/**
 * 
 * File: EditorForm.cs
 * 
 * Author 1: Hopper, Kean. 1911956
 * Author 2: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
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
    public partial class EditorForm : Form
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
        public EditorForm()
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
        public EditorForm( Mode alternateStartMode )
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
                    else if ( SqlQueries.CheckTemplate( TextBox_NewTemplateName.Text ) )
                    {
                        DisplayError( "This template name already exists", "NewArea" );
                    }

                    /* 
                     * Add template to database, reset fields, display success.
                     */

                    else
                    {
                        string templateName = TextBox_NewTemplateName.Text.Replace( " ", "" );
            
                        EditorFormTemplateClass.InsertNewTemplate(templateName, CheckedListBox_NewTemplateExistingSection);
                        
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
                    else if ( SqlQueries.CheckSection( TextBox_NewSectionName.Text ) )
                    {
                        DisplayError( "This section name already exists", "NewArea" );
                    }

                    /* 
                     * Add section to database, reset fields, display success.
                     */

                    else
                    {
                        string sectionName = TextBox_NewSectionName.Text.Replace( " ", "" );
                         
                        EditorFormSectionClass.InsertNewSection(sectionName, CheckedListBox_NewSectionExistingTemplate);

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
                     *      not moved into codeClass because this is a GUI element
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
                    else if ( SqlQueries.CheckCode( TextBox_NewCodeName.Text ) )
                    {
                        DisplayError( "This code name already exists", "NewArea" );
                    }

                    else
                    {
                        EditorFormCodeClass.InsertNewCode(TextBox_NewCodeName, RichTextBox_NewCodeParagraph, ComboBox_NewCodeSection);
                        DisplaySuccess( "New code saved", "NewArea" );
                    }
 
                    break;
            }
        }

        /// <summary>
        /// 
        ///     Trigger function for clicking the edit area save
        ///     button. This will check the field requirements for
        ///     the current mode. If all errors are avoided, the
        ///     template, section, or code will be updated in the database.
        /// 
        /// </summary>
        private void Button_EditSave_Click( object sender, EventArgs e )
        {
            switch ( currentMode )
            {
                case Mode.Template:

                    /* 
                     * Check template field requirements:
                     *      - Template to edit
                     *      - Template name
                     *      - Template name less than or at max length: 25
                     *      - Template name not already in database    
                     */

                    if ( ComboBox_EditTemplateChooseExisting.SelectedItem == null )
                    {
                        DisplayError( "Select a template to edit", "EditArea" );
                    }
                    else if ( TextBox_EditTemplateName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a template name", "EditArea" );
                    }
                    else if ( TextBox_EditTemplateName.Text.Length > 25 )
                    {
                        DisplayError( "Template name limit exceeded", "EditArea" );
                    }
                    else if ( SqlQueries.CheckTemplate( TextBox_EditTemplateName.Text ) )
                    {
                        /* 
                         * This checks if the template name is still the same
                         * so that the user can only edit the section if
                         * they want without being forced to change the name.
                         */

                        if (TextBox_EditTemplateName.Text == ComboBox_EditTemplateChooseExisting.SelectedItem.ToString())
                        {
                            EditorFormTemplateClass.EditTemplate(CheckedListBox_EditTemplateSection, TextBox_EditTemplateName);
                            ClearTemplateModeFields();

                            DisplaySuccess("Template edit saved", "EditArea");
                        }
                        else
                        {
                            DisplayError("This template name already exists", "EditArea");
                        }
                    }
                    else
                    {
                        EditorFormTemplateClass.EditTemplate(CheckedListBox_EditTemplateSection, TextBox_EditTemplateName);
                        ClearTemplateModeFields();

                        DisplaySuccess("Template edit saved", "EditArea");
                    }

                    break;

                case Mode.Section:

                    /* 
                     * Check section field requirements:
                     *      - Section to edit
                     *      - Section name
                     *      - Section name less than or at max length: 25
                     *      - Section name not already in database    
                     */

                    if ( ComboBox_EditSectionChooseExisting.SelectedItem == null )
                    {
                        DisplayError( "Select a section to edit", "EditArea" );
                    }
                    else if ( TextBox_EditSectionName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a section name", "EditArea" );
                    }
                    else if ( TextBox_EditSectionName.Text.Length > 25 )
                    {
                        DisplayError( "Section name limit exceeded", "EditArea" );
                    }
                    else if ( SqlQueries.CheckSection( TextBox_EditSectionName.Text ) )
                    {
                        /* 
                         * This checks if the section name is still the same
                         * so that the user can only edit the template if
                         * they want without being forced to change the name.
                         */

                        if (TextBox_EditSectionName.Text == ComboBox_EditSectionChooseExisting.SelectedItem.ToString())
                        {
                            EditorFormSectionClass.EditSection(ComboBox_EditSectionChooseExisting, TextBox_EditSectionName, CheckedListBox_NewSectionExistingTemplate);
                            ClearSectionModeFields();

                            DisplaySuccess("Section edit saved", "EditArea");
                        }
                        else
                        {
                            DisplayError("This section name already exists", "EditArea");
                        }
                    }
                    else
                    {
                        EditorFormSectionClass.EditSection(ComboBox_EditSectionChooseExisting, TextBox_EditSectionName, CheckedListBox_NewSectionExistingTemplate);
                        ClearSectionModeFields();

                        DisplaySuccess("Section edit saved", "EditArea");
                    }

                    break;

                case Mode.Code:

                    /* 
                     * Check code field requirements:
                     *      - Code to edit
                     *      - Code name
                     *      - Code name less than or at max length: 5
                     *      - Code paragraph
                     *      - Code paragraph less than or at max length: 300
                     *      - Code name contains no spaces
                     *      - Code name not already in databases
                     */

                    if ( ComboBox_EditCodeChooseExisting.SelectedItem == null )
                    {
                        DisplayError( "Select a code to edit", "EditArea" );
                    }
                    else if ( TextBox_EditCodeName.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a code name", "EditArea" );
                    }
                    else if ( TextBox_EditCodeName.Text.Length > 5 )
                    {
                        DisplayError( "Code name limit exceeded", "EditArea" );
                    }
                    else if ( RichTextBox_EditCodeParagraph.Text.Length <= 0 )
                    {
                        DisplayError( "Enter a code paragraph", "EditArea" );
                    }
                    else if ( RichTextBox_EditCodeParagraph.Text.Length > 300 )
                    {
                        DisplayError( "Code paragraph limit exceeded", "EditArea" );
                    }
                    else if ( TextBox_EditCodeName.Text.Contains( " " ) )
                    {
                        DisplayError( "Remove spaces from code name", "EditArea" );
                    }
                    else if ( SqlQueries.CheckCode( TextBox_EditCodeName.Text ) )
                    {
                        /* 
                         * This checks if the code name is still the same
                         * so that the user can only edit the paragraph if
                         * they want without being forced to change the name.
                         */

                        if ( TextBox_EditCodeName.Text == ComboBox_EditCodeChooseExisting.SelectedItem.ToString() )
                        {
                            EditorFormCodeClass.SaveCodeChange(ComboBox_EditCodeChooseExisting, TextBox_EditCodeName, RichTextBox_EditCodeParagraph);
                            ClearCodeModeFields();

                            DisplaySuccess("Code edit saved", "EditArea");
                        }
                        else
                        {
                            DisplayError("This code name already exists", "EditArea" );
                        }
                    }
                    else
                    {
                        EditorFormCodeClass.SaveCodeChange(ComboBox_EditCodeChooseExisting, TextBox_EditCodeName, RichTextBox_EditCodeParagraph);
                        ClearCodeModeFields();

                        DisplaySuccess("Code edit saved", "EditArea");
                    }

                    break;
            }
        }

        

    

      

        /// <summary>
        /// 
        ///     Reset the sections checkbox list items
        ///     for the template edit.
        /// 
        /// </summary>
        private void Reset_CheckedListBox_EditTemplateSection()
        {
            for (int i = 0; i < CheckedListBox_EditTemplateSection.Items.Count; i++)
            {
                CheckedListBox_EditTemplateSection.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// 
        ///     Reset the templates checkbox lsit items
        ///     for the section edit.
        /// 
        /// </summary>
        private void Reset_CheckedListBox_EditSectionTemplate()
        {
            for (int i = 0; i < CheckedListBox_EditSectionTemplate.Items.Count; i++)
            {
                CheckedListBox_EditSectionTemplate.SetItemChecked(i, false);
            }
        }

     
        

     
    
        /// <summary>
        /// 
        ///     Click trigger function for the new area
        ///     back button. This will create a new CodeViewForm
        ///     instance.
        /// 
        /// </summary>
        private void Button_NewBack_Click( object sender, EventArgs e )
        {
            Hide();
            CodeViewForm instance_CodeViewForm = new CodeViewForm();
            instance_CodeViewForm.Show();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the edit area
        ///     cancel button. This will reset the fields
        ///     for the current mode.
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
        ///     Click trigger function for the edit area
        ///     delete button. This will delete the template,
        ///     section, or code from the database.
        ///     
        /// </summary>
        private void Button_EditDelete_Click( object sender, EventArgs e )
        {
            switch (currentMode)
            {
                case Mode.Template:

                    if (ComboBox_EditTemplateChooseExisting.SelectedItem == null)
                    {
                        DisplayError("Select a template to edit", "EditArea");
                        break;
                    }

                    EditorFormTemplateClass.DeleteTemplate(ComboBox_EditTemplateChooseExisting);
                    ClearTemplateModeFields();

                    DisplaySuccess( "Template deleted", "EditArea" );

                    break;

                case Mode.Section:
                    if (ComboBox_EditSectionChooseExisting.SelectedItem == null)
                    {
                        DisplayError("Select a section to edit", "EditArea");
                        break;
                    }
                    EditorFormSectionClass.DeleteSection(ComboBox_EditSectionChooseExisting);

                    ClearSectionModeFields();

                    DisplaySuccess( "Section deleted", "EditArea" );

                    break;

                case Mode.Code:
                    if (ComboBox_EditCodeChooseExisting.SelectedItem == null)
                    {
                        DisplayError("Select a code to edit", "EditArea");
                        break; 
                    }
                    EditorFormCodeClass.DeleteCode(ComboBox_EditCodeChooseExisting);
                    ClearCodeModeFields();
                    DisplaySuccess( "Code deleted", "EditArea" );
                    break;
            }
        }

        /// <summary>
        /// 
        ///     Click trigger for the template mode button.
        ///     This will set the appropriate components to
        ///     display the template mode.
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
        ///     Click trigger for the section mode button.
        ///     This will set the appropriate components to
        ///     display the section mode.
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
        ///     Click trigger for the code mode button.
        ///     This will set the appropriate components to
        ///     display the code mode.
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
        ///     Click trigger function for the edit area
        ///     back button. This will create a new CodeViewForm
        ///     instance.
        /// 
        /// </summary>
        private void Button_EditBack_Click( object sender, EventArgs e )
        {
            Hide();
            CodeViewForm instance_CodeViewForm = new CodeViewForm();
            instance_CodeViewForm.Show();
        }

        /// <summary>
        /// 
        ///     This will set the button colour purple for
        ///     the active button, and white for the inactive
        ///     buttons. NOTE: 83, 60, 183 is purple.
        /// 
        /// </summary>
        /// <param name="mode"> The active button's mode </param>
        private void SetModeButton( Mode mode )
        {
            switch ( mode )
            {
                case Mode.Template:

                    // Active
                    Button_ModeTemplate.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeTemplate.ForeColor = Color.White;

                    // Inactive
                    Button_ModeSection.BackColor = Color.White;
                    Button_ModeSection.ForeColor = Color.FromArgb( 83, 60, 182 );

                    // Inactive
                    Button_ModeCode.BackColor = Color.White;
                    Button_ModeCode.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;

                case Mode.Section:

                    // Active
                    Button_ModeSection.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeSection.ForeColor = Color.White;

                    // Inactive
                    Button_ModeTemplate.BackColor = Color.White;
                    Button_ModeTemplate.ForeColor = Color.FromArgb( 83, 60, 182 );

                    // Inactive
                    Button_ModeCode.BackColor = Color.White;
                    Button_ModeCode.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;

                case Mode.Code:

                    // Active
                    Button_ModeCode.BackColor = Color.FromArgb( 83, 60, 182 );
                    Button_ModeCode.ForeColor = Color.White;

                    // Inactive
                    Button_ModeSection.BackColor = Color.White;
                    Button_ModeSection.ForeColor = Color.FromArgb( 83, 60, 182 );

                    // Inactive
                    Button_ModeTemplate.BackColor = Color.White;
                    Button_ModeTemplate.ForeColor = Color.FromArgb( 83, 60, 182 );

                    break;
            }
        }

        /// <summary>
        /// 
        ///     This will show the new and edit panels for the
        ///     current active mode and hide the panels for the
        ///     inactive modes.
        /// 
        /// </summary>
        /// <param name="mode"> The active panel's mode </param>
        private void SetModePanel( Mode mode )
        {
            switch ( mode )
            {
                case Mode.Template:

                    // Active
                    Panel_NewTemplate.Show();
                    Panel_EditTemplate.Show();

                    // Inactive
                    Panel_NewSection.Hide();
                    Panel_EditSection.Hide();
                    Panel_NewCode.Hide();
                    Panel_EditCode.Hide();

                    break;

                case Mode.Section:

                    // Active
                    Panel_NewSection.Show();
                    Panel_EditSection.Show();

                    // Inactive
                    Panel_NewTemplate.Hide();
                    Panel_EditTemplate.Hide();
                    Panel_NewCode.Hide();
                    Panel_EditCode.Hide();

                    break;

                case Mode.Code:

                    // Active
                    Panel_NewCode.Show();
                    Panel_EditCode.Show();

                    // Inactive
                    Panel_NewTemplate.Hide();
                    Panel_EditTemplate.Hide();
                    Panel_NewSection.Hide();
                    Panel_EditSection.Hide();

                    break;
            }
        }

        /// <summary>
        /// 
        ///     This will hide errors, populate dropdown
        ///     lists and checkboxes, and reset any text
        ///     fields for the template mode.
        /// 
        /// </summary>
        private void ClearTemplateModeFields()
        {
            HideError( "EditArea" );
            HideError( "NewArea" );

            EditorFormTemplateClass.LoadExistingSections(CheckedListBox_NewTemplateExistingSection);
            EditorFormTemplateClass.LoadExistingTemplates(ComboBox_EditTemplateChooseExisting);

            TextBox_NewTemplateName.Clear();
            TextBox_EditTemplateName.Clear();

            Reset_CheckedListBox_EditTemplateSection();
        }

        /// <summary>
        /// 
        ///     This will hide errors, populate dropdown
        ///     lists and checkboxes, and reset any text
        ///     fields for the section mode.
        /// 
        /// </summary>
        private void ClearSectionModeFields()
        {

            HideError("EditArea");
            HideError("NewArea");
            EditorFormSectionClass.PopulateTemplates(CheckedListBox_NewSectionExistingTemplate);
            EditorFormSectionClass.PopulateSections(ComboBox_EditCodeChooseExisting);
            

            TextBox_NewSectionName.Clear();
            TextBox_EditSectionName.Clear();

            Reset_CheckedListBox_EditSectionTemplate();
        }

        /// <summary>
        /// 
        ///     This will hide errors, populate dropdown
        ///     lists, and reset any text fields for the 
        ///     code mode.
        /// 
        /// </summary>
        private void ClearCodeModeFields()
        {

            HideError("EditArea");
            HideError("NewArea");
            EditorFormCodeClass.Populate_ComboBox_NewCodeSection(ComboBox_NewCodeSection);
            EditorFormCodeClass.Populate_ComboBox_EditExistingCode(ComboBox_EditCodeChooseExisting);
            EditorFormCodeClass.Populate_ComboBox_EditCodeSection(ComboBox_EditCodeSection);
            TextBox_NewCodeName.Clear();
            TextBox_EditCodeName.Clear();
            RichTextBox_NewCodeParagraph.Clear();
            RichTextBox_EditCodeParagraph.Clear();

        }

        /// <summary>
        /// 
        ///     This will populate dropdown lists and
        ///     checkboxes needed for the template mode.
        /// 
        /// </summary>
        private void LoadModeTemplate()
        {
            EditorFormTemplateClass.LoadExistingSections(CheckedListBox_NewTemplateExistingSection);
            EditorFormTemplateClass.LoadExistingTemplates(ComboBox_EditTemplateChooseExisting);
        }

        /// <summary>
        /// 
        ///     This will populate dropdown lists and
        ///     checkboxes needed for the section mode.
        /// 
        /// </summary>
        private void LoadModeSection()
        {
            EditorFormSectionClass.PopulateTemplates(CheckedListBox_NewSectionExistingTemplate);
            EditorFormSectionClass.PopulateSections(ComboBox_EditCodeChooseExisting);
        }

        /// <summary>
        /// 
        ///     This will populate dropdown lists
        ///     needed for the code mode.
        /// 
        /// </summary>
        private void LoadModeCode()
        {
            EditorFormCodeClass.Populate_ComboBox_NewCodeSection(ComboBox_NewCodeSection);
            EditorFormCodeClass.Populate_ComboBox_EditExistingCode(ComboBox_EditCodeChooseExisting);
            EditorFormCodeClass.Populate_ComboBox_EditCodeSection(ComboBox_EditCodeSection);
        }

        /// <summary>
        /// 
        ///     Draw trigger for existing template dropdown.
        ///     This will display the items in the list with
        ///     and icon prefixed, it also controls the exact
        ///     position of each value.
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
        ///     Draw trigger for existing section dropdown.
        ///     This will display the items in the list with
        ///     and icon prefixed, it also controls the exact
        ///     position of each value.
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
        ///     Draw trigger for existing code dropdown.
        ///     This will display the items in the list with
        ///     and icon prefixed, it also controls the exact
        ///     position of each value.
        /// 
        /// </summary>
        private void ComboBox_EditCodeChooseExisting_DrawItem( object sender, DrawItemEventArgs e )
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage( Properties.Resources.happytech_circle,
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
            catch (Exception)
            {
                Console.WriteLine("{0} can't be drawn because it does not exist.", e.ToString());
            }
        }

        /// <summary>
        /// 
        ///     Draw trigger for edit code section dropdown.
        ///     This will display the items in the list with
        ///     and icon prefixed, it also controls the exact
        ///     position of each value.
        /// 
        /// </summary>
        private void ComboBox_EditCodeSection_DrawItem( object sender, DrawItemEventArgs e )
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
        ///     Draw trigger for new code section dropdown.
        ///     This will display the items in the list with
        ///     and icon prefixed, it also controls the exact
        ///     position of each value.
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
        ///     Update the existing template dropdown.
        ///         - Remove spaces from template name
        ///         - Hide error and success messages
        ///         - Clear checkbox items
        ///         - Clear and update section list from database
        ///         - Get the template ID from the database 
        ///           using the template name
        ///         - Loop through all sections, 
        ///             - Get section name, add to checkboxes
        ///             - Get section ID
        ///             - Check if template and section share
        ///               PersonalSection foreign keys
        ///             - If they do, add section to checklist items
        ///             - If not, display null error to prevent crash
        /// 
        /// </summary>
        private void ComboBox_EditTemplateChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            TextBox_EditTemplateName.Text = ComboBox_EditTemplateChooseExisting.Text.Replace( " ", "" );
            HideSuccess( "EditArea" );
            HideError( "EditArea" );
            EditorFormTemplateClass.LoadInfoForTemplateEdit(TextBox_EditTemplateName, CheckedListBox_EditTemplateSection);

        }

        /// <summary>
        /// 
        ///     Update the existing section dropdown.
        ///         - Remove spaces from section name
        ///         - Hide error and success messages
        ///         - Clear checkbox items
        ///         - Clear and update template list from database
        ///         - Get the section ID from the database 
        ///           using the section name
        ///         - Loop through all templates, 
        ///             - Get template name, add to checkboxes
        ///             - Get template ID
        ///             - Check if template and section share
        ///               PersonalSection foreign keys
        ///             - If they do, add template to checklist items
        ///             - If not, display null error to prevent crash
        /// 
        /// </summary>
        private void ComboBox_EditSectionChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            //TextBox_EditSectionName.Text = ComboBox_EditSectionChooseExisting.Text.Replace( " ", "" );
            EditorFormSectionClass.LoadInfoForSectionEdit(ComboBox_EditSectionChooseExisting, CheckedListBox_EditSectionTemplate);
            HideSuccess( "EditArea" );
            HideError( "EditArea" );

            CheckedListBox_EditSectionTemplate.Items.Clear();

        }

        /// <summary>
        /// 
        ///     Update the existing section dropdown.
        ///         - Remove spaces from code name
        ///         - Hide error and success messages
        ///         - Clear checkbox items
        ///         - Clear and update section list from database
        ///         - Loop through all sections, 
        ///             - Add sections to dropdown list
        ///         - Get the code paragraph from the database 
        ///           using the code name
        ///         
        /// 
        /// </summary>
       /* private void ComboBox_EditCodeChooseExisting_SelectedIndexChanged( object sender, EventArgs e )
        {
            TextBox_EditCodeName.Text = ComboBox_EditCodeChooseExisting.Text.Replace( " ", "" );

            HideSuccess( "EditArea" );
            HideError( "EditArea" );

            ComboBox_EditCodeSection.Items.Clear();

            UpdateList( "Section" );

            for ( int i = 0; i < Section.sectionList.Count(); i++ )
            {
                ComboBox_EditCodeSection.Items.Add($"{Section.sectionList[i].Name.Replace(" ", "")}");
            }

            DataSet codeDB      = Connection.GetDbConn().
                                    GetDataSet( SqlQueries.
                                        GetCodeParaFromShort( ComboBox_EditCodeChooseExisting.Text.Replace( " ", "" ) ) );

            DataRow codeDBValue = codeDB.Tables[0].Rows[0];

            TextBox_EditCodeName.Text = ComboBox_EditCodeChooseExisting.Text.Replace( " ", "" );
            RichTextBox_EditCodeParagraph.Text = codeDBValue.ItemArray.GetValue( 0 ).ToString();
        } */

        /// <summary>
        /// 
        ///     Text changed trigger for the new template
        ///     name field. This will hide any error or
        ///     success messages.
        /// 
        /// </summary>
        private void TextBox_NewTemplateName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "NewArea" );
            HideError( "NewArea" );
        }

        /// <summary>
        /// 
        ///     Text changed trigger for the edit template
        ///     name field. This will hide any error or
        ///     success messages.
        /// 
        /// </summary>
        private void TextBox_EditTemplateName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "EditArea" );
            HideError( "EditArea" );
        }

        /// <summary>
        /// 
        ///     Text changed trigger for the new section
        ///     name field. This will hide any error or
        ///     success messages.
        /// 
        /// </summary>
        private void TextBox_NewSectionName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "NewArea" );
            HideError( "NewArea" );
        }

        /// <summary>
        /// 
        ///     Text changed trigger for the edit section
        ///     name field. This will hide any error or
        ///     success messages.
        /// 
        /// </summary>
        private void TextBox_EditSectionName_TextChanged( object sender, EventArgs e )
        {
            HideSuccess( "EditArea" );
            HideError( "EditArea" );
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for new
        ///     code name. This will set the limiter
        ///     value red if the name is too long, the
        ///     default grey if not.
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
                    Color.FromArgb( 255, 85, 85 ); // Red
            }
            else
            {
                Label_NewCodeNameLimit.ForeColor =
                    Color.FromArgb( 119, 119, 136 ); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for edit
        ///     code paragraph. This will set the limiter
        ///     value red if the name is too long, the
        ///     default grey if not.
        /// 
        /// </summary>
        private void RichTextBox_EditCodeParagraph_TextChanged( object sender, EventArgs e )
        {
            Label_EditCodeParagraphLimit.Text = $"({RichTextBox_EditCodeParagraph.Text.Length} / 300)";

            if ( RichTextBox_EditCodeParagraph.Text.Length > 300 )
            {
                Label_EditCodeParagraphLimit.ForeColor =
                    Color.FromArgb( 255, 85, 85 ); // Red
            }
            else
            {
                Label_EditCodeParagraphLimit.ForeColor =
                    Color.FromArgb( 119, 119, 136 ); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for new
        ///     code paragraph. This will set the limiter
        ///     value red if the name is too long, the
        ///     default grey if not.
        /// 
        /// </summary>
        private void RichTextBox_NewCodeParagraph_TextChanged( object sender, EventArgs e )
        {
            Label_NewCodeParagraphLimit.Text = $"({RichTextBox_NewCodeParagraph.Text.Length} / 300)";

            if ( RichTextBox_NewCodeParagraph.Text.Length > 300 )
            {
                Label_NewCodeParagraphLimit.ForeColor = 
                    Color.FromArgb( 255, 85, 85 );  // Red
            }
            else
            {
                Label_NewCodeParagraphLimit.ForeColor = 
                    Color.FromArgb( 119, 119, 136 ); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for edit
        ///     code name. This will set the limiter
        ///     value red if the name is too long, the
        ///     default grey if not.
        /// 
        /// </summary>
        private void TextBox_EditCodeName_TextChanged( object sender, EventArgs e )
        {
            Label_EditCodeNameLimit.Text = $"({TextBox_EditCodeName.Text.Length} / 5)";

            if ( TextBox_EditCodeName.Text.Length > 5 )
            {
                Label_EditCodeNameLimit.ForeColor =
                    Color.FromArgb( 255, 85, 85 ); // Red
            }
            else
            {
                Label_EditCodeNameLimit.ForeColor =
                    Color.FromArgb( 119, 119, 136 ); // Default (Grey)
            }
        }

        /// <summary>
        /// 
        ///     Clear the object list and fill it from the database again.
        /// 
        /// </summary>
        /// <param name="type"> Object list to update: Template, Section, or Code </param>
        /* private void UpdateList( string type )
        {
            switch ( type )
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
        } */

        /// <summary>
        /// 
        ///     Display an error at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="message"> The error message </param>
        /// <param name="area"> The area to display the error to </param>
        private  void DisplayError( string message, string area)
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

        public static void DisplayCodeError (string message, string area)
        {

        }

        /// <summary>
        /// 
        ///     Hide the error at the bottom of the specified area.
        /// 
        /// </summary>
        /// <param name="area"> The area to hide the error from </param>
        public  void HideError( string area )
        {
            switch ( area )
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
        private void DisplaySuccess( string message, string area )
        {
            switch ( area )
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
        public void HideSuccess( string area )
        {
            switch ( area )
            {
                case "NewArea":

                    Label_NewSuccess.Hide();

                    break;

                case "EditArea":

                    Label_EditSuccess.Hide();

                    break;
            }
        }

        private void ComboBox_EditCodeChooseExisting_SelectedIndexChanged(object sender, EventArgs e)
        {

            HideError("EditArea");
            HideError("NewArea");
            EditorFormCodeClass.LoadInfoForCodeEdit(TextBox_EditCodeName, RichTextBox_EditCodeParagraph, ComboBox_EditCodeChooseExisting, ComboBox_EditCodeSection);
        }
    }
}
