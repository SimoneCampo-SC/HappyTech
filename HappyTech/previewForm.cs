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
        int curApp = 0;
        string[] appDetails;
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
                checklistAppPreview.Items.Add($"{Applicant.applicants[i].DocType}  {Applicant.applicants[i].AJob}  {Applicant.applicants[i].AfullName}  {Applicant.applicants[i].Aemail}");
            }
        }

        private void checklistAppPreview_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            curApp = e.Index; //index of checked item
                for (int ix = 0; ix < checklistAppPreview.Items.Count; ++ix)
                    if (ix != e.Index) checklistAppPreview.SetItemChecked(ix, false);
            
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {

            foreach (string s in checklistAppPreview.CheckedItems)
            {
                string applicantLookup = checklistAppPreview.Items[curApp].ToString();
                appDetails = applicantLookup.Split(new[] { "  " }, StringSplitOptions.None);
            }

            // stop preview if no applicants have been selected
            if (appDetails == null) return;

            //make a new applicant object with old applicant details
            //this is because applicants are stored in a list and we no longer want to use
            //that list to track the applicant position in a list of applicants
            
            Applicant applicant = new Applicant(appDetails[2], appDetails[3], appDetails[1], appDetails[0]); //name email, job, doctype
            this.Hide();
            EditorForm f3 = new EditorForm(appDetails[2], appDetails[0]);
            f3.Show();
        }
    }
}
