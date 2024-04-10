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
        Bit FoodBitA = new Bit();
        Bit FoodBitB = new Bit();
        String newDirectionA = "Down";
        String newDirectionB = "Down";
        private static int length = 25;
        private int currentScoreA = 0;
        private int currentScoreB = 0;
        private bool gameFinishedA = false;
        private bool gameFinishedB = false;
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
                generateFood(FoodBitA);
                generateFood(FoodBitB);
                initSnake(SnakeBitsA);
                initSnake(SnakeBitsB);
            }
        }
        public void initSnake(LinkedList<Bit> snake)
        {
            snake.Clear();
            snake.AddFirst(new Bit(400, 400, "Down"));
            snake.AddLast(new Bit(450, 400, "Down"));
            snake.AddLast(new Bit(500, 400, "Down"));
        }
        public void generateFood(Bit food)
        {
            //1375x1900
            Random rVar = new Random();
            food.X = 25 * rVar.Next(0, 55);
            food.Y = 25 * rVar.Next(0, 76);
        }
        private void gameTickA(object sender, EventArgs e)
        {
            MoveSnake(SnakeBitsA, newDirectionA);
            CollisionCheck(SnakeBitsA, FoodBitA,"A");
            pictureBoxA.Refresh(); // This causes the picture box to update every tick of the game timer
        }

        private void gameTickB(object sender, EventArgs e)
        {
            MoveSnake(SnakeBitsB, newDirectionB);
            CollisionCheck(SnakeBitsB, FoodBitB,"B");
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
        public void CollisionCheck(LinkedList<Bit> snake, Bit food, string playerID)
        {
            Bit SnakeHead = snake.First.Value;
            // Checking for food and snake collision
            if (SnakeHead.X == food.X && SnakeHead.Y == food.Y)
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
                generateFood(food);
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
        }
        public void increaseScoreB()
        {
            currentScoreB++;
            label4.Text = currentScoreB.ToString();
        }
        public void gameOver(string playerID)
        {
            if (playerID == "A")
            {
                gameTimerA.Stop();
                label3.ForeColor = Color.Red;
                gameOverA.Visible = true;
                gameFinishedA = true;
            }
            else if (playerID == "B")
            {
                gameTimerA.Stop();
                label4.ForeColor = Color.Red;
                gameOverB.Visible = true;
                gameFinishedB = true;
            }

            // Final ending checks
            if (gameFinishedA == true && gameFinishedB == true)
            {
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
            PaintFood(pictureBoxA, FoodBitA, e);
        }

        private void paintFrameB(object sender, PaintEventArgs e)
        {
            PaintSnake(pictureBoxB, SnakeBitsB, e);
            PaintFood(pictureBoxB, FoodBitB, e);
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
        public void PaintFood(PictureBox pictureBox, Bit food, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var penMaster = new Pen(Color.DarkOliveGreen, 4);
            var brushMaster = new SolidBrush(Color.DarkOliveGreen);

            Rectangle tmp = new Rectangle(food.X, food.Y, length, length);
            g.DrawRectangle(penMaster, tmp);
            g.FillRectangle(brushMaster, tmp);
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
    }
}
