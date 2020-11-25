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
        string mode = "showNew"; //mode will be used to keep track of which view is being displayed, choice between
                                 //showNew and showExisting
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
            sectionsListBox.Items.Clear();
            Sections.sectionList.Clear();
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

            Template.CreateTemplateWithSelectedSections(templateBox.Text, sectionsListBox);
            // upon successful template creation, clear the template box and reload the checklist
            templateBox.Clear();
            loadSectionsCheckListBox();
            //show successful label
        }

        private void addSectionPreExist_Click(object sender, EventArgs e)
        {
            
            if (mode == "showNew")
            {
                 preExistLbl.Show();
                 preExistTempBox.Show();
                 updateTemplate.Show();
            //hides forms relating to inserting a new template
                templateBox.Hide();
                label1.Hide();
                templateSubmitBtn.Hide();
            //populate the dropdown with pre existing templates
                loadpreExistTempBox();
                mode = "showExisting";
            }
            else if (mode == "showExisting")
            {
                label1.Show();
                templateBox.Show();
                templateSubmitBtn.Show();
                preExistLbl.Hide();
                preExistTempBox.Hide();
                updateTemplate.Hide();
                mode = "showNew";
            }
           sectionsListBox.Items.Clear();
            loadSectionsCheckListBox();
        }

        private void loadpreExistTempBox()
        {
            Template.templatesForApplicants.Clear();
            Template.listTemplates();
            for (int i = 0; i < Template.templatesForApplicants.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                preExistTempBox.Items.Add($"{Template.templatesForApplicants[i].TempType}");
            }
        }

        private void preExistTempBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a pre-existing template is selected, we need to populate the sectionsListBox AND we need the sections
            //that have already been selected to be pre-selected.
            sectionsListBox.Items.Clear(); // clear out old sections
            Sections.sectionList.Clear();
             // we will use the selected template name to get the selected template's ID
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(preExistTempBox.Text.Replace(" ","")));
            Console.WriteLine(Constants.getTemplateIdFromName(preExistTempBox.Text.Replace(" ", "")));
            DataRow dRow = ds.Tables[0].Rows[0];
            var templateId = dRow.ItemArray.GetValue(0);
            // we need to populate the sectionsListBox 
            Sections.listSection();
            for (int i = 0; i < Sections.sectionList.Count(); i++)
            {
                string sectionNameToAdd = Sections.sectionList[i].name.Replace(" ", "");
                int sectionId = Sections.sectionList[i].id;
                sectionsListBox.Items.Add($"{sectionNameToAdd}");
                //if there is a PersonalSection object with this template id and this section id, set checked to true
                DataSet ds1 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");
                try 
                {
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                
                    if (dRow1 != null)
                    {
                        sectionsListBox.SetItemChecked(i, true);
                    }
                }
                catch { } //crashes if dRow1 IS null, so wrapped it in a try/ catch
              
            }
            // then we will get all the personalSection objects that match these IDs

            //if a personalSection object exists, then show up checked? or 
            // once update existing template button is clicked, maybe drop all PersonalSection objects with this template ID
            //then for each checked box, create a new personalSection object?
        }

        private void updateTemplate_Click(object sender, EventArgs e)
        {
            
            string templateName = preExistTempBox.Text;
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(templateName));
            DataRow dRow = ds.Tables[0].Rows[0];
            var templateId = dRow.ItemArray.GetValue(0);
            for (int i = 0; i < sectionsListBox.Items.Count; i++)
            {
                string sectionName = sectionsListBox.Items[i].ToString();
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(sectionName));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);

                if (sectionsListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    
                    DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT * from PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow2 = ds2.Tables[0].Rows[0];
                        //this has checked the related box was ticked and there IS a PersonalSection object already created for
                        //this template and section combination
                    }
                    catch
                    {
                        //no PersonalSection object was found so one needs to be created
                        Connection.GetDbConn().CreateCommand($"INSERT INTO PersonalSection (template_Id, section_Id) VALUES ('{templateId}', '{sectionId}')");
                        //now a PersonalSection object has been made
                    }
                }
                else if (sectionsListBox.GetItemCheckState(i) != CheckState.Checked) //if checkbox not checked
                {
                    //need to check if there is a Personalsection object
                    DataSet ds3 = Connection.GetDbConn().getDataSet($"SELECT * FROM PersonalSection WHERE template_ID = '{templateId}' and section_ID = '{sectionId}'");
                    try
                    {
                        DataRow dRow3 = ds3.Tables[0].Rows[0];
                        //if this passes then the check box was NOT ticked and there IS a PersonalSection object
                        //so we need to find the row and drop it
                        Connection.GetDbConn().CreateCommand($"DELETE FROM PersonalSection WHERE template_Id = '{templateId}' AND section_Id = '{sectionId}'");
                    }
                    catch { } //if catch is reached then checkbox was NOT ticked and ther was NO PersonalSection object
                }
                
            }
            preExistTempBox.Items.Clear();
                loadpreExistTempBox();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            codeViewForm cv = new codeViewForm();
            cv.Show();
        }
    }
}
