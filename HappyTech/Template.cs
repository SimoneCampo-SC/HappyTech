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
    class Template
    {
        // Template list has been created
        public static List<Template> templates = new List<Template>();

        // List of all the properties 
        public string Header { get; }
        public string TempType { get; }
        public int Id { get; }

        /// <summary>
        /// Constructor of the template class
        /// </summary>
        /// <param name="applicant">holds the applicant object</param>
        /// <param name="tempType">holds the type chosen</param>
        private Template (Applicant applicant, string tempType)
        {
            this.TempType = tempType;
            this.Header = $"Recruiter: {Recruiter.GetInstance().Name} {Recruiter.GetInstance().Surname}, " +
                          $"Applicant: {applicant.AfullName} for {tempType}";
        }

        /// <summary>
        /// overloaded constructor for use in addsections.cs, populates the checklist of templates that a user can add sections to
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        private Template(int id, string name)
        {
            this.Id = id;
            this.TempType = name;
        }

        /// <summary>
        /// The following method generates template according to the number of applicants into the list.
        /// </summary>
        public static void generateTemplate(Applicant Applicant, string tempType)
        {
            Template template = new Template(Applicant, tempType);
            Template.templates.Add(template);
        }

        /// <summary>
        ///Fills the following template into the database
        /// </summary>
        private void FillTemplateIntoDb ()
        {
           //Connection.GetDbConn().CreateCommand(Constants.insertTemplate(Header)); //+ tagID
        }

        public static void listTemplates()
        {
            // retrieves the codes from the database
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateNameId());
            DataRow dRow;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Template _instance = new Template(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // template ID
                    dRow.ItemArray.GetValue(1).ToString() // template's tempType
                    );
               Template.templates.Add(_instance); // Add the code into the list
            }
        }

        public static void createNewTemplate(string templateName)
        {
            string queryString = Constants.insertNewTemplate(templateName);
            Connection.GetDbConn().CreateCommand(queryString);
        }

        public static void CreateTemplateWithSelectedSections (string input, CheckedListBox selectedSections)
        {
            //when template is submitted, needs to make a new section ID, then needs to make new PersonalSection
            //objects for each checked section in the sectionsListBox
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
                string queryString = Constants.insertNewTemplate(input);
                Connection.GetDbConn().CreateCommand(queryString);
                //template object has now been created
                //we will get the id of this new template first instead of getting it in each iteration of the loop
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateIdFromName(input));
                DataRow dRow = ds.Tables[0].Rows[0];
                var templateId = dRow.ItemArray.GetValue(0);
                foreach (string section in selectedSections.CheckedItems)
                {
                    //for each template selected, we have to add a template id and section id to PersonalSection
                    //so we will get the template id from the template name
                    DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(section));
                    DataRow dRow1 = ds1.Tables[0].Rows[0];
                    var sectionId = dRow1.ItemArray.GetValue(0);
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
        }
    }
}
