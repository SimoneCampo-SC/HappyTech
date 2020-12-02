/**
 * 
 * File: PreviewForm.cs
 * 
 * Author 1: Osborne, Oliver. 1602819
 * Author 2: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the user to preview applicant feedback
 *              before submitting it. The user can then submit, which will
 *              save all the feedback files as PDFs.
 * 
 */

using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static HappyTech.DashForm;

// PdfSharp library for converting .rtfs into .pdfs
// Software GmbH Empira http://www.pdfsharp.net/
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace HappyTech
{
    public partial class PreviewForm : Form
    {
        // Sets available cancel stage options.
        private enum Stage
        {
            NotClicked,
            Clicked
        }

        // Declare variables and sets default cancel stage.
        int currentApplicant;
        string[] applicantDetails;
        Stage cancel = Stage.NotClicked;

        /// <summary>
        /// 
        ///     Default constructor. This will fill the checkbox
        ///     list with applicants and set the submit area information.
        /// 
        /// </summary>
        public PreviewForm()
        {
            InitializeComponent();

            for ( int i = 0; i < Applicant.applicants.Count(); i++ )
            {
                CheckedListBox_FeedbackList.Items.
                    Add( $"{Template.templatesForApplicants[i].Type}  "
                       + $"{Applicant.applicants[i].AJob}  "
                       + $"{Applicant.applicants[i].AfullName}  "
                       + $"{Applicant.applicants[i].Aemail}" );
            }

            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            Label_ApplicantTotal.Text = Applicant.applicants.Count.ToString();
        }

        /// <summary>
        /// 
        ///     This will uncheck all other checkboxes that
        ///     aren't the checkbox that was just checked. This
        ///     ensures only one applicant can be selected at a
        ///     time.
        /// 
        /// </summary>
        private void CheckedListBox_FeedbackList_SelectedValueChanged(object sender, EventArgs e)
        {
            currentApplicant = CheckedListBox_FeedbackList.SelectedIndex;

            for ( int i = 0; i < CheckedListBox_FeedbackList.Items.Count; ++i )
            {
                if ( i != currentApplicant ) CheckedListBox_FeedbackList.SetItemChecked( i, false );
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for preview button.
        ///     This will collect the details of the selected
        ///     applicant and start the feedback form with this
        ///     details.
        /// 
        /// </summary>
        private void Button_Preview_Click(object sender, EventArgs e)
        {
            string applicantLookup = CheckedListBox_FeedbackList.Items[currentApplicant].ToString();
            applicantDetails = applicantLookup.Split( new[] { "  " }, StringSplitOptions.None );

            // Stop preview if no applicants have been selected.

            if ( applicantDetails == null )
            {
                DisplayError( "Select an applicant to preview" );
                return;
            }
            else
            {
                HideError();
            }

            // Don't preview if the files can't be opened.

            if ( FilesInUse() ) return;
            

            Hide();
            FeedbackForm instance_FeedbackForm = new FeedbackForm( applicantDetails[2],  // Name
                                                                   applicantDetails[0],  // Type
                                                                   applicantDetails[3],  // Email
                                                                   applicantDetails[1],  // Job
                                                                   currentApplicant );   // List position
            instance_FeedbackForm.Show();
        }

        /// <summary>
        /// 
        ///     This will attempt to open both feedback and
        ///     comments files to check if they are already
        ///     open somewhere. If they can't be read, they
        ///     are already in use and return true. Else,
        ///     false.
        /// 
        /// </summary>
        private bool FilesInUse()
        {
            try
            {
                using ( StreamReader readFeedback = new StreamReader( Recruiter.GetInstance().Name + applicantDetails[2] + ".rtf" ) ) { }
                using ( StreamReader readComments = new StreamReader( Recruiter.GetInstance().Name + applicantDetails[2] + "-comments.rtf" ) ) { }
            }
            catch (Exception)
            {
                DisplayError( "Files already in use" );
                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        ///     Trigger function for clicking the send all
        ///     button. This will convert the RTF files into
        ///     PDFs. Wipe the RTFs, then set the submit area
        ///     to show success.
        /// 
        /// </summary>
        private void Button_Send_Click( object sender, EventArgs e )
        {

            Button_Send.Image = Properties.Resources.happytech_submit;
            Button_Send.Text = "Sending...";

            ConvertToPDF();

            ClearTemporaryFiles();

            ShowSuccess();

            PictureBox_ManagementStage3.Image = Properties.Resources.happytech_tick;

        }

        /// <summary>
        /// 
        ///     This will change the submit area to show that the
        ///     send all was successful by changing the colours of
        ///     the panel and components.
        /// 
        /// </summary>
        private void ShowSuccess()
        {
            Button_Cancel.Hide();
            Button_Preview.Hide();
            Button_Send.Hide();
            Label_Error.Hide();

            Button_Dashboard.BackColor = Color.FromArgb( 19, 174, 71 ); // Green
            Button_Dashboard.ForeColor = Color.White;
            Button_Dashboard.Show();

            Label_SubmitTitle.ForeColor = Color.White;
            Label_SubmitTitle.Text = "Success.";

            Panel_Submit.BackColor = Color.FromArgb( 19, 174, 71 ); // Green
            Label_Recruiter.ForeColor = Color.White;
            Label_RecruiterName.ForeColor = Color.White;
            Label_Applicants.ForeColor = Color.White;
            Label_ApplicantTotal.ForeColor = Color.White;
        }

        /// <summary>
        /// 
        ///     This will convert the contents of the RTF files
        ///     into a final PDF document that would be emailed
        ///     to the recipient. This is done in bulk by looping
        ///     through all applicants.
        /// 
        /// </summary>
        private void ConvertToPDF()
        {
            for ( int i = 0; i < Applicant.applicants.Count; i++ )
            {
                string feedbackText = "No Feedback given.";
                string commentText  = "No comments made.";

                string name         = Applicant.applicants[i].AfullName;
                string type         = Applicant.applicants[i].Atype;
                string job          = Applicant.applicants[i].AJob;
                string recruiter    = Recruiter.GetInstance().Name;

                // Check feedback and comments exist,
                // if not, use default values set above.

                if ( File.Exists( recruiter + name + ".rtf" ) )
                {
                    using ( StreamReader feedbackFile = new StreamReader( recruiter + name + ".rtf" ) )
                    {
                        feedbackText = feedbackFile.ReadToEnd();
                    }
                }

                if ( File.Exists( recruiter + name + "-comments.rtf" ) )
                {
                    using ( StreamReader commentsFile = new StreamReader( recruiter + name + "-comments.rtf" ) )
                    {
                        commentText = commentsFile.ReadToEnd();
                    }
                }

                // Using PdfSharp Library

                PdfDocument document                    = new PdfDocument();
                PdfPage documentPage                    = document.AddPage();
                XGraphics documentGraphics              = XGraphics.FromPdfPage( documentPage );
                XTextFormatter documentTextFormatter    = new XTextFormatter( documentGraphics );

                XFont documentFont                      = new XFont( "Arial", 8.25, XFontStyle.Bold );
                Image documentImage                     = Properties.Resources.happytech_logo_med;
                MemoryStream documentStream             = new MemoryStream();
                XBrush documentBrush                    = XBrushes.Black;
                XStringFormat documentStringFormat      = XStringFormats.TopLeft;

                documentImage.
                    Save( documentStream, System.Drawing.Imaging.ImageFormat.Png );

                XImage documentLogo                     = XImage.FromStream( documentStream );

                XRect documentEditRectangle             = new XRect( documentPage.Width / 8,
                                                                 ( ( documentPage.Height / 12 ) + documentImage.Height ) + 60,
                                                                   ( documentPage.Width / 8 ) + ( documentPage.Width / 1.5 ),
                                                                     documentPage.Height - ( documentPage.Height / 4 ) );

                XRect documentLogoRectangle             = new XRect( ( documentPage.Width / 2 ) - ( documentLogo.PixelWidth / 2 ),
                                                                       documentPage.Height / 16,
                                                                       documentImage.Width,
                                                                       documentImage.Height );

                // Begin drawing the PDF document

                // Logo

                documentGraphics.
                    DrawImage( documentLogo,
                               documentLogoRectangle );

                // Feedback

                documentTextFormatter.
                    DrawString( $"Dear {name},\n\n" +

                                $"Regarding your {type} for the {job} role at HappyTech.\n\n" +

                                  feedbackText + "\n\n" +

                                 "Further comments:\n\n" +

                                  commentText + $"\n\n" +

                                $"Kind Regards,\n" +
                                $"{recruiter}\n" +
                                $"HappyTech Recruiter",

                                 documentFont,
                                 documentBrush,
                                 documentEditRectangle,
                                 documentStringFormat );

                document.Save( recruiter + name + ".pdf" );
                Process.Start( recruiter + name + ".pdf" );

            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for the cancel button.
        ///     This will double check if the user wants to
        ///     cancel as they will be losing all the progress
        ///     made.
        /// 
        /// </summary>
        private void Button_Cancel_Click( object sender, EventArgs e )
        {
            if ( cancel == Stage.NotClicked )
            {
                Button_Cancel.Text = "Are you sure?";
                cancel = Stage.Clicked;
            }
            else if ( cancel == Stage.Clicked )
            {
                Hide();
                DashForm instance_DashForm = new DashForm( Mode.Default );
                instance_DashForm.Show();
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for dashboard button.
        ///     This will create a new DashForm.cs instance
        ///     and allows the program to loop around to the
        ///     beginning.
        /// 
        /// </summary>
        private void Button_Dashboard_Click( object sender, EventArgs e )
        {
            Hide();
            DashForm instance_DashForm = new DashForm( Mode.Default );
            instance_DashForm.Show();
        }

        /// <summary>
        /// 
        ///     This will remove the RTF files as they are no
        ///     longer needed with the existence of the PDF.
        /// 
        /// </summary>
        private void ClearTemporaryFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            FileInfo[] files = directoryInfo.
                                GetFiles( "*.rtf" ).Where( p => p.Extension == ".rtf" ).ToArray();

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

        /// <summary>
        /// 
        ///     Display an error message to let the user
        ///     know what they did wrong.
        /// 
        /// </summary>
        /// <param name="message"> The error message </param>
        private void DisplayError( string message )
        {
            Label_Error.Text = message;
            Label_Error.Show();
        }

        /// <summary>
        /// 
        ///     Hide the error message to let the user
        ///     know that it is no longer an issue.
        /// 
        /// </summary>
        private void HideError()
        {
            Label_Error.Hide();
        }
    }
}
