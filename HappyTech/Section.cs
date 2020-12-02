/**
 * 
 * File: Section.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file contains all the properties relating to the
 *              sections. It has a list which contains all the sections
 *              created.
 *              
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// to keep my code similar to other classes that use lists (template, applicant etc) i have made a sections class.
    /// </summary>
    class Section
    {
        // Contains all the sections stored into the Database
        public static List<Section> sectionList = new List<Section>();

        public int Id { get; }
        public string Name { get; }

        // Private constructor
        private Section(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Fills the sectionList with all the sections presented into the Database
        /// </summary>
        public static void FillSectionList ()
        {
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionNameId());
            DataRow dRow;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Section _instance = new Section(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // section ID
                    dRow.ItemArray.GetValue(1).ToString() // section's name
                    );
               Section.sectionList.Add(_instance); // Add the section into the list
            }
        }

        /// <summary>
        /// inserts a new section and iterates over every checked item in a checklist of template names. creates a PersonalSection
        /// object for each 
        /// </summary>
        /// <param name="input"> This is a string from the section textbox. User input.</param>
        /// <param name="templateCheckBox"> A ChecklistBox object containing template names.</param>
        public static void InsertSectionWithSelectedTemplates(string input, CheckedListBox templateCheckBox)
        {
             //has to create the section object first so we have a section ID to work with
            string queryString = SqlQueries.CreateNewTag(input);
            Connection.GetDbConn().CreateCommand(queryString); //section object has now been created
            //we will get the id of this new section first instead of getting it in each iteration of the loop
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionIdFromName(input));
            DataRow dRow = ds.Tables[0].Rows[0];
            var sectionId = dRow.ItemArray.GetValue(0);
             foreach (string template in templateCheckBox.CheckedItems)
             {
                //for each template selected, we have to add a template id and section id to PersonalSection
                //so we will get the template id from the template name
                DataSet ds1 = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateIdFromName(template));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var templateId = dRow1.ItemArray.GetValue(0);
                //now we have the template id and section id
                string createPersonalSection = $"insert into PersonalSection (template_ID, section_ID) VALUES ('{templateId}', '{sectionId}')";
                Connection.GetDbConn().CreateCommand(createPersonalSection);
                //now a PersonalSection object has been created
            } 
  
        }

    }
}
