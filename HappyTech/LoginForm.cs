using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HappyTech
{
    public partial class LoginForm : Form
    {
        private bool passVis = false;
        private bool debugVis = false;
        /// <summary>
        /// Constructor LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Testing Purposes - Displays Recruiters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (debugVis == false)
            {
                debugVis = true;
                btAutofill.Show();
                btnUsers.Show();
                
            }
            else if (debugVis == true)
            {
                debugVis = false;
                dataViewRecruiter.Hide();
                dataViewRecruiter.DataSource = null;
                btAutofill.Hide();
                btnUsers.Hide();
            }
            
        }

        /// <summary>
        /// Executed when the User Click the Login button
        /// </summary>>
        private void loginButt_Click(object sender, EventArgs e)
        {
            // create a string query to ask the database for
            string login = Constants.selectRecruiter(userEmail.Text, userPassword.Text);

            // open the connection with the DB and ask the query to the database
            DataSet ds = Connection.GetDbConn().getDataSet(login);
           // Console.WriteLine(ds.ToString());
            
            // checks whether the Database has a record of the information inserted
            if (ds.Tables[0].Rows.Count != 0)
            {
                // Points to the Row[0] of the table retrieved from the DB
                DataRow dRow = ds.Tables[0].Rows[0];

                // Call the method which creates the instance 
                Recruiter.createInstance
                    (
                    dRow.ItemArray.GetValue(0).ToString(), // Retrieve the recruiter ID [DB: column 0]
                    dRow.ItemArray.GetValue(1).ToString(), // Retrieve the recruiter Name [DB: column 1]
                    dRow.ItemArray.GetValue(2).ToString(), // Retrieve the recruiter Surname [DB: column 2]
                    dRow.ItemArray.GetValue(3).ToString(), // Retrieve the recruiter Email [DB: column 3]
                    dRow.ItemArray.GetValue(4).ToString()  // Retrieve the recruiter Password [DB: column 4]
                    );

                // Current form is hidden, and the DashForm is created and showed
                this.Hide(); 
                DashForm f2 = new DashForm("default");  
                f2.Show();
            }
            else
            {
                // lable 'error' becomes visible and displays the error message
                error.Visible = true;
                error.Text = "Incorrect email or password";
            }
        }
        /// <summary>
        /// Executed when the User Click the Register button
        /// </summary>
        private void registerButt_Click(object sender, EventArgs e)
        {
            // Current form is hidden, and the RegistrationForm is created and showed
            this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          //  btnPassVis.Hide();
        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {
            //if (!(userPassword.Text == ""))
            if (userPassword.Text.Length > 0)
            {
                btnPassVis.Show();
            }
            else
            {
                btnPassVis.Hide();
            }
        }

        private void btnPassVis_Click(object sender, EventArgs e)
        {
            if (passVis == false)
            {
                passVis = true;
                btnPassVis.Image = Properties.Resources.hidePass;
                userPassword.UseSystemPasswordChar = false;
            }
            else if (passVis == true)
            {
                passVis = false;
                btnPassVis.Image = Properties.Resources.showPass;
                userPassword.UseSystemPasswordChar = true;
            }
            
        }

        // Debug autofill details, for testing purposes
        private void btAutofill_Click(object sender, EventArgs e)
        {
            DataSet dsEmail = Connection.GetDbConn().getDataSet("SELECT email FROM Recruiter");
            DataRow dsEmailRow = dsEmail.Tables[0].Rows[0];
            userEmail.Text = dsEmailRow.ItemArray.GetValue(0).ToString();

            DataSet dsPass = Connection.GetDbConn().getDataSet("SELECT password FROM Recruiter");
            DataRow dsPassRow = dsPass.Tables[0].Rows[0];
            userPassword.Text = dsPassRow.ItemArray.GetValue(0).ToString();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //display table data
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Recruiter");
            dataViewRecruiter.DataSource = ds.Tables[0]; //shows first table
            dataViewRecruiter.Columns[0].Width = 30;
            dataViewRecruiter.Columns[1].Width = 75;
            dataViewRecruiter.Columns[2].Width = 75;
            dataViewRecruiter.Columns[3].Width = 158;
            dataViewRecruiter.Columns[4].Width = 118;
            dataViewRecruiter.Columns[0].HeaderText = "ID";
            dataViewRecruiter.Columns[1].HeaderText = "Name";
            dataViewRecruiter.Columns[2].HeaderText = "Surname";
            dataViewRecruiter.Columns[3].HeaderText = "Email";
            dataViewRecruiter.Columns[4].HeaderText = "Password";
            dataViewRecruiter.Show();
        }
    }
}
