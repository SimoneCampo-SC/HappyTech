/**
 * 
 * File: Code.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This class contains all the properties related to a code.
 *              The instances of this class will be created and added into
 *              the code list. Then, a second list will store all the codes
 *              selected for each feedback.
 *              
 */
using System;
using System.Collections.Generic;
using System.Data;

namespace HappyTech
{
    class Code
    {
        // Holds all the codes presented into the Database
        public static List<Code> codeList = new List<Code>();

        // List of codes selected in the editor
        public static List<string> selectedCodes = new List<string>();

        // Properties can be retrieved and modified
        // Id is Read-Only as it holds the index of a code in the database
        public int Id { get; }
        public string CodeName { get; set; }
        public int SectionID { get; set; }
        public string CodePara { get; set; }

        /// <summary>
        /// Constructor of the Code class
        /// </summary>
        /// <param name="id">holds the code Id</param>
        /// <param name="codeName">holds the name of the code</param>
        /// <param name="secID">holds the section ID belonging to the code</param>
        /// <param name="codePara">holds the section ID belonging to the code</param>
        private Code (int id, string codeName, int secID, string codePara )
        {
            this.Id = id;
            this.CodeName = codeName;
            this.SectionID = secID;
            this.CodePara = codePara;
        }

        /// <summary>
        /// Retrieve the codes from the database and add them into a List <Code>
        /// </summary>
        public static void FillCodeList()
        {
            // Retrieves the codes from the database
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.SelectCodes());
            DataRow dRow;

            // Iterates through the table extracted from the database
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates a new instance passing the data-fields from the database
                Code _instance = new Code(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // Code ID
                    dRow.ItemArray.GetValue(1).ToString(),              // CodeName
                    Int32.Parse(dRow.ItemArray.GetValue(2).ToString()), // SectionNo
                    dRow.ItemArray.GetValue(3).ToString()               // CodeParagraph
                    );
                // the instance is added into the list
                Code.codeList.Add(_instance); 
            }
        }
    }
}
