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
    public partial class Form3 : Form
    {
        string codeDisplay = "{0, -10}{1,-20}";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm df = new DashForm();
            df.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listSelectedCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listSelectedCodes.Items.Add(String.Format(codeDisplay, "G-EXP", "You have shown a good level of experience."));
            listAllCodes.Items.Add(String.Format(codeDisplay, "B-EXP", "You have shown a poor level of experience."));
            listSelectedCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            listAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            listAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            listAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            listAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
        }

        private void listAllCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
