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
        public DashForm()
        {
            InitializeComponent();
            lbName.Text = Recruiter.GetInstance().GetName();
            if (Applicant.applicants.Count > 0)
            {
                btBack.Visible = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recruiter.DestroyRecruiInstance();
            Applicant.applicants.Clear();
            Connection.GetDbConn().CreateCommand(Constants.deleteApplicant());
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((rbCV.Checked == true) || (rbInterview.Checked == true) ||
               (rbTinterview.Checked == true) || (rbAC.Checked == true)) && 
               ((tbAName.Text.Length > 0) && (tbAJob.Text.Length > 0) && 
               (tbAEmail.Text.Length > 0)))
            {
                Connection.GetDbConn().CreateCommand(Constants.insertApplicant(tbAName.Text, tbAEmail.Text, tbAJob.Text));
                Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text);
                Applicant.applicants.Add(applicant);
                this.Hide();
                ConfApplDetailsForm f3 = new ConfApplDetailsForm(false);
                f3.Show();
            }
            else
            {
                lbError.Text = "All the fields must be inserted";
                lbError.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rbAC_CheckedChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void codesViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cf = new codeViewForm();
            cf.Show();
=======
>>>>>>> parent of 5144c56... Merge pull request #4 from BlackSun93/tagCodes-PROTOTYPE
=======
>>>>>>> parent of 5144c56... Merge pull request #4 from BlackSun93/tagCodes-PROTOTYPE
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfApplDetailsForm f3 = new ConfApplDetailsForm(true);
            f3.Show();
        }
    }
}
