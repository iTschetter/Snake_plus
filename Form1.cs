namespace Snake_
{
    public partial class Form1 : Form
    {
        LinkedList<Bit> SnakeBits = new LinkedList<Bit>();
        Bit FoodBit = new Bit();
        private static int length = 50;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            initSnake();
            initFood();
        }
        public void initSnake()
        {
            SnakeBits.Clear();
            SnakeBits.AddFirst(new Bit(400, 400));
            SnakeBits.AddLast(new Bit(450, 400));
            SnakeBits.AddLast(new Bit(500, 400));
        }
        public void initFood()
        {
            //2761x1497
            Random rVar = new Random();
            FoodBit.X = rVar.Next(0, 2761);
            FoodBit.Y = rVar.Next(0, 1497);
        }

        public void GameTick(object sender, EventArgs e) // Everything starts here. 
        {
            pictureBox1.Refresh(); // This causes the picture box to update every tick of the game timer
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
    }
}