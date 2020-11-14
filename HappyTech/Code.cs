using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HappyTech
{
    class Code
    {
        public static List<Code> codeList = new List<Code>();

        private int id;
        private string codeName;
        private int sectionID;
        private Code (int id, string codeName, int secID )
        {
            this.id = id;
            this.codeName = codeName;
            this.sectionID = secID;
        }

        public static void fillCodeList()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.selectCodes());
            DataRow dRow;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dRow = ds.Tables[0].Rows[i];

                Code _instance = new Code(
                    Int32.Parse(dRow.ItemArray.GetValue(0).ToString()),
                    dRow.ItemArray.GetValue(1).ToString(),
                    Int32.Parse(dRow.ItemArray.GetValue(2).ToString())
                    );
                Code.codeList.Add(_instance);
            }
        }
        public string GetCodeName()
        {
            return codeName;
        }
        public int GetCodeTag()
        {
            return sectionID;
        }
        public string GetSectionName()
        {
            DataSet ds = Connection.GetDbConn().getDataSet(Constants.selectSectionName(sectionID));
            DataRow dRow = ds.Tables[0].Rows[0];
            string name = dRow.ItemArray.GetValue(0).ToString();
            return name;
        }
    }
}
