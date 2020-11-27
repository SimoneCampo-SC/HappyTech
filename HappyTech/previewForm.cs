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
        int curApp;
        string[] appDetails;
        string cancelStage;

        public previewForm()
        {
            InitializeComponent();

            cancelStage = "notClicked";

            for (int i = 0; i < Applicant.applicants.Count(); i++)
            {
                checklistAppPreview.Items.Add($"{Template.templatesForApplicants[i].TempType}  {Applicant.applicants[i].AJob}  {Applicant.applicants[i].AfullName}  {Applicant.applicants[i].Aemail}");
            }

            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            lblAppTotalVal.Text = Applicant.applicants.Count.ToString();
        }

        private void checklistAppPreview_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            //curApp = e.Index; //index of checked item
            //for (int i = 0; i < checklistAppPreview.Items.Count; ++i)
            //{
            //    if (i != e.Index) checklistAppPreview.SetItemChecked(i, false);
            //}

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
                lbError.Text = "Select an applicant to preview";
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
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + appDetails[2] + "-comments.rtf"))
                { }
            }
            catch (Exception)
            {
                lbError.Text = "File already in use";
                lbError.Show();
                return;
            }

            //make a new applicant object with old applicant details
            //this is because applicants are stored in a list and we no longer want to use
            //that list to track the applicant position in a list of applicants

            Applicant applicant = new Applicant(appDetails[2], appDetails[3], appDetails[1], Recruiter.GetInstance().Id); // name, email, job, doctype, recruiter id
            this.Hide();
            EditorForm f3 = new EditorForm(appDetails[2], appDetails[0], appDetails[3], appDetails[1], curApp);
            f3.Show();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendBtn.Image = Properties.Resources.happytech_submit;
            sendBtn.Text = "Sending...";

            // Turn rtf files into pdf files here
            // code here

            clearTempFiles();

            backBtn.Hide();
            previewBtn.Hide();
            sendBtn.Hide();
            lbError.Hide();

            btnDash.BackColor = Color.FromArgb(19,174,71);
            btnDash.ForeColor = Color.White;
            btnDash.Show();

            lblSubmit.ForeColor = Color.White;
            lblSubmit.Text = "Success.";

            panelSubmit.BackColor = Color.FromArgb(19, 174, 71);
            lblRecruiter.ForeColor = Color.White;
            lblRecruiterVal.ForeColor = Color.White;
            lblAppTotal.ForeColor = Color.White;
            lblAppTotalVal.ForeColor = Color.White;

            imgStage3.Image = Properties.Resources.happytech_tick;

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

        private void checklistAppPreview_SelectedValueChanged(object sender, EventArgs e)
        {
            //curApp = e.Index; //index of checked item
            curApp = checklistAppPreview.SelectedIndex;
            for (int i = 0; i < checklistAppPreview.Items.Count; ++i)
            {
                if (i != curApp) checklistAppPreview.SetItemChecked(i, false);
            }
        }
    }
}
