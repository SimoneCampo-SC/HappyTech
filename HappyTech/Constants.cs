using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Constants
    {
        static public string insertQuery(string email, string name, string surname, string password)
        {

            string query = $"INSERT INTO Recruiter  (email, name, surname, password) VALUES ('{email}', '{name}', '{surname}', '{password}' )";

            return query;
        }

        static public string selectRecruiter (string userEmail, string userPass)
        {
           string query = $"SELECT * FROM Recruiter WHERE email = '{userEmail}' AND password = '{userPass}'";

            return query;
        }
    }
            
           
    
}
