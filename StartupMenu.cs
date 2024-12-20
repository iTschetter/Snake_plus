﻿using System;
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
        Leaderboard lboardForm;
        public StartupMenu()
        {
            InitializeComponent();
            spgameForm = new Form1();
            spgameForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.spgameForm_gameOver);
            spgameForm.VisibleChanged += new EventHandler(this.spgameForm_visibleChanged);
            mpgameForm = new multiPlayer();
            mpgameForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mpgameForm_gameOver);
            mpgameForm.VisibleChanged += new EventHandler(this.mpgameForm_visibleChanged);
            lboardForm = new Leaderboard();
            lboardForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.lboardForm_gameOver);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void spgameForm_visibleChanged(object sender, EventArgs e)
        {
            if(spgameForm.Visible == false)
            {
               spgameForm.resetGame();
            }
        }
        public void mpgameForm_visibleChanged(Object sender, EventArgs e)
        {
            if (spgameForm.Visible == false)
            {
                mpgameForm.resetGame();
            }
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
            spgameForm = new Form1();
            //lboardForm.refreshLeaderboard();
        }
        private void mpgameForm_gameOver(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            mpgameForm = new multiPlayer();
        }
        private void lboardForm_gameOver(object sender, FormClosingEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            lboardForm.Show(this);
            this.Hide();
        }

        private void lbHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkOliveGreen;
        }

        private void lbUnHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }
    }
}
