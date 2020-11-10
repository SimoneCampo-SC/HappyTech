using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    class Template
    {
        private string header;
        private string tag;
        public static List<Template> templates = new List<Template>();
        private Template (int applicantNo)
        {
            int i = 0;
            this.tag = "tag";
            this.header = Recruiter.GetInstance().GetName() + " "
                          + Recruiter.GetInstance().GetSurname() + ", "
                          + Applicant.applicants[applicantNo].GetName() + " for "
                          + "tag";
            i++;
            Section section = new Section(i.ToString());

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
    }
}
