using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_
{
    public class DatabaseEntry
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }
        public DatabaseEntry(string name, int score, int rank)
        {
            Name = name;
            Score = score;
            Rank = rank;
        }
    }
}
