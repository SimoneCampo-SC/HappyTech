/**
 * 
 * File: previewForm.cs
 * 
 * Author 1: Osborne, Oliver. 1602819 (OMO123@student.aru.ac.uk)
 * Author 2: Hopper, Kean. SID (EMAIL)
 * Course: BEng (Hons) Computer Science, Year 2 Timester 1
 * 
 * Summary:     This file allows the user to preview applicant feedback
 *              before submitting it. The user can then submit which will
 *              save the all feedback as a PDF (to theoretically send bulk emails).
 * 
 */

using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// PdfSharp library for converting .rtfs into .pdfs
// Software GmbH Empira http://www.pdfsharp.net/
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace HappyTech
{
    public partial class previewForm : Form
    {
        // 
        private enum CancelStage
        {
            NotClicked,
            Clicked
        }

        // 
        int currentApplicant;
        string[] applicantDetails;
        CancelStage currentCancel = CancelStage.NotClicked;

        /// <summary>
        /// 
        ///     Cleaned, needs commenting
        /// 
        /// </summary>
        public previewForm()
        {
            InitializeComponent();

            for ( int i = 0; i < Applicant.applicants.Count(); i++ )
            {
                CheckedListBox_FeedbackList.Items.
                    Add( $"{Template.templatesForApplicants[i].TempType}  "
                       + $"{Applicant.applicants[i].AJob}  "
                       + $"{Applicant.applicants[i].AfullName}  "
                       + $"{Applicant.applicants[i].Aemail}" );
            }

            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            Label_ApplicantTotal.Text = Applicant.applicants.Count.ToString();
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void CheckedListBox_FeedbackList_SelectedValueChanged(object sender, EventArgs e)
        {
            currentApplicant = CheckedListBox_FeedbackList.SelectedIndex;
            for (int i = 0; i < CheckedListBox_FeedbackList.Items.Count; ++i)
            {
                if (i != currentApplicant) CheckedListBox_FeedbackList.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// 
        ///     cleaned, needs commenting
        /// 
        /// </summary>
        private void Button_Preview_Click(object sender, EventArgs e)
        {
            string applicantLookup = CheckedListBox_FeedbackList.Items[currentApplicant].ToString();
            applicantDetails = applicantLookup.Split(new[] { "  " }, StringSplitOptions.None);

            // stop preview if no applicants have been selected
            if ( applicantDetails == null )
            {
                DisplayError( "Select an applicant to preview" );
                return;
            }
            else
            {
                HideError();
            }

            TestFilesNotInUse();

            Applicant applicant = new Applicant(applicantDetails[2],        // name
                                                applicantDetails[3],        // email
                                                applicantDetails[1],        // job
                                                Recruiter.GetInstance().Id, // recruiter id
                                                applicantDetails[4]);       // type
            
            Hide();
            EditorForm instance_EditorForm = new EditorForm(applicantDetails[2], applicantDetails[0], applicantDetails[3], applicantDetails[1], currentApplicant);
            instance_EditorForm.Show();
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void TestFilesNotInUse()
        {
            try
            {
                using (StreamReader readFeedback = new StreamReader(Recruiter.GetInstance().Name + applicantDetails[2] + ".rtf")) { }
                using (StreamReader readComments = new StreamReader(Recruiter.GetInstance().Name + applicantDetails[2] + "-comments.rtf")) { }
            }
            catch (Exception)
            {
                DisplayError("File already in use");
                return;
            }
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Send_Click(object sender, EventArgs e)
        {
            Button_Send.Image = Properties.Resources.happytech_submit;
            Button_Send.Text = "Sending...";

            // Turn rtf files into pdf files here
            ConvertToPDF();

            ClearTemporaryFiles();

            Button_Cancel.Hide();
            Button_Preview.Hide();
            Button_Send.Hide();
            Label_Error.Hide();

            Button_Dashboard.BackColor = Color.FromArgb(19,174,71);
            Button_Dashboard.ForeColor = Color.White;
            Button_Dashboard.Show();

            Label_SubmitTitle.ForeColor = Color.White;
            Label_SubmitTitle.Text = "Success.";

            Panel_Submit.BackColor = Color.FromArgb(19, 174, 71);
            Label_Recruiter.ForeColor = Color.White;
            Label_RecruiterName.ForeColor = Color.White;
            Label_Applicants.ForeColor = Color.White;
            Label_ApplicantTotal.ForeColor = Color.White;

            PictureBox_ManagementStage3.Image = Properties.Resources.happytech_tick;

        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void ConvertToPDF()
        {
            for (int i = 0; i < Applicant.applicants.Count; i++)
            {
                string feedbackText = "";
                string commentText = "";

                using (StreamReader feedbackFile = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[i].AfullName + ".rtf"))
                {
                    feedbackText = feedbackFile.ReadToEnd();
                }

                if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[i].AfullName + "-comments.rtf"))
                {
                    using (StreamReader commentsFile = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[i].AfullName + "-comments.rtf"))
                    {
                        commentText = commentsFile.ReadToEnd();
                    }
                }

                ///// PdfSharp PDF version
                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XTextFormatter tf = new XTextFormatter(graph);
                
                XFont font = new XFont("Arial", 8.25, XFontStyle.Bold);
                Image img = Properties.Resources.happytech_logo_med;
                MemoryStream strm = new MemoryStream();
                img.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
                XImage logo = XImage.FromStream(strm);
                XRect rec = new XRect((pdfPage.Width / 2) - (logo.PixelWidth / 2), pdfPage.Height / 16, img.Width, img.Height);
                graph.DrawImage(logo, rec);
                
                tf.DrawString($"Dear {Applicant.applicants[i].AfullName},\n\nRegarding your {Applicant.applicants[i].Atype} for the {Applicant.applicants[i].AJob} role at HappyTech.\n\n"
                    + feedbackText
                    + "\n\nFurther comments:\n\n"
                    + commentText
                    + $"\n\nKind Regards,\n{Recruiter.GetInstance().Name}\nHappyTech Recruiter",
                    font,
                    XBrushes.Black,
                    new XRect(pdfPage.Width / 8,
                        ((pdfPage.Height / 12) + img.Height) + 60,
                        (pdfPage.Width / 8) + (pdfPage.Width / 1.5),
                        pdfPage.Height - (pdfPage.Height / 4)),
                    XStringFormats.TopLeft);
                
                pdf.Save(Recruiter.GetInstance().Name + Applicant.applicants[i].AfullName + ".pdf");
                Process.Start(Recruiter.GetInstance().Name + Applicant.applicants[i].AfullName + ".pdf");

            }
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            if (currentCancel == CancelStage.NotClicked)
            {
                Button_Cancel.Text = "Are you sure?";
                currentCancel = CancelStage.Clicked;
            }
            else if (currentCancel == CancelStage.Clicked)
            {
                Hide();
                DashForm instance_DashForm = new DashForm("default");
                instance_DashForm.Show();
            }
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            Hide();
            DashForm instance_DashForm = new DashForm("default");
            instance_DashForm.Show();
        }

        /// <summary>
        /// 
        ///     //
        /// 
        /// </summary>
        private void ClearTemporaryFiles()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] files = di.GetFiles("*.rtf").Where(p => p.Extension == ".rtf").ToArray();

            foreach (FileInfo file in files)
            {
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
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
        private void DisplayError(string message)
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
