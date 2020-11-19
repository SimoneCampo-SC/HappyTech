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
            InitializeComponentNew();
            //tagBox.Hide();
            //tagSubmit.Hide();
            load_dropdown(); //load tags from the db into the drop-down menu
           
        }

        private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when drop down menu has a value selected, fill the dataGridView with the contents of the Codes table where tag = selected value

           // string query = $"SELECT Id FROM Tag WHERE name = '{tagSelectBox.Text}'";
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(tagSelectBox.Text));
            DataRow dRow = ds.Tables[0].Rows[0];
            var tagId = dRow.ItemArray.GetValue(0);

            // DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT codeShort, codeParagraph FROM Codes WHERE tag_ID = {tagId}");
            //have to convert to string as tagId is 'object' type
            DataSet ds2 = Connection.GetDbConn().getDataSet(Constants.getCodeFromTagId(tagId.ToString()));
            codeDisplay.DataSource = ds2.Tables[0]; //shows first table

        }
      

        private void load_dropdown()
        {

            //DataSet ds = Connection.GetDbConn().getDataSet("SELECT name FROM Tag");
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagNames());
            //tagSelectBox.DataSource = ds.Tables[0]; //shows first table
            //this.tagTableAdapter.Fill(); //populates drop down menu with tags

        }


       /* void fillCombo()
        {
            //DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Tag");
            //codeDisplay.DataSource = ds.Tables[0];
        } */

       /* private void codeDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } */

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm df = new DashForm();
            df.Show();
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            //When add tag button is clicked, show the text box for typing in a new tag name and show the button required to add the
            //alue of the add tage textbox into the db
            tagBox.Show();
            tagSubmit.Show();
        }

        private void addCodeBtn_Click(object sender, EventArgs e) //shows the add code windows form
        {
            this.Hide();
            addCode at = new addCode();
            at.Show();

        
        } 

        /*
        private void submitCodeBtn_Click(object sender, EventArgs e)
        {
           
        } */

        private void tagSubmit_Click(object sender, EventArgs e)
        {
            //this code runs when a new tag is submitted with the submite tag button.
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

                //string queryString = $"INSERT INTO Tag (name) VALUES ('{tagBox.Text}')";
                string queryString = Constants.createNewTag(tagBox.Text);
                Connection.GetDbConn().CreateCommand(queryString);
                //conn.CreateCommand(queryString);
                // DataSet ds = Connection.GetDbConn().getDataSet(login);
                //Console.WriteLine(ds.ToString());
                tagBox.Hide();
                tagSubmit.Hide();
            }
            // update drop down
            
            load_dropdown();
            // DataSet ds = Connection.GetDbConn().getDataSet("SELECT name FROM Tag");
            //tagSelectBox.DataSource = ds.Tables[0];
            //this.Load += this.codeViewForm_Load; doesnt refresh items in drop down
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // codeViewForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "codeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }

     
    
}
