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
                errorMessage.Text = "All the fields must be filled.";
            }
            else
            {
                // Checks whether the credentials inserted doesn't not already exist in the DB
                if (Constants.checkRecruiter(emailBox.Text) == false)
                {
                    // Add the credentials into the Database
                    string queryString = Constants.insertRecruiter(emailBox.Text, nameBox.Text, surnameBox.Text, passBox.Text);
                    Connection.GetDbConn().CreateCommand(queryString);

                    // Current form is hidden, and the ConfRegistrForm is created and showed 
                    // parameter boolean true means "credential inserted"
                    this.Hide();
                    ConfRegistrForm crf = new ConfRegistrForm(true);
                    crf.Show();
                }
                else
                {
                    // Current form is hidden, and the ConfRegistrForm is created and showed 
                    // parameter boolean false means "credentials already exist"
                    this.Hide();
                    ConfRegistrForm crf = new ConfRegistrForm(false);
                    crf.Show();
                }
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
    }
}
