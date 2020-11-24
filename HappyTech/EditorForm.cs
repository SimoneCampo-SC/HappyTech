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
        string previewAppName;
        

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
            //currentPosition = Template.templates.Count - 1; //so that next button will always go to prevForm
            previewAppName = applicantName;
            InitializeComponent();
            lbApplicants.Text = $"You are Previewing a feedback for {applicantName}";

            lbHeader.Text = Recruiter.GetInstance().Name + Recruiter.GetInstance().Surname +
                applicantName + appType;
            //makes header from recruiter instsnce and passed in applicant details
                //recruiter, app, type
                //Template.templates[position].GetHeader();
               // richTextBox2.Text = read in the text in the saved .rtf filename "recruitername applicantname".rtf


            using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + applicantName + ".rtf"))

            {
                //this is supposed to find the saved feedback file and prefill richTextBox2 with the feedback
                //however, this shows formatting code which is not ideal. formatting does not show if file opened in 
                //word
               richTextBox2.Text = sr.ReadToEnd();
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            
            if (mode == "feedback")
            {
                if (currentPosition > 0)
                {
                    this.Hide();
                    EditorForm f = EditorClass.NextForm("backward", currentPosition);
                    f.Show();
                }
                else if (currentPosition == 0)
                {
                    Template.templates.Clear();
                    //Connection.GetDbConn().CreateCommand(Constants.deleteTemplate());
                    this.Hide();
                    ConfApplDetailsForm cadf = new ConfApplDetailsForm(false);
                    cadf.Show();
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
            if (mode == "feedback")
            {
                // save template - should be into the Editor Class
                using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".rtf"))
                {

                    sw.WriteLine(richTextBox2.Text);
                    if (!(richTextBox1.Text == "Enter your comment here..." || richTextBox1.Text == ""))
                    {
                        sw.WriteLine("\r\nComments:\r\n");
                        sw.WriteLine(richTextBox1.Text);
                    }

                }

                
                if (currentPosition < Template.templates.Count - 1)
                {
                    this.Hide();
                    EditorForm f = EditorClass.NextForm("forward", currentPosition);
                    f.Show();
                }
                else if (currentPosition >= Template.templates.Count - 1)
                {
                    this.Hide();
                    previewForm pf = new previewForm();
                    pf.Show();
                }
            }
            else if (mode == "preview")
            {
                using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + previewAppName + ".rtf"))
                {

                    sw.WriteLine(richTextBox2.Text);

                }

                this.Hide();
                previewForm pf = new previewForm();
                pf.Show();
            }
            

            

            //saves the feedback doc to debug folder when next button is clicked

           // richTextBox2.SaveFile(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".txt");


            
        }
        private void EditorForm_Load(object sender, EventArgs e)
        {
            // string item;
            listBox.CheckOnClick = true;
            // Code.codeList.Clear();
            // Code.fillCodeList();
            Sections.listSection();
            Sections.FillSectionPerTemplate(Template.templates[currentPosition].Id);

            for (int i = 0; i < Sections.sectionPerTemplate.Count; i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
               //listBox.Items.Add($"{Code.codeList[i].CodeName}");
                listBox.Items.Add($"{Sections.sectionPerTemplate[i].name}");
            }

            if (mode == "preview")
            {
                richTextBox1.Hide();
                lbComBox.Hide();
                panel2.Width = 623;
                richTextBox2.Width = 623;
            }
        }

        private void listBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Checked)
            //{
            


            //}


            //richTextBox2.AppendText(paragraphToAdd + '\n');
            //appends var to rich text with a newline separator


            //use DB to get code paragraph related to this short code

            //make a feedback object , create section objects then when code box checked, add that code to the section
            //if unchecked, remove code from section - didn't use because complex


            //List<string> checkedItems = new List<string>();
            //foreach (var item in listBox.CheckedItems)
            //    checkedItems.Add(item.ToString());

            //if (e.NewValue == CheckState.Checked)
            //    checkedItems.Add(listBox.Items[e.Index].ToString());
            //else
            //    checkedItems.Remove(listBox.Items[e.Index].ToString());


        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Code.selectedCodes.Clear();
            richTextBox2.Text = "";
            foreach (string code in listBox.CheckedItems)
            {
                //get the code short of the selected list item
                string codeShortLookup = code;
                string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShortLookup}'";
                DataSet ds = Connection.GetDbConn().getDataSet(query);
                DataRow dRow = ds.Tables[0].Rows[0];
                //goes to the db, returns the first row (the codeparagraph) stores in variable
                string paragraphToAdd = dRow.ItemArray.GetValue(0).ToString();
                Code.selectedCodes.Add(paragraphToAdd);

            }

            foreach (string code in Code.selectedCodes)
            {
                richTextBox2.AppendText(code + "\n\n");

            }
        }
    }
}