using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Form3 : Form
    {
        int currentPosition;
        public Form3(int position)
        {
            currentPosition = position;
            InitializeComponent();
            lbApplicants.Text = "Applicant " + (position + 1).ToString() +
                                " out of " + Applicant.applicants.Count;
            lbHeader.Text = Template.templates[position].GetHeader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f;
            if (currentPosition > 0)
            {
                f = EditorClass.NextForm(0, currentPosition);
                this.Hide();
                f.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f;
            if (currentPosition < Template.templates.Count - 1)
            {
                f = EditorClass.NextForm(1, currentPosition);
                this.Hide();
                f.Show();
            }
        }
    }
}
