using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HappyTech
{
    public partial class codeViewForm : Form
    {
        private bool debugVis = false;

        public codeViewForm()
        {
            InitializeComponent();

            loadTemplateDropdown();
            //load_dropdown(); //load tags from the db into the drop-down menu needs to run when template dropdown
            //is given a value
            loadGrid();

        }

        /* private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             //when drop down menu has a value selected, fill the dataGridView with the contents of the Codes table where tag = selected value

            // string query = $"SELECT Id FROM Tag WHERE name = '{tagSelectBox.Text}'";
             DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTagIdFromName(tagSelectBox.Text));
             DataRow dRow = ds.Tables[0].Rows[0];
             var tagId = dRow.ItemArray.GetValue(0);

             // DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT codeShort, codeParagraph FROM Codes WHERE tag_ID = {tagId}");
             //have to convert to string as tagId is 'object' type
             DataSet ds2 = Connection.GetDbConn().getDataSet(Constants.getCodeFromTagId(tagId.ToString()));
             codeDisplay.DataSource = ds2.Tables[0]; //shows first table

         } */
        /// <summary>
        /// This function runs when the form is loaded, populates the template selection dropdown with
        /// all the template names in the template menu
        /// </summary>
        private void loadTemplateDropdown()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getTemplateName());
            //populates drop down menu with sections
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var tempToAdd = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                tempToAdd.Replace(" ", "");
                templateSelectBox.Items.Add(tempToAdd);
            }
        }
        private void loadSectionDropdown(string templateName) //passes in the value contained in the template select dropdown
        {

            //this takes the template name from the template box and finds sections that are related to that template
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.GetSectionPerTemplate(templateName));
            //populates drop down menu with sections
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var codeToAdd = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                codeToAdd.Replace(" ", "");
                tagSelectBox.Items.Add(codeToAdd.Replace(" ", ""));
                //When adding codes to the drop down box, lots of whitespace was being added, leaving the code 
                //unreadable on the dropdown. the replace() method replaces spaces with no space.
            }
        }
        private void loadGrid()
        {
            //uses the text in the tagSelectBox to query the DB for the ID related to the section name
            //try - catch is used because when the form is first loaded, no section will be selected
            //and the form will crash if it tries to load the grid view with "" as a section name.
            //try catch is prefereable to hardcoding a default value to load and form would 
            //crash when defaulting to the 1st section when the program is first run and there are no sections

            try
            {
                tagSelectBox.Text.Replace(" ", "");
                DataSet ds1 = Connection.GetDbConn().getDataSet(Constants.getSectionIdFromName(tagSelectBox.Text));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);
                DataSet ds = Connection.GetDbConn().getDataSet(Constants.getCodeFromSectionId(sectionId));
                codeDisplay.DataSource = ds.Tables[0];
            }
            catch
            {
                //DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT name FROM Section");
                //codeDisplay.DataSource = ds2.Tables[0];
            }
            //if no section name selected, show all the sections (remove code in catch if you want nothing to be displayed)

            if (codeDisplay.Columns.Count > 0)
            {
                codeDisplay.Columns[0].Width = 90;
                codeDisplay.Columns[1].Width = 457;
                codeDisplay.Columns[0].HeaderText = "Code";
                codeDisplay.Columns[1].HeaderText = "Paragraph";
            }
        }


        /* void fillCombo()
         {
             //DataSet ds = Connection.GetDbConn().getDataSet("SELECT * FROM Tag");
             //codeDisplay.DataSource = ds.Tables[0];
         } */

        /* private void codeDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         } */

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm df = new DashForm("newApp");
            df.Show();
        }

        private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void templateSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tagSelectBox.Items.Clear();
            loadSectionDropdown(templateSelectBox.Text);
        }

        private void templateViewBtn_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            addTemplate addTemp = new addTemplate();
            addTemp.Show(); */
            this.Hide();
            NewEditDelete ned = new NewEditDelete();
            ned.Show();

        }

        private void deleteDbBtn_Click(object sender, EventArgs e)
        {
            string delCodes = "DELETE FROM Codes";
            Connection.GetDbConn().CreateCommand(delCodes);

            string delSect = "DELETE FROM Section";
            Connection.GetDbConn().CreateCommand(delSect);

            string delTemp = "DELETE FROM Template";
            Connection.GetDbConn().CreateCommand(delTemp);

            string delPS = "DELETE FROM PersonalSection";
            Connection.GetDbConn().CreateCommand(delPS);

            

        }

        private void btnAutofill_Click(object sender, EventArgs e)
        {
            // autofill database with some test values
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (debugVis == false)
            {
                debugVis = true;
                deleteDbBtn.Show();
                btnAutofill.Show();

            }
            else if (debugVis == true)
            {
                debugVis = false;
                deleteDbBtn.Hide();
                btnAutofill.Hide();
            }
        }

        private void templateSelectBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(templateSelectBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        private void tagSelectBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(tagSelectBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// functionally the same as the code to popluate the templates dropdown at the top of this form
        /// value from this dropdown will be used to determine the template to attach the created section to
        /// </summary>




        /// <summary>
        /// when the submit template button is pressed, run the function inside Templates.cs that takes a string and creates a
        /// new template with that string as its tempType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


    }
    
}
