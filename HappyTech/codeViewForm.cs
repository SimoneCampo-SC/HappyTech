/**
 * 
 * File: CodeViewForm.cs
 * 
 * Author 2: Hopper, Kean. 1911956
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
using static HappyTech.DashForm;

namespace HappyTech
{
    public partial class CodeViewForm : Form
    {
        private bool debugVis = false; //

        /// <summary>
        /// 
        /// </summary>
        public CodeViewForm()
        {
            InitializeComponent();
            LoadTemplateDropdown();

            // Load tags from the db into the drop-down menu needs to run when template dropdown is given a value
            Load_DataGrid_CodeList();

            DataSet dsT = Connection.GetDbConn().GetDataSet(SqlQueries.SelectAllTemplates());
            Label_TemplatesTotal.Text = dsT.Tables[0].Rows.Count.ToString();

            DataSet dsS = Connection.GetDbConn().GetDataSet(SqlQueries.SelectAllSections());
            Label_SectionsTotal.Text = dsS.Tables[0].Rows.Count.ToString();

            DataSet dsC = Connection.GetDbConn().GetDataSet(SqlQueries.SelectCodes());
            Label_CodesTotal.Text = dsC.Tables[0].Rows.Count.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadTemplateDropdown()
        {
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetTemplateName());
            //populates drop down menu with sections
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var tempToAdd = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                tempToAdd.Replace(" ", "");
                ComboBox_SelectTemplate.Items.Add(tempToAdd);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="templateName">        </param>
        private void LoadSectionDropdown(string templateName) //passes in the value contained in the template select dropdown
        {
            //this takes the template name from the template box and finds sections that are related to that template
            DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionPerTemplate(templateName));
            //populates drop down menu with sections
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var codeToAdd = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                codeToAdd.Replace(" ", "");
                ComboBox_SelectSection.Items.Add(codeToAdd.Replace(" ", ""));
                //When adding codes to the drop down box, lots of whitespace was being added, leaving the code 
                //unreadable on the dropdown. the replace() method replaces spaces with no space.
            }
        }
        private void Load_DataGrid_CodeList()
        {
            //uses the text in the tagSelectBox to query the DB for the ID related to the section name
            //try - catch is used because when the form is first loaded, no section will be selected
            //and the form will crash if it tries to load the grid view with "" as a section name.
            //try catch is prefereable to hardcoding a default value to load and form would 
            //crash when defaulting to the 1st section when the program is first run and there are no sections

            try
            {
                ComboBox_SelectSection.Text.Replace(" ", "");
                DataSet ds1 = Connection.GetDbConn().GetDataSet(SqlQueries.GetSectionIdFromName(ComboBox_SelectSection.Text));
                DataRow dRow1 = ds1.Tables[0].Rows[0];
                var sectionId = dRow1.ItemArray.GetValue(0);
                DataSet ds = Connection.GetDbConn().GetDataSet(SqlQueries.GetCodeFromSectionId(sectionId));
                DataGrid_CodeList.DataSource = ds.Tables[0];
            }
            catch
            {
                //DataSet ds2 = Connection.GetDbConn().getDataSet($"SELECT name FROM Section");
                //codeDisplay.DataSource = ds2.Tables[0];
            }
            //if no section name selected, show all the sections (remove code in catch if you want nothing to be displayed)

            if (DataGrid_CodeList.Columns.Count > 0)
            {
                DataGrid_CodeList.Columns[0].Width = 90;
                DataGrid_CodeList.Columns[1].Width = 457;
                DataGrid_CodeList.Columns[0].HeaderText = "Code";
                DataGrid_CodeList.Columns[1].HeaderText = "Paragraph";
            }
        }

        /// <summary>
        /// 
        ///     Click trigger function for the back button.
        ///     This will return the user back the the dashboard.
        /// 
        /// </summary>
        private void Button_Back_Click( object sender, EventArgs e )
        {
            Hide();
            DashForm instance_DashForm = new DashForm( Mode.Applicant );
            instance_DashForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ComboBox_SelectSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DataGrid_CodeList();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ComboBox_SelectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectSection.Items.Clear();
            LoadSectionDropdown(ComboBox_SelectTemplate.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Button_EditTemplate_Click(object sender, EventArgs e)
        {
            Hide();
            EditorForm instance_EditorForm = new EditorForm();
            instance_EditorForm.Show();

        }

        /// <summary>
        /// 
        /// </summary>
        private void Button_Reset_Click(object sender, EventArgs e)
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
        private void Button_Debug_Click(object sender, EventArgs e)
        {
            if (debugVis == false)
            {
                debugVis = true;
                Button_Reset.Show();
                Button_Autofill.Show();

            }
            else if (debugVis == true)
            {
                debugVis = false;
                Button_Reset.Hide();
                Button_Autofill.Hide();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ComboBox_SelectTemplate_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_SelectTemplate.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ComboBox_SelectSection_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.Graphics.DrawImage(Properties.Resources.happytech_circle, e.Bounds.X + 6, e.Bounds.Y + 6, 8, 8);
                e.Graphics.DrawString(ComboBox_SelectSection.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 20, e.Bounds.Y + 3);
                e.DrawFocusRectangle();
            }
            catch (Exception)
            {

            }
        }
    }
}
