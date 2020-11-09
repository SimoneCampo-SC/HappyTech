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
            shortCodeLabel.Hide();
            shortCodeBox.Hide();
            codeParaLabel.Hide();
            codeParaBox.Hide();
            submitCodeBtn.Hide();
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
            this.Hide();
            addTag at = new addTag();
            at.Show();
        }

        private void addCodeBtn_Click(object sender, EventArgs e)
        {
            shortCodeLabel.Show();
            shortCodeBox.Show();
            codeParaLabel.Show();
            codeParaBox.Show();
            submitCodeBtn.Show();
        }

        private void submitCodeBtn_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if ((shortCodeBox.Text.Length == 0) || (codeParaBox.Text.Length == 0))
            {
                stringOk = false;
                // errorMessage.Visible = true;
                // errorMessage.Text = "All the fields must be filled.";
            }
            if (stringOk == true)
            {
                // Need to check whether the fields have already been inserted
                //first need to translate the currently selected tag into its id# for a code to be added into the table
                string query = $"SELECT Id FROM Tag WHERE name = '{tagSelectBox.Text}'";
                DataSet ds = Connection.GetDbConn().getDataSet(query);
                DataRow dRow = ds.Tables[0].Rows[0];
                var tagId = dRow.ItemArray.GetValue(0);
                

                string queryString = $"INSERT INTO Codes (codeShort, codeParagraph , tag_id) VALUES ('{shortCodeBox.Text}', '{codeParaBox.Text}', {tagId})";
                Connection.GetDbConn().CreateCommand(queryString);
            }
            shortCodeBox.Clear();
            codeParaBox.Clear();
        }

    }

     
    
}
