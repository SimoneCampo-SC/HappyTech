/**
 * 
 * File: Recruiter.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file contains all the properties that belong to the
 *              recruiter instance.
 *              
 */

namespace HappyTech
{
    class Recruiter
    {
        // Definition of the static instance
        private static Recruiter _instance; 

        // Definition of all the properties
        public string Id { get; }
        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Password { get; }

        /// <summary>
        /// Private constructor of the Recruiter Class as it cannot be created anywhere in the code
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
        /// Creates the instance for just one time as only one recruiter can login into the application at time
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Recruiter CreateInstance(string id, string name, string surname, string email, string password)
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
