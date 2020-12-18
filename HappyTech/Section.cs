/**
 * 
 * File: Section.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This back-end class contains all the properties belonging to a
 *              section.
 *              
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HappyTech
{
    class Section
    {
        // Private instance is defined as it cannot be create anywhere in the system
        private static Section _instance;

        // Holds all the sections stored into the database
        public static List<Section> sectionList = new List<Section>();

        // Read-Only properties cannot be changed once defined inside the constructor
        public int Id { get; }
        public string Name { get; }

        /// <summary>
        /// Private Constructor, it cannot be called anywhere in the system.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        private Section(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Create instances with the information in database and add it into the sectionList
        /// </summary>
        public static void FillSectionList ()
        {
            // Retrieves all the sections from the database
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionNameId());
            DataRow dRow;

            // Iterates through the section table 
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                dRow = ds.Tables[0].Rows[i];

                // Instance created getting the values from the database 
                 _instance = new Section(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // section ID
                    dRow.ItemArray.GetValue(1).ToString() // section's name
                    );
               // _instance issaved into the list
               Section.sectionList.Add(_instance); 
            }

            // The instance is destroyed as it doesn't need anymore
            _instance = null;
        }

       

    }
}
