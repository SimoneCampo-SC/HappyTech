/**
 * 
 * File: FeedbackForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Osborne, Oliver. 1602819
 * Author 3: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the user to select feedback for
 *              applicants. Furthermore, the user can add comments
 *              and select codes belonging to the template chosen.
 *              They can also iterate at any time to all the other
 *              templates and the details will be saved.
 *              
 */

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static HappyTech.FeedbackClass;

namespace HappyTech
{
    public partial class FeedbackForm : Form
    {
        // Sets the available modes
        public enum Mode
        {
            Feedback,
            Preview,
        }

        int currentPosition;
        private Mode currentMode;

        string PreviewModeApplicantName;

        /// <summary>
        ///  
        ///     Feedback mode constructor. 
        /// 
        /// </summary>
        /// <param name="position"> The position of the template in the list: Integer </param>
        public FeedbackForm( int position )
        {
            InitializeComponent();

            currentMode = Mode.Feedback;
            currentPosition = position;

            Load_CodeList();

            Label_ListPosition.Text = $"Applicant {position + 1} of {Applicant.applicants.Count}";

            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            Label_ApplicantName.Text = Applicant.applicants[position].AfullName;
            Label_ApplicantEmail.Text = Applicant.applicants[position].Aemail;
            Label_ApplicantJob.Text = Applicant.applicants[position].AJob;
            Label_ApplicantTemplate.Text = Template.templatesForApplicants[position].Type;

            // Get the feedback if it exists.
            if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
            {
                using (StreamReader feedbackFile = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
                {
                    RichTextBox_Feedback.Text = feedbackFile.ReadToEnd();
                }
            }

            // Get the comments if it exists.
            if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + "-comments.rtf"))
            {
                using (StreamReader commentsFile = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + "-comments.rtf"))
                {
                    RichTextBox_Comments.Text = commentsFile.ReadToEnd();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicantName"></param>
        /// <param name="appType"></param>
        /// <param name="appEmail"></param>
        /// <param name="appJob"></param>
        /// <param name="curApp"></param>
        public FeedbackForm(string applicantName, string appType, string appEmail, string appJob, int curApp) 
        { 
            // As FeedbackForm usually takes an arguement of the applicant's position in the application list
            // This wont work if you are editing one applicant's feedback from the previewForm screen
            // So overloaded constructor is making a specific type of FeedbackForm for this purpose
            
            InitializeComponent();

            currentMode = Mode.Preview;
            PreviewModeApplicantName = applicantName;
            currentPosition = curApp;

            Load_CodeList();

            Label_ListPosition.Text = "You are in PREVIEW mode";

            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            Label_ApplicantName.Text = applicantName;
            Label_ApplicantEmail.Text = appEmail;
            Label_ApplicantJob.Text = appJob;
            Label_ApplicantTemplate.Text = appType;

            try
            {
                using (StreamReader feedbackFile = new StreamReader(Recruiter.GetInstance().Name + applicantName + ".rtf"))
                {
                    RichTextBox_Feedback.Text = feedbackFile.ReadToEnd();
                }

                using (StreamReader commentsFile = new StreamReader(Recruiter.GetInstance().Name + applicantName + "-comments.rtf"))
                {
                    RichTextBox_Comments.Text = commentsFile.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine( "Can not load feedback or comments as the user has the file open." );
            }
        }

        /// <summary>
        ///     Click trigger function for back button.
        ///     This will return to the previous applicant
        ///     feedback, or if at the start of the list,
        ///     return back to the total applicant list.
        ///     If in preview mode, this will bring the user
        ///     back to the preview form.
        /// 
        /// </summary>
        private void Button_Back_Click(object sender, EventArgs e)
        {
            
            if (currentMode == Mode.Feedback)
            {
                if (currentPosition > 0)
                {
                    Hide();
                    FeedbackForm instance_FeedbackForm = NextForm( Direction.Backward, currentPosition );
                    instance_FeedbackForm.Show();
                }
                else if (currentPosition == 0)
                {
                    Hide();
                    ConfirmApplicantForm instance_ConfirmApplicantForm = new ConfirmApplicantForm( false );
                    instance_ConfirmApplicantForm.Show();
                }
            }
            else if (currentMode == Mode.Preview)
            {
                Hide();
                PreviewForm instance_PreviewForm = new PreviewForm();
                instance_PreviewForm.Show();
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for the next button.
        ///     This will save the feedback and comments, then
        ///     go to the next applicant in the list or if at
        ///     the end of the list, will go to the preview form.
        ///     If in preview mode, this will save the feedback
        ///     and return to the preview form.
        /// 
        /// </summary>
        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Feedback)
            {
                // save template
                if (RichTextBox_Feedback.Text.Length > 0)
                {
                    using (StreamWriter feedbackFile = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".rtf"))
                    {
                        feedbackFile.WriteLine(RichTextBox_Feedback.Text);
                    }
                }


                // save comments
                if (RichTextBox_Comments.Text.Length > 0)
                {
                    using (StreamWriter commentsFile = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + "-comments.rtf"))
                    {
                        commentsFile.WriteLine(RichTextBox_Comments.Text);
                    }
                }

                if (currentPosition < Template.templatesForApplicants.Count - 1)
                {
                    Hide();
                    FeedbackForm instance_FeedbackForm = NextForm(Direction.Forward, currentPosition);
                    instance_FeedbackForm.Show();
                }
                else if (currentPosition >= Template.templatesForApplicants.Count - 1)
                {
                    Hide();
                    PreviewForm instance_PreviewForm = new PreviewForm();
                    instance_PreviewForm.Show();
                }
            }
            else if (currentMode == Mode.Preview)
            {
                if (RichTextBox_Feedback.Text.Length > 0)
                {
                    using (StreamWriter feedbackFile = new StreamWriter(Recruiter.GetInstance().Name + PreviewModeApplicantName + ".rtf"))
                    {
                        feedbackFile.WriteLine(RichTextBox_Feedback.Text);
                    }
                }

                if (RichTextBox_Comments.Text.Length > 0)
                {
                    using (StreamWriter commentsFile = new StreamWriter(Recruiter.GetInstance().Name + PreviewModeApplicantName + "-comments.rtf"))
                    {
                        commentsFile.WriteLine(RichTextBox_Comments.Text);
                    }
                }

                Hide();
                PreviewForm instance_PreviewForm = new PreviewForm();
                instance_PreviewForm.Show();
            }
        }

