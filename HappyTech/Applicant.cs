using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Applicant
    {
        public static List <Applicant> applicants = new List<Applicant>();
        public string AfullName { get;}
        private string Aemail { get;}
        private string AJob { get;}

        public Applicant (string name, string email, string job)
        {
            this.AfullName = name;
            this.Aemail = email;
            this.AJob = job;
        }

        public string GetName()
        {
            return AfullName;
        }

        public string GetEmail()
        {
            return Aemail;
        }
        public string GetJob()
        {
            return AJob;
        }
    }
}
