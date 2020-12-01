/**
 * 
 * File: ConfRegistrForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Author 3: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file displays a confirmation message which informs 
 *              the users that they created their account.
 *              
 */

using System;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class ConfRegistrForm : Form
    {
        /// <summary>
        /// Constructor ConfRegistrForm
        /// </summary>
        public ConfRegistrForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Let's the user to go to the Login Page 
        /// </summary>
        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }
    }
}
