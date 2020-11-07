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
        }
        private void codeViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Codes' table. You can move, or remove it, as needed.
            this.codesTableAdapter.Fill(this.database1DataSet1.Codes);
            // TODO: This line of code loads data into the 'database1DataSet.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this.database1DataSet.Tag);

        }

        private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when drop down menu has a value selected, fill the dataGridView with the contents of the Codes table where tag = selected value
            try
            {
                string selectedTag = tagSelectBox.Text;
                DataSet ds = Connection.GetDbConn().getDataSet($"SELECT Codes.codeShort, Codes.codeParagraph FROM Codes INNER JOIN Tag ON Codes.tag_ID = Tag.id WHERE Tag.name = '{selectedTag}'");
                codeDisplay.DataSource = ds.Tables[0];
            }

            catch
            {
                //needs this or else an exception will throw when the form is generated
            }


        }

        void fillCombo()
        {
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Tag");
            codeDisplay.DataSource = ds.Tables[0];
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
    }

     
    
}
