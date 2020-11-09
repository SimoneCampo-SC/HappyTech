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
    public partial class codeViewForm : Form
    {
        public codeViewForm()
        {
            InitializeComponent();
            tagBox.Hide();
            tagSubmit.Hide();
           
        }

        private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when drop down menu has a value selected, fill the dataGridView with the contents of the Codes table where tag = selected value

            string query = $"SELECT Id FROM Tag WHERE name = '{tagSelectBox.Text}'";
            DataSet ds = Connection.GetDbConn().getDataSet(query);
            DataRow dRow = ds.Tables[0].Rows[0];
            var tagId = dRow.ItemArray.GetValue(0);

            DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT codeShort, codeParagraph FROM Codes WHERE tag_ID = {tagId}");
            codeDisplay.DataSource = ds2.Tables[0]; //shows first table

        }
        private void codeViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Codes' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'database1DataSet.Tag' table. You can move, or remove it, as needed.
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT name FROM Tag");
            tagSelectBox.DataSource = ds.Tables[0]; //shows first table
            //this.tagTableAdapter.Fill(); //populates drop down menu with tags

        }

    

        void fillCombo()
        {
            //DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Tag");
            //codeDisplay.DataSource = ds.Tables[0];
        }

        private void codeDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm df = new DashForm();
            df.Show();
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            tagBox.Show();
            tagSubmit.Show();
        }

        private void addCodeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCode at = new addCode();
            at.Show();


        }

        private void submitCodeBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void tagSubmit_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if (tagBox.Text.Length == 0)
            {
                stringOk = false;
                //errorMessage.Visible = true;
                //errorMessage.Text = "All the fields must be filled.";
            }
            if (stringOk == true)
            {
                // Need to check whether the fields have already been inserted

                string queryString = $"INSERT INTO Tag (name) VALUES ('{tagBox.Text}')";
                Connection.GetDbConn().CreateCommand(queryString);
                //conn.CreateCommand(queryString);
                // DataSet ds = Connection.GetDbConn().getDataSet(login);
                //Console.WriteLine(ds.ToString());
                tagBox.Hide();
                tagSubmit.Hide();
            }
        }
    }

     
    
}
