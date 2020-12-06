/**
 * 
 * File: ConfirmApplicantForm.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Author 2: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file displays all applicants added by the user.
 *              It allows the user to delete all applicants, to add
 *              more, and to begin feedback.
 *              
 */

using System;
using System.Data;
using System.Windows.Forms;
using static HappyTech.DashForm;
using static HappyTech.FeedbackClass;

namespace HappyTech
{
    public partial class ConfirmApplicantForm : Form
    {
        // Sets available cancel stage options.
        private enum Stage
        {
            NotClicked,
            Clicked
        }

        // Sets the default cancel stage.
        Stage cancel = Stage.NotClicked;

        /// <summary>
        /// 
        ///     Constructor. Displays success message if applicant added.
        ///     Gets applicants from database and lists them.
        /// 
        /// </summary>
        /// <param name="applicantAdded"> If a new applicant has been added: True, and False </param>
        public ConfirmApplicantForm(bool applicantAdded)
        {
            InitializeComponent();

            if (applicantAdded) Label_Success.Visible = true;

            DataSet applicantDB = Connection.GetDbConn().
                                    GetDataSet(SqlQueries.SelectApplicant());

            DataGrid_ApplicantList.DataSource = applicantDB.Tables[0];

            for (int i = 0; i < DataGrid_ApplicantList.Columns.Count; i++) 
            {
                DataGrid_ApplicantList.Columns[i].Width = 181;
            }

            Label_RecruiterName.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            Label_ApplicantTotal.Text = Applicant.applicants.Count.ToString();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the add button.
        ///     This will create a new DashForm.cs instance
        ///     so that the user can enter the details of a
        ///     new applicant to add to the list.
        /// 
        /// </summary>
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Hide();
            DashForm instance_DashForm = new DashForm( Mode.Applicant );
            instance_DashForm.Show();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the begin button.
        ///     This will create a new FeedbackForm.cs instance
        ///     from the starting position of 0.
        ///     
        /// </summary>
        private void Button_Begin_Click( object sender, EventArgs e )
        {
            Hide();
            FeedbackForm instance_FeedbackForm = NextForm( Direction.Current, 0 );
            instance_FeedbackForm.Show();
        }

        /// <summary>
        /// 
        ///     Click trigger function for the cancel button.
        ///     This will double check if the user wants to
        ///     cancel as they will be losing all the progress
        ///     made.
        /// 
        /// </summary>
        private void Button_Cancel_Click( object sender, EventArgs e )
        {
            if ( cancel == Stage.NotClicked )
            {
                Button_Cancel.Text = "Are you sure?";
                cancel = Stage.Clicked;
            }
            else if ( cancel == Stage.Clicked )
            {
                Hide();
                DashForm instance_DashForm = new DashForm( Mode.Default );
                instance_DashForm.Show();
            }
        }
    }
}
