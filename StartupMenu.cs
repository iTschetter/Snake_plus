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
        Form1 spgameForm;
        multiPlayer mpgameForm;
        public StartupMenu()
        {
            InitializeComponent();
            spgameForm = new Form1();
            spgameForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.spgameForm_gameOver);
            mpgameForm = new multiPlayer();
            mpgameForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mpgameForm_gameOver);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            spgameForm.Show(this);
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
        private void spgameForm_gameOver(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void mpgameForm_gameOver(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HoverMP(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkOliveGreen;
        }

        private void UnhoverMP(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void HoverEG(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkRed;
        }

        private void UnHoverEG(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void KillGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mpgameForm.Show(this);
            this.Hide();
        }
    }
}
