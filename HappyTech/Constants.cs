using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Constants
    {
        public static string insertRecruiter(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}' )";
            return query;
        }

        public static string insertApplicant(string name, string email, string job)
        {
            string query = $"INSERT INTO Applicant (Applicant_Name, Applicant_Email, job_Position) VALUES ('{name}', '{email}', '{job}')";
            return query;
        }

        public static string deleteApplicant()
        {
            string query = $"DELETE FROM Applicant";
            return query;
        }

        public static string selectRecruiter (string userEmail, string userPass)
        {
           string query = $"SELECT * FROM Recruiter WHERE email = '{userEmail}' AND password = '{userPass}'";
           return query;
        }
    }
            
           
    
}
