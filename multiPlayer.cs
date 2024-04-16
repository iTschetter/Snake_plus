using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Snake_
{
    public partial class multiPlayer : Form
    {
        // 1375x1900
        LinkedList<Bit> SnakeBitsA = new LinkedList<Bit>();
        LinkedList<Bit> SnakeBitsB = new LinkedList<Bit>();
        LinkedList<Bit> FoodBitsA = new LinkedList<Bit>();
        LinkedList<Bit> FoodBitsB = new LinkedList<Bit>();

        String newDirectionA = "Left";
        String newDirectionB = "Left";
        private static int length = 25;
        private int currentScoreA = 0;
        private int currentScoreB = 0;
        private bool gameFinishedA = false;
        private bool gameFinishedB = false;
        private int playerAClock = 0;
        private int playerBClock = 0;
        private int intervalSpeedCounterA = 1;
        private int intervalSpeedCounterB = 1;
        public multiPlayer()
        {
            InitializeComponent();
        }
        private void initGame(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                gameTimerA.Start();
                gameTimerB.Start();
                playerATime.Start();
                playerBTime.Start();
                initFood(FoodBitsA);
                initFood(FoodBitsB);
                initSnake(SnakeBitsA);
                initSnake(SnakeBitsB);
            }
        }
        public void initSnake(LinkedList<Bit> snake)
        {
            snake.Clear();
            snake.AddFirst(new Bit(400, 400, "Left"));
            snake.AddLast(new Bit(425, 400, "Left"));
            snake.AddLast(new Bit(450, 400, "Left"));
        }
        public void initFood(LinkedList<Bit> food)
        {
            //1375x1900
            Random rVar = new Random();
            food.AddFirst(new Bit(25 * rVar.Next(0, 55), 25 * rVar.Next(0, 76)));
        }
        public void generateFood(LinkedList<Bit> food)
        {
            //1375x1900
            Random rVar = new Random();
            food.AddLast(new Bit(25 * rVar.Next(0, 55), 25 * rVar.Next(0, 76)));
        }
        private void gameTickA(object sender, EventArgs e)
        {
            MoveSnake(SnakeBitsA, newDirectionA);
            CollisionCheck(SnakeBitsA, FoodBitsA,"A");
            pictureBoxA.Refresh(); // This causes the picture box to update every tick of the game timer
        }

        private void gameTickB(object sender, EventArgs e)
        {
            MoveSnake(SnakeBitsB, newDirectionB);
            CollisionCheck(SnakeBitsB, FoodBitsB,"B");
            pictureBoxB.Refresh(); // This causes the picture box to update every tick of the game timer
        }
        public void MoveSnake(LinkedList<Bit> snake, string leadDirection)
        {
            String tmpDirection = "Null";
            foreach (Bit bit in snake)
            {
                if (leadDirection == "Left" || leadDirection == "Right")
                {
                    if (leadDirection == "Left")
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.X = bit.X - 25;
                    }
                    else
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.X = bit.X + 25;
                    }
                }
                else
                {
                    if (leadDirection == "Up")
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.Y = bit.Y - 25;
                    }
                    else
                    {
                        tmpDirection = bit.Direction;
                        bit.Direction = leadDirection;
                        leadDirection = tmpDirection;
                        bit.Y = bit.Y + 25;
                    }
                }
            }
        }
        public void CollisionCheck(LinkedList<Bit> snake, LinkedList<Bit> food, string playerID)
        {
            Bit SnakeHead = snake.First.Value;
            // Checking for food and snake collision
            foreach(Bit foodBit in food)
            {
                if (SnakeHead.X == foodBit.X && SnakeHead.Y == foodBit.Y)
                {
                    // Play sound here
                    growSnake(snake);
                    if (playerID == "A")
                    {
                        increaseScoreA();
                    }
                    else if (playerID == "B")
                    {
                        increaseScoreB();
                    }
                    food.Remove(foodBit);
                    generateFood(food);
                    break;
                }
            }
            // Checking for snake and border collision
            if (SnakeHead.X < 0 || SnakeHead.Y < 0)
            {
                gameOver(playerID);
            }
            else if (SnakeHead.X > 1350 || SnakeHead.Y > 1875)
            {
                gameOver(playerID);
            }

            // Checking for snake on snake collision
            foreach (Bit bit in snake.Skip(1))
            {
                if (bit.X == SnakeHead.X && bit.Y == SnakeHead.Y)
                {
                    gameOver(playerID);
                }
            }
        }
        public void growSnake(LinkedList<Bit> snake)
        {
            if (snake.Last.Value.Direction == "Left")
            {
                snake.AddLast(new Bit(snake.Last.Value.X + 25, snake.Last.Value.Y, "Left"));
            }
            else if (snake.Last.Value.Direction == "Right")
            {
                snake.AddLast(new Bit(snake.Last.Value.X - 25, snake.Last.Value.Y, "Right"));
            }
            else if (snake.Last.Value.Direction == "Up")
            {
                snake.AddLast(new Bit(snake.Last.Value.X, snake.Last.Value.Y + 25, "Up"));
            }
            else if (snake.Last.Value.Direction == "Down")
            {
                snake.AddLast(new Bit(snake.Last.Value.X, snake.Last.Value.Y - 25, "Down"));
            }

        }
        public void increaseScoreA()
        {
            currentScoreA++;
            label3.Text = currentScoreA.ToString();
            if(currentScoreA % 5 == 0)
            {
                incrementSpeed("A");
            }
        }
        public void increaseScoreB()
        {
            currentScoreB++;
            label4.Text = currentScoreB.ToString();
            if (currentScoreB % 5 == 0)
            {
                incrementSpeed("B");
            }
        }
        public void incrementSpeed(string playerID)
        {
            if (playerID == "A" && gameTimerB.Interval > 50)
            {
                gameTimerB.Interval = gameTimerB.Interval - 50;
            } 
            else if (playerID == "B" && gameTimerA.Interval > 50)
            {
                gameTimerA.Interval = gameTimerA.Interval - 50;
            } 
        }
        public void gameOver(string playerID)
        {
            if (playerID == "A")
            {
                gameTimerA.Stop();
                playerATime.Stop();
                clockA.ForeColor = Color.Red;
                gameOverA.Visible = true;
                gameFinishedA = true;
            }
            else if (playerID == "B")
            {
                gameTimerB.Stop();
                playerBTime.Stop();
                clockB.ForeColor = Color.Red;
                gameOverB.Visible = true;
                gameFinishedB = true;
            }

            // Final ending checks
            if (gameFinishedA == true && gameFinishedB == true)
            {
                if(playerAClock > playerBClock)
                {
                    winnerA.Visible = true;
                    clockA.ForeColor = Color.Green;
                } else if (playerAClock < playerBClock)
                {
                    winnerB.Visible = true;
                    clockB.ForeColor = Color.Green;
                } else
                {
                    tieA.Visible = true;
                    tieB.Visible = true;
                    clockA.ForeColor = Color.Yellow;
                    clockB.ForeColor = Color.Yellow;
                }

                gameOverPause.Start();
            }
        }

        private void gameOverPauseTick(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void paintFrameA(object sender, PaintEventArgs e)
        {
            PaintSnake(pictureBoxA, SnakeBitsA, e);
            PaintFood(pictureBoxA, FoodBitsA, e);
        }

        private void paintFrameB(object sender, PaintEventArgs e)
        {
            PaintSnake(pictureBoxB, SnakeBitsB, e);
            PaintFood(pictureBoxB, FoodBitsB, e);
        }
        public void PaintSnake(PictureBox pictureBox, LinkedList<Bit> snake, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var penMaster = new Pen(Color.DarkRed, 4);
            var brushMaster = new SolidBrush(Color.DarkRed);

            // Creating rectangles for each body part:
            foreach (Bit bit in snake)
            {
                Rectangle tmp = new Rectangle(bit.X, bit.Y, length, length);
                g.DrawRectangle(penMaster, tmp);
                g.FillRectangle(brushMaster, tmp);
            }

        }
        public void PaintFood(PictureBox pictureBox, LinkedList<Bit> food, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var penMaster = new Pen(Color.DarkOliveGreen, 4);
            var brushMaster = new SolidBrush(Color.DarkOliveGreen);

            foreach (Bit foodBit in food)
            {
                Rectangle tmp = new Rectangle(foodBit.X, foodBit.Y, length, length);
                g.DrawRectangle(penMaster, tmp);
                g.FillRectangle(brushMaster, tmp);
            }
        }

        private void MoveActionDetected(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.W)
            {
                // Adjusting the direction of the snake (direction change will not visually occur until the next game timer tick)
                if (e.KeyCode == Keys.A && SnakeBitsA.First.Value.Direction != "Right")
                {
                    newDirectionA = "Left";
                }
                if (e.KeyCode == Keys.D && SnakeBitsA.First.Value.Direction != "Left")
                {
                    newDirectionA = "Right";
                }
                if (e.KeyCode == Keys.W && SnakeBitsA.First.Value.Direction != "Down")
                {
                    newDirectionA = "Up";
                }
                if (e.KeyCode == Keys.S && SnakeBitsA.First.Value.Direction != "Up")
                {
                    newDirectionA = "Down";
                }
            } else
            {
                // Adjusting the direction of the snake (direction change will not visually occur until the next game timer tick)
                if (e.KeyCode == Keys.Left && SnakeBitsB.First.Value.Direction != "Right")
                {
                    newDirectionB = "Left";
                }
                if (e.KeyCode == Keys.Right && SnakeBitsB.First.Value.Direction != "Left")
                {
                    newDirectionB = "Right";
                }
                if (e.KeyCode == Keys.Up && SnakeBitsB.First.Value.Direction != "Down")
                {
                    newDirectionB = "Up";
                }
                if (e.KeyCode == Keys.Down && SnakeBitsB.First.Value.Direction != "Up")
                {
                    newDirectionB = "Down";
                }
            }
        }

        private void playerATimerTick(object sender, EventArgs e)
        {
            decimal tmpMinute = 0;
            string tmpSecond = "00";
            playerAClock++;

            if(playerAClock > 59) // Incrementing Timer
            {
                tmpMinute = playerAClock / 60;
                if(playerAClock % 60 < 10)
                {
                    tmpSecond = "0" + (playerAClock%60).ToString();
                } else
                {
                    tmpSecond = (playerAClock%60).ToString();
                }
                clockA.Text = Math.Floor(tmpMinute).ToString() + ":" + tmpSecond;

            } else
            {
                if (playerAClock % 60 < 10)
                {
                    tmpSecond = "0" + (playerAClock % 60).ToString();
                }
                else
                {
                    tmpSecond = (playerAClock % 60).ToString();
                }
                clockA.Text = "0:" + tmpSecond;
            }

            if(playerAClock % 10 == 0 && gameTimerA.Interval > 10) // Checking for speed incrementation
            {
                gameTimerA.Interval = gameTimerA.Interval - 10;
                generateFood(FoodBitsA);
            }
        }

        private void playerBTimerTick(object sender, EventArgs e)
        {
            double tmpMinute = 0;
            string tmpSecond = "00";
            playerBClock++;

            if (playerBClock > 59) // Incrementing Timer
            {
                tmpMinute = playerBClock / 60;
                if (playerBClock % 60 < 10)
                {
                    tmpSecond = "0" + (playerBClock % 60).ToString();
                }
                else
                {
                    tmpSecond = (playerBClock % 60).ToString();
                }
                clockB.Text = Math.Floor(tmpMinute).ToString() + ":" + tmpSecond;

            }
            else
            {
                if (playerBClock % 60 < 10)
                {
                    tmpSecond = "0" + (playerBClock % 60).ToString();
                }
                else
                {
                    tmpSecond = (playerBClock % 60).ToString();
                }
                clockB.Text = "0:" + tmpSecond;
            }

            if (playerBClock % 10 == 0 && gameTimerB.Interval > 10) // Checking for speed incrementation
            {
                gameTimerB.Interval = gameTimerB.Interval - 10;
                generateFood(FoodBitsB);
            }
        }
    }
}
