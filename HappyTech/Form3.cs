using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            InitializeComponentNew();

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

        private void Form3_Load(object sender, EventArgs e)
        {
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "G-EXP", "You have shown a good level of experience."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "B-EXP", "You have shown a poor level of experience."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.CheckOnClick = true;
            checklistSelectedCodes.CheckOnClick = true;
        }

        private void checklistSelectedCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checklistSelectedCodes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                e.NewValue = CheckState.Checked;
                checklistAllCodes.Items.Add(checklistSelectedCodes.Items[e.Index].ToString());
                checklistSelectedCodes.Items.Remove(checklistSelectedCodes.Items[e.Index]);
                checklistAllCodes.SetItemChecked(checklistAllCodes.Items.Count - 1, false);
            }
        }

        private void checklistAllCodes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                checklistSelectedCodes.Items.Add(checklistAllCodes.Items[e.Index].ToString());
                checklistAllCodes.Items.Remove(checklistAllCodes.Items[e.Index]);
                checklistSelectedCodes.SetItemChecked(checklistSelectedCodes.Items.Count - 1, true);                
            }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(585, 445);
            this.Name = "Form3";
            this.ResumeLayout(false);

        }

    }
}
