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
    public partial class EditorForm : Form
    {
        int currentPosition;
        public EditorForm(int position)
        {
            currentPosition = position;
            InitializeComponent();
            lbApplicants.Text = $"Applicant {position + 1} out of  {Applicant.applicants.Count}"; 
                
            lbHeader.Text = Template.templates[position].GetHeader();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition > 0)
            {
                // save template - should be in Editor Class
                f = EditorClass.NextForm(0, currentPosition);
                this.Hide();
                f.Show();
            }
        }

        private void btNext2_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition < Template.templates.Count - 1)
            {
                // save template - should be into the Editor Class
                f = EditorClass.NextForm(1, currentPosition);
                this.Hide();
                f.Show();
            }
            else
            {

            }
        }
        private void EditorForm_Load(object sender, EventArgs e)
        {
            string item;
            Code.codeList.Clear();
            Code.fillCodeList();
            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                listBox.Items.Add($"{Code.codeList[i].GetSectionName().Trim()}: {Code.codeList[i].GetCodeName()}");
            }
        }
    }
}