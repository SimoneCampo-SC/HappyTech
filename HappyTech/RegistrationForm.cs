/**
 * 
 * File: RegistrationForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Author 3: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the users to create their own account 
 *              by supplying their name, surname, email, and password.
 *              This data is then saved in the database.
 *              
 */

using System;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class RegistrationForm : Form
    {
        private bool passVis = false;
        /// <summary>
        /// Constructor RegistrationForm
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executed when the User Click the SignIn button
        /// </summary>
        private void registerButton_Click(object sender, EventArgs e)
        {
            // Checks whether at least one of the textboxes is empty
            if ((emailBox.Text.Length == 0) || (nameBox.Text.Length == 0) ||
                (surnameBox.Text.Length == 0) || (passBox.Text.Length == 0))
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Required fields are missing";
            }
            // Checks whether the email provided already exists into the DB
            else if (SqlConstants.checkRecruiter(emailBox.Text) == true) 
            {
                errorMessage.Visible = true;
                errorMessage.Text = "An account with this email already exists";
            }
            else
            {
                // Add the credentials into the Database
                string queryString = SqlConstants.insertRecruiter(emailBox.Text, nameBox.Text, surnameBox.Text, passBox.Text);
                Connection.GetDbConn().CreateCommand(queryString);

                // Current form is hidden, and the ConfRegistrForm is created and showed 
                this.Hide();
                ConfRegistrForm crf = new ConfRegistrForm();
                crf.Show();
            }
        }
        /// <summary>
        /// Executed when the User Click Back button
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            // Current form is hidden, and the LoginForm is created and showed 
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        /// <summary>
        /// Occurs whenewer the user amends the passBox
        /// </summary>
        private void passBox_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the passBox is empty
            if (passBox.Text.Length == 0)
            {
                btnPassVis.Hide();
                errorMessage.Visible = false;
            }
            else
            {
                btnPassVis.Show();
            }

            // Checks whether the passBox is less than 8 characters in length
            if (passBox.Text.Length < 8)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Password must be at least 8 characters";
            }
            // Checks whether the passBox is greater than 8 characters in length
            else if (passBox.Text.Length > 50)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Password must be 50 characters or less";
            }
            else
            {
                errorMessage.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenever the user clicks on the btnPassVis
        /// </summary>
        private void btnPassVis_Click(object sender, EventArgs e)
        {
            if (passVis == false)
            {
                passVis = true;
                btnPassVis.Image = Properties.Resources.hidePass;
                passBox.UseSystemPasswordChar = false;
            }
            else if (passVis == true)
            {
                passVis = false;
                btnPassVis.Image = Properties.Resources.showPass;
                passBox.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Occurs whenewer the user amends the emailBox
        /// </summary>
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (emailBox.Text.Length == 0)
            {
                errorMessage.Visible = false;
            }
            // Checks whether the email does not contain the correct domain
            else if (!(emailBox.Text.Contains("@happytech.com")))
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Email must use @happytech.com";
            }
            else
            {
                errorMessage.Visible = false;
            }
            // Checks whether the email is greater than 50 charactera in length
            if (emailBox.Text.Length > 50)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Email must be 50 characters or less";
            }
            else
            {
                errorMessage.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenewer the user amends the nameBox
        /// </summary>
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the name field is empty
            if (nameBox.Text.Length == 0)
            {
                errorMessage.Visible = false;
            }
            // Checks whether the name field is greater than 50 characters in length
            else if (nameBox.Text.Length > 50)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "First name must be 50 characters or less";
            }
            else
            {
                errorMessage.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenewer the user amends the surnameBox
        /// </summary>
        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the surname box is empty
            if (surnameBox.Text.Length == 0)
            {
                errorMessage.Visible = false;
            }
            // Checks whether the surnameBox is greater than 50 chars in length
            else if (surnameBox.Text.Length > 50)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Surname must be 50 characters or less";
            }
            else
            {
                errorMessage.Visible = false;
            }
        }
    }
}
