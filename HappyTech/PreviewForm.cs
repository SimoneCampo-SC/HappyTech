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
    public partial class PreviewForm : Form
    {
        string applicantDisplay = "{0, -10}{1,-20}{2,-30}{3,-40}";

        public PreviewForm()
        {
            InitializeComponent();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.Items.Add(String.Format(applicantDisplay, "Type", "Date", "AppicantName", "ApplicantEmail"));
            checklistAppPreview.CheckOnClick = true;
        }

        private void checklistAppPreview_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checklistAppPreview.Items.Count; i++)
            {
                if (checklistAppPreview.GetItemChecked(i) == true)
                {
                    checklistAppPreview.SetItemChecked(i, false);
                }
            }
            e.NewValue = CheckState.Checked;

            //int i = 0;
            //foreach (string item in checklistAppPreview.CheckedItems)
            //{
            //    //checklistAppPreview.Items[i];
            //    checklistAppPreview.SetItemChecked(i, false);
            //    i++;
            //}
            //e.NewValue = CheckState.Checked;
        }
    }
}
