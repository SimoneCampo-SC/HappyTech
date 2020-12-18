/**
 * 
 * File: Template.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This backend class contains all the properties relating to the
 *              templates. It has two constructors, the first creates an instance 
 *              with the data stored into the database. The second is used to create 
 *              the templates for applicants, which include additional information 
 *              such as the header.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HappyTech
{
    class Template
    {
        // Contains all the templates being used for the applicants
        public static List<Template> templatesForApplicants = new List<Template>();

        // Contains all the templates stored in the Database
        public static List<Template> templates = new List<Template>();

        // Read-Only properties cannot be modified once created in the constructor
        public string Header { get; }
        public string Type { get; }
        public int Id { get; }

        /// <summary>
        /// private Constructor, creates the instances for the template selected for the applicants
        /// </summary>
        /// <param name="id">Holds the template Id</param>
        /// <param name="type">Holds the template name</param>
        /// <param name="applicant">Holds the applicant object to which the template belongs</param>
        private Template ( int id, string type, Applicant applicant )
        {
            Id = id;
            Type = type;

            // Template Header gets the full name of both the Recruiter and the Applicant as well as its type
            Header = $"Recruiter: {Recruiter.GetInstance().Name} {Recruiter.GetInstance().Surname}, " +
                     $"Applicant: {applicant.AfullName} for {Type}";
        }

        /// <summary>
        /// Overloaded constructor for use in addsections.cs - populates the checklist of templates that a user can add sections to
        /// </summary>
        /// <param name="templateId">   </param>
        /// <param name="templateType">   </param>
        private Template( int templateId, string templateType )
        {
            Id = templateId;
            Type = templateType;
        }

        /// <summary>
        /// Generates templateS according to the number of applicants into the list.
        /// </summary>
        /// <param name="applicant">Gets the object of the applicant being reviewed</param>
        /// <param name="templateType">Gets the type of the template chosen</param>
        public static void GenerateTemplateForApplicant( Applicant applicant, string templateType )
        {
            // Retrieves the template Id from the database given its type
            DataSet templateDB = Connection.GetDbConn().
            GetDataSet(SqlQueries.GetTemplateIdFromName(templateType));

            DataRow templateDBValue;

            for ( int i = 0; i < templateDB.Tables[0].Rows.Count; i++ )
            {
                templateDBValue = templateDB.Tables[0].Rows[i];

                // Creates the instance 
                Template _instance = new Template(
                    Int32.Parse(templateDBValue.ItemArray.GetValue(0).ToString()), // Template ID
                    templateType, // Template's tempType
                    applicant // Applicant belonging to 
                    );
                // Add the applicant inside the list
                Template.templatesForApplicants.Add(_instance);
            }
        }

        /// <summary>
        /// Fill the templates list with all the templates inside the database
        /// </summary>
        public static void GenerateTemplates()
        {
            // retrieves the Id from the database
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateNameId());
            DataRow dRow;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Template _instance = new Template(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // template ID
                    dRow.ItemArray.GetValue(1).ToString() // template's tempType
                    );
               Template.templates.Add(_instance); 
            }
        }

      
    }
}
