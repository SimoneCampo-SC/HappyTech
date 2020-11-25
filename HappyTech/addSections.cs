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
    public partial class addSections : Form
    {
        public addSections()
        {
            InitializeComponent();
            templatesListBox.CheckOnClick = true;
            sectionBox.Hide();
            deleteSection.Hide();
            editSectionCombo.Hide();
            editSectionTextBox.Hide();
            submitEditBtn.Hide();
           
        }

        private void addSections_Load(object sender, EventArgs e)
        {
            
            
            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                templatesListBox.Items.Add($"{Template.templates[i].TempType}");
            }
        }

        /// <summary>
        /// on section submission, has to get each template the user wants to attatch the section to
        /// gets template name, gets id from name
        /// adds a new personalSection object using this new section id and selected template id
        /// repeat for each selected template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagSubmit_Click(object sender, EventArgs e)
        {
            Sections.InsertSectionWithSelectedTemplates(tagBox.Text, templatesListBox);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cv = new codeViewForm();
            cv.Show();
        }

        private void addCodes_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCode ac = new addCode();
            ac.Show();
        }

       

       





        /*
         * i'm thinking have a radial button toggle to toggle between adding codes and adding sections (as they're basically the same)
         * if adding a code, change all references to section to 'code' by getting each label's.Text and changing them
         * clear the check list
         * repopulate list with all the section names instead of template names
         * submit button needs to add to codes
         * codes only need to be added to 1 section because they are specialists
         */

    }
}