        /// <summary>
        /// 
        ///     This will load the list of codes for
        ///     the feedback. Filling them from the
        ///     database.
        /// 
        /// </summary>
        private void Load_CodeList()
        {
            // Only populate listbox with codes where
            // Section id is in personalsection with selected template
            Section.FillSectionList();

            // Have template id so can get personalSection sections
            int templateId = Template.templatesForApplicants[currentPosition].Id;

            // Maybe it is equal to Constants.SelectSectionPerTemplate(tempID) ??
            string psSections = $"SELECT section_ID FROM PersonalSection Where '{templateId}' IN (template_ID)"; 

            DataSet personalSectionDB = Connection.GetDbConn().
                                            GetDataSet(psSections);
            DataRow personalSectionDBValue;

            for (int i = 0; i < personalSectionDB.Tables[0].Rows.Count; i++)
            { 
                // For each section in personal section, need to add all codes
                personalSectionDBValue = personalSectionDB.Tables[0].Rows[i];
                string sectionId = personalSectionDBValue.ItemArray.GetValue(0).ToString();
                
                string getCodes = $"SELECT codeShort FROM Codes WHERE sectionNo = '{sectionId}'";

                DataSet codeDB = Connection.GetDbConn().
                                    GetDataSet( getCodes );
                DataRow codeDBValue;

                for (int j = 0; j < codeDB.Tables[0].Rows.Count; j++)
                {
                    try
                    {
                        codeDBValue = codeDB.Tables[0].Rows[j];

                        ListBox_CodesList.Items.
                            Add( codeDBValue.ItemArray.GetValue(0).ToString() );

                        foreach ( string code in Applicant.applicants[currentPosition].selectedAppCodes )
                        {
                            if ( codeDBValue.ItemArray.GetValue(0).ToString() == code )
                            {
                                ListBox_CodesList.
                                    SetItemChecked( ListBox_CodesList.Items.Count - 1, true );
                            }
                        }
                        
                    }
                    catch 
                    {
                        Console.WriteLine( "Section has no code attached." );
                    } 
                }
            }
        }

        /// <summary>
        /// 
        ///     Select item trigger function for code list.
        ///     This will clear the feedback and refill it with
        ///     the code paragraphs of the selected codes.
        ///     This will also add the code to the applicant's
        ///     selected codes so they can be used later on.
        ///     
        /// 
        /// </summary>
        private void ListBox_CodesList_SelectedValueChanged( object sender, EventArgs e )
        {
            Code.selectedCodes.Clear();
            Applicant.applicants[currentPosition].selectedAppCodes.Clear();

            RichTextBox_Feedback.Text = "";

            foreach (string code in ListBox_CodesList.CheckedItems)
            {
                // Get the code short of the selected list item
                string codeShortLookup = code;

                codeShortLookup = codeShortLookup.Replace(" ", "");
                string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShortLookup}'";

                DataSet codeDB = Connection.GetDbConn().
                                    GetDataSet( query );

                DataRow codeDBValue = codeDB.Tables[0].Rows[0];

                // Goes to the db, returns the first row (the codeparagraph) stores in variable
                string codeParagraph = codeDBValue.ItemArray.GetValue(0).ToString();

                Code.selectedCodes.
                    Add( codeParagraph );

                Applicant.applicants[currentPosition].selectedAppCodes.
                    Add( code );
            }
            foreach (string code in Code.selectedCodes)
            {
                RichTextBox_Feedback.
                    AppendText(code + "\n\n");
            }
        }
    }
}