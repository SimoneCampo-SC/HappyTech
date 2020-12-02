/**
 * 
 * File: DashForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the user to fill applicant details into
 *              the application and to select one of the available template
 *              types. It also allows the user to logout from the system and
 *              to move to the codeViewForm.
 *              
 */

using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class DashForm : Form
    {
        // Sets the available modes
        public enum Mode
        {
            Default,
            Applicant,
        }

        private Mode currentMode;

        /// <summary>
        /// Constructor of the DashForm Class
        /// </summary>
        /// <param name="mode"> either "newApp" or "default"</param>
        public DashForm(Mode mode)
        {
            InitializeComponent();

            currentMode = mode;

            Clear_TemporaryFiles();

            Label_Username.Text = $"{Recruiter.GetInstance().Name}.";

            // Gets all the templates from the database
            DataSet templateDB = Connection.GetDbConn().GetDataSet(SqlQueries.SelectTemplateType());

            for (int i = 0; i < templateDB.Tables[0].Rows.Count; i++)
            {
                // Populate the tempTypeBox with the name of the Templates
                ListBox_TemplateList.Items.Add(templateDB.Tables[0].Rows[i].ItemArray.GetValue(0));
            }

            // Switch constructor checks the mode parameter: ToLower() to make it not case sensitive.
            switch (currentMode)
            {
                case Mode.Applicant:
                    // Checks whether the list of the applicants is not empty
                    if (Applicant.applicants.Count > 0)
                    {
                        // Displays the btBack object
                        Button_Cancel.Visible = true;
                    }
                    break;

                case Mode.Default:
                    // Deletes all the items in the applicants and templatesForApplicants lists
                    // Deletes the applicants from the Database
                    Applicant.applicants.Clear();
                    Template.templatesForApplicants.Clear();
                    Connection.GetDbConn().CreateCommand(SqlQueries.DeleteApplicant());
                    break;
                default:
                    // Do nothing 
                    break;
            }
        }

        /// <summary>
        /// 
        ///     Click tigger function for the logout button.
        ///     This will remove all progress the user has
        ///     made and send them back to the login form.
        /// 
        /// </summary>
        private void Button_Logout_Click(object sender, EventArgs e)
        {
            if (Button_Logout.Text.Equals("Are you sure?"))
            {
                Hide();
                Recruiter.DestroyInstance(); // Recruiter instance is destroied
                Applicant.applicants.Clear(); // Applicants list is cleared
                Template.templatesForApplicants.Clear();
                Connection.GetDbConn().CreateCommand(SqlQueries.DeleteApplicant()); // Applicants are deleted from the database
                LoginForm instance_LoginForm = new LoginForm(); // Returns to the login form
                instance_LoginForm.Show();
            }
            else
            {
                Button_Logout.Text = "Are you sure?";
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for the save button.
        ///     This will check the field requirements are met,
        ///     then it will add the applicant to the list and
        ///     send the user to the ConfirmApplicantForm.
        /// 
        /// </summary>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Checks whether an item in the tempTypeBox has been selected
            // AND whether all the fields have been filled
            if ((ListBox_TemplateList.SelectedItem != null) &&
               ((TextBox_DetailsFullName.Text.Length > 0) && (TextBox_DetailsJobPosition.Text.Length > 0) &&
               (TextBox_DetailsEmail.Text.Length > 0)))
            {
                if ((TextBox_DetailsFullName.Text.Length <= 50) && (TextBox_DetailsJobPosition.Text.Length <= 50) && (TextBox_DetailsEmail.Text.Length <= 50))
                {
                    // Insert applicant details into the database
                    Connection.GetDbConn().CreateCommand(SqlQueries.InsertApplicant(TextBox_DetailsFullName.Text, TextBox_DetailsEmail.Text, 
                                                         TextBox_DetailsJobPosition.Text, Recruiter.GetInstance().Id));

                    // Crearte a new instance of the applicant class
                    Applicant applicant = new Applicant(TextBox_DetailsFullName.Text, TextBox_DetailsEmail.Text, TextBox_DetailsJobPosition.Text, 
                                                        Recruiter.GetInstance().Id, ListBox_TemplateList.SelectedItem.ToString()); 

                    // Add the instance into the applicant list
                    Applicant.applicants.Add(applicant);

                    Template.GenerateTemplateForApplicant(applicant, ListBox_TemplateList.SelectedItem.ToString());

                    Hide();
                    // Create a new ConfApplDetails form passing the value false
                    ConfirmApplicantForm instance_ConfirmApplicantForm = new ConfirmApplicantForm(true);
                    instance_ConfirmApplicantForm.Show();
                }
                else
                {
                    Label_Error.Visible = true;
                    Label_Error.Text = "Fields must be 50 characters or less";
                }
            }
            else
            {
                // Displays the error message
                Label_Error.Visible = true;
                Label_Error.Text = "Missing required fields";
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for the cancel button.
        ///     This will send the user back the ConfirmApplicantForm.
        /// 
        /// </summary>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            ConfirmApplicantForm instance_ConfirmApplicantForm = new ConfirmApplicantForm( false );
            instance_ConfirmApplicantForm.Show();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the editor button.
        ///     This will send the user to the code view and
        ///     editor forms.
        /// 
        /// </summary>
        private void Button_Editor_Click(object sender, EventArgs e)
        {
            Hide();
            CodeViewForm instance_CodeViewForm = new CodeViewForm();
            instance_CodeViewForm.Show();
        }

        /// <summary>
        /// 
        ///     Draws individual items in the list with a
        ///     purple icon next to them and spaces them
        ///     out evenly.
        /// 
        /// </summary>
        private void ListBox_TemplateList_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 8, e.Bounds.Y + 8, 16, 16);
                e.Graphics.DrawString(ListBox_TemplateList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 32, e.Bounds.Y + 8);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for full name.
        ///     This will set the applicant name value to the typed
        ///     value.
        /// 
        /// </summary>
        private void TextBox_DetailsFullName_TextChanged(object sender, EventArgs e)
        {
            Label_ApplicantName.Text = TextBox_DetailsFullName.Text;
            if (Label_ApplicantName.Text.Length > 0)
            {
                PictureBox_Applicant.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                PictureBox_Applicant.Image = Properties.Resources.happytech_empty;
            }
        }

        /// <summary>
        /// 
        ///     Reset fields when the form is loaded.
        /// 
        /// </summary>
        private void DashForm_Load(object sender, EventArgs e)
        {
            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            PictureBox_Recruiter.Image = Properties.Resources.happytech_filled;
            Label_ApplicantName.Text = "";
            Label_ApplicantEmail.Text = "";
            Label_ApplicantJob.Text = "";
            Label_ApplicantTemplate.Text = "";
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for emails.
        ///     This will set the email value to the typed
        ///     value.
        /// 
        /// </summary>
        private void TextBox_DetailsEmail_TextChanged(object sender, EventArgs e)
        {
            Label_ApplicantEmail.Text = TextBox_DetailsEmail.Text;
            if (Label_ApplicantEmail.Text.Length > 0)
            {
                PictureBox_Email.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                PictureBox_Email.Image = Properties.Resources.happytech_empty;
            }
        }

        /// <summary>
        /// 
        ///     Text changed trigger function for job position.
        ///     This will set the position value to the typed
        ///     value.
        /// 
        /// </summary>
        private void TextBox_DetailsJobPosition_TextChanged(object sender, EventArgs e)
        {
            Label_ApplicantJob.Text = TextBox_DetailsJobPosition.Text;
            if (Label_ApplicantJob.Text.Length > 0)
            {
                PictureBox_Position.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                PictureBox_Position.Image = Properties.Resources.happytech_empty;
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for template list.
        ///     This will set the template value to the
        ///     selected item.
        /// 
        /// </summary>
        private void ListBox_TemplateList_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListBox_TemplateList.SelectedItem != null)
            {
                Label_ApplicantTemplate.Text = ListBox_TemplateList.SelectedItem.ToString();
            }

            if (Label_ApplicantTemplate.Text.Length > 0)
            {
                PictureBox_Template.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                PictureBox_Template.Image = Properties.Resources.happytech_empty;
            }
        }
        
        /// <summary>
        /// 
        ///     This will removed all RTF files as the applicants
        ///     no longer exist.
        /// 
        /// </summary>
        private void Clear_TemporaryFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo( AppDomain.CurrentDomain.BaseDirectory );
            FileInfo[] files = directoryInfo.
                                GetFiles( "*.rtf").Where(p => p.Extension == ".rtf" ).ToArray();

            foreach ( FileInfo file in files )
            {
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete( file.FullName );
                }
                catch { }
            }
        }
    }
}
