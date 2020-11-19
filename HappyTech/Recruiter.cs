using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HappyTech
{
    class Recruiter
    {
        // Declaration of the static instance
        private static Recruiter _instance; 

        // Creation of all the properties
        public string Id { get; }
        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Password { get; }

        /// <summary>
        /// Private constructor of the Recruiter Class
        /// </summary>
        /// <param name="id"> holds the Recriter Id</param>
        /// <param name="name">holds the Recriter Name</param>
        /// <param name="surname">holds the Recriter Surname</param>
        /// <param name="email">holds the Recriter Email</param>
        /// <param name="password">holds the Recriter Password</param>
        private Recruiter (string id, string name, string surname, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
        }

        /// <summary>
        /// Creates the instance for just one time
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Recruiter createInstance(string id, string name, string surname, string email, string password)
        {
            // Runs the constructor only if the instance is equal to null
            if (_instance == null)
            {
                _instance = new Recruiter(id, name, surname, email, password);
            }
            return _instance;
        }

        /// <summary>
        /// Returns the instance if it is not equal to null
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Destroys the Instance 
        /// </summary>
        public static void DestroyRecruiInstance()
        {
            _instance = null;
        }
    }
}
