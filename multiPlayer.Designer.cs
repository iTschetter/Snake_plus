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
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
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
            this.gameTimerA.Tick += new System.EventHandler(this.gameTickA);
            // 
            // gameTimerB
            // 
            this.gameTimerB.Tick += new System.EventHandler(this.gameTickB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1381, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1458, 84);
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
            this.label4.Location = new System.Drawing.Point(1458, 242);
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
            this.gameOverA.Location = new System.Drawing.Point(206, 880);
            this.gameOverA.Name = "gameOverA";
            this.gameOverA.Size = new System.Drawing.Size(986, 144);
            this.gameOverA.TabIndex = 8;
            this.gameOverA.Text = "Game Over!";
            this.gameOverA.Visible = false;
            // 
            // gameOverB
            // 
            this.gameOverB.AutoSize = true;
            this.gameOverB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameOverB.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverB.ForeColor = System.Drawing.Color.White;
            this.gameOverB.Location = new System.Drawing.Point(1793, 875);
            this.gameOverB.Name = "gameOverB";
            this.gameOverB.Size = new System.Drawing.Size(986, 144);
            this.gameOverB.TabIndex = 9;
            this.gameOverB.Text = "Game Over!";
            this.gameOverB.Visible = false;
            // 
            // gameOverPause
            // 
            this.gameOverPause.Interval = 1000;
            this.gameOverPause.Tick += new System.EventHandler(this.gameOverPauseTick);
            // 
            // multiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2974, 1902);
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
    }
}