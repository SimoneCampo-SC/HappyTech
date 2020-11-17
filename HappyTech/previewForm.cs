using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class previewForm : Form
    {
        public previewForm()
        {
            InitializeComponent();
        }

        private void previewForm_Load(object sender, EventArgs e)
        {
            //Code.codeList.Clear();
            //Code.fillCodeList(); //fills a list inside code class with items from DB
            checklistAppPreview.CheckOnClick = true;

            for (int i = 0; i < Applicant.applicants.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                checklistAppPreview.Items.Add($"{Applicant.applicants[i].GetName()} {Applicant.applicants[i].GetEmail()}");
            }
        }

        private void checklistAppPreview_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
    
                for (int ix = 0; ix < checklistAppPreview.Items.Count; ++ix)
                    if (ix != e.Index) checklistAppPreview.SetItemChecked(ix, false);
            
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            //make a new applicant object with old applicant details
            //this is because applicants are stored in a list and we no longer want to use
            //that list to track the applicant position in a list of applicants
            //codeShortLookup = listBox.Items[e.Index].ToString();
            Connection.GetDbConn().CreateCommand(Constants.insertApplicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, docType));
            Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text, docType);
            Applicant.applicants.Add(applicant);
            this.Hide();
            ConfApplDetailsForm f3 = new ConfApplDetailsForm(false);
            f3.Show();
        }
    }
}
