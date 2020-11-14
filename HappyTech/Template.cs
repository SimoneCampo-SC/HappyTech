using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    class Template
    {
        private string recruiterID;
        private string header;
        private string tempType;
        public static List<Template> templates = new List<Template>();
        private Template (int applicantNo)
        {
            this.recruiterID = Recruiter.GetInstance().GetID();
            this.tempType = Applicant.applicants[applicantNo].GetDocType();
            this.header = $"Recruiter: {Recruiter.GetInstance().GetName()} {Recruiter.GetInstance().GetSurname()}, " +
                          $"Applicant: {Applicant.applicants[applicantNo].GetName()} " +
                          $"for {tempType}";
        }
        public static void generateTemplates()
        {
            for (int i = 0; i < Applicant.applicants.Count; i++)
            {
                Template template = new Template(i);
                Template.templates.Add(template);
            }
        }

        public string GetHeader()
        {
            return header;
        }

        private void FillTemplateIntoDb ()
        {
            Connection.GetDbConn().CreateCommand(Constants.insertTemplate(recruiterID, header)); //+ tagID
        }
    }
}
