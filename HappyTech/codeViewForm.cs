/**
 * 
 * File: codeViewForm.cs
 * 
 * Author 2: Hopper, Kean. SID
 * Author 3: Osborne, Oliver. 1602819
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file allows the user to view templates, sections,
 *              and codes in a table. They can access the template editor
 *              from here.
 *              
 */

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class codeViewForm : Form
    {
        private bool debugVis = false; //

        /// <summary>
        /// 
        /// </summary>
        public codeViewForm()
        {
            InitializeComponent();
            loadTemplateDropdown();

            // Load tags from the db into the drop-down menu needs to run when template dropdown is given a value
            loadGrid();

            DataSet dsT = Connection.GetDbConn().getDataSet(SqlConstants.SelectAllTemplates());
            lblTempTotalVal.Text = dsT.Tables[0].Rows.Count.ToString();

            DataSet dsS = Connection.GetDbConn().getDataSet(SqlConstants.SelectAllSections());
            lblSectTotalVal.Text = dsS.Tables[0].Rows.Count.ToString();

            DataSet dsC = Connection.GetDbConn().getDataSet(SqlConstants.selectCodes());
            lblCodeTotalVal.Text = dsC.Tables[0].Rows.Count.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private void loadTemplateDropdown()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(SqlConstants.getTemplateName());
            //populates drop down menu with sections
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var tempToAdd = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                tempToAdd.Replace(" ", "");
                templateSelectBox.Items.Add(tempToAdd);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="templateName">        </param>
        private void loadSectionDropdown(string templateName) //passes in the value contained in the template select dropdown
        {
            //this takes the template name from the template box and finds sections that are related to that template
            DataSet ds = Connection.GetDbConn().getDataSet(SqlConstants.GetSectionPerTemplate(templateName));
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
                DataSet ds1 = Connection.GetDbConn().getDataSet(SqlConstants.getSectionIdFromName(tagSelectBox.Text));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);
                DataSet ds = Connection.GetDbConn().getDataSet(SqlConstants.getCodeFromSectionId(sectionId));
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

        /// <summary>
        /// 
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashForm df = new DashForm("newApp");
            df.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void tagSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        /// <summary>
        /// 
        /// </summary>
        private void templateSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tagSelectBox.Items.Clear();
            loadSectionDropdown(templateSelectBox.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void templateViewBtn_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            addTemplate addTemp = new addTemplate();
            addTemp.Show(); */
            this.Hide();
            NewEditDelete ned = new NewEditDelete();
            ned.Show();

        }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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
    }
}
