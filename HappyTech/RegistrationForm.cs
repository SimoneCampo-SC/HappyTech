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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if ((emailBox.Text.Length == 0) || (nameBox.Text.Length == 0) || (surnameBox.Text.Length == 0) || (passBox.Text.Length == 0))
            {
                stringOk = false;
                errorMessage.Visible = true;
                errorMessage.Text = "All the fields must be filled.";
            }
            if ((stringOk == true) && (Constants.checkRecruiter(emailBox.Text, nameBox.Text, surnameBox.Text, passBox.Text) == false))
            {
                string queryString = Constants.insertRecruiter(emailBox.Text, nameBox.Text, surnameBox.Text, passBox.Text);
                Connection.GetDbConn().CreateCommand(queryString);

                this.Hide();
                ConfRegistrForm crf = new ConfRegistrForm(true);
                crf.Show();
            }
            else
            {
                this.Hide();
                ConfRegistrForm crf = new ConfRegistrForm(false);
                crf.Show();
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }
    }
}
