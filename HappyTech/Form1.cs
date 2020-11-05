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
            // create a string query to ask the database for
            string login = Constants.selectRecruiter(userEmail.Text, userPassword.Text);

            // open the connection and ask the query to the database
            DataSet ds = Connection.GetDbConn().getDataSet(login);
            Console.WriteLine(ds.ToString());
            
            // check whether the credentials are connect
            if (ds.Tables[0].Rows.Count != 0)
            {
                DataRow dRow = ds.Tables[0].Rows[0];
                // we need to insert rows dimension
                Recruiter.createInstance
                    (
                    dRow.ItemArray.GetValue(1).ToString(),
                    dRow.ItemArray.GetValue(2).ToString(),
                    dRow.ItemArray.GetValue(3).ToString(),
                    dRow.ItemArray.GetValue(4).ToString()
                    );
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                error.Visible = true;
                error.Text = "Incorrect email or password";
            }
        }
        private void registerButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
