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
        /// <summary>
        /// Constructor ConfRegistrForm
        /// </summary>
        /// <param name="successful">holds the outcome of the operation in the DB</param>
        public ConfRegistrForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executed whenever the user press the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            // Current form is hidden, and the LoginForm is created and showed 
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }
    }
}
