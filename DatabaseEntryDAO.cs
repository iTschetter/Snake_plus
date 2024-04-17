using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_
{
    internal class DatabaseEntryDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=highscoree;";

        public List<DatabaseEntry> getDBEntries()
        {
            // Used for storing dbEntries
            LinkedList<DatabaseEntry> dbEntries = new LinkedList<DatabaseEntry>();

            // Init the db connection and retrieval process
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            MySqlCommand retrieveEntries = new MySqlCommand("SELECT * FROM HIGHSCOREE", dbConnection);

            using (MySqlDataReader dbReader = retrieveEntries.ExecuteReader())
            {
                while (dbReader.Read())
                {
                    DatabaseEntry entry = new DatabaseEntry
                    {
                        Name = dbReader.GetString(0),
                        Score = dbReader.GetInt32(1),
                        Rank = dbReader.GetInt32(2)
                    };
                    dbEntries.AddLast(entry);
                }
            }
            dbConnection.Close();
            List<DatabaseEntry> sortedEntries = dbEntries.OrderBy(r => r.Rank).ToList();

            return sortedEntries;
        }
    }
}
