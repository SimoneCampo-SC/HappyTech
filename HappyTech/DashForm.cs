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
        public string mode;

        /// <summary>
        /// Constructor of the DashForm Class
        /// </summary>
        /// <param name="mode"> either "newApp" or "default"</param>
        public DashForm(string mode)
        {
            this.mode = mode;
            InitializeComponent();
            clearTempFiles();
            // lable gets the name of the recruiter
            lbName.Text = $"{Recruiter.GetInstance().Name}.";

            // Gets all the templates from the database
            DataSet ds = Connection.GetDbConn().getDataSet(SqlQueries.SelectTemplateType());

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // Populate the tempTypeBox with the name of the Templates
                tempTypeBox.Items.Add(ds.Tables[0].Rows[i].ItemArray.GetValue(0));
            }

            // Switch constructor checks the mode parameter: ToLower() to make it not case sensitive.
            switch (mode.ToLower())
            {
                case "newapp":
                    // Checks whether the list of the applicants is not empty
                    if (Applicant.applicants.Count > 0)
                    {
                        // Displays the btBack object
                        btBack.Visible = true;
                    }
                    break;

                case "default":
                    // Deletes all the items in the applicants and templatesForApplicants lists
                    // Deletes the applicants from the Database
                    Applicant.applicants.Clear();
                    Template.templatesForApplicants.Clear();
                    Connection.GetDbConn().CreateCommand(SqlQueries.deleteApplicant());
                    break;
                default:
                    // Do nothing 
                    break;
            }
        }

        /// <summary>
        /// Occurs when the user wants to log out from the system
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (btLogout.Text.Equals("Are you sure?"))
            {
                this.Hide();
                Recruiter.DestroyRecruiInstance(); // Recruiter instance is destroied
                Applicant.applicants.Clear(); // Applicants list is cleared
                Template.templatesForApplicants.Clear();
                Connection.GetDbConn().CreateCommand(SqlQueries.deleteApplicant()); // Applicants are deleted from the database
                LoginForm f1 = new LoginForm(); // Returns to the login form
                f1.Show();
            }
            else
            {
                btLogout.Text = "Are you sure?";
            }
        }

        /// <summary>
        /// Occurs when the recruiter click on the Confirm button
        /// </summary>
        private void btConfirm_Click(object sender, EventArgs e)
        {
            // Checks whether an item in the tempTypeBox has been selected
            // AND whether all the fields have been filled
            if ((tempTypeBox.SelectedItem != null) &&
               ((tbAName.Text.Length > 0) && (tbAJob.Text.Length > 0) &&
               (tbAEmail.Text.Length > 0)))
            {
                if ((tbAName.Text.Length <= 50) && (tbAJob.Text.Length <= 50) && (tbAEmail.Text.Length <= 50))
                {
                    // Insert applicant details into the database
                    Connection.GetDbConn().CreateCommand(SqlQueries.insertApplicant(tbAName.Text, tbAEmail.Text, 
                                                         tbAJob.Text, Recruiter.GetInstance().Id));

                    // Crearte a new instance of the applicant class
                    Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, 
                                                        Recruiter.GetInstance().Id, tempTypeBox.SelectedItem.ToString()); 

                    // Add the instance into the applicant list
                    Applicant.applicants.Add(applicant);

                    Template.GenerateTemplateForApplicant(applicant, tempTypeBox.SelectedItem.ToString());

                    this.Hide();
                    // Create a new ConfApplDetails form passing the value false
                    ConfirmApplicantForm f3 = new ConfirmApplicantForm(true);
                    f3.Show();
                }
                else
                {
                    lbError.Visible = true;
                    lbError.Text = "Fields must be 50 characters or less";
                }
            }
            else
            {
                // Displays the error message
                lbError.Visible = true;
                lbError.Text = "Missing required fields";
            }
        }

        /// <summary>
        /// Occurs when the recruiter clicks on the back button
        /// </summary>
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfirmApplicantForm f3 = new ConfirmApplicantForm(false);
            f3.Show();
        }
        private void codeViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CodeViewForm f3 = new CodeViewForm();
            f3.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void tempTypeBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 8, e.Bounds.Y + 8, 16, 16);
                e.Graphics.DrawString(tempTypeBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 32, e.Bounds.Y + 8);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void tbAName_TextChanged(object sender, EventArgs e)
        {
            lblAppNameVal.Text = tbAName.Text;
            if (lblAppNameVal.Text.Length > 0)
            {
                imgAppName.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                imgAppName.Image = Properties.Resources.happytech_empty;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void DashForm_Load(object sender, EventArgs e)
        {
            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            imgRecruiter.Image = Properties.Resources.happytech_filled;
            lblAppNameVal.Text = "";
            lblAppEmailVal.Text = "";
            lblAppJobVal.Text = "";
            lblAppTempVal.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        private void tbAEmail_TextChanged(object sender, EventArgs e)
        {
            lblAppEmailVal.Text = tbAEmail.Text;
            if (lblAppEmailVal.Text.Length > 0)
            {
                imgAppEmail.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                imgAppEmail.Image = Properties.Resources.happytech_empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void tbAJob_TextChanged(object sender, EventArgs e)
        {
            lblAppJobVal.Text = tbAJob.Text;
            if (lblAppJobVal.Text.Length > 0)
            {
                imgAppJob.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                imgAppJob.Image = Properties.Resources.happytech_empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void tempTypeBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (tempTypeBox.SelectedItem != null)
            {
                lblAppTempVal.Text = tempTypeBox.SelectedItem.ToString();
            }

            if (lblAppTempVal.Text.Length > 0)
            {
                imgAppTemp.Image = Properties.Resources.happytech_filled;
            }
            else
            {
                imgAppTemp.Image = Properties.Resources.happytech_empty;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void clearTempFiles()
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
    }
}
