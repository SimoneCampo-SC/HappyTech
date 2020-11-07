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
    public partial class addTag : Form
    {
        public addTag()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm df = new codeViewForm();
            df.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool stringOk = true;
            if (nameBox.Text.Length == 0)
            {
                stringOk = false;
                //errorMessage.Visible = true;
                //errorMessage.Text = "All the fields must be filled.";
            }
            if (stringOk == true)
            {
                // Need to check whether the fields have already been inserted

                string queryString = $"INSERT INTO Tag (name) VALUES (' { nameBox.Text}')";
                Connection.GetDbConn().CreateCommand(queryString);
                //conn.CreateCommand(queryString);
                // DataSet ds = Connection.GetDbConn().getDataSet(login);
                //Console.WriteLine(ds.ToString());
                this.Hide();
                codeViewForm crf = new codeViewForm();
                crf.Show();
            }
        }
    }
}

