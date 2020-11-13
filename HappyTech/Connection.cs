using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HappyTech
{
    class Connection
    {
        //private object of the class
        private static Connection _instance;

        private string connStr;
        private SqlConnection connToDb;

        private Connection()
        {
            //assigned in properties, points to db location
            connStr = Properties.Settings.Default.database; 
        }

        //use this method whenever a connection to the db is required
        public static Connection GetDbConn()
        {
            if (_instance == null)
                _instance = new Connection();
            return _instance;

        }
            public DataSet getDataSet(string sqlQuery)
            {
            DataSet dataSet = new DataSet(); //create empty dataset
            using (connToDb = new SqlConnection(connStr))
            {
                // open connection
                connToDb.Open();
                //create the object dataadapter to send query to db
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDb);
                adapter.Fill(dataSet);
                
            }

            return dataSet;
            }
        public void CreateCommand(string queryString)
        { 
            using (connToDb = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(queryString, connToDb);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }   
    }
}
