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
        private bool passwordVisible = false;
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
        private void Button_Create_Click(object sender, EventArgs e)
        {
            if ((TextBox_Email.Text.Length == 0) || (TextBox_FirstName.Text.Length == 0) ||
                (TextBox_LastName.Text.Length == 0) || (TextBox_Password.Text.Length == 0))
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Required fields are missing";
            }
            else if (TextBox_FirstName.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "First name must be 50 characters or less";
            }
            else if (TextBox_LastName.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Surname must be 50 characters or less";
            }
            else if (!TextBox_Email.Text.Contains("@happytech.com"))
            {
                Label_Error.Text = "Email must use: @happytech.com";
                Label_Error.Visible = true;
            }
            else if (TextBox_Email.Text.Length > 50)
            {
                Label_Error.Text = "Email must be 50 characters or less";
                Label_Error.Visible = true;
            }
            else if (TextBox_Password.Text.Length < 8)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Password must be at least 8 characters";
            }
            else if (TextBox_Password.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Password must be 50 characters or less";
            }
            else if (SqlQueries.CheckRecruiter(TextBox_Email.Text) == true) 
            {
                Label_Error.Visible = true;
                Label_Error.Text = "An account with this email already exists";
            }
            else
            {
                // Add the credentials into the Database
                string queryString = SqlQueries.InsertRecruiter(TextBox_Email.Text, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_Password.Text);
                Connection.GetDbConn().CreateCommand(queryString);

                // Current form is hidden, and the ConfRegistrForm is created and showed 
                Hide();
                ConfirmRegisterForm instance_ConfirmRegisterForm = new ConfirmRegisterForm();
                instance_ConfirmRegisterForm.Show();
            }
        }
        /// <summary>
        /// Executed when the User Click Back button
        /// </summary>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            // Current form is hidden, and the LoginForm is created and showed 
            Hide();
            LoginForm instance_LoginForm = new LoginForm();
            instance_LoginForm.Show();
        }

        /// <summary>
        /// Occurs whenewer the user amends the passBox
        /// </summary>
        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the passBox is empty
            if (TextBox_Password.Text.Length == 0)
            {
                Button_PasswordVisibility.Hide();
                Label_Error.Visible = false;
            }
            else
            {
                Button_PasswordVisibility.Show();
            }

            // Checks whether the passBox is less than 8 characters in length
            if (TextBox_Password.Text.Length < 8)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Password must be at least 8 characters";
            }
            // Checks whether the passBox is greater than 8 characters in length
            else if (TextBox_Password.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Password must be 50 characters or less";
            }
            else
            {
                Label_Error.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenever the user clicks on the btnPassVis
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

        /// <summary>
        /// Occurs whenewer the user amends the emailBox
        /// </summary>
        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_Email.Text.Length == 0)
            {
                Label_Error.Visible = false;
            }
            else if (!TextBox_Email.Text.Contains("@happytech.com"))
            {
                Label_Error.Text = "Email must use: @happytech.com";
                Label_Error.Visible = true;
            }
            else if (TextBox_Email.Text.Length > 50)
            {
                Label_Error.Text = "Email must be 50 characters or less";
                Label_Error.Visible = true;
            }
            else
            {
                Label_Error.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenewer the user amends the nameBox
        /// </summary>
        private void TextBox_FirstName_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the name field is empty
            if (TextBox_FirstName.Text.Length == 0)
            {
                Label_Error.Visible = false;
            }
            // Checks whether the name field is greater than 50 characters in length
            else if (TextBox_FirstName.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "First name must be 50 characters or less";
            }
            else
            {
                Label_Error.Visible = false;
            }
        }

        /// <summary>
        /// Occurs whenewer the user amends the surnameBox
        /// </summary>
        private void TextBox_LastName_TextChanged(object sender, EventArgs e)
        {
            // Checks whether the surname box is empty
            if (TextBox_LastName.Text.Length == 0)
            {
                Label_Error.Visible = false;
            }
            // Checks whether the surnameBox is greater than 50 chars in length
            else if (TextBox_LastName.Text.Length > 50)
            {
                Label_Error.Visible = true;
                Label_Error.Text = "Surname must be 50 characters or less";
            }
            else
            {
                Label_Error.Visible = false;
            }
        }
    }
}
