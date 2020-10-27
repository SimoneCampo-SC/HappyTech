using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HappyTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display table data
          
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Recruiter");
            dataViewRecruiter.DataSource = ds.Tables[0]; //shows first table
            //login would be ds = SELECT * WHERE username AND password EQUALS inputuser AND inputpass
            //if ds.Tables[0] == NULL
            //dont log in
            //else go to next form and use logged in user as a user
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username box

            //string username = Console.ReadLine();
            //Console.WriteLine(username);

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            //password box
            //string password = Console.ReadLine();
           // Console.WriteLine(password);


        }
        private void loginButt_Click(object sender, EventArgs e)
        {
            //takes username and password box value, open sql connection and check if a record 
            //exists with those values
            string email = username.Text;
            string pass = password.Text;
            string query = "SELECT * FROM Recruiter WHERE email = {0}", email;
            //string query = "SELECT* FROM Recruiter WHERE email = @email";
            
            //command.Parameters.Add("@Title", SqlDbType.VarChar).Value = someone;
            DataSet ds = Connection.GetDbConn().getDataSet();
            
            if (ds.Tables[0] != null)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
           
        }
    }
}
