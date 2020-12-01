/**
 * 
 * File: Applicant.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This class contains all the properties related to an applicant. 
 *              The instances of this class will be added into the database and 
 *              into the list.
 *              
 */

using System;
using System.Collections.Generic;

namespace HappyTech
{
    class Applicant
    {
        // list of Applicant has been created
        public static List <Applicant> applicants = new List<Applicant>();
        public List<String> selectedAppCodes = new List<String>();

        // List of all the read-only properties 
        public string AfullName { get; }
        public string Aemail { get; }
        public string AJob { get; }
        public string RecruiterId { get; }
        public string Atype { get; }

        /// <summary>
        /// Constructor of Applicant class
        /// </summary>
        /// <param name="name">holds applicant name</param>
        /// <param name="email">holds applicant email</param>
        /// <param name="job">holds applicant job</param>
        /// <param name="recruitID">holds recruiter id</param>
        /// <param name="type">holds applicant template type</param>
        public Applicant (string name, string email, string job, string recruitID, string type)
        {
            this.AfullName = name;
            this.Aemail = email;
            this.AJob = job;
            this.RecruiterId = recruitID;
            this.Atype = type;
        }
    }
}
