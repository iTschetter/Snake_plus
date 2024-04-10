namespace Snake_
{
    partial class multiPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.gameTimerA = new System.Windows.Forms.Timer(this.components);
            this.gameTimerB = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameOverA = new System.Windows.Forms.Label();
            this.gameOverB = new System.Windows.Forms.Label();
            this.gameOverPause = new System.Windows.Forms.Timer(this.components);
            this.winnerA = new System.Windows.Forms.Label();
            this.winnerB = new System.Windows.Forms.Label();
            this.tieA = new System.Windows.Forms.Label();
            this.tieB = new System.Windows.Forms.Label();
            this.playerATime = new System.Windows.Forms.Timer(this.components);
            this.playerBTime = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clockA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clockB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(1375, 1900);
            this.pictureBoxA.TabIndex = 1;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.Paint += new System.Windows.Forms.PaintEventHandler(this.paintFrameA);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 9.45001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1:";
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxB.Location = new System.Drawing.Point(1598, 0);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(1375, 1900);
            this.pictureBoxB.TabIndex = 4;
            this.pictureBoxB.TabStop = false;
            this.pictureBoxB.Paint += new System.Windows.Forms.PaintEventHandler(this.paintFrameB);
            // 
            // gameTimerA
            // 
            this.gameTimerA.Interval = 500;
            this.gameTimerA.Tick += new System.EventHandler(this.gameTickA);
            // 
            // gameTimerB
            // 
            this.gameTimerB.Interval = 500;
            this.gameTimerB.Tick += new System.EventHandler(this.gameTickB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1381, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1381, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1381, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // gameOverA
            // 
            this.gameOverA.AutoSize = true;
            this.gameOverA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameOverA.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverA.ForeColor = System.Drawing.Color.White;
            this.gameOverA.Location = new System.Drawing.Point(215, 880);
            this.gameOverA.Name = "gameOverA";
            this.gameOverA.Size = new System.Drawing.Size(944, 144);
            this.gameOverA.TabIndex = 8;
            this.gameOverA.Text = "Game Over";
            this.gameOverA.Visible = false;
            // 
            // gameOverB
            // 
            this.gameOverB.AutoSize = true;
            this.gameOverB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameOverB.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverB.ForeColor = System.Drawing.Color.White;
            this.gameOverB.Location = new System.Drawing.Point(1813, 880);
            this.gameOverB.Name = "gameOverB";
            this.gameOverB.Size = new System.Drawing.Size(944, 144);
            this.gameOverB.TabIndex = 9;
            this.gameOverB.Text = "Game Over";
            this.gameOverB.Visible = false;
            // 
            // gameOverPause
            // 
            this.gameOverPause.Interval = 3000;
            this.gameOverPause.Tick += new System.EventHandler(this.gameOverPauseTick);
            // 
            // winnerA
            // 
            this.winnerA.AutoSize = true;
            this.winnerA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.winnerA.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerA.ForeColor = System.Drawing.Color.White;
            this.winnerA.Location = new System.Drawing.Point(300, 1069);
            this.winnerA.Name = "winnerA";
            this.winnerA.Size = new System.Drawing.Size(773, 144);
            this.winnerA.TabIndex = 10;
            this.winnerA.Text = "You Won!";
            this.winnerA.Visible = false;
            // 
            // winnerB
            // 
            this.winnerB.AutoSize = true;
            this.winnerB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.winnerB.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerB.ForeColor = System.Drawing.Color.White;
            this.winnerB.Location = new System.Drawing.Point(1898, 1069);
            this.winnerB.Name = "winnerB";
            this.winnerB.Size = new System.Drawing.Size(773, 144);
            this.winnerB.TabIndex = 11;
            this.winnerB.Text = "You Won!";
            this.winnerB.Visible = false;
            // 
            // tieA
            // 
            this.tieA.AutoSize = true;
            this.tieA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tieA.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tieA.ForeColor = System.Drawing.Color.White;
            this.tieA.Location = new System.Drawing.Point(285, 1258);
            this.tieA.Name = "tieA";
            this.tieA.Size = new System.Drawing.Size(804, 144);
            this.tieA.TabIndex = 12;
            this.tieA.Text = "You Tied!";
            this.tieA.Visible = false;
            // 
            // tieB
            // 
            this.tieB.AutoSize = true;
            this.tieB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tieB.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tieB.ForeColor = System.Drawing.Color.White;
            this.tieB.Location = new System.Drawing.Point(1883, 1258);
            this.tieB.Name = "tieB";
            this.tieB.Size = new System.Drawing.Size(804, 144);
            this.tieB.TabIndex = 13;
            this.tieB.Text = "You Tied!";
            this.tieB.Visible = false;
            // 
            // playerATime
            // 
            this.playerATime.Interval = 1000;
            this.playerATime.Tick += new System.EventHandler(this.playerATimerTick);
            // 
            // playerBTime
            // 
            this.playerBTime.Interval = 1000;
            this.playerBTime.Tick += new System.EventHandler(this.playerBTimerTick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1381, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 48);
            this.label5.TabIndex = 14;
            this.label5.Text = "Eaten:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 9.45001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1381, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "______";
            // 
            // clockA
            // 
            this.clockA.AutoSize = true;
            this.clockA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clockA.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clockA.ForeColor = System.Drawing.Color.White;
            this.clockA.Location = new System.Drawing.Point(1381, 57);
            this.clockA.Name = "clockA";
            this.clockA.Size = new System.Drawing.Size(139, 48);
            this.clockA.TabIndex = 16;
            this.clockA.Text = "0:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("ROG Fonts", 9.15001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1377, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Player 2:";
            // 
            // clockB
            // 
            this.clockB.AutoSize = true;
            this.clockB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clockB.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clockB.ForeColor = System.Drawing.Color.White;
            this.clockB.Location = new System.Drawing.Point(1381, 392);
            this.clockB.Name = "clockB";
            this.clockB.Size = new System.Drawing.Size(139, 48);
            this.clockB.TabIndex = 18;
            this.clockB.Text = "0:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1381, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 48);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bits";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1381, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Eaten:";
            // 
            // multiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2974, 1902);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clockB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clockA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tieB);
            this.Controls.Add(this.tieA);
            this.Controls.Add(this.winnerB);
            this.Controls.Add(this.winnerA);
            this.Controls.Add(this.gameOverB);
            this.Controls.Add(this.gameOverA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxA);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(3006, 1990);
            this.MinimumSize = new System.Drawing.Size(3006, 1990);
            this.Name = "multiPlayer";
            this.Text = "multiPlayer";
            this.VisibleChanged += new System.EventHandler(this.initGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveActionDetected);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxA;
        public Label label1;
        private PictureBox pictureBoxB;
        private System.Windows.Forms.Timer gameTimerA;
        private System.Windows.Forms.Timer gameTimerB;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label gameOverA;
        public Label gameOverB;
        private System.Windows.Forms.Timer gameOverPause;
        public Label winnerA;
        public Label winnerB;
        public Label tieA;
        public Label tieB;
        private System.Windows.Forms.Timer playerATime;
        private System.Windows.Forms.Timer playerBTime;
        public Label label5;
        public Label label6;
        public Label clockA;
        public Label label8;
        public Label clockB;
        public Label label10;
        public Label label11;
    }
}