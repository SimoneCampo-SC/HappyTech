/**
 * 
 * File: Connections.cs
 * 
 * Author 1: Hopper, Kean. 1911956
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This file creates the connections to the database
 *              used throughout the program.
 *              
 */

using System.Data;
using System.Data.SqlClient;

namespace HappyTech
{
    class Connection
    {
        // Private object of the class
        private static Connection _instance;

        private string connStr;
        private SqlConnection connToDb;

        /// <summary>
        /// default constructor
        /// </summary>
        private Connection()
        {
            // Assigned in properties, points to db location
            connStr = Properties.Settings.Default.database; 
        }

        /// <summary>
        /// creates a connection with the DB, needs to be used before other methods
        /// </summary>
        /// <returns>returns a connection to the DB</returns>        
        public static Connection GetDbConn()
        {
            if (_instance == null)
                _instance = new Connection();
            return _instance;

        }

        /// <summary>
        /// 
        ///    This method opens a connection to the database, takes a sqlquery and returns the results of this query
        /// 
        /// </summary>
        /// <param name="sqlQuery">SQL code to be used. code will be from SqlQueries.cs </param>
        /// <returns>Returns the result of the sql query</returns>
        public DataSet GetDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet(); // Create empty dataset
            using (connToDb = new SqlConnection(connStr))
            {
                // Open connection
                connToDb.Open();
                // Create the object dataadapter to send query to db
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDb);
                adapter.Fill(dataSet);
                
            }
            return dataSet;
        }

        /// <summary>
        /// 
        ///   executes code on the DB and doesn't return anything
        /// 
        /// </summary>
        /// <param name="queryString"> sql query to be executed on the DB. </param>
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
