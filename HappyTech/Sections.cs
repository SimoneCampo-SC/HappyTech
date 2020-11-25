using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// to keep my code similar to other classes that use lists (template, applicant etc) i have made a sections class.
    /// </summary>
    class Sections
    {
        public static List<Sections>sectionList = new List<Sections>();
        public static List<Sections> sectionPerTemplate = new List<Sections>(); 
        public int id { get; }
        public string name { get; }
        private Sections(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static void listSection ()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionNameId());
            DataRow dRow;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Sections _instance = new Sections(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // section ID
                    dRow.ItemArray.GetValue(1).ToString() // section's name
                    );
               Sections.sectionList.Add(_instance); // Add the section into the list
            }
        }

        public static void FillSectionPerTemplate(int tempID)
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.SelectSectionPerTemplate(tempID));
            DataRow dRow;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];
                for (int j = 0; j < sectionList.Count; j++)
                {
                    if (dRow.ItemArray.GetValue(0).ToString().Equals(sectionList[j].id))
                    {
                        sectionPerTemplate.Add(sectionList[j]);
                    }
                }
            }
        }

        public static void InsertSectionWithSelectedTemplates(string input, CheckedListBox templateCheckBox)
        {
             bool stringOk = false; //stringOk will check the string isn't just spaces or blank
            //ideally there would be a check to make sure this name asn't already been entered into the database
            //if SELECT * FROM Section WHERE name = tagBox.Text != null then throw error (because a row exists with this name)
            if (input.Replace(" ", "") != "")
            {
                stringOk = true;
            }

            if (stringOk == true)
            {
                 //has to create the section object first so we have a section ID to work with
                string queryString = Constants.createNewTag(input);
                Connection.GetDbConn().CreateCommand(queryString);
                //section object has now been created
                //we will get the id of this new section first instead of getting it in each iteration of the loop
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(input));
                DataRow dRow = ds.Tables[0].Rows[0];
                var sectionId = dRow.ItemArray.GetValue(0);
                foreach (string template in templateCheckBox.CheckedItems)
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

    }
}
