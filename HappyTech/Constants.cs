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
        public static string SelectSectionPerTemplate(int tempID)
        {
            string query = $"SELECT DISTINCT section_ID FROM PersonalSection WHERE template_ID = '{tempID}'";
            return query;
        }
        public static string selectTemplateType()
        {
            string query = $"SELECT tempType FROM Template";
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

        static public string getCodeFromTagId(object tagId)
        {
            string query = $"SELECT codeShort, codeParagraph FROM Codes WHERE SectionNo = {tagId}";
            return query;
        }

        static public string getTagNames(string templateName) //takes template name and displays section names for this template
        {
            string query = $"select name from Section where Id IN (select section_ID from PersonalSection where template_ID = (select Id from Template where tempType = '{templateName}'))";
            return query;
        }
        static public string getTemplateName()
        {
            string query = "SELECT tempType FROM Template";
            return query;
        }
        static public string getTemplateNameId() //gets name NAD id, used in addsection.cs for populating template check box
        {
            string query = "SELECT Id, tempType FROM Template";
            return query;
        }
        static public string getTemplateIdFromName(string tempName)
        {
            string query = $"SELECT Id FROM Template WHERE tempType = '{tempName}'";
            return query;
        }
        static public string insertNewTemplate(string templateName)
        {
            string query = $"INSERT INTO Template (tempType) VALUES ('{templateName}')";
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
            string query = $"SELECT name FROM Section WHERE Id = '{secID}'";
            return query;
        }
        public static string getSectionIdFromName(string name)
        {
            string query = $"SELECT Id FROM Section WHERE name = '{name}'";
            return query;
        }
        static public string getSectionNameId() //gets name and id, used in sections for populating sections check box in addcode
        {
            string query = "SELECT Id, name FROM Section";
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

        public static string insertApplicant(string name, string email, string job, string id)
        {
            string query = $"INSERT INTO Applicant (Applicant_Name, Applicant_Email, job_Position, Recruiter_ID) VALUES ('{name}', '{email}', '{job}', '{id}')";
            return query;
        }

        public static string SelectApplicant()
        {
            string query = "SELECT Applicant_Name AS 'Name', Job_Position AS 'Job Position' FROM Applicant";
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
