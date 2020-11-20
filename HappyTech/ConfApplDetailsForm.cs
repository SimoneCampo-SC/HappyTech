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
    public partial class ConfApplDetailsForm : Form
    {
        /// <summary>
        /// Constructor of the current Form
        /// </summary>
        /// <param name="value">holds the value which says whether the recruiter added a new applicant</param>
        public ConfApplDetailsForm(bool value)
        {
            InitializeComponent();

            // Checks whether the value is false
            if (value == false)
            {
                // successfull message is not displayed
                lbSuccess.Visible = false;
            }
            // displays how many applicants have been added so far
            lbApplicantNo.Text = Applicant.applicants.Count.ToString() + " applicants added.";
        }

        /// <summary>
        /// Occurs when the recruiter clicks the new button
        /// </summary>
        private void btNewApp_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Dashform displayed again
            DashForm f2 = new DashForm("addApp");
            f2.Show();
        }

        /// <summary>
        /// Occurs when the recruiter clics the Next button
        /// </summary>
        private void btStartFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Template.generateTemplates(); // Templates are generated
            EditorForm f = EditorClass.NextForm(2, 0); // New EditorForm is created passing by values 2 (Default value) and 0
            f.Show();
        }

        // Testing purposes
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Applicant");
            dataGridView1.DataSource = ds.Tables[0]; //shows first table
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm f2 = new DashForm("default");
            f2.Show();
        }
    }
}
