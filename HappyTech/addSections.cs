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
            bool stringOk = false; //stringOk will check the string isn't just spaces or blank
            //ideally there would be a check to make sure this name asn't already been entered into the database
            //if SELECT * FROM Section WHERE name = tagBox.Text != null then throw error (because a row exists with this name)
            if (tagBox.Text.Replace(" ", "") != "")
            {
                stringOk = true;
            }

            if (stringOk == true)
            {
                 //has to create the section object first so we have a section ID to work with
                string queryString = Constants.createNewTag(tagBox.Text);
                Connection.GetDbConn().CreateCommand(queryString);
                //section object has now been created
                //we will get the id of this new section first instead of getting it in each iteration of the loop
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(tagBox.Text));
                DataRow dRow = ds.Tables[0].Rows[0];
                var sectionId = dRow.ItemArray.GetValue(0);
                foreach (string template in templatesListBox.CheckedItems)
                     {
                    //for each template selected, we have to add a template id and section id to PersonalSection
                     //so we will get the template id from the template name
                     DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(template));
                    DataRow dRow1 = ds1.Tables[0].Rows[0];
                     var templateId = dRow1.ItemArray.GetValue(0);
                    //now we have the template id and section id
                    string createPersonalSection = $"insert into PersonalSection (template_ID, section_ID) VALUES ('{templateId}', '{sectionId}')";
                    Connection.GetDbConn().CreateCommand(createPersonalSection);
                    //now a PersonalSection object has been created
                } 
            }
            else if (stringOk == false) {
                //need an error box here to advise user of issue
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
