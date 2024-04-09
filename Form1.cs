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

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            initSnake();
            generateFood();
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
            if(SnakeHead.X == FoodBit.X && SnakeHead.Y == FoodBit.Y)
            {
                // Play sound here
                growSnake(SnakeBits);
                generateFood();
            }
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
    }
}