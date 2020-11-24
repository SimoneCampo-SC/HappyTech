using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// to keep my code similar to other classes that use lists (template, applicant etc) i have made a sections class.
    /// </summary>
    class Sections
    {
        public static List<Sections>sectionList = new List<Sections>();
        public static List<Sections> sectionPerTemplate = new List<Sections>(); 
        public int id { get; }
        public string name { get; }
        private Sections(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static void listSection ()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.getSectionNameId());
            DataRow dRow;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                // Creates the instance
                Sections _instance = new Sections(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()), // section ID
                    dRow.ItemArray.GetValue(1).ToString() // section's name
                    );
               Sections.sectionList.Add(_instance); // Add the section into the list
            }
        }

        public static void FillSectionPerTemplate(int tempID)
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.SelectSectionPerTemplate(tempID));
            DataRow dRow;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];
                for (int j = 0; j < sectionList.Count; j++)
                {
                    if (dRow.ItemArray.GetValue(0).ToString().Equals(sectionList[j].id))
                    {
                        sectionPerTemplate.Add(sectionList[j]);
                    }
                }
            }
        }

    }
}
