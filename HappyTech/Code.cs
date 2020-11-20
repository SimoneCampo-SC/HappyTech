using System;
using System.Collections.Generic;
using System.Data;

namespace HappyTech
{
    class Code
    {
        // List of codes has been created
        public static List<Code> codeList = new List<Code>();

        // List of codes selected in the editor
        public static List<string> selectedCodes = new List<string>();

        // List of current properties
        public int Id { get; }
        public string CodeName { get; set; }
        public int SectionID { get; set; }
        public string CodePara { get; set; }

        /// <summary>
        /// Constructor Code class
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
        /// Fill the codes into the list 
        /// </summary>
        public static void fillCodeList()
        {
            // retrieves the codes from the database
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.selectCodes());

            DataRow dRow;
            // iterates through the table created
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Code _instance = new Code(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // Code ID
                    dRow.ItemArray.GetValue(1).ToString(), // CodeName
                    Int32.Parse(dRow.ItemArray.GetValue(2).ToString()), // SectionNo
                    dRow.ItemArray.GetValue(3).ToString() // CodeParagraph
                    );
                Code.codeList.Add(_instance); // Add the code into the list
            }
        }
        /// <summary>
        /// Retrieves the name of the section given the Section ID
        /// </summary>
        /// <returns></returns>
        public string GetSectionName()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.selectSectionName(SectionID));
            DataRow dRow = ds.Tables[0].Rows[0];
            string name = dRow.ItemArray.GetValue(0).ToString();
            return name;
        }
    }
}
