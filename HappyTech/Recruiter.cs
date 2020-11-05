using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Recruiter
    {
        private static Recruiter _instance;
        private string email;
        private string name;
        private string surname;
        private string password;
        private Recruiter (string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }
        public static Recruiter createInstance(string name, string surname, string email, string password)
        {
            if (_instance == null)
            {
                _instance = new Recruiter(name, surname, email, password);
            }
            return _instance;
        }
        public static Recruiter GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }
            else
            {
                return null;
            }
        }
        public string GetName()
        {
            return _instance.name;
        }
        public string GetSurname()
        {
            return _instance.surname;
        }

        public string GetEmail()
        {
            return _instance.email;
        }
    }
}
