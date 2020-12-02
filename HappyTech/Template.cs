/**
 * 
 * File: Template.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file contains all the properties relating to the
 *              templates. It has two constructors, the first creates 
 *              an instance with the data stored into the database. The
 *              second is used to create the templates for applicants,
 *              which include additional information such as the header.
 *              
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HappyTech
{
    class Template
    {
        // Contains all the templates selected for the applicants
        public static List<Template> templatesForApplicants = new List<Template>();

        // Contains all the templates stored in the Database
        public static List<Template> templates = new List<Template>();

        // List of all the properties 
        public string Header { get; }
        public string Type { get; }
        public int Id { get; }

        /// <summary>
        /// 
        ///     Header constructor.
        /// 
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="name"></param>
        /// <param name="applicant"></param>
        private Template ( int templateId, string name, Applicant applicant )
        {
            Id = templateId;
            Type = name;

            // Template Header gets the name of the Recruiter, Applicant and its type
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
            // retrieves the Id from the database
            DataSet templateDB = Connection.GetDbConn().
                                    GetDataSet( SqlQueries.GetTemplateIdFromName( templateType ) );

            DataRow templateDBValue;

            for ( int i = 0; i < templateDB.Tables[0].Rows.Count; i++ )
            {
                templateDBValue = templateDB.Tables[0].Rows[i];

                // Creates the instance
                Template _instance = new Template(
                    Int32.Parse(templateDBValue.ItemArray.GetValue(0).ToString()), // template ID
                    templateType, // template's tempType
                    applicant
                    );
                Template.templatesForApplicants.Add(_instance); // Add the code into the list
            }
        }

        /// <summary>
        /// Fill the templates list
        /// </summary>
        public static void FillTemplates()
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
               Template.templates.Add(_instance); // Add the code into the list
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="selectedSections"></param>
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
                string queryString = SqlQueries.InsertNewTemplate(input);
                Connection.GetDbConn().CreateCommand(queryString);
                //template object has now been created
                //we will get the id of this new template first instead of getting it in each iteration of the loop
                DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateIdFromName(input));
                DataRow dRow = ds.Tables[0].Rows[0];
                var templateId = dRow.ItemArray.GetValue(0);
                foreach (string section in selectedSections.CheckedItems)
                {
                    //for each template selected, we have to add a template id and section id to PersonalSection
                    //so we will get the template id from the template name
                    DataSet ds1 = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionIdFromName(section));
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
