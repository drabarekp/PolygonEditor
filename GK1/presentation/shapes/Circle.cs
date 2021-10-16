using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Circle : IMovable
    {
        public (int X, int Y) Center { get; set; }
        public int Radius { get; set; }
        public Circle() { }
        public Circle((int X, int Y) center, int rad)
        {
            Center = center;
            Radius = rad;
        }
        public double DistanceFromCenter(int X, int Y)
        {
            return Math.Sqrt((Center.X - X) * (Center.X - X) + (Center.Y - Y) * (Center.Y - Y));
        }

        public void MoveAVector(int X, int Y)
        {
            Center = (Center.X + X, Center.Y + Y);
        }
    }
}
