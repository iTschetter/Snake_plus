using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_
{
    class Bit // Linked List will use this class to store locations of body and head parts of snake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
        //public int width { get; set; }
        //public int height { get; set; }
        public Bit()
        {
            X = 0;
            Y = 0;
            Direction = "Null";
        }
        public Bit(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
