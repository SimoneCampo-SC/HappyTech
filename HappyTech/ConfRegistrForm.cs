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
    public partial class ConfRegistrForm : Form
    {
        public ConfRegistrForm(bool successful)
        {
            InitializeComponent();
            if (successful == true)
            {
                lbSuccessful.Text = "You have successfully registered!";
            }
            else
            {
                lbSuccessful.Text = "The user already exists";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }
    }
}
