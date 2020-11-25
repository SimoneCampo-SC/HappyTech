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
            errorLabel.Hide();
            okLabel.Hide();
            loadSectionChecklistbox();
           
        }

        private void loadSectionChecklistbox()
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
            bool stringOk = false; //stringOk will check the string isn't just spaces or blank
            //ideally there would be a check to make sure this name asn't already been entered into the database
            //if SELECT * FROM Section WHERE name = tagBox.Text != null then throw error (because a row exists with this name)
            string sectionName = tagBox.Text.Replace(" ", "");
            if (sectionName != "")
            {
                stringOk = true;
            }
            if (stringOk == true)
            {
                Sections.InsertSectionWithSelectedTemplates(sectionName, templatesListBox);
                tagBox.Clear();
                
                loadSectionChecklistbox();
                errorLabel.Hide();
                okLabel.Show();
            }
            else if (stringOk == false)
            {
                //need an error box here to advise user of issue
                okLabel.Hide();
                errorLabel.Show();
            }
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
