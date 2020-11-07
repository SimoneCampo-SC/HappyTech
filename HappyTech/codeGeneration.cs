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
    public partial class codeGeneration : Form
    {
        public codeGeneration()
        {
            InitializeComponent();
            
        }

        void fillCombo ()
        {
            DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Tag");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BindComboBox()
        {
            
        }

        private void codeGeneration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.Codes' table. You can move, or remove it, as needed.
            this.codesTableAdapter2.Fill(this.database1DataSet4.Codes);
            // TODO: This line of code loads data into the 'database1DataSet3.Codes' table. You can move, or remove it, as needed.
            this.codesTableAdapter1.Fill(this.database1DataSet3.Codes);
            // TODO: This line of code loads data into the 'database1DataSet2.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this.database1DataSet2.Tag);
            // TODO: This line of code loads data into the 'database1DataSet1.Codes' table. You can move, or remove it, as needed.
            this.codesTableAdapter.Fill(this.database1DataSet1.Codes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when drop down menu has a value selected, fill the dataGridView with the contents of the Codes table where tag = selected value
            try
            {
                string selectedTag = comboBox1.Text;
                DataSet ds = Connection.GetDbConn().getDataSet($"SELECT Codes.codeShort, Codes.codeParagraph FROM Codes INNER JOIN Tag ON Codes.tag = Tag.id WHERE Tag.name = '{selectedTag}'");
                dataGridView1.DataSource = ds.Tables[0];
            }

            catch
            {
                //needs this or else an exception will throw when the form is generated
            }
            
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.codesTableAdapter.FillBy(this.database1DataSet1.Codes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
