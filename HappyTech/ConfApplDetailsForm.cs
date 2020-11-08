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
        public ConfApplDetailsForm(bool value)
        {
            InitializeComponent();
            if (value == true)
            {
                lbSuccess.Visible = false;
            }
            lbApplicantNo.Text = Applicant.applicants.Count.ToString() + " applicants added.";
        }

        private void btNewApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm f2 = new DashForm();
            f2.Show();
        }

        private void btStartFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Applicant");
            dataGridView1.DataSource = ds.Tables[0]; //shows first table
        }
    }
}
