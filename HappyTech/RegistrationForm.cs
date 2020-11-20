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
            // Checks whether all the textboxes have been filled 
            if ((emailBox.Text.Length == 0) || (nameBox.Text.Length == 0) ||
                (surnameBox.Text.Length == 0) || (passBox.Text.Length == 0))
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Required fields are missing";
            }
            else if (!(emailBox.Text.Contains("@happytech.com")))
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Email must use @happytech.com";
            }
            else if (passBox.Text.Length < 8)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Password must be at least 8 characters";
            }
            else if (Constants.checkRecruiter(emailBox.Text) == true) // Checks whether the credentials inserted doesn't not already exist in the DB
            {
                errorMessage.Visible = true;
                errorMessage.Text = "An account with this email already exists";
            }
            else
            {
                // Add the credentials into the Database
                string queryString = Constants.insertRecruiter(emailBox.Text, nameBox.Text, surnameBox.Text, passBox.Text);
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

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            if (!(passBox.Text == ""))
            {
                btnPassVis.Show();
            }
            else
            {
                btnPassVis.Hide();
            }

            if (passBox.Text == "")
            {
                errorMessage.Visible = false;
                errorMessage.Text = "";
            }
            else if (passBox.Text.Length < 8)
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Password must be at least 8 characters";
            }
            else
            {
                errorMessage.Visible = false;
                errorMessage.Text = "";
            }
        }

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

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            btnPassVis.Hide();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                errorMessage.Visible = false;
                errorMessage.Text = "";
            }
            else if (!(emailBox.Text.Contains("@happytech.com")))
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Email must use @happytech.com";
            }
            else
            {
                errorMessage.Visible = false;
                errorMessage.Text = "";
            }
        }
    }
}
