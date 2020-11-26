using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            clearTempFiles();
            // lable gets the name of the recruiter
            lbName.Text = Recruiter.GetInstance().Name + ".";
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
                Template.templatesForApplicants.Clear();
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
            if (btLogout.Text.Equals("Are you sure?"))
            {
                this.Hide();
                Recruiter.DestroyRecruiInstance(); // Recruiter instance is destroied
                Applicant.applicants.Clear(); // Applicants list is cleared
                Template.templatesForApplicants.Clear();
                Connection.GetDbConn().CreateCommand(Constants.deleteApplicant()); // Applicants are deleted from the database
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

                Template.GenerateTemplateForApplicant(applicant, tempTypeBox.SelectedItem.ToString());
   
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

        private void DashForm_Load(object sender, EventArgs e)
        {
            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            imgRecruiter.Image = Properties.Resources.happytech_filled;
            lblAppNameVal.Text = "";
            lblAppEmailVal.Text = "";
            lblAppJobVal.Text = "";
            lblAppTempVal.Text = "";
        }

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
