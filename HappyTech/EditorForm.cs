using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HappyTech
{
    public partial class EditorForm : Form
    {
        int currentPosition; // holds the position of the templates in the list
        string mode; //this tracks how the editor was generated, either feedback - if form created from dashform
        //or wasn't the last applicant
        //mode is "preview" if a document has been selected to edit from the previewForm
        //used to determine function of back button and is set in the constructors

        /// <summary>
        ///  Constructor of the current form
        /// </summary>
        /// <param name="position">holds the current position of the template being showed</param>
        public EditorForm(int position)
        {
            mode = "feedback";
            currentPosition = position; // update the currentPosition
            InitializeComponent();

            /* Displays the applicant selected out of all the applicants
             * position + 1 as the iterator starts from 0 to n-1 */
            lbApplicants.Text = $"Applicant {position + 1} out of  {Applicant.applicants.Count}"; 
            
            // Takes the header of the template in the assigned position in the list
            lbHeader.Text = Template.templates[position].Header;
        }

        public EditorForm(string applicantName, string appType) // takes applicant name + type from previewForm
        { //As editorForm usually takes an arguement of the applicant's position in the application list
            //this wont work if you are editing one applicant's feedback from the previewForm screen
            //so overloaded constructor is making a specific type of editorform for this purpose
            mode = "preview";
            currentPosition = Template.templates.Count - 1; //so that next button will always go to prevForm
            InitializeComponent();
            lbApplicants.Text = $"You are Previewing a feedback for {applicantName}";

            lbHeader.Text = Recruiter.GetInstance().Name + Recruiter.GetInstance().Surname +
                applicantName + appType;
            //makes header from recruiter instsnce and passed in applicant details
                //recruiter, app, type
                //Template.templates[position].GetHeader();
               // richTextBox2.Text = read in the text in the saved .rtf filename "recruitername applicantname".rtf

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + applicantName + ".txt"))
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().GetName() + applicantName + ".rtf"))
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
            {
                //this is supposed to find the saved feedback file and prefill richTextBox2 with the feedback
                //however, this shows formatting code which is not ideal. formatting does not show if file opened in 
                //word
               richTextBox2.Text = sr.ReadToEnd();
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (mode == "feedback")
            {
                if (currentPosition > 0)
                {
                    // save template - should be in Editor Class
                    f = EditorClass.NextForm(0, currentPosition);
                    this.Hide();
                    f.Show();
                }
            }
            else if (mode == "preview")
            {
                this.Hide();
                previewForm pf = new previewForm();
                pf.Show();
            }
          
        }

        private void btNext2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf"))
            {
               
                
                sw.WriteLine(richTextBox2.Text);
                if (richTextBox1.Text != "Enter your comment here..." || richTextBox1.Text != "")
                {
                    sw.WriteLine("\r\nComments:\r\n");
                    sw.WriteLine(richTextBox1.Text);
                }

            }
            //saves the feedback doc to debug folder when next button is clicked
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            richTextBox2.SaveFile(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".txt");
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2
=======
            //richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");
>>>>>>> 6d5850201845c26be35e7bc5d0483ad2d84454c2

            EditorForm f;
            if (currentPosition < Template.templates.Count - 1)
            {
                // save template - should be into the Editor Class
                f = EditorClass.NextForm(1, currentPosition);
                this.Hide();
                f.Show();
            }
            else if (currentPosition >= Template.templates.Count - 1)
            {
                this.Hide();
                previewForm pf = new previewForm();
                pf.Show();
            }
        }
        private void EditorForm_Load(object sender, EventArgs e)
        {
            // string item;
            listBox.CheckOnClick = true;
            Code.codeList.Clear();
            Code.fillCodeList();
            for (int i = 0; i < Code.codeList.Count(); i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                listBox.Items.Add($"{Code.codeList[i].CodeName}");
            }
        }

        private void listBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //get the code short of the selected list item
            string codeShortLookup;
            codeShortLookup = listBox.Items[e.Index].ToString();
            string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShortLookup}'";
            DataSet ds = Connection.GetDbConn().getDataSet(query);
            DataRow dRow = ds.Tables[0].Rows[0];
            //goes to the db, returns the first row (the codeparagraph) stores in variable
            string paragraphToAdd = dRow.ItemArray.GetValue(0).ToString();
            richTextBox2.AppendText(paragraphToAdd + '\n');
            //appends var to rich text with a newline separator


            //use DB to get code paragraph related to this short code

            //make a feedback object , create section objects then when code box checked, add that code to the section
            //if unchecked, remove code from section - didn't use because complex


            List<string> checkedItems = new List<string>();
            foreach (var item in listBox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(listBox.Items[e.Index].ToString());
            else
                checkedItems.Remove(listBox.Items[e.Index].ToString());

           
        }
    }
}