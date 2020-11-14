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
        public string AfullName { get; }
        private string Aemail { get; }
        private string AJob { get; }
        private string docType { get; }

        public Applicant (string name, string email, string job, string dType)
        {
            this.AfullName = name;
            this.Aemail = email;
            this.AJob = job;
            this.docType = dType;
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
        public string GetDocType()
        {
            return docType;
        }
    }
}
