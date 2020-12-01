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

namespace HappyTech
{
    public partial class FeedbackForm : Form
    {
        // Holds the position of the templates in the list
        int currentPosition;

        /* This tracks how the editor was generated, either feedback - if form created from dashform
         * or wasn't the last applicant 
         * mode is "preview" if a document has been selected to edit from the previewForm 
         */
        string mode;

        // Used to determine function of back button and is set in the constructors
        string previewAppName;

        /// <summary>
        ///  Constructor of the current form
        /// </summary>
        /// <param name="position">holds the current position of the template being showed</param>
        public FeedbackForm(int position)
        {
            mode = "feedback";
            currentPosition = position; // update the currentPosition
            InitializeComponent();
            loadListBox();

            /* Displays the applicant selected out of all the applicants
             * position + 1 as the iterator starts from 0 to n-1 */
            lbApplicants.Text = $"Applicant {position + 1} of {Applicant.applicants.Count}";
            richTextBox2.Text = "";
            richTextBox1.Text = "";

            // Takes the header of the template in the assigned position in the list
            // lbHeader.Text = Template.templates[position].Header;
            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            lblAppNameVal.Text = Applicant.applicants[position].AfullName;
            lblAppEmailVal.Text = Applicant.applicants[position].Aemail;
            lblAppJobVal.Text = Applicant.applicants[position].AJob;
            lblAppTempVal.Text = Template.templatesForApplicants[position].TempType;

            // 
            if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
                {
                        richTextBox2.Text = sr.ReadToEnd();
                }
            }
            // 
            if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + "-comments.rtf"))
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + "-comments.rtf"))
                {

                        richTextBox1.Text = sr.ReadToEnd();

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
            // As editorForm usually takes an arguement of the applicant's position in the application list
            // This wont work if you are editing one applicant's feedback from the previewForm screen
            // So overloaded constructor is making a specific type of editorform for this purpose
            mode = "preview";
            previewAppName = applicantName;
            currentPosition = curApp;
            InitializeComponent();
            loadListBox();
            lbApplicants.Text = $"You are in PREVIEW mode";
            richTextBox2.Text = "";
            richTextBox1.Text = "";

            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            lblAppNameVal.Text = applicantName;
            lblAppEmailVal.Text = appEmail;
            lblAppJobVal.Text = appJob;
            lblAppTempVal.Text = appType;

            try
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + applicantName + ".rtf"))
                {
                    //this is supposed to find the saved feedback file and prefill richTextBox2 with the feedback
                    //however, this shows formatting code which is not ideal. formatting does not show if file opened in 
                    //word

                        richTextBox2.Text = sr.ReadToEnd();

                }

                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + applicantName + "-comments.rtf"))
                {
                        richTextBox1.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            { 
                // User has the file open
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            
            if (mode == "feedback")
            {
                if (currentPosition > 0)
                {
                    this.Hide();
                    FeedbackForm f = FeedbackClass.NextForm("backward", currentPosition);
                    f.Show();
                }
                else if (currentPosition == 0)
                {
                   //  Template.templatesForApplicants.Clear();
                    this.Hide();
                    ConfirmApplicantForm cadf = new ConfirmApplicantForm(false);
                    cadf.Show();
                }
            }
            else if (mode == "preview")
            {
                this.Hide();
                PreviewForm pf = new PreviewForm();
                pf.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btNext2_Click(object sender, EventArgs e)
        {
            if (mode == "feedback")
            {
                // save template
                if (richTextBox2.Text.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".rtf"))
                    {
                        sw.WriteLine(richTextBox2.Text);
                    }
                }


                // save comments
                if (richTextBox1.Text.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + "-comments.rtf"))
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }

                if (currentPosition < Template.templatesForApplicants.Count - 1)
                {
                    Hide();
                    FeedbackForm f = FeedbackClass.NextForm("forward", currentPosition);
                    f.Show();
                }
                else if (currentPosition >= Template.templatesForApplicants.Count - 1)
                {
                    Hide();
                    PreviewForm pf = new PreviewForm();
                    pf.Show();
                }
            }
            else if (mode == "preview")
            {
                if (richTextBox2.Text.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + previewAppName + ".rtf"))
                    {
                        sw.WriteLine(richTextBox2.Text);
                    }
                }

                if (richTextBox1.Text.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + previewAppName + "-comments.rtf"))
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }

                Hide();
                PreviewForm pf = new PreviewForm();
                pf.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void loadListBox()
        {
            // Only populate listbox with codes where
            // Section id is in personalsection with selected template
            Section.FillSectionList();

            // Have template id so can get personalSection sections
            int tempId = Template.templatesForApplicants[currentPosition].Id;

            // Maybe it is equal to Constants.SelectSectionPerTemplate(tempID) ??
            string psSections = $"SELECT section_ID FROM PersonalSection Where '{tempId}' IN (template_ID)"; 

            DataSet ds1 = Connection.GetDbConn().getDataSet(psSections);
            DataRow dRow1;

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            { 
                // For each section in personal section, need to add all codes
                dRow1 = ds1.Tables[0].Rows[i];
                string sectionId = dRow1.ItemArray.GetValue(0).ToString();
                
                string getCodes = $"SELECT codeShort FROM Codes WHERE sectionNo = '{sectionId}'";
                DataSet ds2 = Connection.GetDbConn().getDataSet(getCodes);
                DataRow dRow2;
                for (int j = 0; j <ds2.Tables[0].Rows.Count; j++)
                {
                    try
                    {
                        dRow2 = ds2.Tables[0].Rows[j];
                        Console.WriteLine(dRow2.ItemArray.GetValue(0).ToString());
                        listBox.Items.Add(dRow2.ItemArray.GetValue(0).ToString());
                        foreach (string code in Applicant.applicants[currentPosition].selectedAppCodes)
                        {
                            if (dRow2.ItemArray.GetValue(0).ToString() == code)
                            {
                                listBox.SetItemChecked(listBox.Items.Count - 1, true);
                            }
                        }
                        
                    }
                    catch 
                    {
                        // Just in case there is a section that has no codes attached
                    } 
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Code.selectedCodes.Clear();
            Applicant.applicants[currentPosition].selectedAppCodes.Clear();
            richTextBox2.Text = "";
            foreach (string code in listBox.CheckedItems)
            {
                // Get the code short of the selected list item
                string codeShortLookup = code;
                codeShortLookup = codeShortLookup.Replace(" ", "");
                string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShortLookup}'";
                DataSet ds = Connection.GetDbConn().getDataSet(query);
                DataRow dRow = ds.Tables[0].Rows[0];
                // Goes to the db, returns the first row (the codeparagraph) stores in variable
                string paragraphToAdd = dRow.ItemArray.GetValue(0).ToString();
                Code.selectedCodes.Add(paragraphToAdd);
                Applicant.applicants[currentPosition].selectedAppCodes.Add(code);
            }
            foreach (string code in Code.selectedCodes)
            {
                richTextBox2.AppendText(code + "\n\n");
            }
        }
    }
}