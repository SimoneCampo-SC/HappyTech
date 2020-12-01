/*
 * 
 * File: ConfRegistrForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. SID (EMAIL)
 * Author 3: Osborne, Oliver. 1602819 (OMO123@student.aru.ac.uk)
 * Course: BEng (Hons) Computer Science, Year 2 Timester 1
 * 
 * Summary:     This file displays a confirmation message which informs 
 *              the users that they successfully created their account.
 */
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
