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
    public partial class StartupMenu : Form
    {
        Form1 gameForm;
        public StartupMenu()
        {
            InitializeComponent();
            gameForm = new Form1();
            gameForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameForm_gameOver);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            gameForm.Show(this);
            this.Hide();
        }

        private void HoverSP(object sender, EventArgs e)
        {
            // Occurs when "Single Player" is hovered over
            label2.ForeColor = Color.DarkOliveGreen;
        }

        private void UnHoverSP(object sender, EventArgs e)
        {
            // Occurs when "Single Player" is no longer hovered over
            label2.ForeColor = Color.White;
        }
        private void gameForm_gameOver(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
