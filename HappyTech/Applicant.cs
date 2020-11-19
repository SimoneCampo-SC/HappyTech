using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Applicant
    {
        // list of Applicant has been created
        public static List <Applicant> applicants = new List<Applicant>();

        // List of all the read-only properties 
        public string AfullName { get; }
        public string Aemail { get; }
        public string AJob { get; }
        public string DocType { get; }

        /// <summary>
        /// Constructor of Applicant class
        /// </summary>
        /// <param name="name">holds recruiter name</param>
        /// <param name="email">holds recruiter email</param>
        /// <param name="job">holds recruiter job</param>
        /// <param name="dType">holds recruiter type</param>
        public Applicant (string name, string email, string job, string dType)
        {
            this.AfullName = name;
            this.Aemail = email;
            this.AJob = job;
            this.DocType = dType;
        }
    }
}
