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
    }
}
