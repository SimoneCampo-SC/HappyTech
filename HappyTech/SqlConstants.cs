/*
 * 
 * File: SqlConstants.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Timester 1
 * 
 * Summary:     This file contains all the SQL Queries used whithin the program
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HappyTech
{
    class SqlConstants
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

        public static string getTagIdFromName(string input)
        {
            string query = $"SELECT Id from Section where name = '{input}'";
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

        public static string SelectAllSections()
        {
            string query = $"SELECT * FROM Section";
            return query;
        }
        static public string getCodeFromSectionId(object tagId)
        {
            string query = $"SELECT codeShort, codeParagraph FROM Codes WHERE SectionNo = {tagId}";
            return query;
        }
        static public string getCodeParaFromShort(string codeShort)
        {
            string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShort}'";
            return query;
        }

        static public string GetSectionPerTemplate(string templateName) //takes template name and displays section names for this template
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
        public static string createNewTag(string newSectionName)
        {
            string query = $"INSERT INTO Section (name) VALUES ('{newSectionName}')";
            return query;
        }

        public static string insertNewCode(string codeShort, string codePara, object tag)
        {
            string query = $"INSERT INTO Codes (codeShort, codeParagraph , SectionNo) VALUES ('{codeShort}', '{codePara}', {tag})";
            return query;
        }

        public static string getCodeIdFromName (string codeName)
        {
            string query = $"SELECT Id FROM Codes WHERE codeShort = '{codeName}'";
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

        public static string editCode (object codeId, string codeName, string codePara)
        {
            string query = $"UPDATE Codes SET codeShort = '{codeName}', codeParagraph = '{codePara}' WHERE Id = '{codeId}'";
            return query;
        }
        public static string editSection(object sectionId, string sectionName)
        {
            string query = $"UPDATE Section SET name = '{sectionName}' WHERE Id = '{sectionId}'";
            return query;
        }

        public static string editTemplate(object tempId, string templateName)
        {
            string query = $"UPDATE Template SET tempType = '{templateName}' WHERE Id = '{tempId}'";
            return query;
        }
        public static string getCodeId(string codeName)
        {
            string query = $"SELECT Id from Codes WHERE codeShort = '{codeName}'";
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

        public static bool checkTemplate(string template)
        {
            string query = $"SELECT * FROM Template WHERE tempType = '{template}'";
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

        public static bool checkSection(string section)
        {
            string query = $"SELECT * FROM Section WHERE name = '{section}'";
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

        public static bool checkCode(string code)
        {
            string query = $"SELECT * FROM Codes WHERE codeShort = '{code}'";
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

        public static string insertRecruiter(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}')";
            return query;
        }

        public static string insertApplicant(string name, string email, string job, string id)
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

        public static string deleteApplicant()
        {
            string query = $"DELETE FROM Applicant";
            return query;
        }

        /* These are delete statements used in neweditdelete
         * deletion of PersonalSection objects are required for this
         * */
        public static string deleteCodeFromId(object codeId)
        {
            string query = $"DELETE FROM Codes WHERE Id = '{codeId}'";
                return query;
        }
        public static string deleteSectionFromId(object sectionId)
        {
            string query = $"DELETE FROM Section WHERE Id = '{sectionId}'";
                return query;
        }
        public static string deleteTemplateFromId(object templateId)
        {
            string query = $"DELETE FROM Template WHERE Id = '{templateId}'"; 
                return query;
        }

        public static string deletePersonalSectionUsingSectionId (object sectionId)
        {
            string query = $"DELETE FROM PersonalSection WHERE section_ID = '{sectionId}'";
            return query;
        }
        public static string deletePersonalSectionUsingTemplateId(object templateId)
        {
            string query = $"DELETE FROM PersonalSection WHERE template_ID = '{templateId}'";
            return query;
        }
    }
}
