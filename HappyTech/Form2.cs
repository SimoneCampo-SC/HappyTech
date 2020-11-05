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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbName.Text = Recruiter.GetInstance().GetName();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recruiter.DestroyRecruiInstance();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }
    }
}
