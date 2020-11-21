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

        /// <summary>
        /// Constructor of the template class
        /// </summary>
        /// <param name="applicantNo">Holds the number of the applicant related to</param>
        private Template (Applicant applicant, string tempType)
        {
            this.TempType = tempType;
            this.Header = $"Recruiter: {Recruiter.GetInstance().Name} {Recruiter.GetInstance().Surname}, " +
                          $"Applicant: {applicant.AfullName} for {tempType}";
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
    }
}
