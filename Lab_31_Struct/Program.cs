using System;

namespace Lab_31_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P01 = new Point(10, 10);
            Point P02 = new Point(20, 20);
        }
    }
    class x { }

    struct Point
    {
        int X;
        int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
    }
}
