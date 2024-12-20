﻿namespace Snake_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.gameoverPause = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hs = new System.Windows.Forms.Label();
            this.hsName = new System.Windows.Forms.Label();
            this.hsNameVal = new System.Windows.Forms.TextBox();
            this.submitB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(222, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2750, 1500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.paintObject);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.GameTick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameover.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameover.ForeColor = System.Drawing.Color.White;
            this.gameover.Location = new System.Drawing.Point(1125, 500);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(944, 144);
            this.gameover.TabIndex = 1;
            this.gameover.Text = "Game Over";
            this.gameover.Visible = false;
            // 
            // gameoverPause
            // 
            this.gameoverPause.Interval = 1000;
            this.gameoverPause.Tick += new System.EventHandler(this.gameoverPauseTick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // hs
            // 
            this.hs.AutoSize = true;
            this.hs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hs.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hs.ForeColor = System.Drawing.Color.Gold;
            this.hs.Location = new System.Drawing.Point(912, 680);
            this.hs.Name = "hs";
            this.hs.Size = new System.Drawing.Size(1371, 144);
            this.hs.TabIndex = 4;
            this.hs.Text = "New High Score!";
            this.hs.Visible = false;
            // 
            // hsName
            // 
            this.hsName.AutoSize = true;
            this.hsName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsName.Font = new System.Drawing.Font("ROG Fonts", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsName.ForeColor = System.Drawing.Color.White;
            this.hsName.Location = new System.Drawing.Point(912, 900);
            this.hsName.Name = "hsName";
            this.hsName.Size = new System.Drawing.Size(294, 80);
            this.hsName.TabIndex = 5;
            this.hsName.Text = "Name:";
            this.hsName.Visible = false;
            // 
            // hsNameVal
            // 
            this.hsNameVal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hsNameVal.Font = new System.Drawing.Font("ROG Fonts", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsNameVal.ForeColor = System.Drawing.Color.White;
            this.hsNameVal.Location = new System.Drawing.Point(1207, 900);
            this.hsNameVal.Name = "hsNameVal";
            this.hsNameVal.Size = new System.Drawing.Size(1076, 88);
            this.hsNameVal.TabIndex = 6;
            this.hsNameVal.Visible = false;
            // 
            // submitB
            // 
            this.submitB.AutoSize = true;
            this.submitB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submitB.Font = new System.Drawing.Font("ROG Fonts", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitB.ForeColor = System.Drawing.Color.White;
            this.submitB.Location = new System.Drawing.Point(1425, 1062);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(354, 80);
            this.submitB.TabIndex = 7;
            this.submitB.Text = "Submit";
            this.submitB.Visible = false;
            this.submitB.Click += new System.EventHandler(this.submitDBEntry);
            this.submitB.MouseLeave += new System.EventHandler(this.UnHoverSubmit);
            this.submitB.MouseHover += new System.EventHandler(this.HoverSubmit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2974, 1490);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.hsNameVal);
            this.Controls.Add(this.hsName);
            this.Controls.Add(this.hs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(3006, 1578);
            this.MinimumSize = new System.Drawing.Size(3006, 1578);
            this.Name = "Form1";
            this.Text = "Snake+";
            this.VisibleChanged += new System.EventHandler(this.initGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveActionDetected);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public Label gameover;
        public System.Windows.Forms.Timer gameoverPause;
        public Label label1;
        public Label label2;
        public Label hs;
        public Label hsName;
        private TextBox hsNameVal;
        public Label submitB;
    }
}