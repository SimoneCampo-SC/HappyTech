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
        string cancelStage;

        /// <summary>
        /// Constructor of the current Form
        /// </summary>
        /// <param name="value">holds the value which says whether the recruiter added a new applicant</param>
        public ConfApplDetailsForm(bool value)
        {
            InitializeComponent();

            cancelStage = "notClicked";

            // Checks whether the value is false
            if (value == false)
            {
                // successfull message is not displayed
                lbSuccess.Visible = false;
            }

            // displays how many applicants have been added so far
            lbApplicantNo.Text = "Applicants:    " + Applicant.applicants.Count.ToString();

            // Load the Applicants added into the Database
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.SelectApplicant());
            dgvApplicant.DataSource = ds.Tables[0]; //shows first table
            for (int i = 0; i < dgvApplicant.Columns.Count; i++)
            {
                dgvApplicant.Columns[i].Width = 181;
            }
            
            //DataGridViewColumn column = dgvApplicant.Columns[0];
            //column.Width = 60;


        }

        /// <summary>
        /// Occurs when the recruiter clicks the new button
        /// </summary>
        private void btNewApp_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Dashform displayed again
            DashForm f2 = new DashForm("newApp");
            f2.Show();
        }

        /// <summary>
        /// Occurs when the recruiter clics the Next button
        /// </summary>
        private void btStartFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditorForm f = EditorClass.NextForm("default", 0); // New EditorForm is created passing by values 2 (Default value) and 0
            f.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (cancelStage == "notClicked")
            {
                btCancel.Text = "Are you sure?";
                cancelStage = "clicked";
            }
            else if (cancelStage == "clicked")
            {
                this.Hide();
                DashForm f2 = new DashForm("default");
                f2.Show();
            }
        }
    }
}
