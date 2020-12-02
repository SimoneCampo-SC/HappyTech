/**
 * 
 * File: ConfirmRegisterForm.cs
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
    public partial class ConfirmRegisterForm : Form
    {
        /// <summary>
        /// Constructor ConfRegistrForm
        /// </summary>
        public ConfirmRegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the login button.
        ///     This will send the user back to the login form.
        /// 
        /// </summary>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm instance_LoginForm = new LoginForm();
            instance_LoginForm.Show();
        }
    }
}
