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
    public partial class addTemplate : Form
    {
        public addTemplate()
        {
           
            InitializeComponent();
            //hides the fields used to update pre existing templates with pre existing sections
            preExistLbl.Hide();
            preExistTempBox.Hide();
            updateTemplate.Hide();

            loadSectionsCheckListBox();
            sectionsListBox.CheckOnClick = true;
        }

        private void loadSectionsCheckListBox()
        {
            //by default, loads all the sections into the sectionsListBox
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                
                sectionsListBox.Items.Add($"{Sections.sectionList[i].name.Replace(" ","")}");
            }
        }

        private void templateSubmitBtn_Click(object sender, EventArgs e)
        {
            //when template is submitted, needs to make a new section ID, then needs to make new PersonalSection
            //objects for each checked section in the sectionsListBox
            bool stringOk = false; //stringOk will check the string isn't just spaces or blank
            //ideally there would be a check to make sure this name asn't already been entered into the database
            //if SELECT * FROM Section WHERE name = tagBox.Text != null then throw error (because a row exists with this name)
            if (templateBox.Text.Replace(" ", "") != "")
            {
                stringOk = true;
            }

            if (stringOk == true)
            {
                //has to create the section object first so we have a section ID to work with
                string queryString = Constants.insertNewTemplate(templateBox.Text);
                Connection.GetDbConn().CreateCommand(queryString);
                //template object has now been created
                //we will get the id of this new template first instead of getting it in each iteration of the loop
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(templateBox.Text));
                DataRow dRow = ds.Tables[0].Rows[0];
                var sectionId = dRow.ItemArray.GetValue(0);
                foreach (string section in sectionsListBox.CheckedItems)
                {
                    //for each template selected, we have to add a template id and section id to PersonalSection
                    //so we will get the template id from the template name
                    DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(section));
                    DataRow dRow1 = ds1.Tables[0].Rows[0];
                    var templateId = dRow1.ItemArray.GetValue(0);
                    //now we have the template id and section id
                    string createPersonalSection = $"insert into PersonalSection (template_ID, section_ID) VALUES ('{templateId}', '{sectionId}')";
                    Connection.GetDbConn().CreateCommand(createPersonalSection);
                    //now a PersonalSection object has been created
                }
            }
            else if (stringOk == false)
            {
                //need an error box here to advise user of issue
            }

            // upon successful template creation, clear the template box and reload the checklist
            templateBox.Clear();
            loadSectionsCheckListBox();
            //show successful label
        }

        private void addSectionPreExist_Click(object sender, EventArgs e)
        {
            preExistLbl.Show();
            preExistTempBox.Show();
            updateTemplate.Show();

            //populate the dropdown with pre existing templates
            loadpreExistTempBox();
        }

        private void loadpreExistTempBox()
        {

            Template.templates.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templates.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                preExistTempBox.Items.Add($"{Template.templates[i].TempType}");
            }
        }
    }
}
