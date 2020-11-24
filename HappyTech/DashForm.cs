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
            }

            // Checks whether there are applicants inserted so that the back button is displayed
            if (Applicant.applicants.Count > 0)
            {
                btBack.Visible = true;
            }
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.selectTemplateType());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tempTypeBox.Items.Add(ds.Tables[0].Rows[i].ItemArray.GetValue(0));
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
            Template.templates.Clear();
            Connection.GetDbConn().CreateCommand(Constants.deleteApplicant()); // Applicants are deleted from the database
            
            LoginForm f1 = new LoginForm(); // Returns to the login form
            f1.Show();
        }
        /// <summary>
        /// Occurs when the recruiter click on the Confirm button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Checks whether an item in the tempTypeBox has been selected
            // AND whether all the fields have been filled
            if ((tempTypeBox.SelectedItem != null) && 
               ((tbAName.Text.Length > 0) && (tbAJob.Text.Length > 0) && 
               (tbAEmail.Text.Length > 0)))
            { 
                // Insert applicant details into the database
                Connection.GetDbConn().CreateCommand(Constants.insertApplicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, Recruiter.GetInstance().Id));
                
                // Crearte a new instance of the applicant class
                Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, Recruiter.GetInstance().Id);
                // Add the instance into the applicant list
                Applicant.applicants.Add(applicant);

                Template.generateTemplate(applicant, tempTypeBox.SelectedItem.ToString());
   
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
        private void codeViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm f3 = new codeViewForm();
            f3.Show();
        }

       
    }
}
