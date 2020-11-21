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
    public partial class DashForm : Form
    {
        // static variable which holds the template type being chosen by the recruiter
        public static string docType;
        public string mode;
        /// <summary>
        /// Form Constructor
        /// </summary>
        public DashForm(string mode)
        {
            this.mode = mode;
            InitializeComponent();
            // lable gets the name of the recruiter
            lbName.Text = Recruiter.GetInstance().Name;
            if (mode == "newApp")
            {
                // Checks whether the list of the applicants is not empty
                if (Applicant.applicants.Count > 0)
                {
                    btBack.Visible = true;
                }
            }
            else if (mode == "default")
            {
                Applicant.applicants.Clear();
                Connection.GetDbConn().CreateCommand(Constants.deleteApplicant());
                Template.templates.Clear();
                Connection.GetDbConn().CreateCommand(Constants.deleteTemplate());
            }

            // Checks whether there are applicants inserted so that the back button is displayed
            if (Applicant.applicants.Count > 0)
            {
                btBack.Visible = true;
            }
        }

        /// <summary>
        /// Occurs when the user wants to log out from the system
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recruiter.DestroyRecruiInstance(); // Recruiter instance is destroied
            Applicant.applicants.Clear(); // Applicants list is cleared
            Connection.GetDbConn().CreateCommand(Constants.deleteApplicant()); // Applicants are deleted from the database
            
            LoginForm f1 = new LoginForm(); // Returns to the login form
            f1.Show();
        }
        /// <summary>
        /// Occurs when the recruiter click on the Confirm button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Checks whether one of the radio buttons are true
            // AND whether all the fields have been filled
            if (((rbCV.Checked == true) || (rbInterview.Checked == true) ||
               (rbTinterview.Checked == true) || (rbAC.Checked == true)) && 
               ((tbAName.Text.Length > 0) && (tbAJob.Text.Length > 0) && 
               (tbAEmail.Text.Length > 0)))
            { 
                // Insert applicant details into the database
                Connection.GetDbConn().CreateCommand(Constants.insertApplicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, docType, Recruiter.GetInstance().Id));
                // Crearte a new instanc of the applicant class
                Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, docType, Recruiter.GetInstance().Id);
                // Add the instance into the applicant list
                Applicant.applicants.Add(applicant);
                this.Hide();
                // Create a new ConfApplDetails form passing the value false
                ConfApplDetailsForm f3 = new ConfApplDetailsForm(true);
                f3.Show();
            }
            else
            {
                // Displays the error message
                lbError.Visible = true;
            }
        }

        /// <summary>
        /// Occurs when the recruiter clicks on the back button
        /// </summary>
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfApplDetailsForm f3 = new ConfApplDetailsForm(false);
            f3.Show();
        }

        /// <summary>
        /// Occurs when the rbCV is selected
        /// </summary>
        private void rbCV_CheckedChanged(object sender, EventArgs e)
        {
            // set the value as the name of the variable as the name of the template type chosen
            docType = rbCV.Text;
        }

        /// <summary>
        /// Occurs when the rbAC is selected
        /// </summary>
        private void rbAC_CheckedChanged(object sender, EventArgs e)
        {
            // set the value as the name of the variable as the name of the template type chosen
            docType = rbAC.Text;
        }

        /// <summary>
        /// Occurs when the rbInterview is selected
        /// </summary>
        private void rbInterview_CheckedChanged(object sender, EventArgs e)
        {
            // set the value as the name of the variable as the name of the template type chosen
            docType = rbInterview.Text;
        }

        /// <summary>
        /// Occurs when the rbTInterview is selected
        /// </summary>
        private void rbTinterview_CheckedChanged(object sender, EventArgs e)
        {
            // set the value as the name of the variable as the name of the template type chosen
            docType = rbTinterview.Text;
        }

        private void codeViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm f3 = new codeViewForm();
            f3.Show();
        }
    }
}
