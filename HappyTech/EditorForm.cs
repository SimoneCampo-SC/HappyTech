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

namespace HappyTech
{
    public partial class EditorForm : Form
    {
        int currentPosition;
        public EditorForm(int position)
        {
            currentPosition = position;
            InitializeComponent();
            lbApplicants.Text = $"Applicant {position + 1} out of  {Applicant.applicants.Count}"; 
                
            lbHeader.Text = Template.templates[position].GetHeader();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition > 0)
            {
                // save template - should be in Editor Class
                f = EditorClass.NextForm(0, currentPosition);
                this.Hide();
                f.Show();
            }
        }

        private void btNext2_Click(object sender, EventArgs e)
        {
            
            richTextBox2.SaveFile(Recruiter.GetInstance().GetName() + Applicant.applicants[currentPosition].GetName() + ".rtf");

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
                listBox.Items.Add($"{Code.codeList[i].GetCodeName()}");
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
            //appends var to rich text


            //use DB to get code paragraph related to this short code

            //make a feedback object , create section objects then when code box checked, add that code to the section
            //if unchecked, remove code from section



            //add code paragraph to feedback form, maybe with
            //append db.rows value of paragraph, maube end with newline



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