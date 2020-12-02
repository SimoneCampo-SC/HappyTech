/**
 * 
 * File: SqlQueries.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Hopper, Kean 1911956
 * Author 3: Osborne, Oliver 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file contains all the SQL queries used in the
 *              program.
 * 
 */

using System.Data;

namespace HappyTech
{
    class SqlQueries
    {
        public static string SelectAllTemplates()
        {
            string query = $"SELECT * FROM Template";
            return query;
        }
        public static string SelectSectionPerTemplate(int tempID)
        {
            string query = $"SELECT DISTINCT section_ID FROM PersonalSection WHERE template_ID = '{tempID}'";
            return query;
        }

        public static string InsertNewPersonalSection (object templateId, object sectionId)
        {
            string query = $"insert into PersonalSection (template_ID, section_ID) VALUES ('{templateId}', '{sectionId}')";
            return query;
        }
        public static string GetTagIdFromName(string input)
        {
            string query = $"SELECT Id from Section where name = '{input}'";
            return query;
        }
        public static string SelectTemplateType()
        {
            string query = $"SELECT tempType FROM Template";
            return query;
        }

        static public string SelectRecruiter(string userEmail, string userPass)
        {
            string query = $"SELECT * FROM Recruiter WHERE email = '{userEmail}' AND password = '{userPass}'";
            return query;
        }

        public static string SelectAllSections()
        {
            string query = $"SELECT * FROM Section";
            return query;
        }
        static public string GetCodeFromSectionId(object tagId)
        {
            string query = $"SELECT codeShort, codeParagraph FROM Codes WHERE SectionNo = {tagId}";
            return query;
        }
        static public string GetCodeParaFromShort(string codeShort)
        {
            string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShort}'";
            return query;
        }

        static public string GetSectionPerTemplate(string templateName) //takes template name and displays section names for this template
        {
            string query = $"select name from Section where Id IN (select section_ID from PersonalSection where template_ID = (select Id from Template where tempType = '{templateName}'))";
            return query;
        }
        static public string GetTemplateName()
        {
            string query = "SELECT tempType FROM Template";
            return query;
        }
        static public string GetTemplateNameId() //gets name NAD id, used in addsection.cs for populating template check box
        {
            string query = "SELECT Id, tempType FROM Template";
            return query;
        }
        static public string GetTemplateIdFromName(string tempName)
        {
            string query = $"SELECT Id FROM Template WHERE tempType = '{tempName}'";
            return query;
        }
        static public string InsertNewTemplate(string templateName)
        {
            string query = $"INSERT INTO Template (tempType) VALUES ('{templateName}')";
            return query;
        }
        public static string CreateNewTag(string newSectionName)
        {
            string query = $"INSERT INTO Section (name) VALUES ('{newSectionName}')";
            return query;
        }

        public static string InsertNewCode(string codeShort, string codePara, object tag)
        {
            string query = $"INSERT INTO Codes (codeShort, codeParagraph , SectionNo) VALUES ('{codeShort}', '{codePara}', {tag})";
            return query;
        }

        public static string GetCodeIdFromName (string codeName)
        {
            string query = $"SELECT Id FROM Codes WHERE codeShort = '{codeName}'";
            return query;
        }
        public static string SelectSectionName(int secID)
        {
            string query = $"SELECT name FROM Section WHERE Id = '{secID}'";
            return query;
        }
        public static string GetSectionIdFromName(string name)
        {
            string query = $"SELECT Id FROM Section WHERE name = '{name}'";
            return query;
        }
        static public string GetSectionNameId() //gets name and id, used in sections for populating sections check box in addcode
        {
            string query = "SELECT Id, name FROM Section";
            return query;
        }

        public static string SelectCodes()
        {
            string query = "SELECT * FROM Codes";
            return query;
        }

        public static string EditCode (object codeId, string codeName, string codePara)
        {
            string query = $"UPDATE Codes SET codeShort = '{codeName}', codeParagraph = '{codePara}' WHERE Id = '{codeId}'";
            return query;
        }
        public static string EditSection(object sectionId, string sectionName)
        {
            string query = $"UPDATE Section SET name = '{sectionName}' WHERE Id = '{sectionId}'";
            return query;
        }

        public static string EditTemplate(object tempId, string templateName)
        {
            string query = $"UPDATE Template SET tempType = '{templateName}' WHERE Id = '{tempId}'";
            return query;
        }
        public static string GetCodeId(string codeName)
        {
            string query = $"SELECT Id from Codes WHERE codeShort = '{codeName}'";
            return query;
        }

        public static bool CheckRecruiter(string email)
        {
            string query = $"SELECT * FROM Recruiter WHERE email = '{email}'";
            DataSet ds = Connection.GetDbConn().GetDataSet(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckTemplate(string template)
        {
            string query = $"SELECT * FROM Template WHERE tempType = '{template}'";

            DataSet templateDB = Connection.GetDbConn().GetDataSet(query);

            if (templateDB.Tables[0].Rows.Count != 0) return true;
            else return false;
        }

        public static bool CheckSection(string section)
        {
            string query = $"SELECT * FROM Section WHERE name = '{section}'";

            DataSet sectionDB = Connection.GetDbConn().GetDataSet(query);

            if (sectionDB.Tables[0].Rows.Count != 0) return true;
            else return false;
        }

        public static bool CheckCode(string code)
        {
            string query = $"SELECT * FROM Codes WHERE codeShort = '{code}'";

            DataSet codeDB = Connection.GetDbConn().GetDataSet(query);

            if (codeDB.Tables[0].Rows.Count != 0) return true;
            else return false;
        }

        public static string InsertRecruiter(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}')";
            return query;
        }

        public static string InsertApplicant(string name, string email, string job, string id)
        {
            string query = $"INSERT INTO Applicant (Applicant_Name, Applicant_Email, job_Position, Recruiter_ID) VALUES ('{name}', '{email}', '{job}', '{id}')";
            return query;
        }

        public static string SelectApplicant()
        {
            //string query = "SELECT Applicant_Name AS 'Name', Job_Position AS 'Job Position' FROM Applicant";
            string query = "SELECT Applicant_Name AS 'Name', Applicant_Email AS 'Email', Job_Position AS 'Job Position' FROM Applicant";
            return query;
        }

        public static string DeleteApplicant()
        {
            string query = $"DELETE FROM Applicant";
            return query;
        }

        /* These are delete statements used in EditorForm
         * deletion of PersonalSection objects are required for this
         * */
        public static string DeleteCodeFromId(object codeId)
        {
            string query = $"DELETE FROM Codes WHERE Id = '{codeId}'";
                return query;
        }
        public static string DeleteSectionFromId(object sectionId)
        {
            string query = $"DELETE FROM Section WHERE Id = '{sectionId}'";
                return query;
        }
        public static string DeleteTemplateFromId(object templateId)
        {
            string query = $"DELETE FROM Template WHERE Id = '{templateId}'"; 
                return query;
        }

        public static string DeletePersonalSectionUsingSectionId (object sectionId)
        {
            string query = $"DELETE FROM PersonalSection WHERE section_ID = '{sectionId}'";
            return query;
        }
        public static string DeletePersonalSectionUsingTemplateId(object templateId)
        {
            string query = $"DELETE FROM PersonalSection WHERE template_ID = '{templateId}'";
            return query;
        }
    }
}
