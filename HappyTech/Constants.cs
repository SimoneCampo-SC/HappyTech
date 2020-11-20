using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HappyTech
{
    class Constants
    {
        static public string insertQuery(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter  (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}' )";

            return query;
        }

        static public string selectRecruiter(string userEmail, string userPass)
        {
            string query = $"SELECT * FROM Recruiter WHERE email = '{userEmail}' AND password = '{userPass}'";

            return query;
        }

        static public string getTagIdFromName(string tagName)
        {
            string query = $"SELECT Id FROM Section WHERE name = '{tagName}'";
            return query;
        }

        static public string getCodeFromTagId(string tagId)
        {
            string query = $"SELECT codeShort, codeParagraph FROM Codes WHERE SectionNo = {tagId}";
            return query;
        }

        static public string getTagNames()
        {
            string query = "SELECT name FROM Section";
            return query;
        }

        public static string createNewTag(string newTagName)
        {
            string query = $"INSERT INTO Section (name) VALUES ('{newTagName}')";
            return query;
        }

        public static string insertNewCode(string codeShort, string codePara, object tag)
        {
            string query = $"INSERT INTO Codes (codeShort, codeParagraph , SectionNo) VALUES ('{codeShort}', '{codePara}', {tag})";
            return query;
        }
        public static string selectSectionName(int secID)
        {
            string query = $"SELECT (name) FROM Section WHERE Id = {secID}";
            return query;
        }

        public static string selectCodes()
        {
            string query = "SELECT * FROM Codes";
            return query;
        }

        public static bool checkRecruiter(string email)
        {
            string query = $"SELECT * FROM Recruiter WHERE email = '{email}'";
            DataSet ds = Connection.GetDbConn().getDataSet(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string insertTemplate(string recruitId, string header) 
        {
            string query = $"INSERT INTO Template (Recruiter_ID, tempHeader) VALUES ('{recruitId}', '{header}')";
            return query;
        }

        public static string insertRecruiter(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}')";
            return query;
        }

        public static string selectRecruiterID(string email)
        {
            string query = $"SELECT Id FROM Recruiter WHERE email = '{email}'";
            return query;
        }

        public static string insertApplicant(string name, string email, string job, string docType)
        {
            string query = $"INSERT INTO Applicant (Applicant_Name, Applicant_Email, job_Position, Doc_Type) VALUES ('{name}', '{email}', '{job}', '{docType}')";
            return query;
        }

        public static string deleteApplicant()
        {
            string query = $"DELETE FROM Applicant";
            return query;
        }

        public static string deleteTemplate()
        {
            string query = $"DELETE FROM Template";
            return query;
        }


    }
            
           
    
}
