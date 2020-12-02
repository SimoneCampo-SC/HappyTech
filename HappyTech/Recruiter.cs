/**
 * 
 * File: Recruiter.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This class contains all the properties related to the Recruiter. 
 *              The instances of this class is created once the user will login into the system              
 */

namespace HappyTech
{
    class Recruiter
    {
        // Since the recruiter can be only one in the system, a private static instance is created in the class
        private static Recruiter _instance; 

        // Read-Only properties of the Recruiter _instance can be set once in the constructor
        public string Id { get; }
        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Password { get; }

        /// <summary>
        /// private Constructor, it cannot be called anywhere in the code
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
        ///  Creates the instance only if it has not been created before. 
        /// </summary>
        /// <param name="id">Holds the recruiter Id</param>
        /// <param name="name">Holds the recruiter name</param>
        /// <param name="surname">holds the recruiter surname</param>
        /// <param name="email">holds the recruiter email</param>
        /// <param name="password">holds the recruiter password</param>
        /// <returns></returns>
        public static Recruiter CreateInstance(string id, string name, string surname, string email, string password)
        {
            // Runs the constructor if the instance is equal to null
            if (_instance == null)
            {
                _instance = new Recruiter(id, name, surname, email, password);
            }
            return _instance;
        }

        /// <summary>
        /// Returns the Recruiter instance
        /// </summary>
        /// <returns></returns>
        public static Recruiter GetInstance()
        {
            // if the instance exists, it wil be returned 
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
        public static void DestroyInstance()
        {
            _instance = null;
        }
    }
}
