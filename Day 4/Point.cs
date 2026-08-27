using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    // Point p = new();
    // p.getstring()
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point(int X, int Y, int Z) : this(X, Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}, z = {Z}";
        }
    }
}
