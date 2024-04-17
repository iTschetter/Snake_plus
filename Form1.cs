using System.Security.Cryptography.X509Certificates;

namespace Snake_
{
    public partial class Form1 : Form
    {
        // 2750x1500
        LinkedList<Bit> SnakeBits = new LinkedList<Bit>();
        Bit FoodBit = new Bit();
        String newDirection = "Left";
        private static int length = 50;
        public int currentScore = 0;
        DatabaseEntryDAO DAO = new DatabaseEntryDAO();
        public Form1()
        {
            InitializeComponent();
        }
        public void initSnake()
        {
            SnakeBits.Clear();
            SnakeBits.AddFirst(new Bit(400, 400,"Left"));
            SnakeBits.AddLast(new Bit(450, 400,"Left"));
            SnakeBits.AddLast(new Bit(500, 400, "Left"));
        }
        public void generateFood()
        {
            //2750x1500
            Random rVar = new Random();
            FoodBit.X = 50*rVar.Next(0, 55);
            FoodBit.Y = 50*rVar.Next(0, 30);
        }

        public void GameTick(object sender, EventArgs e) // Everything starts here. 
        {
            MoveSnake(newDirection);
            CollisionCheck(SnakeBits.First.Value);
            pictureBox1.Refresh(); // This causes the picture box to update every tick of the game timer
        }
        public void CollisionCheck(Bit SnakeHead)
        {

            // Checking for food and snake collision
            if(SnakeHead.X == FoodBit.X && SnakeHead.Y == FoodBit.Y)
            {
                // Play sound here
                growSnake(SnakeBits);
                increaseScore();
                generateFood();
            }

            // Checking for snake and border collision
            if(SnakeHead.X < 0 || SnakeHead.Y < 0)
            {
                gameOver();
            }
            else if (SnakeHead.X > 2700 || SnakeHead.Y > 1450)
            {
                gameOver();
            }

            // Checking for snake on snake collision
            foreach(Bit bit in SnakeBits.Skip(1))
            {
                if (bit.X == SnakeHead.X && bit.Y == SnakeHead.Y)
                {
                    gameOver();
                }
            }
        }
        public void increaseScore()
        {
            currentScore++;
            label2.Text = currentScore.ToString();
        }
        public void gameOver()
        {
            timer1.Stop();
            label2.ForeColor = Color.Red;
            gameover.Visible = true;
            if(currentScore > DAO.getLastPlace()) // int.Parse(lboardForm.s5.Text))
            {
                newHighScore();
                
            } else if (currentScore <= DAO.getLastPlace())
            {
                gameoverPause.Start();
            }
        }
        public void newHighScore()
        {
            // Grabbing Name:
            hs.Visible = true;
            hsName.Visible = true;
            hsNameVal.Visible = true;
            submitB.Visible = true;
        }
        public void growSnake(LinkedList<Bit> snake)
        {
            if(snake.Last.Value.Direction == "Left")
            {
                snake.AddLast(new Bit(snake.Last.Value.X + 50, snake.Last.Value.Y, "Left"));
            }
            else if (snake.Last.Value.Direction == "Right")
            {
                snake.AddLast(new Bit(snake.Last.Value.X - 50, snake.Last.Value.Y, "Right"));
            }
            else if (snake.Last.Value.Direction == "Up")
            {
                snake.AddLast(new Bit(snake.Last.Value.X, snake.Last.Value.Y + 50, "Up"));
            }
            else if (snake.Last.Value.Direction == "Down")
            {
                snake.AddLast(new Bit(snake.Last.Value.X, snake.Last.Value.Y - 50, "Down"));
            }
            
        }
        public void MoveSnake(string leadDirection)
        {
            String tmpDirection = "Null";
            foreach (Bit bit in SnakeBits)
            {
                if (leadDirection == "Left" || leadDirection == "Right")
                {
                    if (leadDirection == "Left")
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.X = bit.X - 50;
                    }
                    else
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.X = bit.X + 50;
                    }
                }
                else
                {
                    if (leadDirection == "Up")
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.Y = bit.Y - 50;
                    }
                    else
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.Y = bit.Y + 50;
                    }
                }
            }
        }
        public void paintObject(object sender, PaintEventArgs e)
        {
            PaintSnake(pictureBox1, e);
            PaintFood(pictureBox1, e);
        }
        public void PaintSnake(PictureBox pictureBox, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var penMaster = new Pen(Color.DarkRed, 4);
            var brushMaster = new SolidBrush(Color.DarkRed);

            // Creating rectangles for each body part:
            foreach(Bit bit in SnakeBits)
            {
                Rectangle tmp = new Rectangle(bit.X, bit.Y, length, length);
                g.DrawRectangle(penMaster, tmp);
                g.FillRectangle(brushMaster, tmp);
            }

        }
        public void PaintFood(PictureBox pictureBox, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var penMaster = new Pen(Color.DarkOliveGreen, 4);
            var brushMaster = new SolidBrush(Color.DarkOliveGreen);

            Rectangle tmp = new Rectangle(FoodBit.X,FoodBit.Y, length, length);
            g.DrawRectangle(penMaster, tmp);
            g.FillRectangle(brushMaster, tmp);
        }

        private void MoveActionDetected(object sender, KeyEventArgs e) // Occurs whenever a user presses a key down
        {
            // Adjusting the direction of the snake (direction change will not visually occur until the next game timer tick)
            if (e.KeyCode == Keys.Left && SnakeBits.First.Value.Direction != "Right")
            {
                newDirection = "Left";
            } 
            if (e.KeyCode == Keys.Right && SnakeBits.First.Value.Direction != "Left")
            {
                newDirection = "Right";
            }
            if (e.KeyCode == Keys.Up && SnakeBits.First.Value.Direction != "Down")
            {
                newDirection = "Up";
            }
            if (e.KeyCode == Keys.Down && SnakeBits.First.Value.Direction != "Up")
            {
                newDirection = "Down";
            }
        }

        private void gameoverPauseTick(object sender, EventArgs e)
        {
            currentScore = 0;
            gameoverPause.Stop();
            Owner.Show();
            Controls.Clear();
            this.InitializeComponent();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void initGame(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                timer1.Start();
                initSnake();
                generateFood();
            }
        }

        private void HoverSubmit(object sender, EventArgs e)
        {
            if(submitB.Visible == true)
            {
                submitB.ForeColor = Color.Gold;
            }
        }

        private void UnHoverSubmit(object sender, EventArgs e)
        {
            if (submitB.Visible == true)
            {
                submitB.ForeColor = Color.White;
            }
        }

        private void submitDBEntry(object sender, EventArgs e)
        {
            DAO.updateDBEntries(currentScore, hsNameVal.Text);
            //lboardForm.refreshLeaderboard();

            // Then resume normal closing of form:
            gameoverPause.Start();
        }
    }
}