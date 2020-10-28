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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            string email = emailBox.Text;
            email = "'" + email + "'";
            string firstName = nameBox.Text;
            firstName = "'" + firstName + "'";
            string surname = surnameBox.Text;
            surname = "'" + surname + "'";
            string password = passBox.Text;
            password = "'" + password + "'";

            if (  (email.Length == 0) || ( firstName.Length == 0) || (surname.Length == 0)  || password.Length == 0)
            {
                stringOk = false;
            }

            if (stringOk == true)
            {

                string queryString = $"INSERT INTO Recruiter  (email, name, surname, password) VALUES ({email}, {firstName}, {surname}, {password} )";
                Connection.GetDbConn().CreateCommand(queryString);
                //conn.CreateCommand(queryString);
               // DataSet ds = Connection.GetDbConn().getDataSet(login);
                //Console.WriteLine(ds.ToString());


                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }


           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
