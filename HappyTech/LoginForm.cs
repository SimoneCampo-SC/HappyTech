/**
 * 
 * File: LoginForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Author 3: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the user to login into the system using
 *              their own credentials.
 *              
 */

using System;
using System.Data;
using System.Windows.Forms;
using static HappyTech.DashForm;


namespace HappyTech
{
    public partial class LoginForm : Form
    {
        private bool passwordVisible = false;
        private bool debugVisible = false;

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
        private void Button_Debug_Click(object sender, EventArgs e)
        {
            if (debugVisible == false)
            {
                debugVisible = true;
                Button_Autofill.Show();
                Button_Users.Show();
                
            }
            else if (debugVisible == true)
            {
                debugVisible = false;
                DataGrid_Users.Hide();
                DataGrid_Users.DataSource = null;
                Button_Autofill.Hide();
                Button_Users.Hide();
            }
            
        }

        /// <summary>
        /// Click trigger function for the login button.
        /// If the credentials exist in the database, the recruiter instance is created
        /// and the DashForm is showed
        /// 
        /// </summary>>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            // create a string query to ask the database for
            string login = SqlQueries.SelectRecruiter(TextBox_Email.Text, TextBox_Password.Text);

            // open the connection with the DB and ask the query to the database
            DataSet recruiterDB = Connection.GetDbConn().GetDataSet(login);
           // Console.WriteLine(ds.ToString());
            
            // checks whether the Database has a record of the information inserted
            if (recruiterDB.Tables[0].Rows.Count != 0)
            {
                // Points to the Row[0] of the table retrieved from the DB
                DataRow recruiterDBValue = recruiterDB.Tables[0].Rows[0];

                // Call the method which creates the instance 
                Recruiter.CreateInstance
                    (
                    recruiterDBValue.ItemArray.GetValue(0).ToString(), // Retrieve the recruiter ID [DB: column 0]
                    recruiterDBValue.ItemArray.GetValue(1).ToString(), // Retrieve the recruiter Name [DB: column 1]
                    recruiterDBValue.ItemArray.GetValue(2).ToString(), // Retrieve the recruiter Surname [DB: column 2]
                    recruiterDBValue.ItemArray.GetValue(3).ToString(), // Retrieve the recruiter Email [DB: column 3]
                    recruiterDBValue.ItemArray.GetValue(4).ToString()  // Retrieve the recruiter Password [DB: column 4]
                    );

                Hide();
                DashForm instance_DashForm = new DashForm(Mode.Default);
                instance_DashForm.Show();
            }
            else
            {
                // lable 'error' becomes visible and displays the error message
                Label_Error.Text = "Incorrect email or password";
                Label_Error.Visible = true;
            }
        }
        /// <summary>
        /// Click trigger function for the create button
        /// Registration form is showed
        /// </summary>
        private void Button_Create_Click(object sender, EventArgs e)
        {
            // Current form is hidden, and the RegistrationForm is created and showed
            Hide();
            RegistrationForm instance_RegistrationForm = new RegistrationForm();
            instance_RegistrationForm.Show();
        }

        /// <summary>
        /// Occurs when the user change the text inside the userPassword box
        /// </summary>
        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_Password.Text.Length > 0)
            {
                Button_PasswordVisibility.Show();
            }
            else
            {
                Button_PasswordVisibility.Hide();
            }
        }

        /// <summary>
        /// Occurs whenever the user clicks the btnPassVis object
        /// </summary>
        private void Button_PasswordVisibility_Click(object sender, EventArgs e)
        {
            if (passwordVisible == false)
            {
                passwordVisible = true;
                Button_PasswordVisibility.Image = Properties.Resources.hidePass;
                TextBox_Password.UseSystemPasswordChar = false;
            }
            else if (passwordVisible == true)
            {
                passwordVisible = false;
                Button_PasswordVisibility.Image = Properties.Resources.showPass;
                TextBox_Password.UseSystemPasswordChar = true;
            }
            
        }

        // Debug autofill details, for testing purposes
        private void Button_Autofill_Click(object sender, EventArgs e)
        {
            DataSet dsEmail = Connection.GetDbConn().
                                GetDataSet("SELECT email FROM Recruiter");

            DataRow dsEmailRow = dsEmail.Tables[0].Rows[0];
            TextBox_Email.Text = dsEmailRow.ItemArray.GetValue(0).ToString();

            DataSet dsPass = Connection.GetDbConn().
                                GetDataSet("SELECT password FROM Recruiter");

            DataRow dsPassRow = dsPass.Tables[0].Rows[0];
            TextBox_Password.Text = dsPassRow.ItemArray.GetValue(0).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Button_Users_Click(object sender, EventArgs e)
        {
            //display table data
            DataSet ds = Connection.GetDbConn().
                            GetDataSet("SELECT * FROM Recruiter");
            DataGrid_Users.DataSource = ds.Tables[0]; //shows first table
            DataGrid_Users.Columns[0].Width = 30;
            DataGrid_Users.Columns[1].Width = 75;
            DataGrid_Users.Columns[2].Width = 75;
            DataGrid_Users.Columns[3].Width = 158;
            DataGrid_Users.Columns[4].Width = 118;
            DataGrid_Users.Columns[0].HeaderText = "ID";
            DataGrid_Users.Columns[1].HeaderText = "Name";
            DataGrid_Users.Columns[2].HeaderText = "Surname";
            DataGrid_Users.Columns[3].HeaderText = "Email";
            DataGrid_Users.Columns[4].HeaderText = "Password";
            DataGrid_Users.Show();
        }
    }
}
