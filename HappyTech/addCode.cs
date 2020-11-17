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
    public partial class addCode : Form
    {
        public addCode()
        {
            InitializeComponent();
            // DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagNames());
            // tagBox.DataSource = ds.Tables[0]; //shows first table
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagNames());
             sectionBox.DataSource = ds.Tables[0]; //shows first table
        }

        /* private void addCode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Codes' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'database1DataSet.Tag' table. You can move, or remove it, as needed.
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT name FROM Tag");
            tagBox.DataSource = ds.Tables[0]; //shows first table
            //this.tagTableAdapter.Fill(); //populates drop down menu with tags

        } */

        private void selectTag(object sender, EventArgs e)
        {
            string selectedTag = tagBox.Text;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm df = new codeViewForm();
            df.Show();
        }

      /*  private void submitBtn_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if ((codeShortBox.Text.Length == 0) || (codeParaBox.Text.Length == 0))
            {
                stringOk = false;
                // errorMessage.Visible = true;
                // errorMessage.Text = "All the fields must be filled.";
            }
            if (stringOk == true)
            {
                // Need to check whether the fields have already been inserted
                //first need to translate the currently selected tag into its id# for a code to be added into the table
               // string query = $"SELECT Id FROM Tag WHERE name = '{tagBox.Text}'"; //gets value in tagBox
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(tagBox.Text));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var tagId = dRow.ItemArray.GetValue(0); //stroes the tag id in tagId


               // string queryString = $"INSERT INTO Codes (codeShort, codeParagraph , tag_id) VALUES ('{codeShortBox.Text}', '{codeParaBox.Text}', {tagId})";
                Connection.GetDbConn().CreateCommand(Constants.insertNewCode(codeShortBox.Text, codeParaBox.Text, tagId));
            }
            codeShortBox.Clear();
            codeParaBox.Clear();
        } */

        //private void addCode_Load_1(object sender, EventArgs e)
       // {
            // TODO: This line of code loads data into the 'database1DataSet2.Tag' table. You can move, or remove it, as needed.
        //    this.tagTableAdapter.Fill(this.database1DataSet2.Tag);

       // }

       

        private void addCode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.database1DataSet3.Section);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm df = new codeViewForm();
            df.Show();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if ((codeShortBx.Text.Length == 0) || (codeParaBx.Text.Length == 0))
            {
                stringOk = false;
                // errorMessage.Visible = true;
                // errorMessage.Text = "All the fields must be filled.";
            }
            if (stringOk == true)
            {
                // Need to check whether the fields have already been inserted
                //first need to translate the currently selected tag into its id# for a code to be added into the table
                // string query = $"SELECT Id FROM Tag WHERE name = '{tagBox.Text}'"; //gets value in tagBox
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(sectionBox.Text));
                DataRow dRow = ds.Tables[0].Rows[0]; //gets the tag id with this tag name
                var tagId = dRow.ItemArray.GetValue(0); //stroes the tag id in tagId


                // string queryString = $"INSERT INTO Codes (codeShort, codeParagraph , tag_id) VALUES ('{codeShortBox.Text}', '{codeParaBox.Text}', {tagId})";
                Connection.GetDbConn().CreateCommand(Constants.insertNewCode(codeShortBx.Text, codeParaBx.Text, tagId));
            }
            codeShortBx.Clear();
            codeParaBx.Clear();
        }
    }
}


