using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_
{
    public partial class Leaderboard : Form
    {
        DatabaseEntryDAO dbAccessObject = new DatabaseEntryDAO();
        List<DatabaseEntry> dbEntries = new List<DatabaseEntry>();
        public Leaderboard()
        {
            InitializeComponent(); // init
            dbEntries = dbAccessObject.getDBEntries(); // init db retrieval 

            // Here, we paint the leaderboard with up-to-date information
            displayDBEntries();
        }
        public void displayDBEntries()
        {
            foreach(DatabaseEntry dbEntry in dbEntries)
            {
                int tmpX = 0;
                int tmpY = 0;
                switch(dbEntry.Rank)
                {
                    case 1:
                        n1.Text = dbEntry.Name;
                        // Re-centering the name:
                        tmpY = (int)n1.Location.Y;
                        tmpX = 2152 - n1.Width;
                        tmpX = (int)Math.Floor((float)(tmpX + 613) / 2);
                        n1.Location = new Point(tmpX, tmpY);

                        s1.Text = dbEntry.Score.ToString();
                        break;
                    case 2:
                        n2.Text = dbEntry.Name;
                        // Re-centering the name:
                        tmpY = (int)n2.Location.Y;
                        tmpX = 2152 - n2.Width;
                        tmpX = (int)Math.Floor((float)(tmpX + 613) / 2);
                        n2.Location = new Point(tmpX, tmpY);

                        s2.Text = dbEntry.Score.ToString();
                        break;
                    case 3:
                        n3.Text = dbEntry.Name;
                        // Re-centering the name:
                        tmpY = (int)n3.Location.Y;
                        tmpX = 2152 - n3.Width;
                        tmpX = (int)Math.Floor((float)(tmpX + 613) / 2);
                        n3.Location = new Point(tmpX, tmpY);

                        s3.Text = dbEntry.Score.ToString();
                        break;
                    case 4:
                        n4.Text = dbEntry.Name;
                        // Re-centering the name:
                        tmpY = (int)n4.Location.Y;
                        tmpX = 2152 - n4.Width;
                        tmpX = (int)Math.Floor((float)(tmpX + 613) / 2);
                        n4.Location = new Point(tmpX, tmpY);

                        s4.Text = dbEntry.Score.ToString();
                        break;
                    case 5:
                        n5.Text = dbEntry.Name;
                        // Re-centering the name:
                        tmpY = (int)n5.Location.Y;
                        tmpX = 2152 - n5.Width;
                        tmpX = (int)Math.Floor((float)(tmpX + 613) / 2);
                        n5.Location = new Point(tmpX, tmpY);

                        s5.Text = dbEntry.Score.ToString();
                        break;
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HoverExit(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkRed;
        }

        private void UnHoverExit(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkRed;
            Owner.Show();
            Hide();
        }
    }
}
