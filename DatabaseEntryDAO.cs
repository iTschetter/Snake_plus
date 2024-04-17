using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_
{
    public class DatabaseEntryDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=leaderboard;";

        public int getLastPlace()
        {
            int lastPlaceScore = 0;
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            MySqlCommand retrieveEntry = new MySqlCommand("SELECT * FROM `highscoree` WHERE Rank=5", dbConnection);

            using (MySqlDataReader dbReader = retrieveEntry.ExecuteReader())
            {
                while (dbReader.Read())
                {
                    DatabaseEntry entry = new DatabaseEntry
                    {
                        Name = dbReader.GetString(0),
                        Score = dbReader.GetInt32(1),
                        Rank = dbReader.GetInt32(2)
                    };
                    lastPlaceScore = entry.Score;
                }
            }
            dbConnection.Close();
            return lastPlaceScore;
        }
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
        public void updateDBEntries(int newScore, string newName)
        {
            List<DatabaseEntry> dbEntries = getDBEntries();

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            MySqlCommand deleteEntries = new MySqlCommand("DELETE * FROM HIGHSCOREE", dbConnection);

            deleteEntries.ExecuteNonQuery();
            dbConnection.Close();

            dbEntries = modifyEntries(dbEntries, newName, newScore);

            refreshDBEntries(dbEntries);
        }
        public void refreshDBEntries(List<DatabaseEntry> dbEntries)
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            MySqlCommand insertEntry = new MySqlCommand("INSERT INTO `highscoree`(`Name`, `Score`, `Rank`) VALUES (@name,@score,@rank)", dbConnection);

            foreach(DatabaseEntry entry in dbEntries)
            {
                insertEntry.Parameters.AddWithValue("@name", entry.Name);
                insertEntry.Parameters.AddWithValue("@score", entry.Score);
                insertEntry.Parameters.AddWithValue("@rank", entry.Rank);
                insertEntry.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
        public List<DatabaseEntry> modifyEntries(List<DatabaseEntry> databaseEntries, string name, int score)
        {
            databaseEntries.Add(new DatabaseEntry(name, score, 6));
            databaseEntries = databaseEntries.OrderByDescending(r => r.Score).ToList();
            int i = 1;
            foreach(DatabaseEntry entry in databaseEntries)
            {
                entry.Rank = i;
                i++;
            }
            databaseEntries.RemoveAt(databaseEntries.Count - 1);

            return databaseEntries;
        }
    }
}
