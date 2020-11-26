using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HappyTech
{
    public partial class previewForm : Form
    {
        int curApp = 0;
        string[] appDetails;
        string cancelStage;

        public previewForm()
        {
            InitializeComponent();
        }

        private void previewForm_Load(object sender, EventArgs e)
        {
            //Code.codeList.Clear();
            //Code.fillCodeList(); //fills a list inside code class with items from DB
            checklistAppPreview.CheckOnClick = true;
            cancelStage = "notClicked";

            for (int i = 0; i < Applicant.applicants.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                checklistAppPreview.Items.Add($"{Template.templatesForApplicants[i].TempType}  {Applicant.applicants[i].AJob}  {Applicant.applicants[i].AfullName}  {Applicant.applicants[i].Aemail}");
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
            if (appDetails == null)
            {
                lbError.Show();
                return;
            }
            else
            {
                lbError.Hide();
            }

            try
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + appDetails[2] + ".rtf"))
                { }
            }
            catch (Exception)
            {
                lbError.Text = "File already open somewhere";
                lbError.Show();
                return;
            }

            //make a new applicant object with old applicant details
            //this is because applicants are stored in a list and we no longer want to use
            //that list to track the applicant position in a list of applicants

            Applicant applicant = new Applicant(appDetails[2], appDetails[3], appDetails[1], Recruiter.GetInstance().Id); // name, email, job, doctype, recruiter id
            this.Hide();
            EditorForm f3 = new EditorForm(appDetails[2], appDetails[0], appDetails[3], appDetails[1]);
            f3.Show();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendBtn.Image = Properties.Resources.happytech_submit;
            sendBtn.Text = "Sending...";

            backBtn.Hide();
            previewBtn.Hide();
            sendBtn.Hide();
            lbError.Hide();
            imgSuccess.Show();
            lblSuccess.Show();
            btnDash.Show();
            imgStage3.Image = Properties.Resources.happytech_tick;

            // Turn rtf files into pdf files here
            // code here

            clearTempFiles();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (cancelStage == "notClicked")
            {
                backBtn.Text = "Are you sure?";
                cancelStage = "clicked";
            }
            else if (cancelStage == "clicked")
            {
                this.Hide();
                DashForm f2 = new DashForm("default");
                f2.Show();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm f2 = new DashForm("default");
            f2.Show();
        }

        private void clearTempFiles()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] files = di.GetFiles("*.rtf").Where(p => p.Extension == ".rtf").ToArray();

            foreach (FileInfo file in files)
            {
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch { }
            }
        }
    }
}
